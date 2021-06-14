using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class DiscountDto : IEntity
    {
        #region Atributes
        public string IdDiscount { get; set; }
        public int? TypeDiscount { get; set; }
        public System.DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double DiscountValue { get; set; }
        public int DiscountStatus { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion
        #region IEntity
        public string _Id { get => IdDiscount; set => IdDiscount = value; }
        #endregion
    }
}