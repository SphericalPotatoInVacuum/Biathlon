namespace Biathlon
{
    partial class ControlPanel
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.wndBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.formCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(480, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // wndBtn
            // 
            this.wndBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wndBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.wndBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.wndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wndBtn.Location = new System.Drawing.Point(448, 0);
            this.wndBtn.Margin = new System.Windows.Forms.Padding(0);
            this.wndBtn.Name = "wndBtn";
            this.wndBtn.Size = new System.Drawing.Size(32, 32);
            this.wndBtn.TabIndex = 4;
            this.wndBtn.UseVisualStyleBackColor = true;
            this.wndBtn.Click += new System.EventHandler(this.wndBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(416, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(32, 32);
            this.minBtn.TabIndex = 5;
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // formCaption
            // 
            this.formCaption.AutoSize = true;
            this.formCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.formCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.formCaption.Location = new System.Drawing.Point(7, 6);
            this.formCaption.Name = "formCaption";
            this.formCaption.Size = new System.Drawing.Size(101, 20);
            this.formCaption.TabIndex = 6;
            this.formCaption.Text = "FormCaption";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formCaption);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.wndBtn);
            this.Controls.Add(this.minBtn);
            this.MaximumSize = new System.Drawing.Size(0, 32);
            this.MinimumSize = new System.Drawing.Size(512, 32);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(512, 32);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.SizeChanged += new System.EventHandler(this.ControlPanel_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button wndBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Label formCaption;
    }
}
