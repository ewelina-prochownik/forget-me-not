using System;
using System.Windows.Forms;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        public LoginForm(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var isAuthorized = _authService.Authorize(txbUserName.Text);
            if (isAuthorized)
            {
            }

        }
        
    }
}