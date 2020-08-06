using System;
using System.Windows.Forms;

namespace ForgetMeNot.Services.Interfaces
{
    public interface IFormFactory
    {
        Form CreateForm(Type formType);
    }
}