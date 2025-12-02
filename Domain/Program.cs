
using System;

using System.Windows.Forms;

namespace AcademicInfoSystem.Domain
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            try
            {
            

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fatal error");
            }
        }

       

    }
}
