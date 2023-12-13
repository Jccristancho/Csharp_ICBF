using CRUD;
using CRUD.Visual;
using System;
using System.Windows.Forms;

namespace CRUD
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí iniciamos el formulario principal de tu aplicación
            Application.Run(new FormNinos());
        }
    }
}
