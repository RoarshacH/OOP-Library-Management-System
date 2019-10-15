namespace LIbManageSystem.Interfaces
{
    partial class book_functions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_genre = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_fineDay = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_auther = new System.Windows.Forms.TextBox();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_editbk = new System.Windows.Forms.GroupBox();
            this.cmb_status_change = new System.Windows.Forms.ComboBox();
            this.cmb_se = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_location_change = new System.Windows.Forms.TextBox();
            this.txt_fineDay_change = new System.Windows.Forms.TextBox();
            this.txt_price_change = new System.Windows.Forms.TextBox();
            this.txt_auther_change = new System.Windows.Forms.TextBox();
            this.txt_bookname_change = new System.Windows.Forms.TextBox();
            this.txt_search_book = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.btn_reset_edit = new System.Windows.Forms.Button();
            this.btn_confirm_edit = new System.Windows.Forms.Button();
            this.btn_search_book = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_editbk.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1060, 55);
            this.panel1.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::LIbManageSystem.Properties.Resources.home_icon_white_338293;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(18, 9);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(46, 39);
            this.btn_home.TabIndex = 2;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(403, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Functions";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::LIbManageSystem.Properties.Resources.multiply;
            this.btn_close.Location = new System.Drawing.Point(990, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 55);
            this.btn_close.TabIndex = 0;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_genre);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_addBook);
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.txt_fineDay);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_auther);
            this.groupBox1.Controls.Add(this.txt_bookName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 517);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txt_genre
            // 
            this.txt_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_genre.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genre.FormattingEnabled = true;
            this.txt_genre.Items.AddRange(new object[] {
            "Biography",
            "Crime",
            "Drama",
            "Educational",
            "Fantasy",
            "Graphic Novel",
            "Health",
            "History",
            "Light Novel",
            "Modern Fantasy",
            "Poetry",
            "Science",
            "Science Friction",
            "Short Story",
            "Suspence",
            "Technology",
            "Thriller",
            "Travel",
            "Young Adult"});
            this.txt_genre.Location = new System.Drawing.Point(190, 214);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(246, 30);
            this.txt_genre.Sorted = true;
            this.txt_genre.TabIndex = 21;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Available",
            "Borrowed"});
            this.cmb_status.Location = new System.Drawing.Point(190, 381);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(246, 28);
            this.cmb_status.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(41, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 40);
            this.label18.TabIndex = 17;
            this.label18.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(41, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(181, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 53);
            this.label16.TabIndex = 15;
            this.label16.Text = "Add Book";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reset.Location = new System.Drawing.Point(275, 449);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(142, 42);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBook.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addBook.Location = new System.Drawing.Point(58, 449);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(143, 42);
            this.btn_addBook.TabIndex = 13;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = false;
            this.btn_addBook.Click += new System.EventHandler(this.Btn_addBook_Click);
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(190, 336);
            this.txt_location.MaxLength = 50;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(246, 30);
            this.txt_location.TabIndex = 12;
            // 
            // txt_fineDay
            // 
            this.txt_fineDay.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fineDay.Location = new System.Drawing.Point(190, 295);
            this.txt_fineDay.MaxLength = 3;
            this.txt_fineDay.Name = "txt_fineDay";
            this.txt_fineDay.Size = new System.Drawing.Size(246, 30);
            this.txt_fineDay.TabIndex = 11;
            this.txt_fineDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_fineDay_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(190, 254);
            this.txt_price.MaxLength = 10;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(246, 30);
            this.txt_price.TabIndex = 10;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_price_KeyPress);
            // 
            // txt_auther
            // 
            this.txt_auther.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther.Location = new System.Drawing.Point(190, 172);
            this.txt_auther.MaxLength = 100;
            this.txt_auther.Name = "txt_auther";
            this.txt_auther.Size = new System.Drawing.Size(246, 30);
            this.txt_auther.TabIndex = 9;
            // 
            // txt_bookName
            // 
            this.txt_bookName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookName.Location = new System.Drawing.Point(190, 131);
            this.txt_bookName.MaxLength = 100;
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(246, 30);
            this.txt_bookName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(41, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(41, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fine Per day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(41, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Auther Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // groupBox_editbk
            // 
            this.groupBox_editbk.Controls.Add(this.cmb_status_change);
            this.groupBox_editbk.Controls.Add(this.cmb_se);
            this.groupBox_editbk.Controls.Add(this.label9);
            this.groupBox_editbk.Controls.Add(this.label10);
            this.groupBox_editbk.Controls.Add(this.txt_location_change);
            this.groupBox_editbk.Controls.Add(this.txt_fineDay_change);
            this.groupBox_editbk.Controls.Add(this.txt_price_change);
            this.groupBox_editbk.Controls.Add(this.txt_auther_change);
            this.groupBox_editbk.Controls.Add(this.txt_bookname_change);
            this.groupBox_editbk.Controls.Add(this.txt_search_book);
            this.groupBox_editbk.Controls.Add(this.label11);
            this.groupBox_editbk.Controls.Add(this.label12);
            this.groupBox_editbk.Controls.Add(this.label13);
            this.groupBox_editbk.Controls.Add(this.label14);
            this.groupBox_editbk.Controls.Add(this.label15);
            this.groupBox_editbk.Controls.Add(this.label19);
            this.groupBox_editbk.Controls.Add(this.label17);
            this.groupBox_editbk.Controls.Add(this.btn_delete_book);
            this.groupBox_editbk.Controls.Add(this.btn_reset_edit);
            this.groupBox_editbk.Controls.Add(this.btn_confirm_edit);
            this.groupBox_editbk.Controls.Add(this.btn_search_book);
            this.groupBox_editbk.Location = new System.Drawing.Point(507, 61);
            this.groupBox_editbk.Name = "groupBox_editbk";
            this.groupBox_editbk.Size = new System.Drawing.Size(538, 517);
            this.groupBox_editbk.TabIndex = 6;
            this.groupBox_editbk.TabStop = false;
            // 
            // cmb_status_change
            // 
            this.cmb_status_change.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status_change.FormattingEnabled = true;
            this.cmb_status_change.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmb_status_change.Location = new System.Drawing.Point(187, 388);
            this.cmb_status_change.Name = "cmb_status_change";
            this.cmb_status_change.Size = new System.Drawing.Size(298, 28);
            this.cmb_status_change.TabIndex = 22;
            // 
            // cmb_se
            // 
            this.cmb_se.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_se.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_se.FormattingEnabled = true;
            this.cmb_se.Items.AddRange(new object[] {
            "Biography",
            "Crime",
            "Drama",
            "Educational",
            "Fantasy",
            "Graphic Novel",
            "Health",
            "History",
            "Light Novel",
            "Modern Fantasy",
            "Poetry",
            "Science",
            "Science Friction",
            "Short Story",
            "Suspence",
            "Technology",
            "Thriller",
            "Travel",
            "Young Adult"});
            this.cmb_se.Location = new System.Drawing.Point(187, 223);
            this.cmb_se.Name = "cmb_se";
            this.cmb_se.Size = new System.Drawing.Size(298, 30);
            this.cmb_se.Sorted = true;
            this.cmb_se.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(38, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 40);
            this.label9.TabIndex = 43;
            this.label9.Text = "Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(38, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 40);
            this.label10.TabIndex = 42;
            this.label10.Text = "Status";
            // 
            // txt_location_change
            // 
            this.txt_location_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location_change.Location = new System.Drawing.Point(187, 345);
            this.txt_location_change.MaxLength = 50;
            this.txt_location_change.Name = "txt_location_change";
            this.txt_location_change.Size = new System.Drawing.Size(298, 30);
            this.txt_location_change.TabIndex = 41;
            // 
            // txt_fineDay_change
            // 
            this.txt_fineDay_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fineDay_change.Location = new System.Drawing.Point(187, 304);
            this.txt_fineDay_change.MaxLength = 5;
            this.txt_fineDay_change.Name = "txt_fineDay_change";
            this.txt_fineDay_change.Size = new System.Drawing.Size(298, 30);
            this.txt_fineDay_change.TabIndex = 40;
            // 
            // txt_price_change
            // 
            this.txt_price_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price_change.Location = new System.Drawing.Point(187, 263);
            this.txt_price_change.MaxLength = 10;
            this.txt_price_change.Name = "txt_price_change";
            this.txt_price_change.Size = new System.Drawing.Size(298, 30);
            this.txt_price_change.TabIndex = 39;
            // 
            // txt_auther_change
            // 
            this.txt_auther_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther_change.Location = new System.Drawing.Point(187, 181);
            this.txt_auther_change.MaxLength = 100;
            this.txt_auther_change.Name = "txt_auther_change";
            this.txt_auther_change.Size = new System.Drawing.Size(298, 30);
            this.txt_auther_change.TabIndex = 38;
            // 
            // txt_bookname_change
            // 
            this.txt_bookname_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookname_change.Location = new System.Drawing.Point(187, 140);
            this.txt_bookname_change.MaxLength = 100;
            this.txt_bookname_change.Name = "txt_bookname_change";
            this.txt_bookname_change.Size = new System.Drawing.Size(298, 30);
            this.txt_bookname_change.TabIndex = 37;
            // 
            // txt_search_book
            // 
            this.txt_search_book.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_book.Location = new System.Drawing.Point(187, 94);
            this.txt_search_book.Name = "txt_search_book";
            this.txt_search_book.Size = new System.Drawing.Size(150, 30);
            this.txt_search_book.TabIndex = 36;
            this.txt_search_book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_search_book_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(38, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 40);
            this.label11.TabIndex = 35;
            this.label11.Text = "Location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(38, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 40);
            this.label12.TabIndex = 34;
            this.label12.Text = "Fine Per day";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(38, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 40);
            this.label13.TabIndex = 33;
            this.label13.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(38, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 40);
            this.label14.TabIndex = 32;
            this.label14.Text = "Auther Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(38, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 40);
            this.label15.TabIndex = 31;
            this.label15.Text = "Book Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(40, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 40);
            this.label19.TabIndex = 30;
            this.label19.Text = "Book ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(205, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 53);
            this.label17.TabIndex = 16;
            this.label17.Text = "Edit Book";
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_delete_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_book.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_book.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_delete_book.Location = new System.Drawing.Point(365, 449);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(138, 42);
            this.btn_delete_book.TabIndex = 29;
            this.btn_delete_book.Text = "Delete Record";
            this.btn_delete_book.UseVisualStyleBackColor = false;
            this.btn_delete_book.Click += new System.EventHandler(this.Btn_delete_book_Click);
            // 
            // btn_reset_edit
            // 
            this.btn_reset_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_reset_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset_edit.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_edit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reset_edit.Location = new System.Drawing.Point(199, 449);
            this.btn_reset_edit.Name = "btn_reset_edit";
            this.btn_reset_edit.Size = new System.Drawing.Size(140, 42);
            this.btn_reset_edit.TabIndex = 28;
            this.btn_reset_edit.Text = "Reset";
            this.btn_reset_edit.UseVisualStyleBackColor = false;
            this.btn_reset_edit.Click += new System.EventHandler(this.Btn_reset_edit_Click);
            // 
            // btn_confirm_edit
            // 
            this.btn_confirm_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_confirm_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm_edit.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_edit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_confirm_edit.Location = new System.Drawing.Point(26, 449);
            this.btn_confirm_edit.Name = "btn_confirm_edit";
            this.btn_confirm_edit.Size = new System.Drawing.Size(143, 42);
            this.btn_confirm_edit.TabIndex = 27;
            this.btn_confirm_edit.Text = "Confirm Edit";
            this.btn_confirm_edit.UseVisualStyleBackColor = false;
            this.btn_confirm_edit.Click += new System.EventHandler(this.Btn_confirm_edit_Click);
            // 
            // btn_search_book
            // 
            this.btn_search_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_search_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_book.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_search_book.Location = new System.Drawing.Point(384, 93);
            this.btn_search_book.Name = "btn_search_book";
            this.btn_search_book.Size = new System.Drawing.Size(101, 30);
            this.btn_search_book.TabIndex = 26;
            this.btn_search_book.Text = "Search";
            this.btn_search_book.UseVisualStyleBackColor = false;
            this.btn_search_book.Click += new System.EventHandler(this.Btn_search_book_Click);
            // 
            // book_functions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1060, 595);
            this.Controls.Add(this.groupBox_editbk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "book_functions";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "book_functions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_editbk.ResumeLayout(false);
            this.groupBox_editbk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_fineDay;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_auther;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_editbk;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_delete_book;
        private System.Windows.Forms.Button btn_reset_edit;
        private System.Windows.Forms.Button btn_confirm_edit;
        private System.Windows.Forms.Button btn_search_book;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_location_change;
        private System.Windows.Forms.TextBox txt_fineDay_change;
        private System.Windows.Forms.TextBox txt_price_change;
        private System.Windows.Forms.TextBox txt_auther_change;
        private System.Windows.Forms.TextBox txt_bookname_change;
        private System.Windows.Forms.TextBox txt_search_book;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox txt_genre;
        private System.Windows.Forms.ComboBox cmb_status_change;
        private System.Windows.Forms.ComboBox cmb_se;
    }
}