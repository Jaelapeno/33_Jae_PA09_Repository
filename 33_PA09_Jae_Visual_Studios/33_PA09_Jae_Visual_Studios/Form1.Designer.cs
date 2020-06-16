namespace _33_PA09_Jae_Visual_Studios
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
            this.Lbl_Amount = new System.Windows.Forms.Label();
            this.Lbl_SelectCurrency = new System.Windows.Forms.Label();
            this.Lbl_Value = new System.Windows.Forms.Label();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.Txt_Value = new System.Windows.Forms.TextBox();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Rdb_USDollars = new System.Windows.Forms.RadioButton();
            this.Rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.Rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.AutoSize = true;
            this.Lbl_Amount.Location = new System.Drawing.Point(75, 57);
            this.Lbl_Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Amount.TabIndex = 0;
            this.Lbl_Amount.Text = "Amount";
            // 
            // Lbl_SelectCurrency
            // 
            this.Lbl_SelectCurrency.AutoSize = true;
            this.Lbl_SelectCurrency.Location = new System.Drawing.Point(75, 122);
            this.Lbl_SelectCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_SelectCurrency.Name = "Lbl_SelectCurrency";
            this.Lbl_SelectCurrency.Size = new System.Drawing.Size(82, 13);
            this.Lbl_SelectCurrency.TabIndex = 1;
            this.Lbl_SelectCurrency.Text = "Select Currency";
            // 
            // Lbl_Value
            // 
            this.Lbl_Value.AutoSize = true;
            this.Lbl_Value.Location = new System.Drawing.Point(75, 244);
            this.Lbl_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Value.Name = "Lbl_Value";
            this.Lbl_Value.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Value.TabIndex = 2;
            this.Lbl_Value.Text = "Value";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(225, 57);
            this.Txt_Amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(151, 20);
            this.Txt_Amount.TabIndex = 3;
            // 
            // Txt_Value
            // 
            this.Txt_Value.Location = new System.Drawing.Point(225, 244);
            this.Txt_Value.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Value.Name = "Txt_Value";
            this.Txt_Value.ReadOnly = true;
            this.Txt_Value.Size = new System.Drawing.Size(151, 20);
            this.Txt_Value.TabIndex = 4;
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Location = new System.Drawing.Point(412, 122);
            this.Btn_Convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(56, 19);
            this.Btn_Convert.TabIndex = 5;
            this.Btn_Convert.Text = "Convert";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(412, 203);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(56, 19);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Rdb_USDollars
            // 
            this.Rdb_USDollars.AutoSize = true;
            this.Rdb_USDollars.Location = new System.Drawing.Point(225, 122);
            this.Rdb_USDollars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_USDollars.Name = "Rdb_USDollars";
            this.Rdb_USDollars.Size = new System.Drawing.Size(75, 17);
            this.Rdb_USDollars.TabIndex = 7;
            this.Rdb_USDollars.TabStop = true;
            this.Rdb_USDollars.Text = "US Dollars";
            this.Rdb_USDollars.UseVisualStyleBackColor = true;
            // 
            // Rdb_JapaneseYen
            // 
            this.Rdb_JapaneseYen.AutoSize = true;
            this.Rdb_JapaneseYen.Location = new System.Drawing.Point(225, 162);
            this.Rdb_JapaneseYen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_JapaneseYen.Name = "Rdb_JapaneseYen";
            this.Rdb_JapaneseYen.Size = new System.Drawing.Size(93, 17);
            this.Rdb_JapaneseYen.TabIndex = 8;
            this.Rdb_JapaneseYen.TabStop = true;
            this.Rdb_JapaneseYen.Text = "Japanese Yen";
            this.Rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // Rdb_MalaysianRinggit
            // 
            this.Rdb_MalaysianRinggit.AutoSize = true;
            this.Rdb_MalaysianRinggit.Location = new System.Drawing.Point(225, 203);
            this.Rdb_MalaysianRinggit.Margin = new System.Windows.Forms.Padding(2);
            this.Rdb_MalaysianRinggit.Name = "Rdb_MalaysianRinggit";
            this.Rdb_MalaysianRinggit.Size = new System.Drawing.Size(108, 17);
            this.Rdb_MalaysianRinggit.TabIndex = 9;
            this.Rdb_MalaysianRinggit.TabStop = true;
            this.Rdb_MalaysianRinggit.Text = "Malaysian Ringgit";
            this.Rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Rdb_MalaysianRinggit);
            this.Controls.Add(this.Rdb_JapaneseYen);
            this.Controls.Add(this.Rdb_USDollars);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Convert);
            this.Controls.Add(this.Txt_Value);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.Lbl_Value);
            this.Controls.Add(this.Lbl_SelectCurrency);
            this.Controls.Add(this.Lbl_Amount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Amount;
        private System.Windows.Forms.Label Lbl_SelectCurrency;
        private System.Windows.Forms.Label Lbl_Value;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.TextBox Txt_Value;
        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.RadioButton Rdb_USDollars;
        private System.Windows.Forms.RadioButton Rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton Rdb_MalaysianRinggit;
    }
}

