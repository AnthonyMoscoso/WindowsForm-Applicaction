using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class BookTypeDto : IEntity
    {
        #region Atributes
        public string IdType { get; set; }
        public string IdFather { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdType; set => IdType = value; }
        #endregion
    }
}