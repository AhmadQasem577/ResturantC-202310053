namespace ResturantBillingSystem202310053
{
    public partial class Form1 : Form
    {
       

        static float[] BeveragePrices = {
            0,
            1.95f,
            1.5f,
            1.25f,
            2.95f,
            2.50f,
            1.5f
        };
       static float[] AppetaizerPrices = {
            0,
            5.95f,
            6.95f,
            8.95f,
            8.95f,
            10.95f,
            12.95f,
            6.95f
        };
        float[] MainCoursePrices = {
            0,
            15.95f,
            13.95f,
            13.95f,
            11.95f,
            19.95f,
            20.95f,
            18.95f,
            13.95f,
            14.95f
        };
        float[] DessertPrices = {
            0,
            5.95f,
            3.95f,
            5.95f,
            4.95f,
            5.95f
        };
        float subTotalCalc()
        {
            int BevIndex = Beverages.SelectedIndex;
            int MainIndex = MainCourse.SelectedIndex;
            int desIndex = Dessert.SelectedIndex;
            int AppetIndex = Appetizer.SelectedIndex;

            return  BeveragePrices[BevIndex + 1] +
                    MainCoursePrices[MainIndex + 1] +
                    DessertPrices[desIndex + 1] +
                    AppetaizerPrices[AppetIndex + 1];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void CheckBill_Click(object sender, EventArgs e)
        {
            

            float subTotalValue = subTotalCalc();
            subTotal.Text = $"${subTotalValue:F2}";
            Tax.Text = $"${subTotalValue * 0.16:F2}";
            Total.Text = $"${subTotalValue + subTotalValue * 0.16:F2}";




        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }
        private void TaxLabel_Click(object sender, EventArgs e)
        {

        }
        private void Tax_Click(object sender, EventArgs e)
        {

        }
        private void FinalCheck_Click(object sender, EventArgs e)
        {



        }

    }
}
