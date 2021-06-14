using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class ReturnSaleDto : IEntity
    {
        #region Atributes
        public string IdReturn { get; set; }
        public string IdSale { get; set; }
        public double Repayment { get; set; }
        public int RepaymentStatus { get; set; }
        public string ReturnMotive { get; set; }
        public string ReturnDescription { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public double BookPrice { get; set; }
        public byte RepaymentMethod { get; set; }
        public string IdStore { get; set; }
        public string IdWareHouse { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdReturn; set => IdReturn = value; }
        #endregion
    }
}