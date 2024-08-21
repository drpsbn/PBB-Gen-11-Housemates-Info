namespace PBB_Gen_11_Housemates_Info
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            MainLBL = new System.Windows.Forms.Label();
            HMCB = new System.Windows.Forms.ComboBox();
            HMSelLBL = new System.Windows.Forms.Label();
            HMPB = new System.Windows.Forms.PictureBox();
            HMNameLBL = new System.Windows.Forms.Label();
            HMMonikerLBL = new System.Windows.Forms.Label();
            DRPSPHCALogo = new System.Windows.Forms.PictureBox();
            HMStatusLBL = new System.Windows.Forms.Label();
            AppVerLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)HMPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DRPSPHCALogo).BeginInit();
            SuspendLayout();
            // 
            // MainLBL
            // 
            MainLBL.AutoSize = true;
            MainLBL.BackColor = System.Drawing.Color.Transparent;
            MainLBL.Font = new System.Drawing.Font("Pixellari", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            MainLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            MainLBL.Location = new System.Drawing.Point(28, 21);
            MainLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MainLBL.Name = "MainLBL";
            MainLBL.Size = new System.Drawing.Size(494, 35);
            MainLBL.TabIndex = 0;
            MainLBL.Text = "PBB Gen 11 Housemates Info";
            // 
            // HMCB
            // 
            HMCB.BackColor = System.Drawing.Color.Indigo;
            HMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            HMCB.Font = new System.Drawing.Font("Gilroy ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HMCB.ForeColor = System.Drawing.SystemColors.Window;
            HMCB.FormattingEnabled = true;
            HMCB.Items.AddRange(new object[] { "Binsoy Namoca", "Brx Ruiz", "Dingdong and Patrick", "Dylan Yturralde", "Fyang Smith", "Gwen Montano", "Jan Silva", "Jarren Garcia", "Jas Dudley-Scales", "JM Ibarra", "Joli Alferez", "JP Cabrera", "Kai Montinola", "Kanata Tapia", "Kolette Madelo", "Marc Nanninga", "Noimie Steikunas", "Rain Celmar", "Therese Villamor" });
            HMCB.Location = new System.Drawing.Point(247, 68);
            HMCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HMCB.Name = "HMCB";
            HMCB.Size = new System.Drawing.Size(537, 32);
            HMCB.TabIndex = 1;
            HMCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // HMSelLBL
            // 
            HMSelLBL.AutoSize = true;
            HMSelLBL.BackColor = System.Drawing.Color.Transparent;
            HMSelLBL.Font = new System.Drawing.Font("Gilroy ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HMSelLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            HMSelLBL.Location = new System.Drawing.Point(35, 73);
            HMSelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HMSelLBL.Name = "HMSelLBL";
            HMSelLBL.Size = new System.Drawing.Size(204, 26);
            HMSelLBL.TabIndex = 2;
            HMSelLBL.Text = "Select a housemate";
            // 
            // HMPB
            // 
            HMPB.BackColor = System.Drawing.Color.Transparent;
            HMPB.Image = Properties.Resources.PHCAPBBGen11HM_Unselected;
            HMPB.Location = new System.Drawing.Point(41, 118);
            HMPB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HMPB.Name = "HMPB";
            HMPB.Size = new System.Drawing.Size(140, 138);
            HMPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            HMPB.TabIndex = 3;
            HMPB.TabStop = false;
            // 
            // HMNameLBL
            // 
            HMNameLBL.AutoSize = true;
            HMNameLBL.BackColor = System.Drawing.Color.Transparent;
            HMNameLBL.Font = new System.Drawing.Font("Gilroy ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HMNameLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            HMNameLBL.Location = new System.Drawing.Point(188, 118);
            HMNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HMNameLBL.Name = "HMNameLBL";
            HMNameLBL.Size = new System.Drawing.Size(271, 26);
            HMNameLBL.TabIndex = 4;
            HMNameLBL.Text = "Please select a housemate";
            // 
            // HMMonikerLBL
            // 
            HMMonikerLBL.AutoSize = true;
            HMMonikerLBL.BackColor = System.Drawing.Color.Transparent;
            HMMonikerLBL.Font = new System.Drawing.Font("Gilroy Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HMMonikerLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            HMMonikerLBL.Location = new System.Drawing.Point(188, 148);
            HMMonikerLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HMMonikerLBL.Name = "HMMonikerLBL";
            HMMonikerLBL.Size = new System.Drawing.Size(0, 20);
            HMMonikerLBL.TabIndex = 5;
            // 
            // DRPSPHCALogo
            // 
            DRPSPHCALogo.BackColor = System.Drawing.Color.Transparent;
            DRPSPHCALogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            DRPSPHCALogo.Image = Properties.Resources.DRPSPHCABranding2023;
            DRPSPHCALogo.Location = new System.Drawing.Point(644, 222);
            DRPSPHCALogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DRPSPHCALogo.Name = "DRPSPHCALogo";
            DRPSPHCALogo.Size = new System.Drawing.Size(140, 35);
            DRPSPHCALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            DRPSPHCALogo.TabIndex = 6;
            DRPSPHCALogo.TabStop = false;
            // 
            // HMStatusLBL
            // 
            HMStatusLBL.AutoSize = true;
            HMStatusLBL.BackColor = System.Drawing.Color.Transparent;
            HMStatusLBL.Font = new System.Drawing.Font("Gilroy Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HMStatusLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            HMStatusLBL.Location = new System.Drawing.Point(189, 225);
            HMStatusLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HMStatusLBL.Name = "HMStatusLBL";
            HMStatusLBL.Size = new System.Drawing.Size(0, 24);
            HMStatusLBL.TabIndex = 7;
            // 
            // AppVerLBL
            // 
            AppVerLBL.AutoSize = true;
            AppVerLBL.BackColor = System.Drawing.Color.Transparent;
            AppVerLBL.Font = new System.Drawing.Font("Gilroy Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            AppVerLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            AppVerLBL.Location = new System.Drawing.Point(635, 203);
            AppVerLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AppVerLBL.Name = "AppVerLBL";
            AppVerLBL.Size = new System.Drawing.Size(149, 13);
            AppVerLBL.TabIndex = 8;
            AppVerLBL.Text = "Ver. PHCAPBB11-20240822-1";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DRPSPHCAPBBGen11HMGraphic_2024BKG;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(813, 276);
            Controls.Add(AppVerLBL);
            Controls.Add(HMStatusLBL);
            Controls.Add(DRPSPHCALogo);
            Controls.Add(HMMonikerLBL);
            Controls.Add(HMNameLBL);
            Controls.Add(HMPB);
            Controls.Add(HMSelLBL);
            Controls.Add(HMCB);
            Controls.Add(MainLBL);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PBB Gen 11 Housemates Info";
            ((System.ComponentModel.ISupportInitialize)HMPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)DRPSPHCALogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label MainLBL;
        private System.Windows.Forms.ComboBox HMCB;
        private System.Windows.Forms.Label HMSelLBL;
        private System.Windows.Forms.PictureBox HMPB;
        private System.Windows.Forms.Label HMNameLBL;
        private System.Windows.Forms.Label HMMonikerLBL;
        private System.Windows.Forms.PictureBox DRPSPHCALogo;
        private System.Windows.Forms.Label HMStatusLBL;
        private System.Windows.Forms.Label AppVerLBL;
    }
}

