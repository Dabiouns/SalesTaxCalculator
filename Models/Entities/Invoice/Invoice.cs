using SalesTaxesCalculator.Interface;
using System;
using System.Collections.Generic;

namespace SalesTaxesCalculator.Models.Entities.Invoice
{

    public class Invoice : BaseEntity, IInvoice
    {
        #region Privates
        private List<IItem> _items;
        private double _total;
        private double _totalTax;
        #endregion

        #region Constructor
        public Invoice(int id) : base(id) { }

        public Invoice(int id, List<IItem> items) : base(id)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }
        #endregion

        #region Accessor
        public List<IItem> Items { get => _items; set => _items = value; }
        public double Total { get => _total; set => _total = value; }
        public double TotalTax { get => _totalTax; set => _totalTax = value; }

        #endregion

    }
}
