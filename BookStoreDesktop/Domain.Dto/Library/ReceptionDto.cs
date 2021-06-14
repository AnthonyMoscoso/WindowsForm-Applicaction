using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class ReceptionDto  : IEntity
    {
        #region Atributes
        public string IdReception { get; set; }
        public string IdEmployee { get; set; }
        public string IdStore { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Connections

        public virtual List<ReceptionLineDto> ReceptionLine { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdReception; set => IdReception = value; }
        #endregion
    }
}