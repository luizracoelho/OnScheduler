using OnScheduler.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnScheduler.UI
{
    public partial class SplashForm : Form
    {
        private List<AgendamentoDiario> agendamentosDiarios;
        private List<AgendamentoSazonal> agendamentosSazonais;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer1.Enabled = true;
        }

        private async Task ListarAgendamentosSazonais()
        {
            using (var bo = new AgendamentoSazonalBO())
            {
                agendamentosSazonais = bo.List();
            }
        }
        private async Task ListarAgendamentosDiarios()
        {
            using (var bo = new AgendamentoDiarioBO())
            {
                agendamentosDiarios = bo.List();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                Task.WhenAll(
                ListarAgendamentosDiarios(),
                ListarAgendamentosSazonais(),
                ShowForm()
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

        }

        private async Task ShowForm()
        {
            var form = new OnSchedulerForm(agendamentosDiarios, agendamentosSazonais);
            form.Show();

            Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;

            timer2.Stop();
        }
    }
}
