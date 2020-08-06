using System;
using System.Windows.Forms;
using ForgetMeNot.Architecture;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot
{
    public partial class MainForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IFormFactory _formFactory;
        public MainForm(IAuthService authService, IFormFactory formFactory)
        {
            _authService = authService;
            _formFactory = formFactory;
            InitializeComponent();

            lblYourName.Text = @$"Hello {_authService.Name}!";
        }
        
    }
}