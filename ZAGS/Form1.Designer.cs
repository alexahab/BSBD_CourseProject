namespace ZAGS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрграммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гражданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бракиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.Thistle;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1182, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрграммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрграммеToolStripMenuItem
            // 
            this.оПрграммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрграммеToolStripMenuItem.Image")));
            this.оПрграммеToolStripMenuItem.Name = "оПрграммеToolStripMenuItem";
            this.оПрграммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрграммеToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.оПрграммеToolStripMenuItem.Text = "О прграмме";
            this.оПрграммеToolStripMenuItem.Click += new System.EventHandler(this.оПрграммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гражданеToolStripMenuItem,
            this.заявкиToolStripMenuItem,
            this.бракиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // гражданеToolStripMenuItem
            // 
            this.гражданеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("гражданеToolStripMenuItem.Image")));
            this.гражданеToolStripMenuItem.Name = "гражданеToolStripMenuItem";
            this.гражданеToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.гражданеToolStripMenuItem.Text = "Граждане";
            this.гражданеToolStripMenuItem.Click += new System.EventHandler(this.гражданеToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкиToolStripMenuItem.Image")));
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // бракиToolStripMenuItem
            // 
            this.бракиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("бракиToolStripMenuItem.Image")));
            this.бракиToolStripMenuItem.Name = "бракиToolStripMenuItem";
            this.бракиToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.бракиToolStripMenuItem.Text = "Браки";
            this.бракиToolStripMenuItem.Click += new System.EventHandler(this.бракиToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(115, 28);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 141);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.Location = new System.Drawing.Point(131, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(905, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти свидетельство";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите номер свидетельства";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(1200, 851);
            this.MinimumSize = new System.Drawing.Size(1200, 851);
            this.Name = "FormMain";
            this.Text = "Регистрация брака";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрграммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гражданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бракиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripMain;
    }
}

