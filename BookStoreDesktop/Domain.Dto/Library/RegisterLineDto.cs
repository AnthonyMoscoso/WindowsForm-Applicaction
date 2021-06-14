using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class RegisterLineDto : IEntity
    {

        #region Atribute
        public string IdRegisterLine { get; set; }
        public string IdRegister { get; set; }
        public string IdEmployee { get; set; }
        public TimeSpan? EnterHour { get; set; }
        public TimeSpan? ExitHour { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdRegisterLine; set => IdRegisterLine = value; }
        #endregion
    }
}