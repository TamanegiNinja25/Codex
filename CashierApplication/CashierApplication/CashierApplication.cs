namespace CashierApplication
{
    public partial class CashierApplication : Form
    {
        private readonly Cashier _loggedInCashier;
        private DiscountedItem currentItem;
        public CashierApplication()
        {
            InitializeComponent();
            logoutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
        }
        public class UserAccount : frmLoginAccount
        {
            public string full_name { get; private set; }
            public string user_name { get; private set; }
            protected string user_password { get; private set; }
            public UserAccount(string name, string uName, string password)
            {
                this.full_name = name;
                this.user_name = uName;
                this.user_password = password;
            }
            public virtual bool ValidateLogin(string uName, string password)
            {
                return (this.user_name == uName && this.user_password == password);
            }
            public string GetFullName()
            {
                return this.full_name;
            }
        }
        public class Cashier : UserAccount
        {
            public string department { get; private set; }
            public Cashier(string name, string department, string uName, string password)
                : base(name, uName, password)
            {
                this.department = department;
            }
            public string GetDepartment()
            {
                return this.department;
            }
        }
        public class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            protected double total_price;
            public Item(string name, double price, int quantity)
            {
                this.item_name = name;
                this.item_price = price;
                this.item_quantity = quantity;

            }
            public virtual double getTotalPrice()
            {
                total_price = item_price * item_quantity;
                return total_price;
            }
            public virtual void setPayment(double amount)
            {

            }
        }
        public class DiscountedItem : Item
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;
            public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
            {
                item_discount = discount;
            }
            public void setTotalPrice()
            {
                double discountPortion = item_discount * 0.01;
                discounted_price = item_price - (item_price * discountPortion);
                total_price = discounted_price * item_quantity;
            }
            public override void setPayment(double amount)
            {
                payment_amount = amount;
                change = payment_amount - total_price;
            }
            public double getChange()
            {
                return change;
            }
            public double getTotalPrice()
            {
                return total_price;
            }
        }
        private void frmPurchaseDiscountedItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to logout or exit the application?",
                                                      "Confirm Close",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmLoginAccount loginForm = new frmLoginAccount();
                    loginForm.Show();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void computebtn_Click_1(object sender, EventArgs e)
        {
            string name = itemtxt.Text;
            double price = double.Parse(pricetxt.Text);
            double discount = double.Parse(discounttxt.Text);
            int quanti = int.Parse(quantitxt.Text);
            currentItem = new DiscountedItem(name, price, quanti, discount);
            currentItem.setTotalPrice();
            totaltxt.Text = currentItem.getTotalPrice().ToString();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            double payment = double.Parse(paymenttxt.Text);
            currentItem.setPayment(payment);
            changetxt.Text = currentItem.getChange().ToString();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

