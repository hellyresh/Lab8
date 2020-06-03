namespace Lab8_Auto
{
    partial class Search
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mark = new System.Windows.Forms.RadioButton();
            this.surname = new System.Windows.Forms.RadioButton();
            this.fuel = new System.Windows.Forms.RadioButton();
            this.power = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchIt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.searchIt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.power, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fuel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mark, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.surname, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mark.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark.Location = new System.Drawing.Point(254, 50);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(246, 41);
            this.mark.TabIndex = 0;
            this.mark.Text = "марка автомобиля";
            this.mark.UseVisualStyleBackColor = true;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Checked = true;
            this.surname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surname.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(254, 3);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(246, 41);
            this.surname.TabIndex = 3;
            this.surname.TabStop = true;
            this.surname.Text = "фамилия владельца";
            this.surname.UseVisualStyleBackColor = true;
            // 
            // fuel
            // 
            this.fuel.AutoSize = true;
            this.fuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel.Location = new System.Drawing.Point(254, 97);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(246, 41);
            this.fuel.TabIndex = 1;
            this.fuel.Text = "марка бензина";
            this.fuel.UseVisualStyleBackColor = true;
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.power.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(254, 144);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(246, 41);
            this.power.TabIndex = 2;
            this.power.Text = "мощность двигателя";
            this.power.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(245, 94);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.searchTextBox, 2);
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(10, 191);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(483, 34);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchIt
            // 
            this.searchIt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchIt.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchIt.Location = new System.Drawing.Point(397, 238);
            this.searchIt.Name = "searchIt";
            this.searchIt.Size = new System.Drawing.Size(103, 46);
            this.searchIt.TabIndex = 6;
            this.searchIt.Text = "Искать";
            this.searchIt.UseVisualStyleBackColor = false;
            this.searchIt.Click += new System.EventHandler(this.searchIt_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 287);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(525, 343);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton mark;
        private System.Windows.Forms.RadioButton surname;
        private System.Windows.Forms.RadioButton fuel;
        private System.Windows.Forms.RadioButton power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchIt;
    }
}