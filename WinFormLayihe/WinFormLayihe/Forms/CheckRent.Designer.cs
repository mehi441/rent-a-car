namespace WinFormLayihe.Forms
{
    partial class CheckRent
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
            this.numPenalty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPromise = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSell = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // numPenalty
            // 
            this.numPenalty.Location = new System.Drawing.Point(28, 392);
            this.numPenalty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPenalty.Name = "numPenalty";
            this.numPenalty.Size = new System.Drawing.Size(120, 22);
            this.numPenalty.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Penalty Price";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(28, 438);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(200, 38);
            this.btnReceive.TabIndex = 23;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // dtpReceive
            // 
            this.dtpReceive.Location = new System.Drawing.Point(28, 275);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(200, 22);
            this.dtpReceive.TabIndex = 22;
            this.dtpReceive.ValueChanged += new System.EventHandler(this.dtpReceive_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Receive Date";
            // 
            // dtpPromise
            // 
            this.dtpPromise.Enabled = false;
            this.dtpPromise.Location = new System.Drawing.Point(28, 216);
            this.dtpPromise.Name = "dtpPromise";
            this.dtpPromise.Size = new System.Drawing.Size(200, 22);
            this.dtpPromise.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Promise Date";
            // 
            // dtpSell
            // 
            this.dtpSell.Enabled = false;
            this.dtpSell.Location = new System.Drawing.Point(28, 158);
            this.dtpSell.Name = "dtpSell";
            this.dtpSell.Size = new System.Drawing.Size(200, 22);
            this.dtpSell.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sell Date";
            // 
            // txtCar
            // 
            this.txtCar.Enabled = false;
            this.txtCar.Location = new System.Drawing.Point(28, 96);
            this.txtCar.Name = "txtCar";
            this.txtCar.ReadOnly = true;
            this.txtCar.Size = new System.Drawing.Size(200, 22);
            this.txtCar.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Car";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(28, 37);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(200, 22);
            this.txtClient.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client";
            // 
            // numPaid
            // 
            this.numPaid.Enabled = false;
            this.numPaid.Location = new System.Drawing.Point(28, 335);
            this.numPaid.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(120, 22);
            this.numPaid.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Amount Paid";
            // 
            // CheckRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 488);
            this.Controls.Add(this.numPaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPenalty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.dtpReceive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpPromise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label1);
            this.Name = "CheckRent";
            this.Text = "CheckRent";
            ((System.ComponentModel.ISupportInitialize)(this.numPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPenalty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPromise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPaid;
        private System.Windows.Forms.Label label7;
    }
}