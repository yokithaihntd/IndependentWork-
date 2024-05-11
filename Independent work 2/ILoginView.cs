using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_2
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        event EventHandler LoginClicked;
        void ShowMessage(string message);
        void ShowAdminScreen();
        void ShowUserScreen();
    }
}
