using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class ScheduleLineDto : IEntity
    {
        #region Atributes
        public string IdScheduleLine { get; set; }
        public string IdSchedule { get; set; }
        public int MonthNum { get; set; }
        public bool IsFree { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? BreakStar { get; set; }
        public TimeSpan? BreakEnd { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public int MonthDay { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdScheduleLine; set => IdScheduleLine = value; }
        #endregion
    }
}