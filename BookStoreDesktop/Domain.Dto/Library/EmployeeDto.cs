﻿using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;
using System;

namespace Domain.Dto.Library
{
    public class EmployeeDto : PersonDto , IEntity
    {
        #region Atributes 
        public string IdBoss { get; set; }
        public string IdOccupation{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int? TypeStatus { get; set; }
        public double Discount { get; set; }
        #endregion

        #region Connectios
        public OccupationDto Occupation { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PersonDto x = (PersonDto)obj;
                return (IdPerson == x.IdPerson);
            }
        }
        public override int GetHashCode()
        {
            return IdPerson.GetHashCode();
        }
        #endregion
    }
}