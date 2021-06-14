using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class EditionDto : IEntity
    {
        #region Atributes
        public string IdEdition { get; set; }
        public string EditionName { get; set; }
        public string EditionDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdEdition; set => IdEdition = value; }
        #endregion
    }
}