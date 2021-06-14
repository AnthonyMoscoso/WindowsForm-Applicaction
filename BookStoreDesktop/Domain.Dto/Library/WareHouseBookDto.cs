using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class WareHouseBookDto : IEntity
    {
        #region Atributes
        public string IdWareHouseBook { get; set; }
        public string IdWareHouse { get; set; }
        public string IdBook { get; set; }
        public int Stock { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdWareHouseBook; set => IdWareHouseBook = value; }
        #endregion
    }
}