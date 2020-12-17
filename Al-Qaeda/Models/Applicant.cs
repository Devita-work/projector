using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class Applicant:Human
    {
        public int Age; // возраст
        public bool Сitizenship; // гражданство
        public bool Grown; // >18 лет или нет
        public DateTime RecruitmentDate; // дата последнего приёма на работу
        public Work CurrentWork = new Work(); // текущая работа 
        public WorkExperience[] WorkExperience; // массив с предыдущими работами и стажем
    }
}