﻿using System;
using System.Windows.Forms;

namespace GitUI.UserControls
{
    public partial class CredentialControl : UserControl
    {
        public CredentialControl()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get => userNameTextBox.Text;

            set => userNameTextBox.Text = value;
        }

        public string Password
        {
            get => passwordTextBox.Text;

            set => passwordTextBox.Text = value;
        }

        private void CredentialsControl_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
