﻿using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class PermitDto : IEntity
    {
        #region Atributes
        public string IdPermit { get; set; }
        public string PermitName { get; set; }
        public string PermitDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdPermit; set => IdPermit = value; }
        #endregion

        #region Methods
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PermitDto p = (PermitDto)obj;
                return (IdPermit == p.IdPermit);
            }
        }
        public override int GetHashCode()
        {
            return IdPermit.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}