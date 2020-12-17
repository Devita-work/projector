using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class Recruitment // приём на работу
    {
        public Work Work = new Work();
        public HR HR = new HR();
        public Applicant Applicant = new Applicant();

        public Recruitment(Applicant applicant, HR hr, Work work, AgeException AgeExept, CitizenshipException CitizenExept)
        {
            try
            {
                AgeExept.Age(Applicant.Age);
                CitizenExept.Citizenship(Applicant.Сitizenship);
            }
            catch
            {

            }
            HR = hr;
            applicant.WorkExperience[applicant.WorkExperience.Length] = 
                new WorkExperience(applicant.CurrentWork, applicant.RecruitmentDate, DateTime.Now);
            applicant.RecruitmentDate = DateTime.Now;
            applicant.CurrentWork = work;
            work.Workers[work.Workers.Length] = applicant;
        }
    }
}