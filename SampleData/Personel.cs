using Basic = Models.Personel;
using Adv = Models.Personel_Adv;
using System;
using System.Collections.Generic;
using SadrTools.Utility;
using System.Security.Cryptography;

namespace SampleData
{
    public static class Personel
    {
        public static List<Basic.Person> GetPeople()
        {
            var person1 = new Basic.Person
            {

                FirstName = "Soroush",
                LastName = "Sadr",
                //Grade = 18.98,
                SSN = "1111222259",
                BirthDate = new DateTime(1984, 1, 31),
                Gender = true,
                Emails = new List<Basic.Email>
                {
                    new Basic.Email
                    {
                         
                         EmailAddress = "soroush@yahoo.com",
                         EmailProviderType = Basic.EnEmailProviderType.Yahoo
                    },
                    new Basic.Email
                    {
                         
                         EmailAddress = "soroush@microsoft.com",
                         EmailProviderType = Basic.EnEmailProviderType.Microsoft
                    },
                },
                Telephones = new List<Basic.Telephone>
                 {
                     new Basic.Telephone
                     {
                         
                         Number = "09121212121",
                         TelephoneType = Basic.EnTelephoneType.Mobile
                     }
                 }

            };

            var person2 = new Basic.Person
            {
                FirstName = "Ali",
                LastName = "Alavi",
                //Grade = 18.98,
                SSN = "4455770022",
                BirthDate = new DateTime(2000, 1, 31),
                Gender = true,
                Telephones = new List<Basic.Telephone>
                 {
                     new Basic.Telephone
                     {
                         ID = 2 ,
                         Number = "+989120000000",
                         TelephoneType = Basic.EnTelephoneType.Office
                     },
                    new Basic.Telephone
                     {
                         ID = 4 ,
                         Number = "+980212226458",
                         TelephoneType = Basic.EnTelephoneType.Home
                     },
                    new Basic.Telephone
                     {
                         ID = 4 ,
                         Number = "093339300000",
                         TelephoneType = Basic.EnTelephoneType.Mobile
                     },
                 }

            };

            var person3 = new Basic.Person
            {
                FirstName = "arezoo",
                LastName = "Alavi",
               //Grade = 18.98,
                SSN = "1234567890",
                BirthDate = new DateTime(2002, 1, 31),
                Gender = false,
                Emails = new List<Basic.Email>
                {
                    new Basic.Email
                    {
                        EmailAddress = "arezoo@gmail.com",
                         EmailProviderType = Basic.EnEmailProviderType.Google
                    },
                    new Basic.Email
                    {
                        EmailAddress = "arezo.Alavi55@live.com",
                         EmailProviderType = Basic.EnEmailProviderType.Microsoft
                    },

                }
            };

            var people = new List<Basic.Person> { person1, person2, person3 };

            //people.Add(person1);

            return people;

        }


        public static List<Adv.Person> GetPeopleYasamin()
        {
            var person1 = new Adv.Person
            {
                
                FirstName = "Soroush",
                LastName = "Sadr",
                Grade = 18.98,
                SSN = "0012450098",
                BirthDate = new DateTime(1984, 1, 31),
                Gender = true,
                Emails = new List<Adv.Email>
                {
                    new Adv.Email
                    {
                         EmailAddress = "soroush@yahoo.com",
                         EmailProviderType = Adv.EnEmailProviderType.Yahoo
                    },
                    new Adv.Email
                    {
                         EmailAddress = "soroush@microsoft.com",
                         EmailProviderType = Adv.EnEmailProviderType.Microsoft
                    },
                },
                Telephones = new List<Adv.Telephone>
                 {
                     new Adv.Telephone
                     {
                         Number = "09121212121",
                         TelephoneType = Adv.EnTelephoneType.Mobile
                     }
                 }

            };

            var person2 = new Adv.Person
            {
                FirstName = "Ali",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "5555666600",
                BirthDate = new DateTime(2000, 1, 31),
                Gender = true,
                Telephones = new List<Adv.Telephone>
                 {
                     new Adv.Telephone
                     {
                         Number = "888111222",
                         TelephoneType = Adv.EnTelephoneType.Office
                     }
                 }

            };

            var person3 = new Adv.Person
            {
                FirstName = "arezoo",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "9999111155",
                BirthDate = new DateTime(2002, 1, 31),
                Gender = false,
                Emails = new List<Adv.Email>
                {
                    new Adv.Email
                    {
                        EmailAddress = "arezoo@gmail.com",
                        EmailProviderType = Adv.EnEmailProviderType.Google
                    }
                }
            };

            return new List<Adv.Person> { person1, person2, person3 };

        }


        //'ToString': cannot declare instance members in a static class SampleData
        /*
        public override string ToString()
        {
            return base.ToString();
        }
        */

    }
}
