using Core.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Users
{
    public class UserDto : IEntity
    {
        #region Atributes
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdUser.ToString(); set => IdUser = Convert.ToInt32(value); }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{IdUser}\n{Username}\n{PassWord}";
        }
        #endregion
    }
}
