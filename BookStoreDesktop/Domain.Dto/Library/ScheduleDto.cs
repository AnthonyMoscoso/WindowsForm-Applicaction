using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class ScheduleDto : IEntity
    {
        #region Atributes
        public string IdSchedule { get; set; }
        public int YearValue { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdEmployee { get; set; }
        #endregion

        #region Connections
        public List<ScheduleLineDto> ScheduleLine { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdSchedule; set => IdSchedule = value; }
        #endregion
    }
}