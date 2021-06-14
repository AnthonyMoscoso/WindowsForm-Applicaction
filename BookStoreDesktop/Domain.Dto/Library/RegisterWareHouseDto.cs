using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class RegisterWareHouseDto : RegisterDto , IEntity
    {
        public string IdWareHouse { get; set; }
    }
}