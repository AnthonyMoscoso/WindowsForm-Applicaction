﻿using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class EditorialDto : IEntity
    {
        #region Atribute
        public string IdEditorial { get; set; }
        public string IdDirection { get; set; }
        public string IdEditorialFather { get; set; }
        public string EditorialName { get; set; }
        public string EditorialDescription { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdEditorial; set => IdEditorial = value; }
        #endregion
    }
}