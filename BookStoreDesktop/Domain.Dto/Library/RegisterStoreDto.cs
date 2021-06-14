using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class RegisterStoreDto : RegisterDto ,IEntity
    {
        public string IdStore { get; set; }
    }
}