namespace SalesTaxesCalculator.Models.Entities
{
    /// <summary>
    /// Base type use by every entity
    /// Use as Identity for EF
    /// </summary>
    public class BaseEntity
    {
        #region Privates
        
        private int _id;
        #endregion

        #region Constructor

        public BaseEntity(int id) {
            _id = id;
        }
        #endregion

        #region Accessor

        public int Id { 
            get => _id; set => _id = value; 
        }
        #endregion
    }
}
