using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Enum;
using System;
using System.Collections.Generic;

namespace SalesTaxesCalculator.Models.Entities.Invoice
{
    /// <summary>
    /// Represent an item
    /// </summary>
    public class Item : BaseEntity , IItem
    {
        #region Privates
        private IDescription _description;
        private float _price;
        private int _quantity;
        private ItemCategories _itemCategories;
        private bool _isImported;
        private List<ITaxe> _applicableTaxes;
        private double totalTaxes;
        #endregion

        #region Constructor

        public Item(int id) : base(id)
        {
        }

        public Item(int id, IDescription description, float price, int quantity, ItemCategories itemCategories, bool isImported, List<ITaxe> applicableTaxes) : base(id)
        {
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _price = price;
            _quantity = quantity;           
            _itemCategories = itemCategories;
            _isImported = isImported;
            _applicableTaxes = applicableTaxes ?? throw new ArgumentNullException(nameof(applicableTaxes));
        }

        public Item(int id, IDescription description, float price, int quantity, ItemCategories itemCategories, bool isImported) : base(id)
        {
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _price = price;
            _quantity = quantity;
            _itemCategories = itemCategories;
            _isImported = isImported;
        }

        #endregion

        #region Accessor

        public List<ITaxe> ApplicableTaxes {
            get => _applicableTaxes;
            set => _applicableTaxes = value;
        }

        public double TotalTaxes { get => totalTaxes; set => totalTaxes = value; }
        public float Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public bool IsImported { get => _isImported; set => _isImported = value; }
        public bool TaxesExemption {  get => _itemCategories != ItemCategories.Others; }
        public ItemCategories ItemCategories { get => _itemCategories; set => _itemCategories = value; }
   
        #endregion

        #region Functions

        public override string ToString()
        {
            return string.Format(SalesTaxesCalculator.RessourceFile.Resource.ItemLine, _quantity, _description.Name, _price);
        }
        #endregion
    }
}
