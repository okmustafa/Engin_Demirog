using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)  //Constructor = Oluşturucu  (Ptt managerı newlediğim zaman çalışır)
        {
            _applicantService = applicantService;
        } 
        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine();
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(person.FirstName+ " için maske VERİLEMEDİ!");

            }


        }


    }
}
