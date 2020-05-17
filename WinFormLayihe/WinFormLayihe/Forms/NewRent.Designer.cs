namespace WinFormLayihe.Forms
{
    partial class NewRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClient = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSell = new System.Windows.Forms.DateTimePicker();
            this.dtpPromise = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnRent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.lblAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 46);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 17);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(26, 66);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(256, 24);
            this.cbClients.Sorted = true;
            this.cbClients.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sell Date";
            // 
            // dtpSell
            // 
            this.dtpSell.Location = new System.Drawing.Point(26, 128);
            this.dtpSell.Name = "dtpSell";
            this.dtpSell.Size = new System.Drawing.Size(173, 22);
            this.dtpSell.TabIndex = 3;
            this.dtpSell.ValueChanged += new System.EventHandler(this.dtpSell_ValueChanged);
            // 
            // dtpPromise
            // 
            this.dtpPromise.Location = new System.Drawing.Point(26, 191);
            this.dtpPromise.Name = "dtpPromise";
            this.dtpPromise.Size = new System.Drawing.Size(173, 22);
            this.dtpPromise.TabIndex = 5;
            this.dtpPromise.ValueChanged += new System.EventHandler(this.dtpPromise_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promise Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car";
            // 
            // cbCars
            // 
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(26, 253);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(256, 24);
            this.cbCars.TabIndex = 7;
            this.cbCars.SelectedIndexChanged += new System.EventHandler(this.cbCars_SelectedIndexChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(288, 66);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(28, 24);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "+";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(288, 252);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(28, 24);
            this.btnAddCar.TabIndex = 9;
            this.btnAddCar.Text = "+";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(26, 320);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 22);
            this.numPrice.TabIndex = 11;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(26, 439);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(290, 42);
            this.btnRent.TabIndex = 12;
            this.btnRent.Text = "Rent a Car  ";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Year";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(196, 320);
            this.numYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.ReadOnly = true;
            this.numYear.Size = new System.Drawing.Size(120, 22);
            this.numYear.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Price";
            // 
            // numTotalPrice
            // 
            this.numTotalPrice.Enabled = false;
            this.numTotalPrice.Location = new System.Drawing.Point(26, 381);
            this.numTotalPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalPrice.Name = "numTotalPrice";
            this.numTotalPrice.Size = new System.Drawing.Size(120, 22);
            this.numTotalPrice.TabIndex = 16;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(164, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(59, 17);
            this.lblAdmin.TabIndex = 17;
            this.lblAdmin.Text = "Admin : ";
            // 
            // NewRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 503);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.numTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.cbCars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPromise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.lblClient);
            this.Name = "NewRent";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSell;
        private System.Windows.Forms.DateTimePicker dtpPromise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTotalPrice;
        private System.Windows.Forms.Label lblAdmin;
    }
}