﻿using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;
using InsuranceApplication.Forms;

namespace InsuranceApplication
{
    public partial class formInsuranceClaim : Form
    {
        public formInsuranceClaim()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserType usertype = User.Login(txtUsername.Text, txtPassword.Text);
                if (usertype == UserType.Undefined)
                    throw new NullReferenceException();
                object user = null;
                Form home = null;
                switch (usertype)
                {
                    case UserType.Admin:
                        user = new Admin(txtUsername.Text, txtPassword.Text);
                        home = new AdminHome((Admin)user);
                        break;
                    case UserType.FinanceManager:
                        user = new FinanceManager(txtUsername.Text, txtPassword.Text);
                        home = new FinanceManagerHome((FinanceManager)user);
                        break;
                    case UserType.ClientManager:
                        user = new ClaimManager(txtUsername.Text, txtPassword.Text);
                        home = new ClaimManagerHome((ClaimManager)user);
                        break;
                    case UserType.Client:
                        user = new Client(txtUsername.Text, txtPassword.Text);
                        home = new ClientHome((Client)user);
                        break;
                }
                Hide();
                home.ShowDialog();
                txtPassword.Text = string.Empty;
                Show();
            } catch (NullReferenceException ex)
            {
                MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register f4 = new Register();
            f4.ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword f3 = new ForgotPassword(txtUsername.Text);
            f3.ShowDialog();
        }
    }
}
