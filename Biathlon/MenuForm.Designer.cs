namespace Biathlon
{
    partial class MenuForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.controlPanel1 = new Biathlon.ControlPanel();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlPanel1
            // 
            this.controlPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel1.Location = new System.Drawing.Point(0, 0);
            this.controlPanel1.MaximumSize = new System.Drawing.Size(0, 32);
            this.controlPanel1.MinimumSize = new System.Drawing.Size(512, 32);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(512, 32);
            this.controlPanel1.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBtn.Location = new System.Drawing.Point(128, 128);
            this.startBtn.Margin = new System.Windows.Forms.Padding(0);
            this.startBtn.MaximumSize = new System.Drawing.Size(256, 64);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(256, 64);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Начать";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.infoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoBtn.Location = new System.Drawing.Point(128, 256);
            this.infoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.infoBtn.MaximumSize = new System.Drawing.Size(256, 64);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(256, 64);
            this.infoBtn.TabIndex = 2;
            this.infoBtn.Text = "Информация";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(512, 448);
            this.ControlBox = false;
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.controlPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 448);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Биатлон";
            this.Resize += new System.EventHandler(this.MenuForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPanel controlPanel1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button infoBtn;
    }
}

