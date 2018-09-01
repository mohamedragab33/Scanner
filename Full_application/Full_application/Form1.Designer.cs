namespace Full_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnuploadForm = new System.Windows.Forms.Button();
            this.btnsitting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnuploadForm
            // 
            this.btnuploadForm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnuploadForm.FlatAppearance.BorderSize = 0;
            this.btnuploadForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuploadForm.ForeColor = System.Drawing.Color.White;
            this.btnuploadForm.Image = ((System.Drawing.Image)(resources.GetObject("btnuploadForm.Image")));
            this.btnuploadForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuploadForm.Location = new System.Drawing.Point(179, 424);
            this.btnuploadForm.Name = "btnuploadForm";
            this.btnuploadForm.Size = new System.Drawing.Size(302, 100);
            this.btnuploadForm.TabIndex = 0;
            this.btnuploadForm.Text = "رفع صور";
            this.btnuploadForm.UseVisualStyleBackColor = false;
            this.btnuploadForm.Click += new System.EventHandler(this.btnuploadForm_Click);
            // 
            // btnsitting
            // 
            this.btnsitting.BackColor = System.Drawing.Color.Coral;
            this.btnsitting.FlatAppearance.BorderSize = 0;
            this.btnsitting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsitting.ForeColor = System.Drawing.Color.White;
            this.btnsitting.Image = ((System.Drawing.Image)(resources.GetObject("btnsitting.Image")));
            this.btnsitting.Location = new System.Drawing.Point(477, 424);
            this.btnsitting.Name = "btnsitting";
            this.btnsitting.Size = new System.Drawing.Size(317, 100);
            this.btnsitting.TabIndex = 1;
            this.btnsitting.Text = "        الأعدادات ";
            this.btnsitting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsitting.UseVisualStyleBackColor = false;
            this.btnsitting.Click += new System.EventHandler(this.btnsitting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 69);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(534, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(979, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsitting);
            this.Controls.Add(this.btnuploadForm);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnuploadForm;
        public System.Windows.Forms.Button btnsitting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

