using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class TaxesDto : IEntity
    {
        #region Atributes
        public string IdTaxes { get; set; }
        public string TaxTittle { get; set; }
        public string TaxDescription { get; set; }
        public int TaxType { get; set; }
        public double TaxValue { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdTaxes; set => IdTaxes = value; }
        #endregion

        #region Methods

        public override int GetHashCode()
        {
            return IdTaxes.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                TaxesDto x = (TaxesDto)obj;
                return (IdTaxes == x.IdTaxes);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}