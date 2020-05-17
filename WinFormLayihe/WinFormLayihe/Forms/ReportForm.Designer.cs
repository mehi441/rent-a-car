namespace WinFormLayihe.Forms
{
    partial class ReportForm
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
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCarNumbers = new System.Windows.Forms.ComboBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReceiveAdmin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSellAdmin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSellStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSellEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPriceMin = new System.Windows.Forms.NumericUpDown();
            this.numPriceMax = new System.Windows.Forms.NumericUpDown();
            this.dtpReceiveEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpReceiveStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnToExel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRents
            // 
            this.dgvRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column14,
            this.Column10,
            this.Column11,
            this.Column9,
            this.Column12,
            this.Column13});
            this.dgvRents.Location = new System.Drawing.Point(12, 135);
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.RowHeadersWidth = 51;
            this.dgvRents.RowTemplate.Height = 24;
            this.dgvRents.Size = new System.Drawing.Size(1587, 590);
            this.dgvRents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand";
            // 
            // cbBrands
            // 
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(12, 29);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(154, 24);
            this.cbBrands.TabIndex = 2;
            this.cbBrands.SelectedIndexChanged += new System.EventHandler(this.cbBrands_SelectedIndexChanged);
            // 
            // cbModels
            // 
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(12, 89);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(154, 24);
            this.cbModels.TabIndex = 4;
            this.cbModels.SelectedIndexChanged += new System.EventHandler(this.cbModels_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number";
            // 
            // cbCarNumbers
            // 
            this.cbCarNumbers.FormattingEnabled = true;
            this.cbCarNumbers.Location = new System.Drawing.Point(192, 29);
            this.cbCarNumbers.Name = "cbCarNumbers";
            this.cbCarNumbers.Size = new System.Drawing.Size(154, 24);
            this.cbCarNumbers.TabIndex = 6;
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(192, 89);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(154, 24);
            this.cbClients.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client";
            // 
            // cbReceiveAdmin
            // 
            this.cbReceiveAdmin.FormattingEnabled = true;
            this.cbReceiveAdmin.Location = new System.Drawing.Point(377, 89);
            this.cbReceiveAdmin.Name = "cbReceiveAdmin";
            this.cbReceiveAdmin.Size = new System.Drawing.Size(154, 24);
            this.cbReceiveAdmin.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Receive Admin";
            // 
            // cbSellAdmin
            // 
            this.cbSellAdmin.FormattingEnabled = true;
            this.cbSellAdmin.Location = new System.Drawing.Point(377, 29);
            this.cbSellAdmin.Name = "cbSellAdmin";
            this.cbSellAdmin.Size = new System.Drawing.Size(154, 24);
            this.cbSellAdmin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sell Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sell Date End";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sell Date Start";
            // 
            // dtpSellStart
            // 
            this.dtpSellStart.Location = new System.Drawing.Point(562, 31);
            this.dtpSellStart.Name = "dtpSellStart";
            this.dtpSellStart.Size = new System.Drawing.Size(163, 22);
            this.dtpSellStart.TabIndex = 17;
            // 
            // dtpSellEnd
            // 
            this.dtpSellEnd.Location = new System.Drawing.Point(562, 91);
            this.dtpSellEnd.Name = "dtpSellEnd";
            this.dtpSellEnd.Size = new System.Drawing.Size(163, 22);
            this.dtpSellEnd.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(944, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Price Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(944, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Price Min";
            // 
            // numPriceMin
            // 
            this.numPriceMin.Location = new System.Drawing.Point(947, 30);
            this.numPriceMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceMin.Name = "numPriceMin";
            this.numPriceMin.Size = new System.Drawing.Size(120, 22);
            this.numPriceMin.TabIndex = 23;
            // 
            // numPriceMax
            // 
            this.numPriceMax.Location = new System.Drawing.Point(947, 90);
            this.numPriceMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceMax.Name = "numPriceMax";
            this.numPriceMax.Size = new System.Drawing.Size(120, 22);
            this.numPriceMax.TabIndex = 24;
            // 
            // dtpReceiveEnd
            // 
            this.dtpReceiveEnd.Location = new System.Drawing.Point(756, 91);
            this.dtpReceiveEnd.Name = "dtpReceiveEnd";
            this.dtpReceiveEnd.Size = new System.Drawing.Size(163, 22);
            this.dtpReceiveEnd.TabIndex = 28;
            // 
            // dtpReceiveStart
            // 
            this.dtpReceiveStart.Location = new System.Drawing.Point(756, 31);
            this.dtpReceiveStart.Name = "dtpReceiveStart";
            this.dtpReceiveStart.Size = new System.Drawing.Size(163, 22);
            this.dtpReceiveStart.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(753, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Receive Date End";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(753, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Receive Date start";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1093, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 33);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToExel
            // 
            this.btnToExel.Location = new System.Drawing.Point(1452, 84);
            this.btnToExel.Name = "btnToExel";
            this.btnToExel.Size = new System.Drawing.Size(143, 33);
            this.btnToExel.TabIndex = 30;
            this.btnToExel.Text = "To Exel";
            this.btnToExel.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Brand";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Model";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Client Fullname";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sell date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Promise date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Receive date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Price";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "First Pay";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Penalty Pay";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total Price";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Sell Admin Name";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Receive Admin Name";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 737);
            this.Controls.Add(this.btnToExel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpReceiveEnd);
            this.Controls.Add(this.dtpReceiveStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numPriceMax);
            this.Controls.Add(this.numPriceMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpSellEnd);
            this.Controls.Add(this.dtpSellStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbReceiveAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSellAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCarNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRents);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCarNumbers;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReceiveAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSellAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSellStart;
        private System.Windows.Forms.DateTimePicker dtpSellEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPriceMin;
        private System.Windows.Forms.NumericUpDown numPriceMax;
        private System.Windows.Forms.DateTimePicker dtpReceiveEnd;
        private System.Windows.Forms.DateTimePicker dtpReceiveStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnToExel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}