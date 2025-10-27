namespace CashierApplication.V2
{
    public partial class frmDiscountedItem : Form
    {
        private DiscountedItem currentItem;
        public frmDiscountedItem()
        {
            InitializeComponent();
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
        private void computebtn_Click(object sender, EventArgs e)
        {
            string name = itemtxt.Text;
            double price = double.Parse(pricetxt.Text);
            double discount = double.Parse(discounttxt.Text);
            int quanti = int.Parse(quantitxt.Text);
            currentItem = new DiscountedItem(name, price, quanti, discount);
            currentItem.setTotalPrice();
            totaltxt.Text = currentItem.getTotalPrice().ToString();
        }

        private void submittxt_Click(object sender, EventArgs e)
        {
            double payment = double.Parse(paymenttxt.Text);
            currentItem.setPayment(payment);
            changetxt.Text = currentItem.getChange().ToString();
        }
    }
}