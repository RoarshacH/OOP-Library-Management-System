namespace LIbManageSystem.Interfaces
{
    partial class dashbord_lib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashbord_lib));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_members = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.txt_memid = new System.Windows.Forms.TextBox();
            this.btn_issueBook = new System.Windows.Forms.Button();
            this.btn_search_mem = new System.Windows.Forms.Button();
            this.AcceptBook = new System.Windows.Forms.Panel();
            this.rtn_dateDB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_acceptBook = new System.Windows.Forms.Button();
            this.cmb_book = new System.Windows.Forms.ComboBox();
            this.fine = new System.Windows.Forms.TextBox();
            this.datertn = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mem_se = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtndate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.today_datetime = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AcceptBook.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1036, 51);
            this.panel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::LIbManageSystem.Properties.Resources.home_icon_white_338293;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(12, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(46, 39);
            this.btn_home.TabIndex = 3;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(362, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Librarian Dashboard";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::LIbManageSystem.Properties.Resources.multiply;
            this.btn_close.Location = new System.Drawing.Point(966, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 51);
            this.btn_close.TabIndex = 0;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_members);
            this.panel2.Controls.Add(this.btn_payment);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_books);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 533);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 199);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_members
            // 
            this.btn_members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_members.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_members.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_members.Location = new System.Drawing.Point(51, 333);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(168, 35);
            this.btn_members.TabIndex = 3;
            this.btn_members.Text = "Members";
            this.btn_members.UseVisualStyleBackColor = false;
            this.btn_members.Click += new System.EventHandler(this.Btn_members_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_payment.Location = new System.Drawing.Point(51, 392);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(168, 35);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.Btn_payment_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.Location = new System.Drawing.Point(51, 451);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(168, 35);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // btn_books
            // 
            this.btn_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_books.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_books.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_books.Location = new System.Drawing.Point(51, 274);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(168, 35);
            this.btn_books.TabIndex = 0;
            this.btn_books.Text = "Books";
            this.btn_books.UseVisualStyleBackColor = false;
            this.btn_books.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member ID";
            // 
            // txt_bookid
            // 
            this.txt_bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookid.Location = new System.Drawing.Point(203, 76);
            this.txt_bookid.MaxLength = 20;
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(330, 30);
            this.txt_bookid.TabIndex = 5;
            // 
            // txt_memid
            // 
            this.txt_memid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memid.Location = new System.Drawing.Point(203, 124);
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.Size = new System.Drawing.Size(330, 30);
            this.txt_memid.TabIndex = 6;
            // 
            // btn_issueBook
            // 
            this.btn_issueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_issueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issueBook.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issueBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_issueBook.Location = new System.Drawing.Point(585, 155);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(129, 42);
            this.btn_issueBook.TabIndex = 7;
            this.btn_issueBook.Text = "Issue Book";
            this.btn_issueBook.UseVisualStyleBackColor = false;
            this.btn_issueBook.Click += new System.EventHandler(this.Btn_issueBook_Click);
            // 
            // btn_search_mem
            // 
            this.btn_search_mem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_search_mem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_mem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search_mem.Location = new System.Drawing.Point(585, 72);
            this.btn_search_mem.Name = "btn_search_mem";
            this.btn_search_mem.Size = new System.Drawing.Size(135, 30);
            this.btn_search_mem.TabIndex = 8;
            this.btn_search_mem.Text = "Search";
            this.btn_search_mem.UseVisualStyleBackColor = false;
            this.btn_search_mem.Click += new System.EventHandler(this.Btn_search_mem_Click);
            // 
            // AcceptBook
            // 
            this.AcceptBook.AccessibleName = "";
            this.AcceptBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.AcceptBook.Controls.Add(this.rtn_dateDB);
            this.AcceptBook.Controls.Add(this.label14);
            this.AcceptBook.Controls.Add(this.label13);
            this.AcceptBook.Controls.Add(this.btn_acceptBook);
            this.AcceptBook.Controls.Add(this.cmb_book);
            this.AcceptBook.Controls.Add(this.fine);
            this.AcceptBook.Controls.Add(this.datertn);
            this.AcceptBook.Controls.Add(this.label11);
            this.AcceptBook.Controls.Add(this.label10);
            this.AcceptBook.Controls.Add(this.label9);
            this.AcceptBook.Controls.Add(this.txt_mem_se);
            this.AcceptBook.Controls.Add(this.label8);
            this.AcceptBook.Controls.Add(this.btn_search_mem);
            this.AcceptBook.Location = new System.Drawing.Point(290, 284);
            this.AcceptBook.Name = "AcceptBook";
            this.AcceptBook.Size = new System.Drawing.Size(735, 290);
            this.AcceptBook.TabIndex = 9;
            // 
            // rtn_dateDB
            // 
            this.rtn_dateDB.Enabled = false;
            this.rtn_dateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtn_dateDB.Location = new System.Drawing.Point(194, 176);
            this.rtn_dateDB.Name = "rtn_dateDB";
            this.rtn_dateDB.Size = new System.Drawing.Size(115, 24);
            this.rtn_dateDB.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(316, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "Current Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(7, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 30);
            this.label13.TabIndex = 19;
            this.label13.Text = "Return Book Section";
            // 
            // btn_acceptBook
            // 
            this.btn_acceptBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_acceptBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceptBook.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceptBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_acceptBook.Location = new System.Drawing.Point(585, 218);
            this.btn_acceptBook.Name = "btn_acceptBook";
            this.btn_acceptBook.Size = new System.Drawing.Size(135, 45);
            this.btn_acceptBook.TabIndex = 18;
            this.btn_acceptBook.Text = "Accept Book";
            this.btn_acceptBook.UseVisualStyleBackColor = false;
            this.btn_acceptBook.Click += new System.EventHandler(this.Btn_acceptBook_Click);
            // 
            // cmb_book
            // 
            this.cmb_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_book.FormattingEnabled = true;
            this.cmb_book.Location = new System.Drawing.Point(195, 122);
            this.cmb_book.Name = "cmb_book";
            this.cmb_book.Size = new System.Drawing.Size(338, 33);
            this.cmb_book.TabIndex = 17;
            this.cmb_book.DropDownClosed += new System.EventHandler(this.Cmb_book_DropDownClosed);
            // 
            // fine
            // 
            this.fine.Enabled = false;
            this.fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fine.Location = new System.Drawing.Point(195, 226);
            this.fine.Name = "fine";
            this.fine.Size = new System.Drawing.Size(338, 30);
            this.fine.TabIndex = 16;
            // 
            // datertn
            // 
            this.datertn.CustomFormat = "yyyy-MM-dd";
            this.datertn.Enabled = false;
            this.datertn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datertn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datertn.Location = new System.Drawing.Point(426, 174);
            this.datertn.Name = "datertn";
            this.datertn.Size = new System.Drawing.Size(107, 24);
            this.datertn.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(44, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Fine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(44, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Return Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(44, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Book Name";
            // 
            // txt_mem_se
            // 
            this.txt_mem_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem_se.Location = new System.Drawing.Point(195, 73);
            this.txt_mem_se.Name = "txt_mem_se";
            this.txt_mem_se.Size = new System.Drawing.Size(338, 30);
            this.txt_mem_se.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(44, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Member ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.rtndate);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.today_datetime);
            this.panel3.Controls.Add(this.btn_issueBook);
            this.panel3.Controls.Add(this.txt_memid);
            this.panel3.Controls.Add(this.txt_bookid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(290, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 219);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // rtndate
            // 
            this.rtndate.CustomFormat = "yyyy-MM-dd";
            this.rtndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rtndate.Location = new System.Drawing.Point(421, 173);
            this.rtndate.Name = "rtndate";
            this.rtndate.Size = new System.Drawing.Size(112, 24);
            this.rtndate.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(8, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "Issue Book Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(308, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(65, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Issue Date";
            // 
            // today_datetime
            // 
            this.today_datetime.CustomFormat = "yyyy-MM-dd";
            this.today_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.today_datetime.Location = new System.Drawing.Point(203, 173);
            this.today_datetime.Name = "today_datetime";
            this.today_datetime.Size = new System.Drawing.Size(107, 24);
            this.today_datetime.TabIndex = 9;
            // 
            // dashbord_lib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1036, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AcceptBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashbord_lib";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashbord_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AcceptBook.ResumeLayout(false);
            this.AcceptBook.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.TextBox txt_memid;
        private System.Windows.Forms.Button btn_issueBook;
        private System.Windows.Forms.Button btn_search_mem;
        private System.Windows.Forms.Panel AcceptBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mem_se;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker today_datetime;
        private System.Windows.Forms.Button btn_acceptBook;
        private System.Windows.Forms.ComboBox cmb_book;
        private System.Windows.Forms.TextBox fine;
        private System.Windows.Forms.DateTimePicker datertn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker rtndate;
        private System.Windows.Forms.Button btn_members;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox rtn_dateDB;
        private System.Windows.Forms.Button btn_home;
    }
}