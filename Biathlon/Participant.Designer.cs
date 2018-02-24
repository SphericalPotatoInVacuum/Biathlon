namespace Biathlon
{
    partial class Participant
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participant));
            this.placePan = new System.Windows.Forms.Panel();
            this.placeLbl = new System.Windows.Forms.Label();
            this.numberPan = new System.Windows.Forms.Panel();
            this.numberLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.countryLbl = new System.Windows.Forms.Label();
            this.flagImg = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.timeLbl = new System.Windows.Forms.Label();
            this.missLbl = new System.Windows.Forms.Label();
            this.missPan = new System.Windows.Forms.Panel();
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.placePan.SuspendLayout();
            this.numberPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagImg)).BeginInit();
            this.container.SuspendLayout();
            this.missPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // placePan
            // 
            this.placePan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.placePan.Controls.Add(this.placeLbl);
            this.placePan.Location = new System.Drawing.Point(4, 4);
            this.placePan.Margin = new System.Windows.Forms.Padding(4);
            this.placePan.Name = "placePan";
            this.placePan.Size = new System.Drawing.Size(24, 24);
            this.placePan.TabIndex = 0;
            // 
            // placeLbl
            // 
            this.placeLbl.AutoSize = true;
            this.placeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.placeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.placeLbl.Location = new System.Drawing.Point(0, 0);
            this.placeLbl.MinimumSize = new System.Drawing.Size(24, 24);
            this.placeLbl.Name = "placeLbl";
            this.placeLbl.Size = new System.Drawing.Size(24, 24);
            this.placeLbl.TabIndex = 0;
            this.placeLbl.Text = "10";
            this.placeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberPan
            // 
            this.numberPan.BackColor = System.Drawing.SystemColors.Window;
            this.numberPan.Controls.Add(this.numberLbl);
            this.numberPan.Location = new System.Drawing.Point(35, 4);
            this.numberPan.Margin = new System.Windows.Forms.Padding(4);
            this.numberPan.Name = "numberPan";
            this.numberPan.Size = new System.Drawing.Size(24, 24);
            this.numberPan.TabIndex = 1;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numberLbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberLbl.Location = new System.Drawing.Point(0, 0);
            this.numberLbl.MinimumSize = new System.Drawing.Size(24, 24);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(24, 24);
            this.numberLbl.TabIndex = 1;
            this.numberLbl.Text = "10";
            this.numberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.nameLbl.Location = new System.Drawing.Point(65, 4);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(232, 24);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "RASTORGUJEVS Andrejs";
            // 
            // countryLbl
            // 
            this.countryLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLbl.AutoSize = true;
            this.countryLbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.countryLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryLbl.Location = new System.Drawing.Point(292, 3);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countryLbl.Size = new System.Drawing.Size(51, 28);
            this.countryLbl.TabIndex = 3;
            this.countryLbl.Text = "NOR";
            this.countryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryLbl.UseMnemonic = false;
            // 
            // flagImg
            // 
            this.flagImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flagImg.Image = ((System.Drawing.Image)(resources.GetObject("flagImg.Image")));
            this.flagImg.InitialImage = null;
            this.flagImg.Location = new System.Drawing.Point(346, 4);
            this.flagImg.Margin = new System.Windows.Forms.Padding(4);
            this.flagImg.MaximumSize = new System.Drawing.Size(32, 4);
            this.flagImg.MinimumSize = new System.Drawing.Size(36, 24);
            this.flagImg.Name = "flagImg";
            this.flagImg.Size = new System.Drawing.Size(36, 24);
            this.flagImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagImg.TabIndex = 4;
            this.flagImg.TabStop = false;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.MidnightBlue;
            this.container.Controls.Add(this.placePan);
            this.container.Controls.Add(this.countryLbl);
            this.container.Controls.Add(this.flagImg);
            this.container.Controls.Add(this.numberPan);
            this.container.Controls.Add(this.nameLbl);
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(386, 32);
            this.container.TabIndex = 5;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.timeLbl.Location = new System.Drawing.Point(428, 0);
            this.timeLbl.MaximumSize = new System.Drawing.Size(80, 32);
            this.timeLbl.MinimumSize = new System.Drawing.Size(84, 32);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(84, 32);
            this.timeLbl.TabIndex = 7;
            this.timeLbl.Text = "36:27.35";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // missLbl
            // 
            this.missLbl.AutoSize = true;
            this.missLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.missLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.missLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.missLbl.Location = new System.Drawing.Point(0, 0);
            this.missLbl.MinimumSize = new System.Drawing.Size(32, 32);
            this.missLbl.Name = "missLbl";
            this.missLbl.Size = new System.Drawing.Size(32, 32);
            this.missLbl.TabIndex = 7;
            this.missLbl.Text = "12";
            this.missLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // missPan
            // 
            this.missPan.BackColor = System.Drawing.Color.Black;
            this.missPan.Controls.Add(this.missLbl);
            this.missPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.missPan.Location = new System.Drawing.Point(396, 0);
            this.missPan.Name = "missPan";
            this.missPan.Size = new System.Drawing.Size(32, 32);
            this.missPan.TabIndex = 8;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.missPan);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(0, 32);
            this.MinimumSize = new System.Drawing.Size(512, 32);
            this.Name = "Participant";
            this.Size = new System.Drawing.Size(512, 32);
            this.placePan.ResumeLayout(false);
            this.placePan.PerformLayout();
            this.numberPan.ResumeLayout(false);
            this.numberPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagImg)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.missPan.ResumeLayout(false);
            this.missPan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel placePan;
        private System.Windows.Forms.Panel numberPan;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label placeLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.PictureBox flagImg;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label missLbl;
        private System.Windows.Forms.Panel missPan;
        private System.Windows.Forms.ToolTip tooltip1;
    }
}
