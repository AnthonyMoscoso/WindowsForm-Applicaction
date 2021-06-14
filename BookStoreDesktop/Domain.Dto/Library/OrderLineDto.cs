using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class OrderLineDto : IEntity
    {
        #region Atributes
        public string IdOrderLine { get; set; }
        public string IdOrder { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdOrderLine; set => IdOrderLine = value; }
        #endregion
    }
}