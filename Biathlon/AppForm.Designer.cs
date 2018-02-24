namespace Biathlon
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.controlPanel1 = new Biathlon.ControlPanel();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.countryFilterBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.countryFilterLbl = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryFilterPan = new System.Windows.Forms.Panel();
            this.numberFilterPan = new System.Windows.Forms.Panel();
            this.sortTypePan = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.fileNamePan = new System.Windows.Forms.Panel();
            this.fileLblScroller = new System.Windows.Forms.Timer(this.components);
            this.updateBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flagUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.countryFilterPan.SuspendLayout();
            this.numberFilterPan.SuspendLayout();
            this.fileNamePan.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel1
            // 
            this.controlPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel1.Location = new System.Drawing.Point(0, 0);
            this.controlPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel1.MaximumSize = new System.Drawing.Size(0, 32);
            this.controlPanel1.MinimumSize = new System.Drawing.Size(640, 32);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(640, 32);
            this.controlPanel1.TabIndex = 0;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openFileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.openFileBtn.Location = new System.Drawing.Point(62, 424);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(256, 24);
            this.openFileBtn.TabIndex = 2;
            this.openFileBtn.Text = "Выбрать файл";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // countryFilterBox
            // 
            this.countryFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryFilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryFilterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countryFilterBox.Location = new System.Drawing.Point(191, -1);
            this.countryFilterBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryFilterBox.MaxLength = 3;
            this.countryFilterBox.Name = "countryFilterBox";
            this.countryFilterBox.Size = new System.Drawing.Size(64, 24);
            this.countryFilterBox.TabIndex = 6;
            this.countryFilterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(88, -1);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 24);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // countryFilterLbl
            // 
            this.countryFilterLbl.AutoSize = true;
            this.countryFilterLbl.BackColor = System.Drawing.Color.Transparent;
            this.countryFilterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryFilterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.countryFilterLbl.Location = new System.Drawing.Point(0, -2);
            this.countryFilterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryFilterLbl.MinimumSize = new System.Drawing.Size(0, 24);
            this.countryFilterLbl.Name = "countryFilterLbl";
            this.countryFilterLbl.Size = new System.Drawing.Size(192, 24);
            this.countryFilterLbl.TabIndex = 8;
            this.countryFilterLbl.Text = "Фильтр по IOC коду страны";
            this.countryFilterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileNameLbl.AutoEllipsis = true;
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fileNameLbl.Location = new System.Drawing.Point(-1, -2);
            this.fileNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLbl.MaximumSize = new System.Drawing.Size(0, 24);
            this.fileNameLbl.MinimumSize = new System.Drawing.Size(256, 24);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(256, 24);
            this.fileNameLbl.TabIndex = 9;
            this.fileNameLbl.Text = "Файл не выбран";
            this.fileNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(16, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Первые";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(162, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "участников";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryFilterPan
            // 
            this.countryFilterPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countryFilterPan.BackColor = System.Drawing.SystemColors.Control;
            this.countryFilterPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryFilterPan.Controls.Add(this.countryFilterBox);
            this.countryFilterPan.Controls.Add(this.countryFilterLbl);
            this.countryFilterPan.Location = new System.Drawing.Point(380, 394);
            this.countryFilterPan.Name = "countryFilterPan";
            this.countryFilterPan.Size = new System.Drawing.Size(256, 24);
            this.countryFilterPan.TabIndex = 13;
            // 
            // numberFilterPan
            // 
            this.numberFilterPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberFilterPan.BackColor = System.Drawing.SystemColors.Control;
            this.numberFilterPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberFilterPan.Controls.Add(this.label1);
            this.numberFilterPan.Controls.Add(this.numericUpDown1);
            this.numberFilterPan.Controls.Add(this.label2);
            this.numberFilterPan.Location = new System.Drawing.Point(380, 424);
            this.numberFilterPan.Name = "numberFilterPan";
            this.numberFilterPan.Size = new System.Drawing.Size(256, 24);
            this.numberFilterPan.TabIndex = 14;
            // 
            // sortTypePan
            // 
            this.sortTypePan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortTypePan.BackColor = System.Drawing.SystemColors.Control;
            this.sortTypePan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortTypePan.Location = new System.Drawing.Point(380, 454);
            this.sortTypePan.Name = "sortTypePan";
            this.sortTypePan.Size = new System.Drawing.Size(256, 24);
            this.sortTypePan.TabIndex = 15;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.AutoScroll = true;
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.ColumnCount = 1;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.Location = new System.Drawing.Point(4, 36);
            this.container.Name = "container";
            this.container.RowCount = 1;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.Size = new System.Drawing.Size(632, 352);
            this.container.TabIndex = 17;
            // 
            // fileNamePan
            // 
            this.fileNamePan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNamePan.BackColor = System.Drawing.SystemColors.Control;
            this.fileNamePan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNamePan.Controls.Add(this.fileNameLbl);
            this.fileNamePan.Location = new System.Drawing.Point(62, 454);
            this.fileNamePan.Name = "fileNamePan";
            this.fileNamePan.Size = new System.Drawing.Size(256, 24);
            this.fileNamePan.TabIndex = 16;
            // 
            // fileLblScroller
            // 
            this.fileLblScroller.Interval = 50;
            this.fileLblScroller.Tick += new System.EventHandler(this.fileLblScroller_Tick);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.updateBtn.Location = new System.Drawing.Point(380, 484);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(256, 24);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Применить фильтры";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flagUpdateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // flagUpdateToolStripMenuItem
            // 
            this.flagUpdateToolStripMenuItem.Name = "flagUpdateToolStripMenuItem";
            this.flagUpdateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flagUpdateToolStripMenuItem.Text = "Обновить флаги";
            this.flagUpdateToolStripMenuItem.Click += new System.EventHandler(this.flagUpdateToolStripMenuItem_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 512);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.fileNamePan);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sortTypePan);
            this.Controls.Add(this.numberFilterPan);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.controlPanel1);
            this.Controls.Add(this.countryFilterPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 512);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Биатлон";
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.SizeChanged += new System.EventHandler(this.AppForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.countryFilterPan.ResumeLayout(false);
            this.countryFilterPan.PerformLayout();
            this.numberFilterPan.ResumeLayout(false);
            this.numberFilterPan.PerformLayout();
            this.fileNamePan.ResumeLayout(false);
            this.fileNamePan.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPanel controlPanel1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox countryFilterBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label countryFilterLbl;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel countryFilterPan;
        private System.Windows.Forms.Panel numberFilterPan;
        private System.Windows.Forms.Panel sortTypePan;
        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.Panel fileNamePan;
        private System.Windows.Forms.Timer fileLblScroller;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flagUpdateToolStripMenuItem;
    }
}