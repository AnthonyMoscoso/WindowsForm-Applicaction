using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class ProviderDto : IEntity
    {
        #region atribute
        public string IdProvider { get; set; }
        public string IdDirection { get; set; }
        public string ProviderName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        #endregion

        #region Connectios
        public DirectionDto Direction { get; set; }
        #endregion

        #region
        public string _Id { get => IdProvider; set => IdProvider = value; }
        #endregion
    }
}