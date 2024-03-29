namespace AnalogSaat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Saat = new PictureBox();
            Çevir = new Button();
            pictureBox1akrep = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Saat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1akrep).BeginInit();
            SuspendLayout();
            // 
            // Saat
            // 
            Saat.BackColor = Color.Transparent;
            Saat.Image = Properties.Resources.kadran;
            Saat.Location = new Point(0, 0);
            Saat.Name = "Saat";
            Saat.Size = new Size(500, 500);
            Saat.TabIndex = 0;
            Saat.TabStop = false;
            // 
            // Çevir
            // 
            Çevir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Çevir.Location = new Point(506, 60);
            Çevir.Name = "Çevir";
            Çevir.Size = new Size(139, 60);
            Çevir.TabIndex = 1;
            Çevir.Text = "Çevir";
            Çevir.UseVisualStyleBackColor = true;
            Çevir.Click += Çevir_Click;
            // 
            // pictureBox1akrep
            // 
            pictureBox1akrep.BackColor = Color.Transparent;
            pictureBox1akrep.Image = Properties.Resources.akrep;
            pictureBox1akrep.Location = new Point(0, 217);
            pictureBox1akrep.Name = "pictureBox1akrep";
            pictureBox1akrep.Size = new Size(500, 500);
            pictureBox1akrep.TabIndex = 2;
            pictureBox1akrep.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 622);
            Controls.Add(pictureBox1akrep);
            Controls.Add(Çevir);
            Controls.Add(Saat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Saat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1akrep).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Saat;
        private Button Çevir;
        private PictureBox pictureBox1akrep;
    }
}
