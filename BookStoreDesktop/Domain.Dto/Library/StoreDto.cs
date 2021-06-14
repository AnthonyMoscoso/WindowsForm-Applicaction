using Core.Models.Entities.Abstracts;
using System.Collections.Generic;

namespace Domain.Dto.Library
{
    public class StoreDto : IEntity
    {
        #region Atributes
        public string IdStore { get; set; }
        public string IdDirection { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Connections 
        public DirectionDto Direction { get; set; }
        
        public List<ReceptionDto> Reception { get; set; }
      
         public List<EmployeeDto> Employee { get; set; }


        #endregion

        #region IEntity
        public string _Id { get => IdStore; set => IdStore = value; }

        #endregion
    }
}