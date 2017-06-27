using OnScheduler.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnScheduler.UI
{
    public partial class OnSchedulerForm : Form
    {
        public OnSchedulerForm(List<AgendamentoDiario> diario, List<AgendamentoSazonal> sazonal)
        {
            components = new Container();
            OnSchedulerContextMenu = new ContextMenu();
            menuItem1 = new MenuItem();

            OnSchedulerContextMenu.MenuItems.AddRange(
                new MenuItem[] { menuItem1 });

            menuItem1.Index = 0;
            menuItem1.Text = "Sair";
            menuItem1.Click += new EventHandler(MenuItem1_Click);

            OnSchedulerNotifyIcon = new NotifyIcon(components)
            {
                Icon = new Icon("OnScheduler.ico"),
                ContextMenu = OnSchedulerContextMenu,
                Text = "OnScheduler",
                Visible = true
            };

            OnSchedulerNotifyIcon.DoubleClick += new EventHandler(OnSchedulerNotifyIcon_DoubleClick);

            InitializeComponent();
            InitializeOtherComponents();

            agendamentosDiarios = diario;
            agendamentosSazonais = sazonal;
        }

        private void OnScheduler_Load(object sender, EventArgs e)
        {
            OnSchedulerTimer.Start();
            OnSchedulerTimer.Enabled = true;
            OnSchedulerTimer.Tick += OnSchedulerTimer_Tick;

            ZerarDatas();

            AgendamentoDiarioDataGridView.AutoGenerateColumns = false;
            agendamentoDiarioBindingSource.DataSource = agendamentosDiarios;
            AgendamentoDiarioDataGridView.DataSource = agendamentoDiarioBindingSource;

            AgendamentoSazonalDataGridView.AutoGenerateColumns = false;
            agendamentoSazonalBindingSource.DataSource = agendamentosSazonais;
            AgendamentoSazonalDataGridView.DataSource = agendamentoSazonalBindingSource;
            TipoSazonalidadeComboBox.DataSource = Enum.GetNames(typeof(TipoSazonalidade)).ToList();

            OnSchedulerNotifyIcon.Visible = false;
        }

        private void OnSchedulerTimer_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                #region Agendamento Diario
                foreach (var item in agendamentosDiarios)
                {
                    await AgendamentoDiarioBO.ExecutarAsync(item);
                }
                #endregion

                #region Agendamento Sazonal

                foreach (var item in agendamentosSazonais)
                {
                    await AgendamentoSazonalBO.ExecutarAsync(item);
                }
                #endregion
            });
        }

        #region Rodar na Bandeja

        private IContainer components;
        private NotifyIcon OnSchedulerNotifyIcon;
        private ContextMenu OnSchedulerContextMenu;
        private MenuItem menuItem1;

        private void InitializeOtherComponents()
        {
            this.SuspendLayout();
            // 
            // OnSchedulerForm
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnSchedulerForm_FormClosing);
            this.Resize += OnSchedulerForm_Resize;
            //
            //OnSchedulerNotifyIcon
            //
            this.OnSchedulerNotifyIcon.DoubleClick += new System.EventHandler(this.OnSchedulerNotifyIcon_DoubleClick);
            this.ResumeLayout(false);

        }

        private void OnSchedulerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                OnSchedulerNotifyIcon.Visible = true;
                Hide();
            }
        }

        private void OnSchedulerNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();

            WindowState = FormWindowState.Maximized;

            OnSchedulerNotifyIcon.Visible = false;
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void OnSchedulerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnSchedulerNotifyIcon.Visible = true;
            Hide();
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        #endregion

        #region Agendamento Diario

        private List<AgendamentoDiario> agendamentosDiarios;

        private void ListarAgendamentosDiarios()
        {
            using (var bo = new AgendamentoDiarioBO())
            {
                agendamentosDiarios = bo.List();
            }
        }

        private void SalvarDiarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = string.IsNullOrEmpty(IdDiarioTextBox.Text) ? 0 : Convert.ToInt32(IdDiarioTextBox.Text);

                using (var bo = new AgendamentoDiarioBO())
                {
                    var agendamentoDiario = new AgendamentoDiario
                    {
                        Id = id,
                        Url = UrlDiarioTextBox.Text,
                        Datas = PreencherDatas(),
                        Descricao = DescricaoDiarioTextBox.Text
                    };

                    bo.Save(agendamentoDiario);

                    MessageBox.Show("Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarGridDiario();

                    ResetarCampos();
                    ListarAgendamentosDiarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarGridDiario()
        {
            using (var bo = new AgendamentoDiarioBO())
            {
                agendamentoDiarioBindingSource.DataSource = bo.List();
                AgendamentoDiarioDataGridView.DataSource = agendamentoDiarioBindingSource;
            }

        }

        private void ResetarCampos()
        {
            DescricaoDiarioTextBox.Text = "";
            UrlDiarioTextBox.Text = "";
            IdDiarioTextBox.Text = "";

            DomingoCheckBox.Checked = false;
            SegundaCheckBox.Checked = false;
            TercaCheckBox.Checked = false;
            QuartaCheckBox.Checked = false;
            QuintaCheckBox.Checked = false;
            SextaCheckBox.Checked = false;
            SabadoCheckBox.Checked = false;

            DomingoDateTimePicker.Enabled = false;
            SegundaDateTimePicker.Enabled = false;
            TercaDateTimePicker.Enabled = false;
            QuartaDateTimePicker.Enabled = false;
            QuintaDateTimePicker.Enabled = false;
            SextaDateTimePicker.Enabled = false;
            SabadoDateTimePicker.Enabled = false;

            ZerarDatas();

            DescricaoDiarioTextBox.Focus();
        }

        private void ZerarDatas()
        {
            DomingoDateTimePicker.Value = DateTime.Today;
            SegundaDateTimePicker.Value = DateTime.Today;
            TercaDateTimePicker.Value = DateTime.Today;
            QuartaDateTimePicker.Value = DateTime.Today;
            QuintaDateTimePicker.Value = DateTime.Today;
            SextaDateTimePicker.Value = DateTime.Today;
            SabadoDateTimePicker.Value = DateTime.Today;
        }

        private List<Data> PreencherDatas()
        {
            var datas = new List<Data>();

            if (DomingoCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Sunday,
                    Hora = DomingoDateTimePicker.Value.TimeOfDay
                });
            }

            if (SegundaCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Monday,
                    Hora = SegundaDateTimePicker.Value.TimeOfDay
                });
            }

            if (TercaCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Tuesday,
                    Hora = TercaDateTimePicker.Value.TimeOfDay
                });
            }

            if (QuartaCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Wednesday,
                    Hora = QuartaDateTimePicker.Value.TimeOfDay
                });
            }

            if (QuintaCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Thursday,
                    Hora = QuintaDateTimePicker.Value.TimeOfDay
                });
            }

            if (SextaCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Friday,
                    Hora = SextaDateTimePicker.Value.TimeOfDay
                });
            }

            if (SabadoCheckBox.Checked)
            {
                datas.Add(new Data
                {
                    DiaSemana = DayOfWeek.Saturday,
                    Hora = SabadoDateTimePicker.Value.TimeOfDay
                });
            }

            return datas;
        }

        public void HabilitaDesabilitaCheckBox(CheckBox check, DateTimePicker picker)
        {
            if (check.Checked)
                picker.Enabled = true;
            else
                picker.Enabled = false;
        }

        private void DomingoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(DomingoCheckBox, DomingoDateTimePicker);
        }

        private void SegundaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(SegundaCheckBox, SegundaDateTimePicker);
        }

        private void TercaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(TercaCheckBox, TercaDateTimePicker);
        }

        private void QuartaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(QuartaCheckBox, QuartaDateTimePicker);
        }

        private void QuintaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(QuintaCheckBox, QuintaDateTimePicker);
        }

        private void SextaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(SextaCheckBox, SextaDateTimePicker);
        }

        private void SabadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDesabilitaCheckBox(SabadoCheckBox, SabadoDateTimePicker);
        }

        private void AgendamentoDiarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DesabilitarCampos();

            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(AgendamentoDiarioDataGridView.Rows[e.RowIndex].Cells["IdDiario"].Value.ToString());

                using (var bo = new AgendamentoDiarioBO())
                {
                    var agendamento = bo.Get(id);

                    IdDiarioTextBox.Text = agendamento.Id.ToString();
                    DescricaoDiarioTextBox.Text = agendamento.Descricao;
                    UrlDiarioTextBox.Text = agendamento.Url;

                    PreencherCheckBox(agendamento);
                }
            }
        }

        private void DesabilitarCampos()
        {
            DomingoCheckBox.Checked = false;
            DomingoDateTimePicker.Enabled = false;

            SegundaCheckBox.Checked = false;
            SegundaDateTimePicker.Enabled = false;

            TercaCheckBox.Checked = false;
            TercaDateTimePicker.Enabled = false;

            QuartaCheckBox.Checked = false;
            QuartaDateTimePicker.Enabled = false;

            QuintaCheckBox.Checked = false;
            QuintaDateTimePicker.Enabled = false;

            SextaCheckBox.Checked = false;
            SextaDateTimePicker.Enabled = false;

            SabadoCheckBox.Checked = false;
            SabadoDateTimePicker.Enabled = false;
        }

        private void PreencherCheckBox(AgendamentoDiario agendamento)
        {
            foreach (var data in agendamento.Datas)
            {
                if (data.DiaSemana == DayOfWeek.Sunday)
                {
                    DomingoCheckBox.Checked = true;
                    DomingoDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Monday)
                {
                    SegundaCheckBox.Checked = true;
                    SegundaDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Tuesday)
                {
                    TercaCheckBox.Checked = true;
                    TercaDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Wednesday)
                {
                    QuartaCheckBox.Checked = true;
                    QuartaDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Thursday)
                {
                    QuintaCheckBox.Checked = true;
                    QuintaDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Friday)
                {
                    SextaCheckBox.Checked = true;
                    SextaDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }

                if (data.DiaSemana == DayOfWeek.Saturday)
                {
                    SabadoCheckBox.Checked = true;
                    SabadoDateTimePicker.Value = DateTime.Today.AddTicks(data.Hora.Ticks);
                }
            }
        }

        private void AgendamentoDiarioDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    var index = AgendamentoDiarioDataGridView.CurrentCell?.OwningRow.Index;

                    if (index >= 0)
                    {
                        var id = Convert.ToInt32(AgendamentoDiarioDataGridView.Rows[(int)index].Cells["IdDiario"].Value.ToString());

                        if (id != null)
                        {
                            var result = MessageBox.Show("Tem certeza que deseja remover este agendamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                using (var bo = new AgendamentoDiarioBO())
                                {
                                    bo.Remove(id);
                                }

                                AtualizarGridDiario();

                                ResetarCampos();
                                ListarAgendamentosDiarios();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Agendamento Sazonal

        private List<AgendamentoSazonal> agendamentosSazonais;

        private void ListarAgendamentosSazonais()
        {
            using (var bo = new AgendamentoSazonalBO())
            {
                agendamentosSazonais = bo.List();
            }
        }

        private void SalvarSazonalButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = string.IsNullOrEmpty(IdSazonalTextBox.Text) ? 0 : Convert.ToInt32(IdSazonalTextBox.Text);

                using (var bo = new AgendamentoSazonalBO())
                {
                    var agendamentoSazonal = new AgendamentoSazonal
                    {
                        Id = id,
                        Url = UrlSazonalTextBox.Text,
                        Descricao = DescricaoSazonalTextBox.Text,
                        TempoAviso = Convert.ToDecimal(SazonalidadeTextBox.Text),
                        TipoSazonalidade = (TipoSazonalidade)TipoSazonalidadeComboBox.SelectedIndex
                    };

                    bo.Save(agendamentoSazonal);

                    MessageBox.Show("Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarGridSazonal();

                    LimparCampos();
                    ListarAgendamentosSazonais();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarGridSazonal()
        {
            using (var bo = new AgendamentoSazonalBO())
            {
                agendamentoSazonalBindingSource.DataSource = bo.List();
                AgendamentoSazonalDataGridView.DataSource = agendamentoSazonalBindingSource;
            }

        }

        private void LimparCampos()
        {
            DescricaoSazonalTextBox.Text = "";
            UrlSazonalTextBox.Text = "";
            TipoSazonalidadeComboBox.SelectedIndex = 0;
            SazonalidadeTextBox.Text = "";
            IdSazonalTextBox.Text = "";

            DescricaoSazonalTextBox.Focus();
        }

        private void AgendamentoSazonalDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(AgendamentoSazonalDataGridView.Rows[e.RowIndex].Cells["IdSazonal"].Value.ToString());

                using (var bo = new AgendamentoSazonalBO())
                {
                    var agendamentoSazonal = bo.Get(id);

                    IdSazonalTextBox.Text = agendamentoSazonal.Id.ToString();
                    DescricaoSazonalTextBox.Text = agendamentoSazonal.Descricao;
                    UrlSazonalTextBox.Text = agendamentoSazonal.Url;
                    TipoSazonalidadeComboBox.SelectedIndex = (int)agendamentoSazonal.TipoSazonalidade;
                    SazonalidadeTextBox.Text = agendamentoSazonal.TempoAviso.ToString();
                }
            }
        }

        private void AgendamentoSazonalDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    var index = AgendamentoSazonalDataGridView.CurrentCell?.OwningRow.Index;

                    if (index >= 0)
                    {
                        var id = Convert.ToInt32(AgendamentoSazonalDataGridView.Rows[(int)index].Cells["IdSazonal"].Value.ToString());

                        if (id != null)
                        {
                            var result = MessageBox.Show("Tem certeza que deseja remover este agendamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                using (var bo = new AgendamentoSazonalBO())
                                {
                                    bo.Remove(id);
                                }

                                AtualizarGridSazonal();

                                LimparCampos();
                                ListarAgendamentosSazonais();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion
    }
}