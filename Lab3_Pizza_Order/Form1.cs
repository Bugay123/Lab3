namespace Lab3_Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double CheesePizzaPrice = 8.00;
        private const double PepperoniPizzaPrice = 9.00;
        private const double VeggiePizzaPrice = 10.00;
        private const double MeatLoversPizzaPrice = 11.00;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            int quantity = (int)quantityNumericUpDown.Value;

            
            double totalPrice = 0.0;
            if (cheesePizzaRadioButton.Checked)
            {
                totalPrice = quantity * CheesePizzaPrice;
            }
            else if (pepperoniPizzaRadioButton.Checked)
            {
                totalPrice = quantity * PepperoniPizzaPrice;
            }
            else if (veggiePizzaRadioButton.Checked)
            {
                totalPrice = quantity * VeggiePizzaPrice;
            }
            else if (meatLoversPizzaRadioButton.Checked)
            {
                totalPrice = quantity * MeatLoversPizzaPrice;
            }

            
            if (quantity > 20)
            {
                totalPrice *= 0.9;
            }
            label1.Visible = true;
            label1.Text = $"Total Price: {totalPrice:F2}";
        }
    }
}
