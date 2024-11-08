namespace AutoSpaSystem
{
    partial class customerDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCartype = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnCartype);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 676);
            this.panel1.TabIndex = 9;
            // 
            // btnCartype
            // 
            this.btnCartype.BackColor = System.Drawing.Color.Khaki;
            this.btnCartype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartype.Location = new System.Drawing.Point(11, 215);
            this.btnCartype.Name = "btnCartype";
            this.btnCartype.Size = new System.Drawing.Size(174, 55);
            this.btnCartype.TabIndex = 11;
            this.btnCartype.Text = "Book";
            this.btnCartype.UseVisualStyleBackColor = false;
            this.btnCartype.Click += new System.EventHandler(this.btnCartype_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Khaki;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Location = new System.Drawing.Point(11, 276);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(174, 55);
            this.btnServices.TabIndex = 10;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Khaki;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(11, 154);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(174, 55);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(199, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 37);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSpaSystem.Properties.Resources._415241327_883921876608915_3257178092286953776_n;
            this.pictureBox1.Location = new System.Drawing.Point(246, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // customerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "customerDashboard";
            this.Text = "customerDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCartype;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
    }
}