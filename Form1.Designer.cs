namespace TypeRacer
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
            this.labelTextOriginal = new System.Windows.Forms.Label();
            this.textBoxTextType = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.TypingProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextOriginal
            // 
            this.labelTextOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextOriginal.Location = new System.Drawing.Point(12, 31);
            this.labelTextOriginal.Name = "labelTextOriginal";
            this.labelTextOriginal.Size = new System.Drawing.Size(776, 80);
            this.labelTextOriginal.TabIndex = 0;
            this.labelTextOriginal.Text = "A contango market implies oil traders believe crude prices will rally in the futu" +
    "re, encouraging them to store oil now and to sell at a later date.";
            // 
            // textBoxTextType
            // 
            this.textBoxTextType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextType.Location = new System.Drawing.Point(12, 172);
            this.textBoxTextType.Multiline = true;
            this.textBoxTextType.Name = "textBoxTextType";
            this.textBoxTextType.Size = new System.Drawing.Size(776, 161);
            this.textBoxTextType.TabIndex = 1;
            this.textBoxTextType.TextChanged += new System.EventHandler(this.textBoxTextType_TextChanged);
            this.textBoxTextType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTextType_KeyDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::TypeRacer.Properties.Resources.close;
            this.pictureBoxClose.Location = new System.Drawing.Point(708, 358);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            // 
            // TypingProgress
            // 
            this.TypingProgress.Location = new System.Drawing.Point(12, 134);
            this.TypingProgress.Name = "TypingProgress";
            this.TypingProgress.Size = new System.Drawing.Size(776, 23);
            this.TypingProgress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TypingProgress);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.textBoxTextType);
            this.Controls.Add(this.labelTextOriginal);
            this.Name = "Form1";
            this.Text = "Typerecer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextOriginal;
        private System.Windows.Forms.TextBox textBoxTextType;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.ProgressBar TypingProgress;
    }
}

