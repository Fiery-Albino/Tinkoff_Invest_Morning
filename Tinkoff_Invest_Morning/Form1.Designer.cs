
namespace Tinkoff_Invest_Morning
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clTiker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQttyBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPriceBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAvailablePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFigi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateLimitOrders = new System.Windows.Forms.Button();
            this.lbLimitOrders = new System.Windows.Forms.ListBox();
            this.bntSetToken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.cbSandbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbToken
            // 
            this.tbToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToken.Location = new System.Drawing.Point(56, 12);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(607, 20);
            this.tbToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Токен";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clChecked,
            this.clTiker,
            this.clName,
            this.clQttyBuy,
            this.clPriceBuy,
            this.clAvailablePrice,
            this.clFigi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 167);
            this.dataGridView1.TabIndex = 2;
            // 
            // clChecked
            // 
            this.clChecked.DataPropertyName = "Checked";
            this.clChecked.HeaderText = "Включить";
            this.clChecked.Name = "clChecked";
            // 
            // clTiker
            // 
            this.clTiker.DataPropertyName = "Tiker";
            this.clTiker.HeaderText = "Тикер";
            this.clTiker.Name = "clTiker";
            this.clTiker.ReadOnly = true;
            this.clTiker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTiker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "FullName";
            this.clName.HeaderText = "Название";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clQttyBuy
            // 
            this.clQttyBuy.DataPropertyName = "BuyQtty";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.clQttyBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.clQttyBuy.HeaderText = "Кол-во покупки";
            this.clQttyBuy.Name = "clQttyBuy";
            this.clQttyBuy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clQttyBuy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clPriceBuy
            // 
            this.clPriceBuy.DataPropertyName = "BuyPrice";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clPriceBuy.DefaultCellStyle = dataGridViewCellStyle2;
            this.clPriceBuy.HeaderText = "Цена покупки";
            this.clPriceBuy.Name = "clPriceBuy";
            this.clPriceBuy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clPriceBuy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clAvailablePrice
            // 
            this.clAvailablePrice.DataPropertyName = "AvailablePrice";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clAvailablePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.clAvailablePrice.HeaderText = "Доступная цена";
            this.clAvailablePrice.Name = "clAvailablePrice";
            this.clAvailablePrice.ReadOnly = true;
            // 
            // clFigi
            // 
            this.clFigi.DataPropertyName = "Figi";
            this.clFigi.HeaderText = "Column1";
            this.clFigi.Name = "clFigi";
            this.clFigi.Visible = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchase.Location = new System.Drawing.Point(716, 239);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(109, 23);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Выставить заявки на покупку";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUpdateLimitOrders);
            this.groupBox1.Controls.Add(this.lbLimitOrders);
            this.groupBox1.Location = new System.Drawing.Point(15, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущие заявки";
            // 
            // btnUpdateLimitOrders
            // 
            this.btnUpdateLimitOrders.Location = new System.Drawing.Point(6, 127);
            this.btnUpdateLimitOrders.Name = "btnUpdateLimitOrders";
            this.btnUpdateLimitOrders.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLimitOrders.TabIndex = 1;
            this.btnUpdateLimitOrders.Text = "Обновить";
            this.btnUpdateLimitOrders.UseVisualStyleBackColor = true;
            this.btnUpdateLimitOrders.Click += new System.EventHandler(this.btnUpdateLimitOrders_Click);
            // 
            // lbLimitOrders
            // 
            this.lbLimitOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLimitOrders.FormattingEnabled = true;
            this.lbLimitOrders.Location = new System.Drawing.Point(6, 16);
            this.lbLimitOrders.Name = "lbLimitOrders";
            this.lbLimitOrders.Size = new System.Drawing.Size(798, 108);
            this.lbLimitOrders.TabIndex = 0;
            // 
            // bntSetToken
            // 
            this.bntSetToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSetToken.Location = new System.Drawing.Point(755, 12);
            this.bntSetToken.Name = "bntSetToken";
            this.bntSetToken.Size = new System.Drawing.Size(70, 23);
            this.bntSetToken.TabIndex = 6;
            this.bntSetToken.Text = "Ok";
            this.bntSetToken.UseVisualStyleBackColor = true;
            this.bntSetToken.Click += new System.EventHandler(this.bntSetToken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Счета";
            // 
            // cbAccounts
            // 
            this.cbAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(56, 38);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(607, 21);
            this.cbAccounts.TabIndex = 8;
            // 
            // cbSandbox
            // 
            this.cbSandbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSandbox.AutoSize = true;
            this.cbSandbox.Location = new System.Drawing.Point(669, 14);
            this.cbSandbox.Name = "cbSandbox";
            this.cbSandbox.Size = new System.Drawing.Size(79, 17);
            this.cbSandbox.TabIndex = 9;
            this.cbSandbox.Text = "песочница";
            this.cbSandbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 436);
            this.Controls.Add(this.cbSandbox);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntSetToken);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbToken);
            this.Name = "Form1";
            this.Text = "Tinkoff Invets Morning v0.02";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbLimitOrders;
        private System.Windows.Forms.Button btnUpdateLimitOrders;
        private System.Windows.Forms.Button bntSetToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.CheckBox cbSandbox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTiker;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQttyBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPriceBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAvailablePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFigi;
    }
}

