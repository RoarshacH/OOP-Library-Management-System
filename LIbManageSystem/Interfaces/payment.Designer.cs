namespace LIbManageSystem.Interfaces
{
    partial class payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mem = new System.Windows.Forms.TextBox();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.txt_lib = new System.Windows.Forms.TextBox();
            this.txt_detals = new System.Windows.Forms.RichTextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cur_date = new System.Windows.Forms.DateTimePicker();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 49);
            this.panel1.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::LIbManageSystem.Properties.Resources.home_icon_white_338293;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(21, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(44, 39);
            this.btn_home.TabIndex = 2;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Accept Payment";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::LIbManageSystem.Properties.Resources.multiply;
            this.btn_close.Location = new System.Drawing.Point(850, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 49);
            this.btn_close.TabIndex = 0;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(552, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 43);
            this.label6.TabIndex = 9;
            this.label6.Text = "Librarian  ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 43);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type Of Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 43);
            this.label9.TabIndex = 12;
            this.label9.Text = "Time";
            // 
            // txt_mem
            // 
            this.txt_mem.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem.Location = new System.Drawing.Point(207, 106);
            this.txt_mem.MaxLength = 10;
            this.txt_mem.Name = "txt_mem";
            this.txt_mem.Size = new System.Drawing.Size(303, 32);
            this.txt_mem.TabIndex = 14;
            this.txt_mem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_mem_KeyPress);
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(207, 244);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(303, 32);
            this.txt_payment.TabIndex = 16;
            this.txt_payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_payment_KeyPress);
            // 
            // txt_lib
            // 
            this.txt_lib.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lib.Location = new System.Drawing.Point(207, 153);
            this.txt_lib.MaxLength = 10;
            this.txt_lib.Name = "txt_lib";
            this.txt_lib.Size = new System.Drawing.Size(303, 32);
            this.txt_lib.TabIndex = 20;
            this.txt_lib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_lib_KeyPress);
            // 
            // txt_detals
            // 
            this.txt_detals.Location = new System.Drawing.Point(550, 149);
            this.txt_detals.MaxLength = 40;
            this.txt_detals.Name = "txt_detals";
            this.txt_detals.Size = new System.Drawing.Size(352, 163);
            this.txt_detals.TabIndex = 21;
            this.txt_detals.Text = "";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Fine Payment",
            "Renewal",
            "Damaged Books",
            "Other"});
            this.cmb_type.Location = new System.Drawing.Point(207, 198);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(303, 35);
            this.cmb_type.TabIndex = 22;
            // 
            // cur_date
            // 
            this.cur_date.CustomFormat = "yyyy-MM-dd";
            this.cur_date.Enabled = false;
            this.cur_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cur_date.Location = new System.Drawing.Point(207, 288);
            this.cur_date.Name = "cur_date";
            this.cur_date.Size = new System.Drawing.Size(303, 22);
            this.cur_date.TabIndex = 23;
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_payment.Location = new System.Drawing.Point(704, 353);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(198, 44);
            this.btn_payment.TabIndex = 24;
            this.btn_payment.Text = "Accept Payment";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.Btn_payment_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(473, 353);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(188, 44);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(920, 437);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.cur_date);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_detals);
            this.Controls.Add(this.txt_lib);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.txt_mem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payment";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mem;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.TextBox txt_lib;
        private System.Windows.Forms.RichTextBox txt_detals;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DateTimePicker cur_date;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_cancel;
    }
}