using System;
using System.Windows.Forms;
using ForgetMeNot.Architecture;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IFormFactory _formFactory;
        public LoginForm(IAuthService authService, IFormFactory formFactory)
        {
            _authService = authService;
            _formFactory = formFactory;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var isAuthorized = _authService.Authorize(txbUserName.Text);
            if (isAuthorized)
            {
                var mainForm = _formFactory.CreateForm(typeof(MainForm));
                mainForm.Show();
                mainForm.Closed += (s, args) => this.Close();
                this.Hide();
            }

        }
        
    }
}