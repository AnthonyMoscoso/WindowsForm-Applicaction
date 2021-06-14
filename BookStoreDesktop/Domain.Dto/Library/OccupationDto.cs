using Core.Models.Entities.Abstracts;

namespace Domain.Dto.Library
{
    public class OccupationDto : IEntity
    {
        #region Atributes
        public string IdOccupation { get; set; }
        public string OcupationName { get; set; }
        public string OcupationDescription { get; set; }
        public double Salary { get; set; }
        public double PayNormalHours { get; set; }
        public double PayExtraHours { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdOccupation; set => IdOccupation = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {OcupationName}\nDescription: {OcupationDescription}\nSalary: {Salary}\nPayExtra: {PayExtraHours}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return IdOccupation.GetHashCode();
        }
        #endregion
    }
}