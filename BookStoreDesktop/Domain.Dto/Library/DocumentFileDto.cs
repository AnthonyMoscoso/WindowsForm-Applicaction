using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class DocumentFileDto : IEntity
    {
        #region Atributes
        public string IdDocument { get; set; }
        public string DocumentDir { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdDocument; set => IdDocument = value; }
        #endregion
    }
}