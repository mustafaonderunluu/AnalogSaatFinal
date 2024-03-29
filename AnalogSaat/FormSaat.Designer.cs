namespace AnalogSaat
{
    partial class FormSaat
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
            components = new System.ComponentModel.Container();
            pictureBox1saat = new PictureBox();
            pictureBox1akrep = new PictureBox();
            pictureBox1yelkovan = new PictureBox();
            pictureBox1saniye = new PictureBox();
            pictureBox1milisaniye = new PictureBox();
            timer1saat = new System.Windows.Forms.Timer(components);
            label1saat = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1saat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1akrep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1yelkovan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1saniye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1milisaniye).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1saat
            // 
            pictureBox1saat.BackColor = Color.Transparent;
            pictureBox1saat.Image = Properties.Resources.kadran;
            pictureBox1saat.Location = new Point(12, 12);
            pictureBox1saat.Name = "pictureBox1saat";
            pictureBox1saat.Size = new Size(505, 500);
            pictureBox1saat.TabIndex = 0;
            pictureBox1saat.TabStop = false;
            // 
            // pictureBox1akrep
            // 
            pictureBox1akrep.BackColor = Color.Transparent;
            pictureBox1akrep.Image = Properties.Resources.akrep;
            pictureBox1akrep.Location = new Point(0, 35);
            pictureBox1akrep.Name = "pictureBox1akrep";
            pictureBox1akrep.Size = new Size(500, 500);
            pictureBox1akrep.TabIndex = 1;
            pictureBox1akrep.TabStop = false;
            // 
            // pictureBox1yelkovan
            // 
            pictureBox1yelkovan.BackColor = Color.Transparent;
            pictureBox1yelkovan.Image = Properties.Resources.yelkovan;
            pictureBox1yelkovan.Location = new Point(0, 179);
            pictureBox1yelkovan.Name = "pictureBox1yelkovan";
            pictureBox1yelkovan.Size = new Size(500, 356);
            pictureBox1yelkovan.TabIndex = 2;
            pictureBox1yelkovan.TabStop = false;
            // 
            // pictureBox1saniye
            // 
            pictureBox1saniye.BackColor = Color.Transparent;
            pictureBox1saniye.Image = Properties.Resources.saniye;
            pictureBox1saniye.Location = new Point(0, 260);
            pictureBox1saniye.Name = "pictureBox1saniye";
            pictureBox1saniye.Size = new Size(500, 383);
            pictureBox1saniye.TabIndex = 3;
            pictureBox1saniye.TabStop = false;
            // 
            // pictureBox1milisaniye
            // 
            pictureBox1milisaniye.BackColor = Color.Transparent;
            pictureBox1milisaniye.Image = Properties.Resources.mili;
            pictureBox1milisaniye.Location = new Point(0, 349);
            pictureBox1milisaniye.Name = "pictureBox1milisaniye";
            pictureBox1milisaniye.Size = new Size(500, 500);
            pictureBox1milisaniye.TabIndex = 4;
            pictureBox1milisaniye.TabStop = false;
            // 
            // timer1saat
            // 
            timer1saat.Enabled = true;
            timer1saat.Interval = 1;
            timer1saat.Tick += timer1saat_Tick;
            // 
            // label1saat
            // 
            label1saat.AutoSize = true;
            label1saat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1saat.Location = new Point(168, 314);
            label1saat.Name = "label1saat";
            label1saat.Size = new Size(195, 41);
            label1saat.TabIndex = 5;
            label1saat.Text = "00:00:00:000";
            // 
            // FormSaat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 561);
            Controls.Add(label1saat);
            Controls.Add(pictureBox1saat);
            Controls.Add(pictureBox1milisaniye);
            Controls.Add(pictureBox1saniye);
            Controls.Add(pictureBox1yelkovan);
            Controls.Add(pictureBox1akrep);
            Name = "FormSaat";
            Text = "FormSaat";
            Load += FormSaat_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1saat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1akrep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1yelkovan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1saniye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1milisaniye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1saat;
        private PictureBox pictureBox1akrep;
        private PictureBox pictureBox1yelkovan;
        private PictureBox pictureBox1saniye;
        private PictureBox pictureBox1milisaniye;
        private System.Windows.Forms.Timer timer1saat;
        private Label label1saat;
    }
}