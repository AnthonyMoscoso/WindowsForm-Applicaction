using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class ShippingLineDto : IEntity
    {
        #region atributes
        public string IdShippingLine { get; set; }
        public string IdShipping { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdShippingLine; set => IdShippingLine = value; }
        #endregion
    }
}