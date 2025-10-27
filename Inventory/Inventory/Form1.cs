using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Inventory.ExceptionClass;
namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showProductList = new BindingSource();
            prodgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prodgrid.DataSource = showProductList;
            manufacturingdate.Format = DateTimePickerFormat.Custom;
            manufacturingdate.CustomFormat = "yyyy-MM-dd";
            expirationdate.Format = DateTimePickerFormat.Custom;
            expirationdate.CustomFormat = "yyyy-MM-dd";
        }
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(prodtxt.Text);
                _Category = categcbx.Text;
                _MfgDate = manufacturingdate.Value.ToString("yyyy-MM-dd");
                _ExpDate = expirationdate.Value.ToString("yyyy-MM-dd");
                _Description = descriptiontxt.Text;
                _Quantity = Quantity(quantitxt.Text);
                _SellPrice = SellingPrice(sellpricetxt.Text);

                // add to BindingSource (grid is already bound to showProductList)
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));

                // optional: clear inputs or set focus for next entry
                prodtxt.Clear();
                quantitxt.Clear();
                sellpricetxt.Clear();
                descriptiontxt.Clear();
                categcbx.SelectedIndex = -1;
                prodtxt.Focus();
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show("Product name error: " + ex.Message, "ERROR ERROR ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show("Quantity error: " + ex.Message, "ERROR ERROR ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show("Price error: " + ex.Message, "ERROR ERROR ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
            {
            "Beverages",
            "Bread/Bakery",
            "Canned/Jarred Goods",
            "Dairy",
            "Frozen Goods",
            "Meat",
            "Personal Care",
            "Other"
            };

            foreach (string c in ListOfProductCategory)
                categcbx.Items.Add(c);
        }
        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                throw new StringFormatException("Product Name MUST CONTAIN ONLY Letters and Spaces.");
            if (string.IsNullOrWhiteSpace(name))
                throw new StringFormatException("Please Enter a valid Product Name.");
            if (name.Trim().Length > 50)
                throw new StringFormatException("Product name is too long (max 50 characters).");
            return name.Trim();
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
                throw new NumberFormatException("Quantity must be numeric only.");
            if (!int.TryParse(qty, NumberStyles.Integer, CultureInfo.CurrentCulture, out int q))
                throw new NumberFormatException("Quantity must be a whole number.");
            if (q < 0)
                throw new NumberFormatException("Quantity cannot be negative.");
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (string.IsNullOrWhiteSpace(price))
                throw new CurrencyFormatException("Price cannot be empty.");

            if (!Regex.IsMatch(price, @"^(\d+(\.\d{1,2})?)$"))
                throw new CurrencyFormatException("Price must be numeric, e.g. 25 or 25.50.");

            if (!double.TryParse(price, NumberStyles.Currency | NumberStyles.Number, CultureInfo.CurrentCulture, out double parsedPrice))
            {
                if (!double.TryParse(price, NumberStyles.Number, CultureInfo.InvariantCulture, out parsedPrice))
                    throw new CurrencyFormatException("Price must be a valid number (example: 25.50).");
            }
            if (parsedPrice < 0)
                throw new CurrencyFormatException("Price cannot be negative.");
            return parsedPrice;
        }
    }
}

