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
            this.btnCLose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStoredProcedure
            // 
            this.tbStoredProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoredProcedure.Location = new System.Drawing.Point(164, 306);
            this.tbStoredProcedure.Name = "tbStoredProcedure";
            this.tbStoredProcedure.Size = new System.Drawing.Size(350, 26);
            this.tbStoredProcedure.TabIndex = 22;
            // 
            // tbRegularExpression
            // 
            this.tbRegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegularExpression.Location = new System.Drawing.Point(164, 228);
            this.tbRegularExpression.Name = "tbRegularExpression";
            this.tbRegularExpression.Size = new System.Drawing.Size(350, 26);
            this.tbRegularExpression.TabIndex = 21;
            // 
            // tbPreparedStatement
            // 
            this.tbPreparedStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreparedStatement.Location = new System.Drawing.Point(164, 162);
            this.tbPreparedStatement.Name = "tbPreparedStatement";
            this.tbPreparedStatement.Size = new System.Drawing.Size(350, 26);
            this.tbPreparedStatement.TabIndex = 20;
            // 
            // btnPreparedStatement
            // 
            this.btnPreparedStatement.Location = new System.Drawing.Point(535, 156);
            this.btnPreparedStatement.Name = "btnPreparedStatement";
            this.btnPreparedStatement.Size = new System.Drawing.Size(120, 40);
            this.btnPreparedStatement.TabIndex = 26;
            this.btnPreparedStatement.Text = "GO";
            this.btnPreparedStatement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prepared statement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Regular expression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stored procedure";
            // 
            // btnRegularExpression
            // 
            this.btnRegularExpression.Location = new System.Drawing.Point(535, 222);
            this.btnRegularExpression.Name = "btnRegularExpression";
            this.btnRegularExpression.Size = new System.Drawing.Size(120, 40);
            this.btnRegularExpression.TabIndex = 31;
            this.btnRegularExpression.Text = "GO";
            this.btnRegularExpression.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "SQL injection";
            // 
            // tbSQLInjection
            // 
            this.tbSQLInjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQLInjection.Location = new System.Drawing.Point(164, 383);
            this.tbSQLInjection.Name = "tbSQLInjection";
            this.tbSQLInjection.Size = new System.Drawing.Size(350, 26);
            this.tbSQLInjection.TabIndex = 33;
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.Location = new System.Drawing.Point(535, 300);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(120, 40);
            this.btnStoredProcedure.TabIndex = 34;
            this.btnStoredProcedure.Text = "GO";
            this.btnStoredProcedure.UseVisualStyleBackColor = true;
            // 
            // btnSQLInjection
            // 
            this.btnSQLInjection.Location = new System.Drawing.Point(535, 377);
            this.btnSQLInjection.Name = "btnSQLInjection";
            this.btnSQLInjection.Size = new System.Drawing.Size(120, 40);
            this.btnSQLInjection.TabIndex = 36;
            this.btnSQLInjection.Text = "GO";
            this.btnSQLInjection.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dropdown";
            // 
            // cbDropdown
            // 
            this.cbDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropdown.FormattingEnabled = true;
            this.cbDropdown.Location = new System.Drawing.Point(164, 87);
            this.cbDropdown.Name = "cbDropdown";
            this.cbDropdown.Size = new System.Drawing.Size(350, 28);
            this.cbDropdown.TabIndex = 37;
            // 
            // btnDropDown
            // 
            this.btnDropDown.Location = new System.Drawing.Point(535, 81);
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(120, 40);
            this.btnDropDown.TabIndex = 39;
            this.btnDropDown.Text = "GO";
            this.btnDropDown.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(16, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 5);
            this.panel1.TabIndex = 41;
            // 
            // btnCLose
            // 
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(620, 11);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(35, 30);
            this.btnCLose.TabIndex = 42;
            this.btnCLose.Text = "X";
            this.btnCLose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 5);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(12, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 5);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Recreate";
            // 
            // btnReCreate
            // 
            this.btnReCreate.BackColor = System.Drawing.Color.DarkGray;
            this.btnReCreate.BackgroundImage = global::DBD.Properties.Resources.db;
            this.btnReCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReCreate.FlatAppearance.BorderSize = 0;
            this.btnReCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReCreate.Location = new System.Drawing.Point(593, 479);
            this.btnReCreate.Name = "btnReCreate";
            this.btnReCreate.Size = new System.Drawing.Size(62, 59);
            this.btnReCreate.TabIndex = 43;
            this.btnReCreate.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(667, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReCreate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCLose);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
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
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReCreate;
    }
}

