using Core.Models.Entities.Abstracts;
using Domain.Dto.Library;

namespace Models.Domain.Dto.Library
{
    public class ReceptionPurchaseDto : ReceptionDto , IEntity
    {
        public string IdPurchase { get; set; }
    }
}