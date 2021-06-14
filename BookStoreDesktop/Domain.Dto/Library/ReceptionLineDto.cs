using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class ReceptionLineDto : IEntity
    {
        #region Atributes
        public string IdReceptionLine { get; set; }
        public string IdReception { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdReceptionLine; set => IdReceptionLine = value; }
        #endregion
    }
}