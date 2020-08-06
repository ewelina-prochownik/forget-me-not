using System;
using System.Windows.Forms;
using Autofac;
using ForgetMeNot.Architecture;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot.Services.Implementations
{
    public class AutofacFormFactory : IFormFactory
    {
        private readonly ILifetimeScope currentScope;

        public AutofacFormFactory(ILifetimeScope currentScope)
        {
            this.currentScope = currentScope;
        }

        public Form CreateForm(Type formType)
        {
            // begin a new lifetime scope for each form instance
            var scope = this.currentScope.BeginLifetimeScope();

            var form = (Form) scope.Resolve(formType);

            //form.disposed.subscrfibe()
            form.Disposed += (s, e) =>
            {
                // finish the scope when the form is disposed (closed)
                scope.Dispose();
            };

            return form;
        }
    }
}