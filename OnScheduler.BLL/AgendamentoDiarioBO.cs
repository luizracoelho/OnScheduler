﻿using OnBase;
using OnScheduler.DAL;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace OnScheduler.BLL
{
    public class AgendamentoDiarioBO : BaseLogic<AgendamentoDiario, AgendamentoDiarioDAO>
    {
        public AgendamentoDiarioBO()
        {

        }

        public override void Save(AgendamentoDiario entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Url) || entity.Datas == null || string.IsNullOrEmpty(entity.Descricao))
                    throw new Exception("Todos os campos devem ser preenchidos corretamente.");

                base.Save(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected override void Insert(AgendamentoDiario entity)
        {
            //Fazer backup das datas
            var datas = entity.Datas;

            //Anular as datas
            entity.Datas = null;

            //Salvar o agendamento
            base.Insert(entity);

            //Salvar as datas
            using (var dataBo = new DataBO())
            {
                foreach (var data in datas)
                {
                    data.AgendamentoDiario_Id = entity.Id;
                    dataBo.Save(data);
                }
            }
        }

        protected override void Edit(AgendamentoDiario entity)
        {
            //Fazer backup das datas
            var datas = entity.Datas;

            //Anular as datas
            entity.Datas = null;

            //Alterar o agendamento
            base.Edit(entity);

            //Obter datas mantidas
            var datasMantidas = datas.Where(x => x.Id > 0)
                .Select(x => x.Id)
                .ToList();

            using (var dataBo = new DataBO())
            {
                //Encontrar as datas no banco
                var datasBd = dataBo.List().Where(x => x.AgendamentoDiario_Id == entity.Id);

                //Obter as datas a serem removidas
                var datasARemover = datasBd.Where(x => !datasMantidas.Contains(x.Id))
                                    .Select(x => x.Id)
                                    .ToList();

                //Remover datas
                foreach (var data in datasARemover)
                {
                    dataBo.Remove(data);
                }

                //Adicionar ou editar os itens
                foreach (var data in datas)
                {
                    data.AgendamentoDiario_Id = entity.Id;
                    dataBo.Save(data);
                }
            }
        }

        private static void EditUltimaExecucao(AgendamentoDiario agendamento)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var datas = agendamento.Datas;

                    //Anular as foreign keys
                    agendamento.Datas = null;

                    //Adicionar a data da última execução
                    agendamento.DataUltimaExecucao = DateTime.Now;

                    //Editar a data da última execução
                    using (var dao = new AgendamentoDiarioDAO())
                    {
                        dao.EditUltimaExecucao(agendamento);
                    }

                    agendamento.Datas = datas;

                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task ExecutarAsync(AgendamentoDiario agendamento)
        {
            var date = DateTime.Now.TimeOfDay;

            foreach (var data in agendamento.Datas)
            {
                if (data.Hora.Hours == date.Hours && data.Hora.Minutes == date.Minutes)
                {
                    using (var client = new HttpClient())
                    {
                        var rgx = new Regex("http://?");
                        var preffix = rgx.IsMatch(agendamento.Url) ? "" : "http://";
                        
                        agendamento.DataUltimaExecucao = agendamento.DataUltimaExecucao ?? new DateTime();

                        //Verificar se a URL será requisitada
                        if (agendamento.DataUltimaExecucao?.Hour <= data.Hora.Hours && agendamento.DataUltimaExecucao?.Minute <= data.Hora.Minutes)
                        {
                            //Editar a ultima execução
                            EditUltimaExecucao(agendamento);

                            //Requisitar URL
                            await client.GetAsync(preffix + agendamento.Url);
                        }
                    }
                }
            }
        }
    }
}
