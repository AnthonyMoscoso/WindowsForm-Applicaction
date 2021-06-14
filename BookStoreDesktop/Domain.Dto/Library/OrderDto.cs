using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class OrderDto : IEntity
    {
        #region Atribute
        public string IdOrder { get; set; }
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdWareHouse { get; set; }
        public int OrderStatus { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string note { get; set; }
        #endregion;

        #region Connections
        public List<OrderLineDto> OrderLine { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdOrder; set => IdOrder = value; }
        #endregion
    }
}