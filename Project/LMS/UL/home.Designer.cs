namespace LMS.UL
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bntreports = new System.Windows.Forms.PictureBox();
            this.bntaddbokks = new System.Windows.Forms.Button();
            this.bntaddmember = new System.Windows.Forms.Button();
            this.bntborow = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntreports)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 493);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1012, 547);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bntreports
            // 
            this.bntreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntreports.Image = ((System.Drawing.Image)(resources.GetObject("bntreports.Image")));
            this.bntreports.Location = new System.Drawing.Point(0, 0);
            this.bntreports.Name = "bntreports";
            this.bntreports.Size = new System.Drawing.Size(1012, 150);
            this.bntreports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bntreports.TabIndex = 3;
            this.bntreports.TabStop = false;
            // 
            // bntaddbokks
            // 
            this.bntaddbokks.AutoSize = true;
            this.bntaddbokks.Location = new System.Drawing.Point(45, 16);
            this.bntaddbokks.Name = "bntaddbokks";
            this.bntaddbokks.Size = new System.Drawing.Size(104, 39);
            this.bntaddbokks.TabIndex = 4;
            this.bntaddbokks.Text = "Add Books";
            this.bntaddbokks.UseVisualStyleBackColor = true;
            this.bntaddbokks.Click += new System.EventHandler(this.bntaddbokks_Click);
            // 
            // bntaddmember
            // 
            this.bntaddmember.AutoSize = true;
            this.bntaddmember.Location = new System.Drawing.Point(45, 75);
            this.bntaddmember.Name = "bntaddmember";
            this.bntaddmember.Size = new System.Drawing.Size(104, 39);
            this.bntaddmember.TabIndex = 5;
            this.bntaddmember.Text = "Add Member";
            this.bntaddmember.UseVisualStyleBackColor = true;
            this.bntaddmember.Click += new System.EventHandler(this.bntaddmember_Click);
            // 
            // bntborow
            // 
            this.bntborow.AutoSize = true;
            this.bntborow.Location = new System.Drawing.Point(45, 131);
            this.bntborow.Name = "bntborow";
            this.bntborow.Size = new System.Drawing.Size(104, 39);
            this.bntborow.TabIndex = 6;
            this.bntborow.Text = "Borrow books";
            this.bntborow.UseVisualStyleBackColor = true;
            this.bntborow.Click += new System.EventHandler(this.bntborow_Click);
            // 
            // bntExit
            // 
            this.bntExit.AutoSize = true;
            this.bntExit.Location = new System.Drawing.Point(45, 303);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(104, 39);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bntaddbokks);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Controls.Add(this.bntaddmember);
            this.panel1.Controls.Add(this.bntborow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(832, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 397);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(45, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(45, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Submit Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1012, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntreports);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "home";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntreports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bntreports;
        private System.Windows.Forms.Button bntaddbokks;
        private System.Windows.Forms.Button bntaddmember;
        private System.Windows.Forms.Button bntborow;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;




    }
}