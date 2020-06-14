using System;
using System.Windows.Forms;

namespace ForgetMeNot
{
    public interface IFormFactory
    {
        Form CreateForm(Type formType);
    }
}