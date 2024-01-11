using SadrTools.Utility;

namespace Models.Personel_Adv
{
    /// <summary>
    /// موجودیت اطلاعات تماس
    /// </summary>
    public class Telephone
    {
        public Telephone()
        {
            ID = NumericHelper.GetRandom();
            Number = "111111111";
            TelephoneType = EnTelephoneType.Other;
        }

        public int ID
        {
            //get
            //{
            //    return NumericHelper.GetRandom();
            //}
            get;
        }

        public string Number { get; set; }

        public EnTelephoneType TelephoneType { get; set; }

        public override string ToString()
        {
            return $"{ID} {Number} {TelephoneType}\n";
        }
    }

}
