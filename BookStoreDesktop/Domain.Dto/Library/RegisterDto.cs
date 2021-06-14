using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class RegisterDto : IEntity
    {
        #region Atribute
        public string IdRegister { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Connections
        public List<RegisterLineDto> RegisterLine { get; set; }

        #endregion

        #region IEntity
        public string _Id { get => IdRegister; set => IdRegister = value; }

        #endregion
    }
}