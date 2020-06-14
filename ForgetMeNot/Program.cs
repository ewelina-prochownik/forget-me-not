using System;
using System.Windows.Forms;
using Autofac;
using ForgetMeNot.Services;
using ForgetMeNot.Services.Implementations;

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
            builder.RegisterType<LoginForm>();
            builder.RegisterType<AutofacFormFactory>().As<IFormFactory>();
            var container = builder.Build();
            FormFactory.Use(container.Resolve<IFormFactory>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<LoginForm>());
        }
    }
}