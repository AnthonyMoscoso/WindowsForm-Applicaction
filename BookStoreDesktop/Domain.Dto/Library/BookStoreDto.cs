using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class BookStoreDto : IEntity
    {
        #region Atributes
        public string IdBookStore { get; set; }
        public string IdBook { get; set; }
        public string IdStore { get; set; }
        public double BookPrice { get; set; }
        public int Stock { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdBookStore; set => IdBookStore = value; }
        #endregion

    }
}