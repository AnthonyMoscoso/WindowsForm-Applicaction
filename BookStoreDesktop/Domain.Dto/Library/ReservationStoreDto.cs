using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class ReservationStoreDto : ReservationDto , IEntity
    {
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdStoreSale { get; set; }
    }
}