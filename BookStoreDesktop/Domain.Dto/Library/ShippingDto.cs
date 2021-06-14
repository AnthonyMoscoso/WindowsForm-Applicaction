using Core.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class ShippingDto : IEntity
    {

        #region Atributes
        public string IdShipping { get; set; }
        public string IdDirectionFrom { get; set; }
        public string IdDirectionTo { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ExpectArrivalDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int ShippingStatus { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdWareHouse { get; set; }

        #endregion

        #region Connections

        public List<ShippingLineDto> ShippingLine { get; set; }
        public DirectionDto Direction { get; set; }
        public DirectionDto Direction1 { get; set; }

        #endregion

        #region IEntity 

        public string _Id { get => IdShipping; set => IdShipping = value; }
        #endregion
    }
}