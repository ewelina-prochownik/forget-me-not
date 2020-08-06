using System;
using System.Windows.Forms;

namespace ForgetMeNot.Architecture
{
    public interface IFormFactory
    {
        Form CreateForm(Type formType);
    }
}