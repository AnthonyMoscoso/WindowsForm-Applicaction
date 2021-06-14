using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;
using System;
using System.Collections.Generic;


namespace Domain.Dto.Library
{
    public class PersonDto : IEntity
    {
        #region Atributes
        public string IdPerson { get; set; }
        public string NamePerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public int TypePerson { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string Dni { get; set; }

        #endregion

        #region Connections
        public List<SaleDto> Reservation { get; set; }
        public List<ReservationDto> Sale { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdPerson; set => IdPerson = value; }
        #endregion
    }
}