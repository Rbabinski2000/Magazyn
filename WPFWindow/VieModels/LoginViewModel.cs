using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFWindow.VieModels
{
    public class LoginViewModel:ViewModelBase 
    {
        private string _userName;

        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged("Username");
            }
        }

        public ICommand LoginCommand { get; }
    }
}
