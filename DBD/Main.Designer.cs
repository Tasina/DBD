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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecreate = new System.Windows.Forms.Button();
            this.btnPreparedStatement = new System.Windows.Forms.Button();
            this.lbDBstate = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStoredProcedure
            // 
            this.tbStoredProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoredProcedure.Location = new System.Drawing.Point(11, 235);
            this.tbStoredProcedure.Name = "tbStoredProcedure";
            this.tbStoredProcedure.Size = new System.Drawing.Size(350, 26);
            this.tbStoredProcedure.TabIndex = 22;
            // 
            // tbRegularExpression
            // 
            this.tbRegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegularExpression.Location = new System.Drawing.Point(11, 174);
            this.tbRegularExpression.Name = "tbRegularExpression";
            this.tbRegularExpression.Size = new System.Drawing.Size(350, 26);
            this.tbRegularExpression.TabIndex = 21;
            // 
            // tbPreparedStatement
            // 
            this.tbPreparedStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreparedStatement.Location = new System.Drawing.Point(11, 112);
            this.tbPreparedStatement.Name = "tbPreparedStatement";
            this.tbPreparedStatement.Size = new System.Drawing.Size(350, 26);
            this.tbPreparedStatement.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prepared statement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Regular expression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stored procedure";
            // 
            // btnRegularExpression
            // 
            this.btnRegularExpression.BackColor = System.Drawing.Color.Transparent;
            this.btnRegularExpression.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegularExpression.BackgroundImage")));
            this.btnRegularExpression.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegularExpression.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegularExpression.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegularExpression.Location = new System.Drawing.Point(366, 158);
            this.btnRegularExpression.Name = "btnRegularExpression";
            this.btnRegularExpression.Size = new System.Drawing.Size(38, 41);
            this.btnRegularExpression.TabIndex = 31;
            this.btnRegularExpression.UseVisualStyleBackColor = false;
            this.btnRegularExpression.Click += new System.EventHandler(this.btnRegularExpression_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "SQL injection";
            // 
            // tbSQLInjection
            // 
            this.tbSQLInjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQLInjection.Location = new System.Drawing.Point(11, 319);
            this.tbSQLInjection.Name = "tbSQLInjection";
            this.tbSQLInjection.Size = new System.Drawing.Size(350, 26);
            this.tbSQLInjection.TabIndex = 33;
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.BackColor = System.Drawing.Color.Transparent;
            this.btnStoredProcedure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStoredProcedure.BackgroundImage")));
            this.btnStoredProcedure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoredProcedure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoredProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStoredProcedure.Location = new System.Drawing.Point(366, 219);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(38, 41);
            this.btnStoredProcedure.TabIndex = 34;
            this.btnStoredProcedure.UseVisualStyleBackColor = false;
            this.btnStoredProcedure.Click += new System.EventHandler(this.btnStoredProcedure_Click);
            // 
            // btnSQLInjection
            // 
            this.btnSQLInjection.BackColor = System.Drawing.Color.Transparent;
            this.btnSQLInjection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSQLInjection.BackgroundImage")));
            this.btnSQLInjection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSQLInjection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSQLInjection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSQLInjection.Location = new System.Drawing.Point(366, 303);
            this.btnSQLInjection.Name = "btnSQLInjection";
            this.btnSQLInjection.Size = new System.Drawing.Size(38, 41);
            this.btnSQLInjection.TabIndex = 36;
            this.btnSQLInjection.UseVisualStyleBackColor = false;
            this.btnSQLInjection.Click += new System.EventHandler(this.btnSQLInjection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dropdown";
            // 
            // cbDropdown
            // 
            this.cbDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropdown.FormattingEnabled = true;
            this.cbDropdown.Location = new System.Drawing.Point(11, 46);
            this.cbDropdown.Name = "cbDropdown";
            this.cbDropdown.Size = new System.Drawing.Size(350, 28);
            this.cbDropdown.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(-26, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 8);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(-26, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 8);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Recreate";
            // 
            // btnRecreate
            // 
            this.btnRecreate.BackColor = System.Drawing.Color.Transparent;
            this.btnRecreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecreate.BackgroundImage")));
            this.btnRecreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecreate.FlatAppearance.BorderSize = 0;
            this.btnRecreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecreate.Location = new System.Drawing.Point(361, 413);
            this.btnRecreate.Name = "btnRecreate";
            this.btnRecreate.Size = new System.Drawing.Size(56, 61);
            this.btnRecreate.TabIndex = 43;
            this.btnRecreate.UseVisualStyleBackColor = false;
            this.btnRecreate.Click += new System.EventHandler(this.btnRecreate_Click);
            // 
            // btnPreparedStatement
            // 
            this.btnPreparedStatement.BackColor = System.Drawing.Color.Transparent;
            this.btnPreparedStatement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreparedStatement.BackgroundImage")));
            this.btnPreparedStatement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreparedStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreparedStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreparedStatement.Location = new System.Drawing.Point(366, 96);
            this.btnPreparedStatement.Name = "btnPreparedStatement";
            this.btnPreparedStatement.Size = new System.Drawing.Size(38, 41);
            this.btnPreparedStatement.TabIndex = 26;
            this.btnPreparedStatement.UseVisualStyleBackColor = false;
            this.btnPreparedStatement.Click += new System.EventHandler(this.btnPreparedStatement_Click);
            // 
            // lbDBstate
            // 
            this.lbDBstate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDBstate.FormattingEnabled = true;
            this.lbDBstate.Location = new System.Drawing.Point(11, 413);
            this.lbDBstate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDBstate.Name = "lbDBstate";
            this.lbDBstate.Size = new System.Drawing.Size(331, 82);
            this.lbDBstate.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "SELECT query:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::DBD.Properties.Resources.app_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDBstate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecreate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
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
            this.Name = "Main";
            this.Text = "Ways of preventing SQL Injection";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecreate;
        private System.Windows.Forms.ListBox lbDBstate;
        private System.Windows.Forms.Label label7;
    }
}

