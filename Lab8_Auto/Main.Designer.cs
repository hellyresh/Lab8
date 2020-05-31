namespace Lab8_Auto
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showAll = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.delete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.add, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.search, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.showAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showAll.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.Location = new System.Drawing.Point(20, 5);
            this.showAll.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(160, 61);
            this.showAll.TabIndex = 0;
            this.showAll.Text = "Показать всё";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.ShowAll);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(220, 5);
            this.search.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(160, 61);
            this.search.TabIndex = 1;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(420, 5);
            this.add.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(160, 61);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(620, 5);
            this.delete.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(161, 61);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tableView
            // 
            this.tableView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.tableView, 4);
            this.tableView.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.tableView.Location = new System.Drawing.Point(143, 76);
            this.tableView.Margin = new System.Windows.Forms.Padding(20, 5, 20, 10);
            this.tableView.MaximumSize = new System.Drawing.Size(515, 900);
            this.tableView.Multiline = true;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableView.Size = new System.Drawing.Size(515, 631);
            this.tableView.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(823, 592);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button showAll;
        public System.Windows.Forms.TextBox tableView;
    }
}

