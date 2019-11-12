using SalesTaxesCalculator.Interface;
using System;

namespace SalesTaxesCalculator.Models.Entities
{
    public class Description : IDescription
    {
        #region Privates
        private string _name;
        private string _desc;
        #endregion

        #region Constructor
        public Description(string name, string description)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _desc = description ;
        }
        #endregion

        #region Accessor
        public string Name { get => _name; set => _name = value; }
        public string Desc { get => _desc; set => _desc = value; }
        #endregion
    }
}
