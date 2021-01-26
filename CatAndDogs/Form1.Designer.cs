namespace CatAndDogs
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.getADog = new System.Windows.Forms.Button();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.GetACat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(652, 37);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(301, 308);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            // 
            // getADog
            // 
            this.getADog.Location = new System.Drawing.Point(652, 400);
            this.getADog.Name = "getADog";
            this.getADog.Size = new System.Drawing.Size(146, 23);
            this.getADog.TabIndex = 1;
            this.getADog.Text = "Get Dog Image";
            this.getADog.UseVisualStyleBackColor = true;
            this.getADog.Click += new System.EventHandler(this.getADog_Click);
            // 
            // CatPicture
            // 
            this.CatPicture.Location = new System.Drawing.Point(188, 37);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(313, 308);
            this.CatPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CatPicture.TabIndex = 2;
            this.CatPicture.TabStop = false;
            // 
            // GetACat
            // 
            this.GetACat.Location = new System.Drawing.Point(188, 400);
            this.GetACat.Name = "GetACat";
            this.GetACat.Size = new System.Drawing.Size(148, 23);
            this.GetACat.TabIndex = 3;
            this.GetACat.Text = "Get Cat Image";
            this.GetACat.UseVisualStyleBackColor = true;
            this.GetACat.Click += new System.EventHandler(this.GetACat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 530);
            this.Controls.Add(this.GetACat);
            this.Controls.Add(this.CatPicture);
            this.Controls.Add(this.getADog);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button getADog;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button GetACat;
    }
}

