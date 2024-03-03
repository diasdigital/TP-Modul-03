namespace TPMOD3
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
            Keluaran = new Label();
            Tombol = new Button();
            boxNama = new TextBox();
            SuspendLayout();
            // 
            // Keluaran
            // 
            Keluaran.AutoSize = true;
            Keluaran.Location = new Point(157, 177);
            Keluaran.Name = "Keluaran";
            Keluaran.Size = new Size(45, 20);
            Keluaran.TabIndex = 0;
            Keluaran.Text = "Halo ";
            // 
            // Tombol
            // 
            Tombol.Location = new Point(334, 101);
            Tombol.Name = "Tombol";
            Tombol.Size = new Size(94, 29);
            Tombol.TabIndex = 1;
            Tombol.Text = "Submit";
            Tombol.UseVisualStyleBackColor = true;
            Tombol.Click += Tombol_Click;
            // 
            // boxNama
            // 
            boxNama.Location = new Point(84, 103);
            boxNama.Name = "boxNama";
            boxNama.Size = new Size(216, 27);
            boxNama.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 327);
            Controls.Add(boxNama);
            Controls.Add(Tombol);
            Controls.Add(Keluaran);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Keluaran;
        private Button Tombol;
        private TextBox boxNama;
    }
}
