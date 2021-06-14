using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class BookEditorialDto : IEntity
    {
        #region Atribute
        public string IdBookEditorial { get; set; }
        public string IdBook { get; set; }
        public string IdEditorial { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsDiscontinued { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdBookEditorial; set => IdBookEditorial = value; }
        #endregion
    }
}