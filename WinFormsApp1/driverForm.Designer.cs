namespace WinFormsApp1
{
    partial class driverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driverForm));
            tabControl1 = new TabControl();
            Orders = new TabPage();
            myOrdersLbl = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            btnDeny = new Button();
            btnAccept = new Button();
            dataGridView1 = new DataGridView();
            order_id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Forms = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            loadBtn = new Button();
            docImage4 = new PictureBox();
            docImage3 = new PictureBox();
            docImage2 = new PictureBox();
            docImage1 = new PictureBox();
            tabControl1.SuspendLayout();
            Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docImage4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docImage3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docImage1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Orders);
            tabControl1.Controls.Add(Forms);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(951, 649);
            tabControl1.TabIndex = 0;
            // 
            // Orders
            // 
            Orders.Controls.Add(myOrdersLbl);
            Orders.Controls.Add(dataGridView2);
            Orders.Controls.Add(btnDeny);
            Orders.Controls.Add(btnAccept);
            Orders.Controls.Add(dataGridView1);
            Orders.Location = new Point(4, 29);
            Orders.Name = "Orders";
            Orders.Size = new Size(943, 616);
            Orders.TabIndex = 2;
            Orders.Text = "Заказы";
            Orders.UseVisualStyleBackColor = true;
            Orders.Click += Orders_Click;
            // 
            // myOrdersLbl
            // 
            myOrdersLbl.AutoSize = true;
            myOrdersLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            myOrdersLbl.Location = new Point(3, 345);
            myOrdersLbl.Name = "myOrdersLbl";
            myOrdersLbl.Size = new Size(95, 20);
            myOrdersLbl.TabIndex = 4;
            myOrdersLbl.Text = "Мои заказы";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridView2.Location = new Point(3, 368);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(940, 249);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "ID заказа";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Фамилия заказчика";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Имя заказчика";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Телефон заказчика";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Время принятия заказа";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Пункт отправления";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.HeaderText = "Пункт назначения";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(733, 313);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(94, 29);
            btnDeny.TabIndex = 2;
            btnDeny.Text = "Отказаться";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(846, 313);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Принять";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_id, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 304);
            dataGridView1.TabIndex = 0;
            // 
            // order_id
            // 
            order_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            order_id.HeaderText = "ID заказа";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Фамилия заказчика";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Имя заказчика";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Телефон заказчика";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Время принятия заказа";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Пункт отправления";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Пункт назначения";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Forms
            // 
            Forms.Controls.Add(label4);
            Forms.Controls.Add(label3);
            Forms.Controls.Add(label2);
            Forms.Controls.Add(label1);
            Forms.Controls.Add(loadBtn);
            Forms.Controls.Add(docImage4);
            Forms.Controls.Add(docImage3);
            Forms.Controls.Add(docImage2);
            Forms.Controls.Add(docImage1);
            Forms.Location = new Point(4, 29);
            Forms.Name = "Forms";
            Forms.Size = new Size(943, 616);
            Forms.TabIndex = 3;
            Forms.Text = "Отчеты";
            Forms.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 284);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Фото салона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 284);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Фото сзади";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 9);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 6;
            label2.Text = "Фото спереди";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Фото машины";
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(685, 567);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(94, 29);
            loadBtn.TabIndex = 4;
            loadBtn.Text = "Загрузить";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // docImage4
            // 
            docImage4.BackgroundImageLayout = ImageLayout.Zoom;
            docImage4.Location = new Point(419, 307);
            docImage4.Name = "docImage4";
            docImage4.Size = new Size(360, 240);
            docImage4.TabIndex = 3;
            docImage4.TabStop = false;
            docImage4.Click += docImage4_Click;
            // 
            // docImage3
            // 
            docImage3.BackgroundImageLayout = ImageLayout.Zoom;
            docImage3.Location = new Point(10, 307);
            docImage3.Name = "docImage3";
            docImage3.Size = new Size(360, 240);
            docImage3.TabIndex = 2;
            docImage3.TabStop = false;
            docImage3.Click += docImage3_Click;
            // 
            // docImage2
            // 
            docImage2.BackgroundImageLayout = ImageLayout.Zoom;
            docImage2.Location = new Point(419, 32);
            docImage2.Name = "docImage2";
            docImage2.Size = new Size(360, 240);
            docImage2.TabIndex = 1;
            docImage2.TabStop = false;
            docImage2.Click += docImage2_Click;
            // 
            // docImage1
            // 
            docImage1.BackgroundImageLayout = ImageLayout.Zoom;
            docImage1.Location = new Point(10, 32);
            docImage1.Name = "docImage1";
            docImage1.Size = new Size(360, 240);
            docImage1.TabIndex = 0;
            docImage1.TabStop = false;
            docImage1.Click += docImage1_Click;
            // 
            // driverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 673);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "driverForm";
            Text = "TaxiMax - Мой кабинет";
            Load += driverForm_Load;
            tabControl1.ResumeLayout(false);
            Orders.ResumeLayout(false);
            Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Forms.ResumeLayout(false);
            Forms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docImage4).EndInit();
            ((System.ComponentModel.ISupportInitialize)docImage3).EndInit();
            ((System.ComponentModel.ISupportInitialize)docImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)docImage1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Orders;
        private TabPage Forms;
        private DataGridView dataGridView1;
        private Button btnDeny;
        private Button btnAccept;
        private PictureBox docImage1;
        private DataGridView dataGridView2;
        private Label myOrdersLbl;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox docImage2;
        private Button loadBtn;
        private PictureBox docImage4;
        private PictureBox docImage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}