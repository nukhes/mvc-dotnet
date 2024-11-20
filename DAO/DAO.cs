using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAO
{
    class DAO
    {
        private string errorMessage = "Não foi possível se conectar: ";
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
    }
}
