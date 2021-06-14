using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class ReceptionOrderDto : ReceptionDto , IEntity
    {
        public string IdOrder { get; set; }

    }
}