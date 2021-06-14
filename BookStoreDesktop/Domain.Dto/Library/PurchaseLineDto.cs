using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class PurchaseLineDto : IEntity
    {
        #region Atribute
        public string IdPurchaseLine { get; set; }
        public string IdPurchase { get; set; }
        public string IdBook { get; set; }
        public double BookPurchasePrice { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdPurchaseLine; set => IdPurchaseLine = value; }
        #endregion
    }
}