using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class SaleLineDto : IEntity
    {
        #region
        public string IdSaleLine { get; set; }
        public string IdSale { get; set; }
        public string IdBook { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public int? StatusLine { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        #endregion

        #region IEntity
        public string _Id { get => IdSaleLine; set => IdSaleLine = value; }
        #endregion

    }
}