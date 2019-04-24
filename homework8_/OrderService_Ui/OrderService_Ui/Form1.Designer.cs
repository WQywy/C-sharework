namespace OrderService_Ui
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryText = new System.Windows.Forms.TextBox();
            this.queryBotton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.queryIdLabel = new System.Windows.Forms.Label();
            this.queryIdText = new System.Windows.Forms.TextBox();
            this.queryIdBotton = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDBS = new System.Windows.Forms.BindingSource(this.components);
            this.orderBS = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerId,
            this.CustomerName});
            this.dataGridView1.DataSource = this.orderBS;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(433, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(469, 12);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(103, 15);
            this.queryLabel.TabIndex = 1;
            this.queryLabel.Text = "Customer Id:";
            // 
            // queryText
            // 
            this.queryText.Location = new System.Drawing.Point(601, 9);
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(100, 25);
            this.queryText.TabIndex = 2;
            // 
            // queryBotton
            // 
            this.queryBotton.Location = new System.Drawing.Point(736, 12);
            this.queryBotton.Name = "queryBotton";
            this.queryBotton.Size = new System.Drawing.Size(75, 23);
            this.queryBotton.TabIndex = 3;
            this.queryBotton.Text = "Search";
            this.queryBotton.UseVisualStyleBackColor = true;
            this.queryBotton.Click += new System.EventHandler(this.queryBotton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.goodIdDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderDBS;
            this.dataGridView2.Location = new System.Drawing.Point(12, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(731, 271);
            this.dataGridView2.TabIndex = 4;
            // 
            // queryIdLabel
            // 
            this.queryIdLabel.AutoSize = true;
            this.queryIdLabel.Location = new System.Drawing.Point(472, 62);
            this.queryIdLabel.Name = "queryIdLabel";
            this.queryIdLabel.Size = new System.Drawing.Size(79, 15);
            this.queryIdLabel.TabIndex = 5;
            this.queryIdLabel.Text = "Order Id:";
            // 
            // queryIdText
            // 
            this.queryIdText.Location = new System.Drawing.Point(601, 59);
            this.queryIdText.Name = "queryIdText";
            this.queryIdText.Size = new System.Drawing.Size(100, 25);
            this.queryIdText.TabIndex = 6;
            // 
            // queryIdBotton
            // 
            this.queryIdBotton.Location = new System.Drawing.Point(736, 60);
            this.queryIdBotton.Name = "queryIdBotton";
            this.queryIdBotton.Size = new System.Drawing.Size(75, 23);
            this.queryIdBotton.TabIndex = 7;
            this.queryIdBotton.Text = "Delete";
            this.queryIdBotton.UseVisualStyleBackColor = true;
            this.queryIdBotton.Click += new System.EventHandler(this.queryIdBotton_Click);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "Id";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // orderDBS
            // 
            this.orderDBS.DataSource = typeof(OrderService_Ui.OrderDetail);
            // 
            // orderBS
            // 
            this.orderBS.DataSource = typeof(OrderService_Ui.OrderService);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 535);
            this.Controls.Add(this.queryIdBotton);
            this.Controls.Add(this.queryIdText);
            this.Controls.Add(this.queryIdLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.queryBotton);
            this.Controls.Add(this.queryText);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderDBS;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Button queryBotton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label queryIdLabel;
        private System.Windows.Forms.TextBox queryIdText;
        private System.Windows.Forms.Button queryIdBotton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
    }
}

        
    


