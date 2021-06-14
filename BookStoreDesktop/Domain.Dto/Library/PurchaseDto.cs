using Core.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class PurchaseDto : IEntity
    {
        #region Atribute
        public string IdPurchase { get; set; }
        public string IdEditorial { get; set; }
        public string IdEmployee { get; set; }
        public int PurchaseStatus { get; set; }
        public double Total { get; set; }
        public DateTime? ExpectArrivalDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Connections
        public List<PurchaseLineDto> PurchaseLine { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdPurchase; set => IdPurchase = value; }
        #endregion
    }
}