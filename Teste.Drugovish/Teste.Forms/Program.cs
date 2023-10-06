

using Teste.Domain.Entities;
using Teste.Forms.View;

namespace Teste.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run( new FConfiguracao() );
            using (var login = new FrmLogin())
            {

                try
                {
                    login.ShowDialog();
                    if (login.gerente.Id == 0)
                    {
                        return;
                    }
                    else
                    {
                        Application.Run(new FrmPrincipal(login.gerente));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }
    }
}