using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class SocieDto : PersonDto , IEntity
    {
        public double Discount { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? DesactivateDate { get; set; }
    }
}