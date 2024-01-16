namespace ZAGS
{
    partial class FormPeopleList
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
            System.Windows.Forms.Label iD_гражданинаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label гражданствоLabel;
            System.Windows.Forms.Label национальностьLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label место_рожденияLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label полLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeopleList));
            this.marriage_registrationDataSet = new ZAGS.Marriage_registrationDataSet();
            this.гражданеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гражданеTableAdapter = new ZAGS.Marriage_registrationDataSetTableAdapters.ГражданеTableAdapter();
            this.tableAdapterManager = new ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager();
            this.гражданеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.гражданеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_гражданинаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.гражданствоTextBox = new System.Windows.Forms.TextBox();
            this.национальностьTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.место_рожденияTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            iD_гражданинаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            гражданствоLabel = new System.Windows.Forms.Label();
            национальностьLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            место_рожденияLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданеBindingNavigator)).BeginInit();
            this.гражданеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_гражданинаLabel
            // 
            iD_гражданинаLabel.AutoSize = true;
            iD_гражданинаLabel.Location = new System.Drawing.Point(12, 45);
            iD_гражданинаLabel.Name = "iD_гражданинаLabel";
            iD_гражданинаLabel.Size = new System.Drawing.Size(105, 16);
            iD_гражданинаLabel.TabIndex = 1;
            iD_гражданинаLabel.Text = "ID гражданина:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(12, 73);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(12, 101);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(12, 129);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // гражданствоLabel
            // 
            гражданствоLabel.AutoSize = true;
            гражданствоLabel.Location = new System.Drawing.Point(12, 157);
            гражданствоLabel.Name = "гражданствоLabel";
            гражданствоLabel.Size = new System.Drawing.Size(96, 16);
            гражданствоLabel.TabIndex = 9;
            гражданствоLabel.Text = "Гражданство:";
            // 
            // национальностьLabel
            // 
            национальностьLabel.AutoSize = true;
            национальностьLabel.Location = new System.Drawing.Point(12, 185);
            национальностьLabel.Name = "национальностьLabel";
            национальностьLabel.Size = new System.Drawing.Size(120, 16);
            национальностьLabel.TabIndex = 11;
            национальностьLabel.Text = "Национальность:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(12, 214);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(109, 16);
            дата_рожденияLabel.TabIndex = 13;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // место_рожденияLabel
            // 
            место_рожденияLabel.AutoSize = true;
            место_рожденияLabel.Location = new System.Drawing.Point(12, 241);
            место_рожденияLabel.Name = "место_рожденияLabel";
            место_рожденияLabel.Size = new System.Drawing.Size(118, 16);
            место_рожденияLabel.TabIndex = 15;
            место_рожденияLabel.Text = "Место рождения:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(12, 269);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(143, 16);
            паспортные_данныеLabel.TabIndex = 17;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(12, 297);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 19;
            полLabel.Text = "Пол:";
            // 
            // marriage_registrationDataSet
            // 
            this.marriage_registrationDataSet.DataSetName = "Marriage_registrationDataSet";
            this.marriage_registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гражданеBindingSource
            // 
            this.гражданеBindingSource.DataMember = "Граждане";
            this.гражданеBindingSource.DataSource = this.marriage_registrationDataSet;
            // 
            // гражданеTableAdapter
            // 
            this.гражданеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БракиTableAdapter = null;
            this.tableAdapterManager.ГражданеTableAdapter = this.гражданеTableAdapter;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            // 
            // гражданеBindingNavigator
            // 
            this.гражданеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.гражданеBindingNavigator.BindingSource = this.гражданеBindingSource;
            this.гражданеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.гражданеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.гражданеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.гражданеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.гражданеBindingNavigatorSaveItem});
            this.гражданеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.гражданеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.гражданеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.гражданеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.гражданеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.гражданеBindingNavigator.Name = "гражданеBindingNavigator";
            this.гражданеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.гражданеBindingNavigator.Size = new System.Drawing.Size(413, 31);
            this.гражданеBindingNavigator.TabIndex = 0;
            this.гражданеBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // гражданеBindingNavigatorSaveItem
            // 
            this.гражданеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.гражданеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("гражданеBindingNavigatorSaveItem.Image")));
            this.гражданеBindingNavigatorSaveItem.Name = "гражданеBindingNavigatorSaveItem";
            this.гражданеBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.гражданеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.гражданеBindingNavigatorSaveItem.Click += new System.EventHandler(this.гражданеBindingNavigatorSaveItem_Click_1);
            // 
            // iD_гражданинаTextBox
            // 
            this.iD_гражданинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "ID_гражданина", true));
            this.iD_гражданинаTextBox.Location = new System.Drawing.Point(161, 42);
            this.iD_гражданинаTextBox.Name = "iD_гражданинаTextBox";
            this.iD_гражданинаTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_гражданинаTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(161, 70);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(161, 98);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(161, 126);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // гражданствоTextBox
            // 
            this.гражданствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Гражданство", true));
            this.гражданствоTextBox.Location = new System.Drawing.Point(161, 154);
            this.гражданствоTextBox.Name = "гражданствоTextBox";
            this.гражданствоTextBox.Size = new System.Drawing.Size(200, 22);
            this.гражданствоTextBox.TabIndex = 10;
            // 
            // национальностьTextBox
            // 
            this.национальностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Национальность", true));
            this.национальностьTextBox.Location = new System.Drawing.Point(161, 182);
            this.национальностьTextBox.Name = "национальностьTextBox";
            this.национальностьTextBox.Size = new System.Drawing.Size(200, 22);
            this.национальностьTextBox.TabIndex = 12;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.гражданеBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(161, 210);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 14;
            // 
            // место_рожденияTextBox
            // 
            this.место_рожденияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Место_рождения", true));
            this.место_рожденияTextBox.Location = new System.Drawing.Point(161, 238);
            this.место_рожденияTextBox.Name = "место_рожденияTextBox";
            this.место_рожденияTextBox.Size = new System.Drawing.Size(200, 22);
            this.место_рожденияTextBox.TabIndex = 16;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Паспортные_данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(161, 266);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(200, 22);
            this.паспортные_данныеTextBox.TabIndex = 18;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гражданеBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(161, 294);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 22);
            this.полTextBox.TabIndex = 20;
            // 
            // FormPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(413, 387);
            this.Controls.Add(iD_гражданинаLabel);
            this.Controls.Add(this.iD_гражданинаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(гражданствоLabel);
            this.Controls.Add(this.гражданствоTextBox);
            this.Controls.Add(национальностьLabel);
            this.Controls.Add(this.национальностьTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(место_рожденияLabel);
            this.Controls.Add(this.место_рожденияTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(this.гражданеBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(431, 434);
            this.MinimumSize = new System.Drawing.Size(431, 434);
            this.Name = "FormPeopleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Граждане";
            this.Load += new System.EventHandler(this.FormPeopleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданеBindingNavigator)).EndInit();
            this.гражданеBindingNavigator.ResumeLayout(false);
            this.гражданеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marriage_registrationDataSet marriage_registrationDataSet;
        private System.Windows.Forms.BindingSource гражданеBindingSource;
        private Marriage_registrationDataSetTableAdapters.ГражданеTableAdapter гражданеTableAdapter;
        private Marriage_registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator гражданеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton гражданеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_гражданинаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox гражданствоTextBox;
        private System.Windows.Forms.TextBox национальностьTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox место_рожденияTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox полTextBox;
    }
}