namespace WinFormLayihe.Forms
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.btnReceiveCar = new System.Windows.Forms.Button();
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.carToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminsToolStripMenuItem
            // 
            this.adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            this.adminsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.adminsToolStripMenuItem.Text = "Admins";
            this.adminsToolStripMenuItem.Click += new System.EventHandler(this.adminsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.usersToolStripMenuItem.Text = "Clients";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.carToolStripMenuItem.Text = "Cars";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // btnNewRent
            // 
            this.btnNewRent.Location = new System.Drawing.Point(12, 40);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(111, 34);
            this.btnNewRent.TabIndex = 1;
            this.btnNewRent.Text = "New Rent";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // btnReceiveCar
            // 
            this.btnReceiveCar.Location = new System.Drawing.Point(153, 40);
            this.btnReceiveCar.Name = "btnReceiveCar";
            this.btnReceiveCar.Size = new System.Drawing.Size(111, 34);
            this.btnReceiveCar.TabIndex = 2;
            this.btnReceiveCar.Text = "Receive Car";
            this.btnReceiveCar.UseVisualStyleBackColor = true;
            this.btnReceiveCar.Click += new System.EventHandler(this.btnReceiveCar_Click);
            // 
            // dgvRents
            // 
            this.dgvRents.AllowUserToAddRows = false;
            this.dgvRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.c,
            this.Column6});
            this.dgvRents.Location = new System.Drawing.Point(12, 94);
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.RowHeadersWidth = 51;
            this.dgvRents.RowTemplate.Height = 24;
            this.dgvRents.Size = new System.Drawing.Size(1235, 325);
            this.dgvRents.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marka Model";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client FullName";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sell Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Promise Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // c
            // 
            this.c.HeaderText = "Amount paid";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sell Admin Name";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 425);
            this.Controls.Add(this.dgvRents);
            this.Controls.Add(this.btnReceiveCar);
            this.Controls.Add(this.btnNewRent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.Button btnReceiveCar;
        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}