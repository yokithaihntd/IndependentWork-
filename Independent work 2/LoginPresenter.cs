using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_2
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _view.LoginClicked += OnLoginClicked;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string username = _view.Username;
            string password = _view.Password;


            if (username == "admin" && password == "admin")
                _view.ShowAdminScreen();
            else if (username == "user" && password == "user")
                _view.ShowUserScreen();
            else
                _view.ShowMessage("Неправильний логін або пароль");
        }
    }
}
