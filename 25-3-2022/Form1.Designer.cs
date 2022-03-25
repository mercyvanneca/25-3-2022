namespace _25_3_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Data = new System.Windows.Forms.Label();
            this.TextBox_Data = new System.Windows.Forms.TextBox();
            this.Label_Mode = new System.Windows.Forms.Label();
            this.Button_Proses = new System.Windows.Forms.Button();
            this.ComboBox_Mode = new System.Windows.Forms.ComboBox();
            this.CheckBox_Block = new System.Windows.Forms.CheckBox();
            this.ListBox_Kiri = new System.Windows.Forms.ListBox();
            this.ListBox_Kanan = new System.Windows.Forms.ListBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(33, 32);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(40, 15);
            this.Label_Data.TabIndex = 0;
            this.Label_Data.Text = "Data : ";
            // 
            // TextBox_Data
            // 
            this.TextBox_Data.Location = new System.Drawing.Point(79, 29);
            this.TextBox_Data.Name = "TextBox_Data";
            this.TextBox_Data.Size = new System.Drawing.Size(225, 23);
            this.TextBox_Data.TabIndex = 1;
            this.TextBox_Data.TextChanged += new System.EventHandler(this.TextBox_Data_TextChanged);
            // 
            // Label_Mode
            // 
            this.Label_Mode.AutoSize = true;
            this.Label_Mode.Location = new System.Drawing.Point(33, 70);
            this.Label_Mode.Name = "Label_Mode";
            this.Label_Mode.Size = new System.Drawing.Size(47, 15);
            this.Label_Mode.TabIndex = 2;
            this.Label_Mode.Text = "Mode : ";
            this.Label_Mode.Click += new System.EventHandler(this.Label_Mode_Click);
            // 
            // Button_Proses
            // 
            this.Button_Proses.Location = new System.Drawing.Point(33, 118);
            this.Button_Proses.Name = "Button_Proses";
            this.Button_Proses.Size = new System.Drawing.Size(75, 23);
            this.Button_Proses.TabIndex = 4;
            this.Button_Proses.Text = "Proses";
            this.Button_Proses.UseVisualStyleBackColor = true;
            this.Button_Proses.Click += new System.EventHandler(this.Button_Proses_Click);
            // 
            // ComboBox_Mode
            // 
            this.ComboBox_Mode.FormattingEnabled = true;
            this.ComboBox_Mode.Location = new System.Drawing.Point(79, 70);
            this.ComboBox_Mode.Name = "ComboBox_Mode";
            this.ComboBox_Mode.Size = new System.Drawing.Size(225, 23);
            this.ComboBox_Mode.TabIndex = 5;
            this.ComboBox_Mode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Mode_SelectedIndexChanged);
            // 
            // CheckBox_Block
            // 
            this.CheckBox_Block.AutoSize = true;
            this.CheckBox_Block.Location = new System.Drawing.Point(279, 122);
            this.CheckBox_Block.Name = "CheckBox_Block";
            this.CheckBox_Block.Size = new System.Drawing.Size(55, 19);
            this.CheckBox_Block.TabIndex = 6;
            this.CheckBox_Block.Text = "Block";
            this.CheckBox_Block.UseVisualStyleBackColor = true;
            this.CheckBox_Block.CheckedChanged += new System.EventHandler(this.CheckBox_Block_CheckedChanged);
            // 
            // ListBox_Kiri
            // 
            this.ListBox_Kiri.FormattingEnabled = true;
            this.ListBox_Kiri.ItemHeight = 15;
            this.ListBox_Kiri.Location = new System.Drawing.Point(33, 165);
            this.ListBox_Kiri.Name = "ListBox_Kiri";
            this.ListBox_Kiri.Size = new System.Drawing.Size(131, 274);
            this.ListBox_Kiri.TabIndex = 7;
            this.ListBox_Kiri.SelectedIndexChanged += new System.EventHandler(this.ListBox_Kiri_SelectedIndexChanged);
            // 
            // ListBox_Kanan
            // 
            this.ListBox_Kanan.FormattingEnabled = true;
            this.ListBox_Kanan.ItemHeight = 15;
            this.ListBox_Kanan.Location = new System.Drawing.Point(279, 165);
            this.ListBox_Kanan.Name = "ListBox_Kanan";
            this.ListBox_Kanan.Size = new System.Drawing.Size(131, 274);
            this.ListBox_Kanan.TabIndex = 8;
            this.ListBox_Kanan.SelectedIndexChanged += new System.EventHandler(this.ListBox_Kanan_SelectedIndexChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(193, 202);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(54, 23);
            this.Button1.TabIndex = 9;
            this.Button1.Text = ">>";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(193, 244);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(54, 23);
            this.Button2.TabIndex = 10;
            this.Button2.Text = ">";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(193, 284);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(54, 23);
            this.Button3.TabIndex = 11;
            this.Button3.Text = "<";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(193, 324);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(54, 23);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "<<";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(193, 367);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(54, 23);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "X";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 477);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ListBox_Kanan);
            this.Controls.Add(this.ListBox_Kiri);
            this.Controls.Add(this.CheckBox_Block);
            this.Controls.Add(this.ComboBox_Mode);
            this.Controls.Add(this.Button_Proses);
            this.Controls.Add(this.Label_Mode);
            this.Controls.Add(this.TextBox_Data);
            this.Controls.Add(this.Label_Data);
            this.Name = "Form1";
            this.Text = "Form Tugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.TextBox TextBox_Data;
        private System.Windows.Forms.Label Label_Mode;
        private System.Windows.Forms.Button Button_Proses;
        private System.Windows.Forms.ComboBox ComboBox_Mode;
        private System.Windows.Forms.CheckBox CheckBox_Block;
        private System.Windows.Forms.ListBox ListBox_Kiri;
        private System.Windows.Forms.ListBox ListBox_Kanan;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
    }
}
