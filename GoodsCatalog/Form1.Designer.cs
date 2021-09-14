
namespace GoodsCatalog
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.producersList = new System.Windows.Forms.ComboBox();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.countField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programItem,
            this.categoryItem,
            this.producersItem,
            this.productItem,
            this.aboutItem,
            this.ordersItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programItem
            // 
            this.programItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitItem});
            this.programItem.Name = "programItem";
            this.programItem.Size = new System.Drawing.Size(65, 20);
            this.programItem.Text = "&Program";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(93, 22);
            this.exitItem.Text = "&Exit";
            // 
            // categoryItem
            // 
            this.categoryItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCategoryItem,
            this.updateCategoryItem,
            this.deleteCategoryItem});
            this.categoryItem.Name = "categoryItem";
            this.categoryItem.Size = new System.Drawing.Size(75, 20);
            this.categoryItem.Text = "&Categories";
            // 
            // createCategoryItem
            // 
            this.createCategoryItem.Name = "createCategoryItem";
            this.createCategoryItem.Size = new System.Drawing.Size(180, 22);
            this.createCategoryItem.Text = "&CreateCategory";
            this.createCategoryItem.Click += new System.EventHandler(this.createCategoryItem_Click);
            // 
            // updateCategoryItem
            // 
            this.updateCategoryItem.Name = "updateCategoryItem";
            this.updateCategoryItem.Size = new System.Drawing.Size(180, 22);
            this.updateCategoryItem.Text = "&UpdateCategory";
            this.updateCategoryItem.Click += new System.EventHandler(this.updateCategoryItem_Click);
            // 
            // deleteCategoryItem
            // 
            this.deleteCategoryItem.Name = "deleteCategoryItem";
            this.deleteCategoryItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCategoryItem.Text = "&DeleteCategory";
            this.deleteCategoryItem.Click += new System.EventHandler(this.deleteCategoryItem_Click);
            // 
            // producersItem
            // 
            this.producersItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProducerItem,
            this.updateProducerItem,
            this.deleteProducerItem});
            this.producersItem.Name = "producersItem";
            this.producersItem.Size = new System.Drawing.Size(72, 20);
            this.producersItem.Text = "&Producers";
            // 
            // createProducerItem
            // 
            this.createProducerItem.Name = "createProducerItem";
            this.createProducerItem.Size = new System.Drawing.Size(160, 22);
            this.createProducerItem.Text = "&CreateProducer";
            // 
            // updateProducerItem
            // 
            this.updateProducerItem.Name = "updateProducerItem";
            this.updateProducerItem.Size = new System.Drawing.Size(160, 22);
            this.updateProducerItem.Text = "UpdateProducer";
            // 
            // deleteProducerItem
            // 
            this.deleteProducerItem.Name = "deleteProducerItem";
            this.deleteProducerItem.Size = new System.Drawing.Size(160, 22);
            this.deleteProducerItem.Text = "&DeleteProducer";
            // 
            // productItem
            // 
            this.productItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProductItem,
            this.updateProductItem,
            this.deleteProductItem});
            this.productItem.Name = "productItem";
            this.productItem.Size = new System.Drawing.Size(66, 20);
            this.productItem.Text = "&Products";
            // 
            // createProductItem
            // 
            this.createProductItem.Name = "createProductItem";
            this.createProductItem.Size = new System.Drawing.Size(154, 22);
            this.createProductItem.Text = "&CreateProduct";
            // 
            // updateProductItem
            // 
            this.updateProductItem.Name = "updateProductItem";
            this.updateProductItem.Size = new System.Drawing.Size(154, 22);
            this.updateProductItem.Text = "&UpdateProduct";
            // 
            // deleteProductItem
            // 
            this.deleteProductItem.Name = "deleteProductItem";
            this.deleteProductItem.Size = new System.Drawing.Size(154, 22);
            this.deleteProductItem.Text = "&DeleteProduct";
            // 
            // aboutItem
            // 
            this.aboutItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorItem});
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(52, 20);
            this.aboutItem.Text = "&About";
            // 
            // authorItem
            // 
            this.authorItem.Name = "authorItem";
            this.authorItem.Size = new System.Drawing.Size(111, 22);
            this.authorItem.Text = "&Author";
            // 
            // ordersItem
            // 
            this.ordersItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersManageItem});
            this.ordersItem.Name = "ordersItem";
            this.ordersItem.Size = new System.Drawing.Size(54, 20);
            this.ordersItem.Text = "&Orders";
            // 
            // ordersManageItem
            // 
            this.ordersManageItem.Name = "ordersManageItem";
            this.ordersManageItem.Size = new System.Drawing.Size(117, 22);
            this.ordersManageItem.Text = "&Manage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodsCatalog.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(142, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автоматизированная система управления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(249, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "каталогом товаров";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.producersList);
            this.groupBox1.Controls.Add(this.categoriesList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры выборки товаров";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(501, 20);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 24);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Выбрать";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(223, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Производитель:";
            // 
            // producersList
            // 
            this.producersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producersList.FormattingEnabled = true;
            this.producersList.Location = new System.Drawing.Point(358, 21);
            this.producersList.Name = "producersList";
            this.producersList.Size = new System.Drawing.Size(121, 23);
            this.producersList.TabIndex = 2;
            // 
            // categoriesList
            // 
            this.categoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(96, 21);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(121, 23);
            this.categoriesList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(1, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Категория:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список товаров";
            // 
            // productsList
            // 
            this.productsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.productsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsList.FullRowSelect = true;
            this.productsList.HideSelection = false;
            this.productsList.Location = new System.Drawing.Point(3, 17);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(585, 176);
            this.productsList.TabIndex = 0;
            this.productsList.UseCompatibleStateImageBehavior = false;
            this.productsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ед. измерения";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Срок хранения";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Доставка";
            this.columnHeader6.Width = 71;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orderButton);
            this.groupBox3.Controls.Add(this.countField);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.priceField);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nameField);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление заказами";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(454, 43);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(118, 24);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Заказать товар";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(341, 45);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(93, 21);
            this.countField.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(341, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Количество:";
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(220, 45);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(93, 21);
            this.priceField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(220, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(6, 45);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(180, 21);
            this.nameField.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Наименование:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 458);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог товаров - Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem categoryItem;
        private System.Windows.Forms.ToolStripMenuItem createCategoryItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryItem;
        private System.Windows.Forms.ToolStripMenuItem producersItem;
        private System.Windows.Forms.ToolStripMenuItem productItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem createProducerItem;
        private System.Windows.Forms.ToolStripMenuItem updateProducerItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProducerItem;
        private System.Windows.Forms.ToolStripMenuItem createProductItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductItem;
        private System.Windows.Forms.ToolStripMenuItem authorItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox producersList;
        private System.Windows.Forms.ComboBox categoriesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView productsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem ordersItem;
        private System.Windows.Forms.ToolStripMenuItem ordersManageItem;
    }
}

