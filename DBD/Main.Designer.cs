namespace DBD
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbStoredProcedure = new System.Windows.Forms.TextBox();
            this.tbRegularExpression = new System.Windows.Forms.TextBox();
            this.tbPreparedStatement = new System.Windows.Forms.TextBox();
            this.btnPreparedStatement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegularExpression = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSQLInjection = new System.Windows.Forms.TextBox();
            this.btnStoredProcedure = new System.Windows.Forms.Button();
            this.btnSQLInjection = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDropdown = new System.Windows.Forms.ComboBox();
            this.btnDropDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbDatabaseItems = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStoredProcedure
            // 
            this.tbStoredProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoredProcedure.Location = new System.Drawing.Point(216, 284);
            this.tbStoredProcedure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStoredProcedure.Name = "tbStoredProcedure";
            this.tbStoredProcedure.Size = new System.Drawing.Size(465, 30);
            this.tbStoredProcedure.TabIndex = 22;
            // 
            // tbRegularExpression
            // 
            this.tbRegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegularExpression.Location = new System.Drawing.Point(216, 209);
            this.tbRegularExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegularExpression.Name = "tbRegularExpression";
            this.tbRegularExpression.Size = new System.Drawing.Size(465, 30);
            this.tbRegularExpression.TabIndex = 21;
            // 
            // tbPreparedStatement
            // 
            this.tbPreparedStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreparedStatement.Location = new System.Drawing.Point(216, 132);
            this.tbPreparedStatement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPreparedStatement.Name = "tbPreparedStatement";
            this.tbPreparedStatement.Size = new System.Drawing.Size(465, 30);
            this.tbPreparedStatement.TabIndex = 20;
            // 
            // btnPreparedStatement
            // 
            this.btnPreparedStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreparedStatement.Location = new System.Drawing.Point(710, 125);
            this.btnPreparedStatement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreparedStatement.Name = "btnPreparedStatement";
            this.btnPreparedStatement.Size = new System.Drawing.Size(160, 49);
            this.btnPreparedStatement.TabIndex = 26;
            this.btnPreparedStatement.Text = "GO";
            this.btnPreparedStatement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prepared statement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Regular expression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stored procedure";
            // 
            // btnRegularExpression
            // 
            this.btnRegularExpression.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegularExpression.Location = new System.Drawing.Point(710, 201);
            this.btnRegularExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegularExpression.Name = "btnRegularExpression";
            this.btnRegularExpression.Size = new System.Drawing.Size(160, 49);
            this.btnRegularExpression.TabIndex = 31;
            this.btnRegularExpression.Text = "GO";
            this.btnRegularExpression.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "SQL injection";
            // 
            // tbSQLInjection
            // 
            this.tbSQLInjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQLInjection.Location = new System.Drawing.Point(216, 381);
            this.tbSQLInjection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSQLInjection.Name = "tbSQLInjection";
            this.tbSQLInjection.Size = new System.Drawing.Size(465, 30);
            this.tbSQLInjection.TabIndex = 33;
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoredProcedure.Location = new System.Drawing.Point(710, 276);
            this.btnStoredProcedure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(160, 49);
            this.btnStoredProcedure.TabIndex = 34;
            this.btnStoredProcedure.Text = "GO";
            this.btnStoredProcedure.UseVisualStyleBackColor = true;
            // 
            // btnSQLInjection
            // 
            this.btnSQLInjection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSQLInjection.Location = new System.Drawing.Point(710, 374);
            this.btnSQLInjection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSQLInjection.Name = "btnSQLInjection";
            this.btnSQLInjection.Size = new System.Drawing.Size(160, 49);
            this.btnSQLInjection.TabIndex = 36;
            this.btnSQLInjection.Text = "GO";
            this.btnSQLInjection.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dropdown";
            // 
            // cbDropdown
            // 
            this.cbDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropdown.FormattingEnabled = true;
            this.cbDropdown.Location = new System.Drawing.Point(216, 51);
            this.cbDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropdown.Name = "cbDropdown";
            this.cbDropdown.Size = new System.Drawing.Size(465, 33);
            this.cbDropdown.TabIndex = 37;
            // 
            // btnDropDown
            // 
            this.btnDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropDown.Location = new System.Drawing.Point(710, 44);
            this.btnDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(160, 49);
            this.btnDropDown.TabIndex = 39;
            this.btnDropDown.Text = "GO";
            this.btnDropDown.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(13, 348);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 10);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 10);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(13, 447);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 10);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Recreate";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(884, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 587);
            this.panel4.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(884, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(417, 10);
            this.panel5.TabIndex = 43;
            // 
            // lbDatabaseItems
            // 
            this.lbDatabaseItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDatabaseItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDatabaseItems.Enabled = false;
            this.lbDatabaseItems.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabaseItems.ItemHeight = 24;
            this.lbDatabaseItems.Location = new System.Drawing.Point(910, 44);
            this.lbDatabaseItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDatabaseItems.Name = "lbDatabaseItems";
            this.lbDatabaseItems.Size = new System.Drawing.Size(390, 386);
            this.lbDatabaseItems.TabIndex = 45;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1030, 460);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 43);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnReCreate
            // 
            this.btnReCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnReCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReCreate.BackgroundImage")));
            this.btnReCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReCreate.FlatAppearance.BorderSize = 0;
            this.btnReCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReCreate.Location = new System.Drawing.Point(750, 507);
            this.btnReCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnReCreate.Name = "btnReCreate";
            this.btnReCreate.Size = new System.Drawing.Size(83, 73);
            this.btnReCreate.TabIndex = 43;
            this.btnReCreate.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1320, 614);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbDatabaseItems);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReCreate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDropdown);
            this.Controls.Add(this.btnSQLInjection);
            this.Controls.Add(this.btnStoredProcedure);
            this.Controls.Add(this.tbSQLInjection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegularExpression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPreparedStatement);
            this.Controls.Add(this.tbStoredProcedure);
            this.Controls.Add(this.tbRegularExpression);
            this.Controls.Add(this.tbPreparedStatement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "DBD: SQL Injection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbStoredProcedure;
        private System.Windows.Forms.TextBox tbRegularExpression;
        private System.Windows.Forms.TextBox tbPreparedStatement;
        private System.Windows.Forms.Button btnPreparedStatement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegularExpression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSQLInjection;
        private System.Windows.Forms.Button btnStoredProcedure;
        private System.Windows.Forms.Button btnSQLInjection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDropdown;
        private System.Windows.Forms.Button btnDropDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lbDatabaseItems;
        private System.Windows.Forms.Button btnRefresh;
    }
}

