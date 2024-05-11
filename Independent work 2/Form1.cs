using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Independent_work_2
{
    public partial class Form1 : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public event EventHandler LoginClicked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowAdminScreen()
        {
            MessageBox.Show("Ви увійшли як адміністратор");
        }

        public void ShowUserScreen()
        {
            MessageBox.Show("Ви увійшли як користувач");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
