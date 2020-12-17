using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class CitizenshipException : ArgumentException
    {
        public void Citizenship(string citizenship)
        {
            if (citizenship != "Русский") {
                throw new Exception("Андрюха, у нас нелегал, по коням!");
            }
        }
        
    }
}