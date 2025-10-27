using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
                            double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }
        public string Product_Name { get => _ProductName; set => _ProductName = value; }
        public string Category { get => _Category; set => _Category = value; }
        public string ManufacturingDate { get => _ManufacturingDate; set => _ManufacturingDate = value; }
        public string ExpirationDate { get => _ExpirationDate; set => _ExpirationDate = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double SellingPrice { get => _SellingPrice; set => _SellingPrice = value; }
    }
}
