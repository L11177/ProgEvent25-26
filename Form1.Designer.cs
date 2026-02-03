namespace ProgEvent25_26
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
            Avion = new PictureBox();
            Voiture = new PictureBox();
            BouttonPermuter = new Button();
            BoutonDisparition = new Button();
            ((System.ComponentModel.ISupportInitialize)Avion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Voiture).BeginInit();
            SuspendLayout();
            // 
            // Avion
            // 
            Avion.Image = Properties.Resources.Airbus_A320_200_Airbus_Industries__AIB___House_colors__F_WWBA___MSN_001__10276181983_;
            Avion.Location = new Point(334, 30);
            Avion.Name = "Avion";
            Avion.Size = new Size(216, 147);
            Avion.SizeMode = PictureBoxSizeMode.StretchImage;
            Avion.TabIndex = 0;
            Avion.TabStop = false;
            // 
            // Voiture
            // 
            Voiture.Image = Properties.Resources.istockphoto_2017093099_612x612;
            Voiture.Location = new Point(40, 30);
            Voiture.Name = "Voiture";
            Voiture.Size = new Size(218, 147);
            Voiture.SizeMode = PictureBoxSizeMode.StretchImage;
            Voiture.TabIndex = 1;
            Voiture.TabStop = false;
            // 
            // BouttonPermuter
            // 
            BouttonPermuter.Location = new Point(40, 230);
            BouttonPermuter.Name = "BouttonPermuter";
            BouttonPermuter.Size = new Size(218, 59);
            BouttonPermuter.TabIndex = 2;
            BouttonPermuter.Text = "Permuter";
            BouttonPermuter.UseVisualStyleBackColor = true;
            BouttonPermuter.Click += BouttonPermuter_Click;
            // 
            // BoutonDisparition
            // 
            BoutonDisparition.Location = new Point(334, 230);
            BoutonDisparition.Name = "BoutonDisparition";
            BoutonDisparition.Size = new Size(218, 59);
            BoutonDisparition.TabIndex = 3;
            BoutonDisparition.Text = "Fenêtre suivante";
            BoutonDisparition.UseVisualStyleBackColor = true;
            BoutonDisparition.Click += BoutonDisparition_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 345);
            Controls.Add(BoutonDisparition);
            Controls.Add(BouttonPermuter);
            Controls.Add(Voiture);
            Controls.Add(Avion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Avion).EndInit();
            ((System.ComponentModel.ISupportInitialize)Voiture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Avion;
        private PictureBox Voiture;
        private Button BouttonPermuter;
        private Button BoutonDisparition;
    }
}
