﻿using Models.Personel;
using SadrTools.Utility;

namespace Models.Personel_Adv
{
    /// <summary>
    /// موجودیت اطلاعات تماس
    /// </summary>
    public class Email
    {
        public Email()
        {
            ID = NumericHelper.GetRandom();
            EmailAddress = "test@test.ir";
            EmailProviderType = EnEmailProviderType.Other;
        }

        public int ID
        {
            get;
        }

        public string EmailAddress { get; set; }

        public EnEmailProviderType EmailProviderType { get; set; }

        public override string ToString()
        {
            return $"{ID} {EmailAddress} {EmailProviderType}\n";
        }
    }

}
