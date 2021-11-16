
namespace iktat
{
    partial class LetterOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetterOne));
            System.Windows.Forms.Label id_letterLabel;
            System.Windows.Forms.Label erkezettLabel;
            System.Windows.Forms.Label targyLabel;
            System.Windows.Forms.Label leirasLabel;
            System.Windows.Forms.Label id_userLabel;
            this.letterDS = new iktat.letterDS();
            this.lettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lettersTableAdapter = new iktat.letterDSTableAdapters.lettersTableAdapter();
            this.tableAdapterManager = new iktat.letterDSTableAdapters.TableAdapterManager();
            this.lettersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lettersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_letterLabel1 = new System.Windows.Forms.Label();
            this.erkezettDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.targyTextBox = new System.Windows.Forms.TextBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.id_userComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new iktat.letterDSTableAdapters.usersTableAdapter();
            this.fKlettersuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_letterLabel = new System.Windows.Forms.Label();
            erkezettLabel = new System.Windows.Forms.Label();
            targyLabel = new System.Windows.Forms.Label();
            leirasLabel = new System.Windows.Forms.Label();
            id_userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.letterDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingNavigator)).BeginInit();
            this.lettersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKlettersuserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // letterDS
            // 
            this.letterDS.DataSetName = "letterDS";
            this.letterDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lettersBindingSource
            // 
            this.lettersBindingSource.DataMember = "letters";
            this.lettersBindingSource.DataSource = this.letterDS;
            // 
            // lettersTableAdapter
            // 
            this.lettersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lettersTableAdapter = this.lettersTableAdapter;
            this.tableAdapterManager.UpdateOrder = iktat.letterDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // lettersBindingNavigator
            // 
            this.lettersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lettersBindingNavigator.BindingSource = this.lettersBindingSource;
            this.lettersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lettersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lettersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lettersBindingNavigatorSaveItem});
            this.lettersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lettersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lettersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lettersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lettersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lettersBindingNavigator.Name = "lettersBindingNavigator";
            this.lettersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lettersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.lettersBindingNavigator.TabIndex = 0;
            this.lettersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lettersBindingNavigatorSaveItem
            // 
            this.lettersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lettersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lettersBindingNavigatorSaveItem.Image")));
            this.lettersBindingNavigatorSaveItem.Name = "lettersBindingNavigatorSaveItem";
            this.lettersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lettersBindingNavigatorSaveItem.Text = "Save Data";
            this.lettersBindingNavigatorSaveItem.Click += new System.EventHandler(this.lettersBindingNavigatorSaveItem_Click);
            // 
            // id_letterLabel
            // 
            id_letterLabel.AutoSize = true;
            id_letterLabel.Location = new System.Drawing.Point(61, 50);
            id_letterLabel.Name = "id_letterLabel";
            id_letterLabel.Size = new System.Drawing.Size(45, 13);
            id_letterLabel.TabIndex = 1;
            id_letterLabel.Text = "Id letter:";
            // 
            // id_letterLabel1
            // 
            this.id_letterLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lettersBindingSource, "Id_letter", true));
            this.id_letterLabel1.Location = new System.Drawing.Point(115, 50);
            this.id_letterLabel1.Name = "id_letterLabel1";
            this.id_letterLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_letterLabel1.TabIndex = 2;
            this.id_letterLabel1.Text = "label1";
            // 
            // erkezettLabel
            // 
            erkezettLabel.AutoSize = true;
            erkezettLabel.Location = new System.Drawing.Point(61, 80);
            erkezettLabel.Name = "erkezettLabel";
            erkezettLabel.Size = new System.Drawing.Size(48, 13);
            erkezettLabel.TabIndex = 3;
            erkezettLabel.Text = "erkezett:";
            // 
            // erkezettDateTimePicker
            // 
            this.erkezettDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lettersBindingSource, "erkezett", true));
            this.erkezettDateTimePicker.Location = new System.Drawing.Point(115, 76);
            this.erkezettDateTimePicker.Name = "erkezettDateTimePicker";
            this.erkezettDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.erkezettDateTimePicker.TabIndex = 4;
            // 
            // targyLabel
            // 
            targyLabel.AutoSize = true;
            targyLabel.Location = new System.Drawing.Point(61, 105);
            targyLabel.Name = "targyLabel";
            targyLabel.Size = new System.Drawing.Size(33, 13);
            targyLabel.TabIndex = 5;
            targyLabel.Text = "targy:";
            // 
            // targyTextBox
            // 
            this.targyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lettersBindingSource, "targy", true));
            this.targyTextBox.Location = new System.Drawing.Point(115, 102);
            this.targyTextBox.Name = "targyTextBox";
            this.targyTextBox.Size = new System.Drawing.Size(200, 20);
            this.targyTextBox.TabIndex = 6;
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Location = new System.Drawing.Point(61, 131);
            leirasLabel.Name = "leirasLabel";
            leirasLabel.Size = new System.Drawing.Size(34, 13);
            leirasLabel.TabIndex = 7;
            leirasLabel.Text = "leiras:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lettersBindingSource, "leiras", true));
            this.leirasTextBox.Location = new System.Drawing.Point(115, 128);
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(200, 20);
            this.leirasTextBox.TabIndex = 8;
            // 
            // id_userLabel
            // 
            id_userLabel.AutoSize = true;
            id_userLabel.Location = new System.Drawing.Point(61, 157);
            id_userLabel.Name = "id_userLabel";
            id_userLabel.Size = new System.Drawing.Size(42, 13);
            id_userLabel.TabIndex = 9;
            id_userLabel.Text = "Id user:";
            // 
            // id_userComboBox
            // 
            this.id_userComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lettersBindingSource, "Id_user", true));
            this.id_userComboBox.DataSource = this.usersBindingSource;
            this.id_userComboBox.DisplayMember = "nev";
            this.id_userComboBox.FormattingEnabled = true;
            this.id_userComboBox.Location = new System.Drawing.Point(115, 154);
            this.id_userComboBox.Name = "id_userComboBox";
            this.id_userComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_userComboBox.TabIndex = 10;
            this.id_userComboBox.ValueMember = "Id_user";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.letterDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // fKlettersuserBindingSource
            // 
            this.fKlettersuserBindingSource.DataMember = "FK_letters_user";
            this.fKlettersuserBindingSource.DataSource = this.usersBindingSource;
            // 
            // LetterOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_letterLabel);
            this.Controls.Add(this.id_letterLabel1);
            this.Controls.Add(erkezettLabel);
            this.Controls.Add(this.erkezettDateTimePicker);
            this.Controls.Add(targyLabel);
            this.Controls.Add(this.targyTextBox);
            this.Controls.Add(leirasLabel);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(id_userLabel);
            this.Controls.Add(this.id_userComboBox);
            this.Controls.Add(this.lettersBindingNavigator);
            this.Name = "LetterOne";
            this.Text = "LetterOne";
            this.Load += new System.EventHandler(this.LetterOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letterDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingNavigator)).EndInit();
            this.lettersBindingNavigator.ResumeLayout(false);
            this.lettersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKlettersuserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private letterDS letterDS;
        private System.Windows.Forms.BindingSource lettersBindingSource;
        private letterDSTableAdapters.lettersTableAdapter lettersTableAdapter;
        private letterDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lettersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lettersBindingNavigatorSaveItem;
        private System.Windows.Forms.Label id_letterLabel1;
        private System.Windows.Forms.DateTimePicker erkezettDateTimePicker;
        private System.Windows.Forms.TextBox targyTextBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.ComboBox id_userComboBox;
        private letterDSTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource fKlettersuserBindingSource;
    }
}