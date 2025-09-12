using System;
using System.Windows.Forms;

namespace clockdown
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormTask Tareas = new FormTask();
            Tareas.WindowState = FormWindowState.Normal;

            Tareas.Show();
            Application.Run();
        }
    }
}
