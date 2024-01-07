using SadrTools.Utility;

namespace Models.Personel
{
    /// <summary>
    /// موجودیت اطلاعات تماس
    /// </summary>
    public class Email
    {
        public Email()
        {
            ID = NumericHelper.GetRandom(100,2000);
            EmailAddress = "test@test.ir";
            EmailProviderType = EnEmailProviderType.Other;
        }

        public int ID { get; set; }

        public string EmailAddress { get; set; }

        public EnEmailProviderType EmailProviderType { get; set; }

        public override string ToString()
        {
            return $"{ID} {EmailAddress} {EmailProviderType}\n";
        }
    }

}
