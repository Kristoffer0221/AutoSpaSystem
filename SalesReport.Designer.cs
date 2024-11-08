namespace AutoSpaSystem
{
    partial class SalesReport
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
            this.dataGridViewtansactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCartype = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnServiceOrder = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtansactions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtansactions
            // 
            this.dataGridViewtansactions.AllowUserToAddRows = false;
            this.dataGridViewtansactions.ColumnHeadersHeight = 34;
            this.dataGridViewtansactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewtansactions.Location = new System.Drawing.Point(208, 212);
            this.dataGridViewtansactions.Name = "dataGridViewtansactions";
            this.dataGridViewtansactions.RowHeadersVisible = false;
            this.dataGridViewtansactions.RowHeadersWidth = 62;
            this.dataGridViewtansactions.RowTemplate.Height = 28;
            this.dataGridViewtansactions.Size = new System.Drawing.Size(987, 351);
            this.dataGridViewtansactions.TabIndex = 16;
            this.dataGridViewtansactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTansactions_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 82);
            this.label1.TabIndex = 15;
            this.label1.Text = "SALES REPORT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnCartype);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnServiceOrder);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 676);
            this.panel1.TabIndex = 14;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Khaki;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(12, 462);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(174, 55);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCartype
            // 
            this.btnCartype.BackColor = System.Drawing.Color.Khaki;
            this.btnCartype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartype.Location = new System.Drawing.Point(12, 401);
            this.btnCartype.Name = "btnCartype";
            this.btnCartype.Size = new System.Drawing.Size(174, 55);
            this.btnCartype.TabIndex = 4;
            this.btnCartype.Text = "Book";
            this.btnCartype.UseVisualStyleBackColor = false;
            this.btnCartype.Click += new System.EventHandler(this.btnCartype_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Khaki;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Location = new System.Drawing.Point(13, 340);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(174, 55);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnServiceOrder
            // 
            this.btnServiceOrder.BackColor = System.Drawing.Color.Khaki;
            this.btnServiceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceOrder.Location = new System.Drawing.Point(13, 279);
            this.btnServiceOrder.Name = "btnServiceOrder";
            this.btnServiceOrder.Size = new System.Drawing.Size(174, 55);
            this.btnServiceOrder.TabIndex = 2;
            this.btnServiceOrder.Text = "Service Order";
            this.btnServiceOrder.UseVisualStyleBackColor = false;
            this.btnServiceOrder.Click += new System.EventHandler(this.btnServiceOrder_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Khaki;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Location = new System.Drawing.Point(13, 218);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(174, 55);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Khaki;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(13, 157);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(174, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(200, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 37);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sales Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 665);
            this.Controls.Add(this.dataGridViewtansactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtansactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtansactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCartype;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnServiceOrder;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}