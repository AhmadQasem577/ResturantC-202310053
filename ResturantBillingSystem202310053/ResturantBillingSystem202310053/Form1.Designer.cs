namespace ResturantBillingSystem202310053
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            WaiterInformation = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            TableNumber = new Label();
            textBox1 = new TextBox();
            MenuItems = new GroupBox();
            DessertLabel = new Label();
            Dessert = new ComboBox();
            MainCourseLabel = new Label();
            MainCourse = new ComboBox();
            AppetizerLabel = new Label();
            Appetizer = new ComboBox();
            BeverageLabel = new Label();
            Beverages = new ComboBox();
            CheckBill = new Button();
            subTotal = new Label();
            SubTotalLabel = new Label();
            TaxLabel = new Label();
            Tax = new Label();
            TotalLabel = new Label();
            Total = new Label();
            WaiterInformation.SuspendLayout();
            MenuItems.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 17F);
            label.Location = new Point(53, 9);
            label.Name = "label";
            label.Size = new Size(302, 40);
            label.TabIndex = 0;
            label.Text = "Resturant of italy nana";
            label.Click += label1_Click;
            // 
            // WaiterInformation
            // 
            WaiterInformation.Controls.Add(textBox2);
            WaiterInformation.Controls.Add(label1);
            WaiterInformation.Controls.Add(TableNumber);
            WaiterInformation.Controls.Add(textBox1);
            WaiterInformation.Location = new Point(522, 52);
            WaiterInformation.Name = "WaiterInformation";
            WaiterInformation.Size = new Size(359, 151);
            WaiterInformation.TabIndex = 1;
            WaiterInformation.TabStop = false;
            WaiterInformation.Text = "Waiter info";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 68);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Waiter Name";
            label1.Click += label1_Click_2;
            // 
            // TableNumber
            // 
            TableNumber.AutoSize = true;
            TableNumber.Location = new Point(6, 26);
            TableNumber.Name = "TableNumber";
            TableNumber.Size = new Size(102, 20);
            TableNumber.TabIndex = 1;
            TableNumber.Text = "Table Number";
            TableNumber.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MenuItems
            // 
            MenuItems.Controls.Add(DessertLabel);
            MenuItems.Controls.Add(Dessert);
            MenuItems.Controls.Add(MainCourseLabel);
            MenuItems.Controls.Add(MainCourse);
            MenuItems.Controls.Add(AppetizerLabel);
            MenuItems.Controls.Add(Appetizer);
            MenuItems.Controls.Add(BeverageLabel);
            MenuItems.Controls.Add(Beverages);
            MenuItems.Location = new Point(25, 52);
            MenuItems.Name = "MenuItems";
            MenuItems.Size = new Size(465, 378);
            MenuItems.TabIndex = 2;
            MenuItems.TabStop = false;
            MenuItems.Text = "Menu Items";
            MenuItems.Enter += groupBox1_Enter;
            // 
            // DessertLabel
            // 
            DessertLabel.AutoSize = true;
            DessertLabel.Location = new Point(28, 279);
            DessertLabel.Name = "DessertLabel";
            DessertLabel.Size = new Size(58, 20);
            DessertLabel.TabIndex = 10;
            DessertLabel.Text = "Dessert";
            DessertLabel.Click += label4_Click;
            // 
            // Dessert
            // 
            Dessert.FormattingEnabled = true;
            Dessert.Items.AddRange(new object[] { "Apple Pie", "Sundae", "Carrot Cake", "Mud Pie", "Apple Crisp" });
            Dessert.Location = new Point(28, 302);
            Dessert.Name = "Dessert";
            Dessert.Size = new Size(193, 28);
            Dessert.TabIndex = 9;
            // 
            // MainCourseLabel
            // 
            MainCourseLabel.AutoSize = true;
            MainCourseLabel.Location = new Point(28, 196);
            MainCourseLabel.Name = "MainCourseLabel";
            MainCourseLabel.Size = new Size(91, 20);
            MainCourseLabel.TabIndex = 8;
            MainCourseLabel.Text = "Main Course";
            // 
            // MainCourse
            // 
            MainCourse.FormattingEnabled = true;
            MainCourse.Items.AddRange(new object[] { "Seafood Alfredo", "Chicken Alfredo", "Chicken Picatta", "Turkey Club", "Lobster Pie", "Prime Rib", "Shrimp Scampi", "Turkey Dinner", "StuffedChecken", "", "", "", "", "", "", "" });
            MainCourse.Location = new Point(28, 219);
            MainCourse.Name = "MainCourse";
            MainCourse.Size = new Size(193, 28);
            MainCourse.TabIndex = 7;
            // 
            // AppetizerLabel
            // 
            AppetizerLabel.AutoSize = true;
            AppetizerLabel.Location = new Point(28, 128);
            AppetizerLabel.Name = "AppetizerLabel";
            AppetizerLabel.Size = new Size(74, 20);
            AppetizerLabel.TabIndex = 6;
            AppetizerLabel.Text = "Appetizer";
            // 
            // Appetizer
            // 
            Appetizer.FormattingEnabled = true;
            Appetizer.Items.AddRange(new object[] { "Buffalo Wings", "buffalo Fingers", "Potato Skins", "Nachos", "Mushroom Caps", "Shrimp Coctail", "Chips and Salsa" });
            Appetizer.Location = new Point(28, 151);
            Appetizer.Name = "Appetizer";
            Appetizer.Size = new Size(193, 28);
            Appetizer.TabIndex = 5;
            // 
            // BeverageLabel
            // 
            BeverageLabel.AutoSize = true;
            BeverageLabel.Location = new Point(28, 51);
            BeverageLabel.Name = "BeverageLabel";
            BeverageLabel.Size = new Size(77, 20);
            BeverageLabel.TabIndex = 4;
            BeverageLabel.Text = "Beverages";
            BeverageLabel.Click += label2_Click;
            // 
            // Beverages
            // 
            Beverages.FormattingEnabled = true;
            Beverages.Items.AddRange(new object[] { "Soda", "Tea", "Coffee", "Mineral Water", "Juice", "Milk" });
            Beverages.Location = new Point(28, 74);
            Beverages.Name = "Beverages";
            Beverages.Size = new Size(193, 28);
            Beverages.TabIndex = 0;
            // 
            // CheckBill
            // 
            CheckBill.Location = new Point(522, 209);
            CheckBill.Name = "CheckBill";
            CheckBill.Size = new Size(359, 59);
            CheckBill.TabIndex = 3;
            CheckBill.Text = "Clear Bill";
            CheckBill.UseVisualStyleBackColor = true;
            CheckBill.Click += CheckBill_Click;
            // 
            // subTotal
            // 
            subTotal.AutoSize = true;
            subTotal.Location = new Point(611, 292);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(44, 20);
            subTotal.TabIndex = 4;
            subTotal.Text = "$0.00";
            subTotal.Click += label2_Click_1;
            // 
            // SubTotalLabel
            // 
            SubTotalLabel.AutoSize = true;
            SubTotalLabel.Location = new Point(522, 292);
            SubTotalLabel.Name = "SubTotalLabel";
            SubTotalLabel.Size = new Size(67, 20);
            SubTotalLabel.TabIndex = 5;
            SubTotalLabel.Text = "SubTotal";
            SubTotalLabel.Click += label2_Click_2;
            // 
            // TaxLabel
            // 
            TaxLabel.AutoSize = true;
            TaxLabel.Location = new Point(522, 331);
            TaxLabel.Name = "TaxLabel";
            TaxLabel.Size = new Size(30, 20);
            TaxLabel.TabIndex = 7;
            TaxLabel.Text = "Tax";
            TaxLabel.Click += TaxLabel_Click;
            // 
            // Tax
            // 
            Tax.AutoSize = true;
            Tax.Location = new Point(611, 331);
            Tax.Name = "Tax";
            Tax.Size = new Size(44, 20);
            Tax.TabIndex = 6;
            Tax.Text = "$0.00";
            Tax.Click += Tax_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(522, 373);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(42, 20);
            TotalLabel.TabIndex = 9;
            TotalLabel.Text = "Total";
            TotalLabel.Click += TotalLabel_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(611, 373);
            Total.Name = "Total";
            Total.Size = new Size(44, 20);
            Total.TabIndex = 8;
            Total.Text = "$0.00";
            // 
            // Form1
            // 
            AcceptButton = CheckBill;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 530);
            Controls.Add(TotalLabel);
            Controls.Add(Total);
            Controls.Add(TaxLabel);
            Controls.Add(Tax);
            Controls.Add(SubTotalLabel);
            Controls.Add(subTotal);
            Controls.Add(CheckBill);
            Controls.Add(MenuItems);
            Controls.Add(WaiterInformation);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            WaiterInformation.ResumeLayout(false);
            WaiterInformation.PerformLayout();
            MenuItems.ResumeLayout(false);
            MenuItems.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private GroupBox WaiterInformation;
        private Label TableNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private GroupBox MenuItems;
        private Label BeverageLabel;
        private ComboBox Beverages;
        private Label DessertLabel;
        private ComboBox Dessert;
        private Label MainCourseLabel;
        private ComboBox MainCourse;
        private Label AppetizerLabel;
        private ComboBox Appetizer;
        private Button CheckBill;
        private Label subTotal;
        private Label SubTotalLabel;
        private Label TaxLabel;
        private Label Tax;
        private Label TotalLabel;
        private Label Total;
    }
}
