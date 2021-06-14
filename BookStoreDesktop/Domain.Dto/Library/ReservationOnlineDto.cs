using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class ReservationOnlineDto : ReservationDto , IEntity
    {
        public string IdWareHouse { get; set; }
        public string IdOnlineSale { get; set; }
    }
}