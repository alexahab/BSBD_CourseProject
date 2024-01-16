namespace ZAGS
{
    partial class FormZaivkiList
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
            System.Windows.Forms.Label номер_заявкиLabel;
            System.Windows.Forms.Label новая_фамилия_женыLabel;
            System.Windows.Forms.Label новая_фамилия_мужаLabel;
            System.Windows.Forms.Label принялLabel;
            System.Windows.Forms.Label дата_подачиLabel;
            System.Windows.Forms.Label зАГСLabel;
            System.Windows.Forms.Label женаLabel;
            System.Windows.Forms.Label мужLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZaivkiList));
            this.marriage_registrationDataSet = new ZAGS.Marriage_registrationDataSet();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new ZAGS.Marriage_registrationDataSetTableAdapters.ЗаявкиTableAdapter();
            this.tableAdapterManager = new ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager();
            this.заявкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заявкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_заявкиTextBox = new System.Windows.Forms.TextBox();
            this.новая_фамилия_женыTextBox = new System.Windows.Forms.TextBox();
            this.новая_фамилия_мужаTextBox = new System.Windows.Forms.TextBox();
            this.принялTextBox = new System.Windows.Forms.TextBox();
            this.дата_подачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.зАГСTextBox = new System.Windows.Forms.TextBox();
            this.женаTextBox = new System.Windows.Forms.TextBox();
            this.мужTextBox = new System.Windows.Forms.TextBox();
            номер_заявкиLabel = new System.Windows.Forms.Label();
            новая_фамилия_женыLabel = new System.Windows.Forms.Label();
            новая_фамилия_мужаLabel = new System.Windows.Forms.Label();
            принялLabel = new System.Windows.Forms.Label();
            дата_подачиLabel = new System.Windows.Forms.Label();
            зАГСLabel = new System.Windows.Forms.Label();
            женаLabel = new System.Windows.Forms.Label();
            мужLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).BeginInit();
            this.заявкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_заявкиLabel
            // 
            номер_заявкиLabel.AutoSize = true;
            номер_заявкиLabel.Location = new System.Drawing.Point(12, 41);
            номер_заявкиLabel.Name = "номер_заявкиLabel";
            номер_заявкиLabel.Size = new System.Drawing.Size(102, 16);
            номер_заявкиLabel.TabIndex = 1;
            номер_заявкиLabel.Text = "Номер заявки:";
            // 
            // новая_фамилия_женыLabel
            // 
            новая_фамилия_женыLabel.AutoSize = true;
            новая_фамилия_женыLabel.Location = new System.Drawing.Point(12, 69);
            новая_фамилия_женыLabel.Name = "новая_фамилия_женыLabel";
            новая_фамилия_женыLabel.Size = new System.Drawing.Size(150, 16);
            новая_фамилия_женыLabel.TabIndex = 3;
            новая_фамилия_женыLabel.Text = "Новая фамилия жены:";
            // 
            // новая_фамилия_мужаLabel
            // 
            новая_фамилия_мужаLabel.AutoSize = true;
            новая_фамилия_мужаLabel.Location = new System.Drawing.Point(12, 97);
            новая_фамилия_мужаLabel.Name = "новая_фамилия_мужаLabel";
            новая_фамилия_мужаLabel.Size = new System.Drawing.Size(150, 16);
            новая_фамилия_мужаLabel.TabIndex = 5;
            новая_фамилия_мужаLabel.Text = "Новая фамилия мужа:";
            // 
            // принялLabel
            // 
            принялLabel.AutoSize = true;
            принялLabel.Location = new System.Drawing.Point(12, 125);
            принялLabel.Name = "принялLabel";
            принялLabel.Size = new System.Drawing.Size(59, 16);
            принялLabel.TabIndex = 7;
            принялLabel.Text = "Принял:";
            // 
            // дата_подачиLabel
            // 
            дата_подачиLabel.AutoSize = true;
            дата_подачиLabel.Location = new System.Drawing.Point(12, 154);
            дата_подачиLabel.Name = "дата_подачиLabel";
            дата_подачиLabel.Size = new System.Drawing.Size(93, 16);
            дата_подачиLabel.TabIndex = 9;
            дата_подачиLabel.Text = "Дата подачи:";
            // 
            // зАГСLabel
            // 
            зАГСLabel.AutoSize = true;
            зАГСLabel.Location = new System.Drawing.Point(12, 181);
            зАГСLabel.Name = "зАГСLabel";
            зАГСLabel.Size = new System.Drawing.Size(44, 16);
            зАГСLabel.TabIndex = 11;
            зАГСLabel.Text = "ЗАГС:";
            // 
            // женаLabel
            // 
            женаLabel.AutoSize = true;
            женаLabel.Location = new System.Drawing.Point(12, 209);
            женаLabel.Name = "женаLabel";
            женаLabel.Size = new System.Drawing.Size(47, 16);
            женаLabel.TabIndex = 13;
            женаLabel.Text = "Жена:";
            // 
            // мужLabel
            // 
            мужLabel.AutoSize = true;
            мужLabel.Location = new System.Drawing.Point(12, 237);
            мужLabel.Name = "мужLabel";
            мужLabel.Size = new System.Drawing.Size(38, 16);
            мужLabel.TabIndex = 15;
            мужLabel.Text = "Муж:";
            // 
            // marriage_registrationDataSet
            // 
            this.marriage_registrationDataSet.DataSetName = "Marriage_registrationDataSet";
            this.marriage_registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.marriage_registrationDataSet;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БракиTableAdapter = null;
            this.tableAdapterManager.ГражданеTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            // 
            // заявкиBindingNavigator
            // 
            this.заявкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявкиBindingNavigator.BindingSource = this.заявкиBindingSource;
            this.заявкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявкиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.заявкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заявкиBindingNavigatorSaveItem});
            this.заявкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявкиBindingNavigator.Name = "заявкиBindingNavigator";
            this.заявкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявкиBindingNavigator.Size = new System.Drawing.Size(420, 31);
            this.заявкиBindingNavigator.TabIndex = 0;
            this.заявкиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // заявкиBindingNavigatorSaveItem
            // 
            this.заявкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкиBindingNavigatorSaveItem.Image")));
            this.заявкиBindingNavigatorSaveItem.Name = "заявкиBindingNavigatorSaveItem";
            this.заявкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.заявкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заявкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявкиBindingNavigatorSaveItem_Click);
            // 
            // номер_заявкиTextBox
            // 
            this.номер_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Номер_заявки", true));
            this.номер_заявкиTextBox.Location = new System.Drawing.Point(168, 38);
            this.номер_заявкиTextBox.Name = "номер_заявкиTextBox";
            this.номер_заявкиTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_заявкиTextBox.TabIndex = 2;
            // 
            // новая_фамилия_женыTextBox
            // 
            this.новая_фамилия_женыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Новая_фамилия_жены", true));
            this.новая_фамилия_женыTextBox.Location = new System.Drawing.Point(168, 66);
            this.новая_фамилия_женыTextBox.Name = "новая_фамилия_женыTextBox";
            this.новая_фамилия_женыTextBox.Size = new System.Drawing.Size(200, 22);
            this.новая_фамилия_женыTextBox.TabIndex = 4;
            // 
            // новая_фамилия_мужаTextBox
            // 
            this.новая_фамилия_мужаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Новая_фамилия_мужа", true));
            this.новая_фамилия_мужаTextBox.Location = new System.Drawing.Point(168, 94);
            this.новая_фамилия_мужаTextBox.Name = "новая_фамилия_мужаTextBox";
            this.новая_фамилия_мужаTextBox.Size = new System.Drawing.Size(200, 22);
            this.новая_фамилия_мужаTextBox.TabIndex = 6;
            // 
            // принялTextBox
            // 
            this.принялTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Принял", true));
            this.принялTextBox.Location = new System.Drawing.Point(168, 122);
            this.принялTextBox.Name = "принялTextBox";
            this.принялTextBox.Size = new System.Drawing.Size(200, 22);
            this.принялTextBox.TabIndex = 8;
            // 
            // дата_подачиDateTimePicker
            // 
            this.дата_подачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкиBindingSource, "Дата_подачи", true));
            this.дата_подачиDateTimePicker.Location = new System.Drawing.Point(168, 150);
            this.дата_подачиDateTimePicker.Name = "дата_подачиDateTimePicker";
            this.дата_подачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_подачиDateTimePicker.TabIndex = 10;
            // 
            // зАГСTextBox
            // 
            this.зАГСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "ЗАГС", true));
            this.зАГСTextBox.Location = new System.Drawing.Point(168, 178);
            this.зАГСTextBox.Name = "зАГСTextBox";
            this.зАГСTextBox.Size = new System.Drawing.Size(200, 22);
            this.зАГСTextBox.TabIndex = 12;
            // 
            // женаTextBox
            // 
            this.женаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Жена", true));
            this.женаTextBox.Location = new System.Drawing.Point(168, 206);
            this.женаTextBox.Name = "женаTextBox";
            this.женаTextBox.Size = new System.Drawing.Size(200, 22);
            this.женаTextBox.TabIndex = 14;
            // 
            // мужTextBox
            // 
            this.мужTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "Муж", true));
            this.мужTextBox.Location = new System.Drawing.Point(168, 234);
            this.мужTextBox.Name = "мужTextBox";
            this.мужTextBox.Size = new System.Drawing.Size(200, 22);
            this.мужTextBox.TabIndex = 16;
            // 
            // FormZaivkiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(420, 327);
            this.Controls.Add(номер_заявкиLabel);
            this.Controls.Add(this.номер_заявкиTextBox);
            this.Controls.Add(новая_фамилия_женыLabel);
            this.Controls.Add(this.новая_фамилия_женыTextBox);
            this.Controls.Add(новая_фамилия_мужаLabel);
            this.Controls.Add(this.новая_фамилия_мужаTextBox);
            this.Controls.Add(принялLabel);
            this.Controls.Add(this.принялTextBox);
            this.Controls.Add(дата_подачиLabel);
            this.Controls.Add(this.дата_подачиDateTimePicker);
            this.Controls.Add(зАГСLabel);
            this.Controls.Add(this.зАГСTextBox);
            this.Controls.Add(женаLabel);
            this.Controls.Add(this.женаTextBox);
            this.Controls.Add(мужLabel);
            this.Controls.Add(this.мужTextBox);
            this.Controls.Add(this.заявкиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(438, 374);
            this.MinimumSize = new System.Drawing.Size(438, 374);
            this.Name = "FormZaivkiList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.FormZaivkiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).EndInit();
            this.заявкиBindingNavigator.ResumeLayout(false);
            this.заявкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marriage_registrationDataSet marriage_registrationDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private Marriage_registrationDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private Marriage_registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявкиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заявкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_заявкиTextBox;
        private System.Windows.Forms.TextBox новая_фамилия_женыTextBox;
        private System.Windows.Forms.TextBox новая_фамилия_мужаTextBox;
        private System.Windows.Forms.TextBox принялTextBox;
        private System.Windows.Forms.DateTimePicker дата_подачиDateTimePicker;
        private System.Windows.Forms.TextBox зАГСTextBox;
        private System.Windows.Forms.TextBox женаTextBox;
        private System.Windows.Forms.TextBox мужTextBox;
    }
}