using SalesTaxesCalculator.Interface;
using System;

namespace SalesTaxesCalculator.Models.Entities
{
    /// <summary>
    /// Define taxes at the item level
    /// </summary>
    public class Taxe : BaseEntity, ITaxe
    {
        #region Privates
        private IDescription _description;
        //private TaxeType _taxeType;
        private float _rates;
        private float _total;

        public Taxe(int id, IDescription description, float rates) : base(id)
        {
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _rates = rates;

        }
        #endregion

        #region Accessor       

        public float Rates
        {
            get => _rates;
        }
        public float Total { get => _total; set => _total = value; }

        IDescription ITaxe.Description
        {
            get => _description;
            set => _description = value;
        }


        #endregion


    }
}
