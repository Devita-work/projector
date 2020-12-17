using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class Human
    {
        public string FIO // Имя
        {
            get
            {
                string fio = name + ' ' + secondName + ' ' + lastName;
                return fio;
            }
            set
            {
                string[] fio = value.Split(' ');
                name = fio[0];
                secondName = fio[1];
                lastName = fio[2];
            }
        }
        string name;
        string secondName;
        string lastName;
        public Gender Gender;

    }
}