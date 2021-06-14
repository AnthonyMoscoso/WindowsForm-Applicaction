using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class PaymentBonusDto : IEntity
    {
        #region Atributes
        public string IdPaymentBonus { get; set; }
        public string BonusTittle { get; set; }
        public int BonusType { get; set; }
        public double BonusValue { get; set; }
        public string BonusDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        #endregion

        #region Methods

        public override int GetHashCode()
        {
            return IdPaymentBonus.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PaymentBonusDto x = (PaymentBonusDto)obj;
                return (IdPaymentBonus == x.IdPaymentBonus);
            }
        }
        public override string ToString()
        {
            return $"{IdPaymentBonus};{BonusTittle};{BonusType};{BonusValue};{BonusDescription};{CreateDate};{LastUpdateDate};{StatusCode}";
        }
        #endregion
    }
}