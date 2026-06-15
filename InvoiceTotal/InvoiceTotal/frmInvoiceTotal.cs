namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;

            //if (customerType == "r")
            //{
            //    if (subtotal < 250)
            //        discountPct = .0m;
            //    else if (subtotal >= 250 && subtotal < 500)
            //        discountPct = .25m;
            //    else if (subtotal >= 500)
            //        discountPct = .30m;
            //}
            //else if (customerType == "c")
            //{
            //    if (subtotal > 0)
            //        discountPct = .2m;
            //    //else
            //    //    discountPct = .3m;
            //}
            //else if (customerType == "t")
            //{
            //    if (subtotal <= 500)
            //        discountPct = .4m;
            //    else
            //        discountPct = .5m;
            //}
            //else
            //{
            //    discountPct = .1m;
            //}

            //switch (customerType)
            //{
            //    case "R":
            //        if (subtotal < 250)
            //            discountPct = .0m;
            //        else if (subtotal >= 250 && subtotal < 500)
            //            discountPct = .25m;
            //        else if (subtotal >= 500)
            //            discountPct = .30m;
            //        break;
            //    //case "r":
            //    //    if (subtotal < 250)
            //    //        discountPct = .0m;
            //    //    else if (subtotal >= 250 && subtotal < 500)
            //    //        discountPct = .25m;
            //    //    else if (subtotal >= 500)
            //    //        discountPct = .30m;
            //    //    break;
            //    case "C":
            //        if (subtotal > 0)
            //            discountPct = .2m;
            //        break;
            //    //case "c":
            //    //    if (subtotal > 0)
            //    //        discountPct = .2m;
            //    //    break;
            //    case "T":
            //        if (subtotal <= 500)
            //            discountPct = .4m;
            //        else
            //            discountPct = .5m;
            //        break;
            //    //case "t":
            //    //    if (subtotal <= 500)
            //    //        discountPct = .4m;
            //    //    else
            //    //        discountPct = .5m;
            //    //    break;
            //    default:
            //        discountPct = .1m;
            //        break;
            //}
            discountPct = customerType switch
            {
                "R" => 0.3m,
                "C" => 0.2m,
                "T" => 0.5m,
                _ => 0.1m
            };

            decimal discountAmt = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }
    }
}