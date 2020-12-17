using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class AgeException : ArgumentException
    {
        public void Age(int age)
        {
            if(age < 18)
            {
                throw new Exception("Соискатель не подходит по возрасту");
            }
        }
        
    }
}