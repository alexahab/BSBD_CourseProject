namespace ZAGS
{
    partial class FormBrakiList
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
            System.Windows.Forms.Label номер_свидетельстваLabel;
            System.Windows.Forms.Label статус_бракаLabel;
            System.Windows.Forms.Label дата_заключенияLabel;
            System.Windows.Forms.Label iD_заявкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrakiList));
            this.marriage_registrationDataSet = new ZAGS.Marriage_registrationDataSet();
            this.бракиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бракиTableAdapter = new ZAGS.Marriage_registrationDataSetTableAdapters.БракиTableAdapter();
            this.tableAdapterManager = new ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager();
            this.бракиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.бракиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_свидетельстваTextBox = new System.Windows.Forms.TextBox();
            this.статус_бракаTextBox = new System.Windows.Forms.TextBox();
            this.дата_заключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_заявкиTextBox = new System.Windows.Forms.TextBox();
            номер_свидетельстваLabel = new System.Windows.Forms.Label();
            статус_бракаLabel = new System.Windows.Forms.Label();
            дата_заключенияLabel = new System.Windows.Forms.Label();
            iD_заявкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бракиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бракиBindingNavigator)).BeginInit();
            this.бракиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_свидетельстваLabel
            // 
            номер_свидетельстваLabel.AutoSize = true;
            номер_свидетельстваLabel.Location = new System.Drawing.Point(12, 45);
            номер_свидетельстваLabel.Name = "номер_свидетельстваLabel";
            номер_свидетельстваLabel.Size = new System.Drawing.Size(155, 16);
            номер_свидетельстваLabel.TabIndex = 1;
            номер_свидетельстваLabel.Text = "Номер свидетельства:";
            // 
            // статус_бракаLabel
            // 
            статус_бракаLabel.AutoSize = true;
            статус_бракаLabel.Location = new System.Drawing.Point(12, 73);
            статус_бракаLabel.Name = "статус_бракаLabel";
            статус_бракаLabel.Size = new System.Drawing.Size(98, 16);
            статус_бракаLabel.TabIndex = 3;
            статус_бракаLabel.Text = "Статус брака:";
            // 
            // дата_заключенияLabel
            // 
            дата_заключенияLabel.AutoSize = true;
            дата_заключенияLabel.Location = new System.Drawing.Point(12, 102);
            дата_заключенияLabel.Name = "дата_заключенияLabel";
            дата_заключенияLabel.Size = new System.Drawing.Size(125, 16);
            дата_заключенияLabel.TabIndex = 5;
            дата_заключенияLabel.Text = "Дата заключения:";
            // 
            // iD_заявкиLabel
            // 
            iD_заявкиLabel.AutoSize = true;
            iD_заявкиLabel.Location = new System.Drawing.Point(12, 129);
            iD_заявкиLabel.Name = "iD_заявкиLabel";
            iD_заявкиLabel.Size = new System.Drawing.Size(72, 16);
            iD_заявкиLabel.TabIndex = 7;
            iD_заявкиLabel.Text = "ID заявки:";
            // 
            // marriage_registrationDataSet
            // 
            this.marriage_registrationDataSet.DataSetName = "Marriage_registrationDataSet";
            this.marriage_registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бракиBindingSource
            // 
            this.бракиBindingSource.DataMember = "Браки";
            this.бракиBindingSource.DataSource = this.marriage_registrationDataSet;
            // 
            // бракиTableAdapter
            // 
            this.бракиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ZAGS.Marriage_registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БракиTableAdapter = this.бракиTableAdapter;
            this.tableAdapterManager.ГражданеTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            // 
            // бракиBindingNavigator
            // 
            this.бракиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.бракиBindingNavigator.BindingSource = this.бракиBindingSource;
            this.бракиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.бракиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.бракиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.бракиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.бракиBindingNavigatorSaveItem});
            this.бракиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.бракиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.бракиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.бракиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.бракиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.бракиBindingNavigator.Name = "бракиBindingNavigator";
            this.бракиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.бракиBindingNavigator.Size = new System.Drawing.Size(440, 31);
            this.бракиBindingNavigator.TabIndex = 0;
            this.бракиBindingNavigator.Text = "bindingNavigator1";
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
            // бракиBindingNavigatorSaveItem
            // 
            this.бракиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.бракиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("бракиBindingNavigatorSaveItem.Image")));
            this.бракиBindingNavigatorSaveItem.Name = "бракиBindingNavigatorSaveItem";
            this.бракиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.бракиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.бракиBindingNavigatorSaveItem.Click += new System.EventHandler(this.бракиBindingNavigatorSaveItem_Click);
            // 
            // номер_свидетельстваTextBox
            // 
            this.номер_свидетельстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бракиBindingSource, "Номер_свидетельства", true));
            this.номер_свидетельстваTextBox.Location = new System.Drawing.Point(173, 42);
            this.номер_свидетельстваTextBox.Name = "номер_свидетельстваTextBox";
            this.номер_свидетельстваTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_свидетельстваTextBox.TabIndex = 2;
            // 
            // статус_бракаTextBox
            // 
            this.статус_бракаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бракиBindingSource, "Статус_брака", true));
            this.статус_бракаTextBox.Location = new System.Drawing.Point(173, 70);
            this.статус_бракаTextBox.Name = "статус_бракаTextBox";
            this.статус_бракаTextBox.Size = new System.Drawing.Size(200, 22);
            this.статус_бракаTextBox.TabIndex = 4;
            // 
            // дата_заключенияDateTimePicker
            // 
            this.дата_заключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.бракиBindingSource, "Дата_заключения", true));
            this.дата_заключенияDateTimePicker.Location = new System.Drawing.Point(173, 98);
            this.дата_заключенияDateTimePicker.Name = "дата_заключенияDateTimePicker";
            this.дата_заключенияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_заключенияDateTimePicker.TabIndex = 6;
            // 
            // iD_заявкиTextBox
            // 
            this.iD_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.бракиBindingSource, "ID_заявки", true));
            this.iD_заявкиTextBox.Location = new System.Drawing.Point(173, 126);
            this.iD_заявкиTextBox.Name = "iD_заявкиTextBox";
            this.iD_заявкиTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_заявкиTextBox.TabIndex = 8;
            // 
            // FormBrakiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(440, 265);
            this.Controls.Add(номер_свидетельстваLabel);
            this.Controls.Add(this.номер_свидетельстваTextBox);
            this.Controls.Add(статус_бракаLabel);
            this.Controls.Add(this.статус_бракаTextBox);
            this.Controls.Add(дата_заключенияLabel);
            this.Controls.Add(this.дата_заключенияDateTimePicker);
            this.Controls.Add(iD_заявкиLabel);
            this.Controls.Add(this.iD_заявкиTextBox);
            this.Controls.Add(this.бракиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 312);
            this.MinimumSize = new System.Drawing.Size(458, 312);
            this.Name = "FormBrakiList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Браки";
            this.Load += new System.EventHandler(this.FormBrakiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marriage_registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бракиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бракиBindingNavigator)).EndInit();
            this.бракиBindingNavigator.ResumeLayout(false);
            this.бракиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marriage_registrationDataSet marriage_registrationDataSet;
        private System.Windows.Forms.BindingSource бракиBindingSource;
        private Marriage_registrationDataSetTableAdapters.БракиTableAdapter бракиTableAdapter;
        private Marriage_registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator бракиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton бракиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_свидетельстваTextBox;
        private System.Windows.Forms.TextBox статус_бракаTextBox;
        private System.Windows.Forms.DateTimePicker дата_заключенияDateTimePicker;
        private System.Windows.Forms.TextBox iD_заявкиTextBox;
    }
}