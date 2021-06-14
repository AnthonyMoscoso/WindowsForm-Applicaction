using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class RolDto : IEntity
    {
        #region
        public string IdRol { get; set; }
        public string RolName { get; set; }
        public string RolDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion
        #region IEntity
        public string _Id { get => IdRol ; set => IdRol = value; }
        #endregion
    }
}