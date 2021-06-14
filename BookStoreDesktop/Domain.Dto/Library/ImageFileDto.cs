using Core.Models.Entities.Abstracts;
using System;

namespace Domain.Dto.Library
{
    public class ImageFileDto : IEntity
    {
        #region Atributes
        public string IdImageFile { get; set; }
        public string FileDir { get; set; }
        public string ImageFileName { get; set; }
        public string ImageType { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion
        #region IEntity
        public string _Id { get => IdImageFile; set => IdImageFile = value; }
        #endregion
    }
}