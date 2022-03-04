namespace arizonaTouristAttractionsFinal
{
    partial class Form1
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
            System.Windows.Forms.Label locationNameLabel;
            System.Windows.Forms.Label countyLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label locationPictureLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.arizona1DataSet = new arizonaTouristAttractionsFinal.arizona1DataSet();
            this.arizonaLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arizonaLocationTableAdapter = new arizonaTouristAttractionsFinal.arizona1DataSetTableAdapters.arizonaLocationTableAdapter();
            this.tableAdapterManager = new arizonaTouristAttractionsFinal.arizona1DataSetTableAdapters.TableAdapterManager();
            this.arizonaLocationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.arizonaLocationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.countyTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.locationPictureTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.resultsComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            locationNameLabel = new System.Windows.Forms.Label();
            countyLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            locationPictureLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arizona1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizonaLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizonaLocationBindingNavigator)).BeginInit();
            this.arizonaLocationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // locationNameLabel
            // 
            locationNameLabel.AutoSize = true;
            locationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationNameLabel.Location = new System.Drawing.Point(473, 37);
            locationNameLabel.Name = "locationNameLabel";
            locationNameLabel.Size = new System.Drawing.Size(55, 20);
            locationNameLabel.TabIndex = 1;
            locationNameLabel.Text = "Name:";
            // 
            // countyLabel
            // 
            countyLabel.AutoSize = true;
            countyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countyLabel.Location = new System.Drawing.Point(465, 63);
            countyLabel.Name = "countyLabel";
            countyLabel.Size = new System.Drawing.Size(63, 20);
            countyLabel.TabIndex = 3;
            countyLabel.Text = "County:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(489, 87);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "City:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(451, 115);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(77, 20);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ratingLabel.Location = new System.Drawing.Point(468, 141);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(60, 20);
            ratingLabel.TabIndex = 9;
            ratingLabel.Text = "Rating:";
            // 
            // locationPictureLabel
            // 
            locationPictureLabel.AutoSize = true;
            locationPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationPictureLabel.Location = new System.Drawing.Point(466, 193);
            locationPictureLabel.Name = "locationPictureLabel";
            locationPictureLabel.Size = new System.Drawing.Size(62, 20);
            locationPictureLabel.TabIndex = 11;
            locationPictureLabel.Text = "Picture:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(454, 167);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(74, 20);
            locationLabel.TabIndex = 13;
            locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(435, 217);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // arizona1DataSet
            // 
            this.arizona1DataSet.DataSetName = "arizona1DataSet";
            this.arizona1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arizonaLocationBindingSource
            // 
            this.arizonaLocationBindingSource.DataMember = "arizonaLocation";
            this.arizonaLocationBindingSource.DataSource = this.arizona1DataSet;
            // 
            // arizonaLocationTableAdapter
            // 
            this.arizonaLocationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.arizonaLocationTableAdapter = this.arizonaLocationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = arizonaTouristAttractionsFinal.arizona1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // arizonaLocationBindingNavigator
            // 
            this.arizonaLocationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.arizonaLocationBindingNavigator.BindingSource = this.arizonaLocationBindingSource;
            this.arizonaLocationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.arizonaLocationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.arizonaLocationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.arizonaLocationBindingNavigatorSaveItem});
            this.arizonaLocationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.arizonaLocationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.arizonaLocationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.arizonaLocationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.arizonaLocationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.arizonaLocationBindingNavigator.Name = "arizonaLocationBindingNavigator";
            this.arizonaLocationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.arizonaLocationBindingNavigator.Size = new System.Drawing.Size(724, 25);
            this.arizonaLocationBindingNavigator.TabIndex = 0;
            this.arizonaLocationBindingNavigator.Text = "bindingNavigator1";
            this.arizonaLocationBindingNavigator.Click += new System.EventHandler(this.arizonaLocationBindingNavigator_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.arizonaLocationBindingNavigator_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.arizonaLocationBindingNavigator_Click);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.arizonaLocationBindingNavigator_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.arizonaLocationBindingNavigator_Click);
            // 
            // arizonaLocationBindingNavigatorSaveItem
            // 
            this.arizonaLocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.arizonaLocationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("arizonaLocationBindingNavigatorSaveItem.Image")));
            this.arizonaLocationBindingNavigatorSaveItem.Name = "arizonaLocationBindingNavigatorSaveItem";
            this.arizonaLocationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.arizonaLocationBindingNavigatorSaveItem.Text = "Save Data";
            this.arizonaLocationBindingNavigatorSaveItem.Click += new System.EventHandler(this.arizonaLocationBindingNavigatorSaveItem_Click);
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "locationName", true));
            this.locationNameTextBox.Location = new System.Drawing.Point(528, 37);
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.locationNameTextBox.TabIndex = 2;
            // 
            // countyTextBox
            // 
            this.countyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "County", true));
            this.countyTextBox.Location = new System.Drawing.Point(528, 63);
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.Size = new System.Drawing.Size(180, 20);
            this.countyTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(528, 89);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(180, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(528, 115);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(180, 20);
            this.categoryTextBox.TabIndex = 8;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(528, 141);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(180, 20);
            this.ratingTextBox.TabIndex = 10;
            // 
            // locationPictureTextBox
            // 
            this.locationPictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "locationPicture", true));
            this.locationPictureTextBox.Location = new System.Drawing.Point(528, 193);
            this.locationPictureTextBox.Name = "locationPictureTextBox";
            this.locationPictureTextBox.Size = new System.Drawing.Size(180, 20);
            this.locationPictureTextBox.TabIndex = 12;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(528, 167);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(180, 20);
            this.locationTextBox.TabIndex = 14;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arizonaLocationBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(528, 219);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(180, 219);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // resultsComboBox
            // 
            this.resultsComboBox.FormattingEnabled = true;
            this.resultsComboBox.Location = new System.Drawing.Point(12, 158);
            this.resultsComboBox.Name = "resultsComboBox";
            this.resultsComboBox.Size = new System.Drawing.Size(414, 21);
            this.resultsComboBox.TabIndex = 17;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 78);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(414, 74);
            this.searchTextBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(205, 43);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(223, 29);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(203, 43);
            this.showButton.TabIndex = 21;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\tbwit078\\source\\repos\\arizonaTouristAttractionsFinal\\arizonaTouristAttra" +
    "ctionsFinal\\Images";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arizonaTouristAttractionsFinal.Properties.Resources.Arizona_Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resultsComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(locationPictureLabel);
            this.Controls.Add(this.locationPictureTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countyLabel);
            this.Controls.Add(this.countyTextBox);
            this.Controls.Add(locationNameLabel);
            this.Controls.Add(this.locationNameTextBox);
            this.Controls.Add(this.arizonaLocationBindingNavigator);
            this.Name = "Form1";
            this.Text = "Arizona Tourist Attractions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arizona1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizonaLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizonaLocationBindingNavigator)).EndInit();
            this.arizonaLocationBindingNavigator.ResumeLayout(false);
            this.arizonaLocationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private arizona1DataSet arizona1DataSet;
        private System.Windows.Forms.BindingSource arizonaLocationBindingSource;
        private arizona1DataSetTableAdapters.arizonaLocationTableAdapter arizonaLocationTableAdapter;
        private arizona1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator arizonaLocationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton arizonaLocationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.TextBox countyTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox locationPictureTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox resultsComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

