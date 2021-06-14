using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class StoreSaleDto : SaleDto , IEntity
    {
        public string IdStore { get; set; }
        public string IdSeller { get; set; }
        
    }
}