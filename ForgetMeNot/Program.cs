using System;
using System.Windows.Forms;
using Autofac;
using ForgetMeNot.Services;

namespace ForgetMeNot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.ResolveServices();
            builder.RegisterType<Form1>();
            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form1>());
        }
    }
}