namespace tehtava1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(257, 257);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Previous Picture";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 295);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Picture";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(95, 345);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(169, 345);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "/ 20";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fantasia1.jpg");
            this.imageList1.Images.SetKeyName(1, "fantasia2.jpg");
            this.imageList1.Images.SetKeyName(2, "fantasia3.jpg");
            this.imageList1.Images.SetKeyName(3, "fantasia4.jpg");
            this.imageList1.Images.SetKeyName(4, "fantasia5.jpg");
            this.imageList1.Images.SetKeyName(5, "fantasia6.jpg");
            this.imageList1.Images.SetKeyName(6, "fantasia13.jpg");
            this.imageList1.Images.SetKeyName(7, "fantasia14.jpg");
            this.imageList1.Images.SetKeyName(8, "fantasia15.jpg");
            this.imageList1.Images.SetKeyName(9, "fantasia18.jpg");
            this.imageList1.Images.SetKeyName(10, "fantasia19.jpg");
            this.imageList1.Images.SetKeyName(11, "fantasia20.jpg");
            this.imageList1.Images.SetKeyName(12, "juusto7.jpg");
            this.imageList1.Images.SetKeyName(13, "kansi1.jpg");
            this.imageList1.Images.SetKeyName(14, "kansi2.jpg");
            this.imageList1.Images.SetKeyName(15, "kansi3.JPG");
            this.imageList1.Images.SetKeyName(16, "kansi4.JPG");
            this.imageList1.Images.SetKeyName(17, "muotok1.jpg");
            this.imageList1.Images.SetKeyName(18, "muotok4.jpg");
            this.imageList1.Images.SetKeyName(19, "overi4.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 384);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

