﻿using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class PayRollDto : IEntity
    {
        #region Atributes
        public string IdPayRoll { get; set; }
        public string IdEmployee { get; set; }
        public int YearValue { get; set; }
        public int MonthNum { get; set; }
        public double NormalHourWorkers { get; set; }
        public double ExtraHourWorkers { get; set; }
        public double PayNormalHours { get; set; }
        public double PayExtraHours { get; set; }
        public double ExtraTotal { get; set; }
        public double TotalGross { get; set; }
        public double TotalNet { get; set; }
        public int TaxesTotal { get; set; }
        public System.DateTime PayDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Connections 

        public ICollection<TaxesDto> Taxes { get; set; }
        public ICollection<PaymentBonusDto> PaymentBonus { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdPayRoll; set => IdPayRoll = value; }
        #endregion
    }
}