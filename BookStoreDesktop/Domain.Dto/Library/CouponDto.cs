﻿using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class CouponDto : IEntity
    {
        #region Atributes
        public string IdCoupon { get; set; }
        public string CouponCode { get; set; }
        public DateTime StartOffert { get; set; }
        public DateTime? FinishOffert { get; set; }
        public int TypeCoupon { get; set; }
        public double CouponValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdCoupon; set => IdCoupon = value; }
        #endregion
    }
}