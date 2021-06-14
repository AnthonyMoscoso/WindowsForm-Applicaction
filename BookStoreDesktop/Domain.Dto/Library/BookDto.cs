using Core.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class BookDto : IEntity
    {
        #region Atributes
        public string IdBook { get; set; }
        public string IdType { get; set; }
        public string IdEdition { get; set; }
        public string BookTittle { get; set; }
        public string Languages { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Pags { get; set; }
        public string ISBM { get; set; }
        public int EditionNum { get; set; }
        public string Synopsis { get; set; }
        public double Price { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public int BindingType { get; set; }
        #endregion

        #region Connections 
        public List<AutorDto> Autor { get; set; }
        public List<BookEditorialDto> BookEditorial { get; set; }
        public List<GenderDto> Gender { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdBook; set => IdBook = value; }

        #endregion
    }
}