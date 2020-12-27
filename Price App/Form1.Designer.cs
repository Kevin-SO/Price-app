namespace Price_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.qty = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.qty_box = new System.Windows.Forms.TextBox();
            this.width_box = new System.Windows.Forms.TextBox();
            this.height_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.kind = new System.Windows.Forms.ComboBox();
            this.kind_label = new System.Windows.Forms.Label();
            this.mainl = new System.Windows.Forms.Label();
            this.room_lbox = new System.Windows.Forms.ListBox();
            this.width_lbox = new System.Windows.Forms.ListBox();
            this.height_lbox = new System.Windows.Forms.ListBox();
            this.room_box = new System.Windows.Forms.TextBox();
            this.room_label = new System.Windows.Forms.Label();
            this.price_lbox = new System.Windows.Forms.ListBox();
            this.roombox_l = new System.Windows.Forms.Label();
            this.widthbox_l = new System.Windows.Forms.Label();
            this.heightbox_l = new System.Windows.Forms.Label();
            this.Pricebox_l = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.main_box = new System.Windows.Forms.TextBox();
            this.d_box = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.grand_t = new System.Windows.Forms.Label();
            this.total0 = new System.Windows.Forms.Label();
            this.tax0 = new System.Windows.Forms.Label();
            this.depositl = new System.Windows.Forms.Label();
            this.balancel = new System.Windows.Forms.Label();
            this.line_l = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.tax1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pile_cbox = new System.Windows.Forms.ComboBox();
            this.ext_button = new System.Windows.Forms.Button();
            this.extra_box = new System.Windows.Forms.TextBox();
            this.extra_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.no_lbox = new System.Windows.Forms.ListBox();
            this.rem_bo = new System.Windows.Forms.TextBox();
            this.rem_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(68, 141);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(85, 28);
            this.qty.TabIndex = 1;
            this.qty.Text = "Quantity";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(85, 169);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(62, 28);
            this.width.TabIndex = 2;
            this.width.Text = "Width";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(83, 195);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(65, 28);
            this.height.TabIndex = 3;
            this.height.Text = "Height";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(85, 117);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 28);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // qty_box
            // 
            this.qty_box.Location = new System.Drawing.Point(154, 147);
            this.qty_box.Name = "qty_box";
            this.qty_box.Size = new System.Drawing.Size(100, 20);
            this.qty_box.TabIndex = 5;
            // 
            // width_box
            // 
            this.width_box.Location = new System.Drawing.Point(154, 173);
            this.width_box.Name = "width_box";
            this.width_box.Size = new System.Drawing.Size(100, 20);
            this.width_box.TabIndex = 6;
            this.width_box.TextChanged += new System.EventHandler(this.width_box_TextChanged);
            // 
            // height_box
            // 
            this.height_box.Location = new System.Drawing.Point(154, 199);
            this.height_box.Name = "height_box";
            this.height_box.Size = new System.Drawing.Size(100, 20);
            this.height_box.TabIndex = 7;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(154, 121);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(100, 20);
            this.price_box.TabIndex = 8;
            // 
            // kind
            // 
            this.kind.FormattingEnabled = true;
            this.kind.Items.AddRange(new object[] {
            "Fon",
            "Stor-Zebra",
            "Curtain"});
            this.kind.Location = new System.Drawing.Point(154, 68);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(100, 21);
            this.kind.TabIndex = 9;
            this.kind.SelectedIndexChanged += new System.EventHandler(this.kind_SelectedIndexChanged);
            // 
            // kind_label
            // 
            this.kind_label.AutoSize = true;
            this.kind_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kind_label.Location = new System.Drawing.Point(88, 64);
            this.kind_label.Name = "kind_label";
            this.kind_label.Size = new System.Drawing.Size(51, 28);
            this.kind_label.TabIndex = 10;
            this.kind_label.Text = "Kind";
            // 
            // mainl
            // 
            this.mainl.AutoSize = true;
            this.mainl.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainl.Location = new System.Drawing.Point(41, 16);
            this.mainl.Name = "mainl";
            this.mainl.Size = new System.Drawing.Size(43, 23);
            this.mainl.TabIndex = 12;
            this.mainl.Text = "Main";
            // 
            // room_lbox
            // 
            this.room_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_lbox.FormattingEnabled = true;
            this.room_lbox.ItemHeight = 18;
            this.room_lbox.Location = new System.Drawing.Point(49, 458);
            this.room_lbox.Name = "room_lbox";
            this.room_lbox.Size = new System.Drawing.Size(131, 148);
            this.room_lbox.TabIndex = 13;
            this.room_lbox.SelectedIndexChanged += new System.EventHandler(this.room_lbox_SelectedIndexChanged);
            // 
            // width_lbox
            // 
            this.width_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_lbox.FormattingEnabled = true;
            this.width_lbox.ItemHeight = 18;
            this.width_lbox.Location = new System.Drawing.Point(186, 458);
            this.width_lbox.Name = "width_lbox";
            this.width_lbox.Size = new System.Drawing.Size(140, 148);
            this.width_lbox.TabIndex = 14;
            // 
            // height_lbox
            // 
            this.height_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_lbox.FormattingEnabled = true;
            this.height_lbox.ItemHeight = 18;
            this.height_lbox.Location = new System.Drawing.Point(332, 458);
            this.height_lbox.Name = "height_lbox";
            this.height_lbox.Size = new System.Drawing.Size(151, 148);
            this.height_lbox.TabIndex = 15;
            // 
            // room_box
            // 
            this.room_box.Location = new System.Drawing.Point(154, 95);
            this.room_box.Name = "room_box";
            this.room_box.Size = new System.Drawing.Size(100, 20);
            this.room_box.TabIndex = 17;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_label.Location = new System.Drawing.Point(85, 91);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(58, 28);
            this.room_label.TabIndex = 18;
            this.room_label.Text = "Room";
            // 
            // price_lbox
            // 
            this.price_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbox.FormattingEnabled = true;
            this.price_lbox.ItemHeight = 18;
            this.price_lbox.Location = new System.Drawing.Point(489, 459);
            this.price_lbox.Name = "price_lbox";
            this.price_lbox.Size = new System.Drawing.Size(151, 148);
            this.price_lbox.TabIndex = 19;
            // 
            // roombox_l
            // 
            this.roombox_l.AutoSize = true;
            this.roombox_l.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roombox_l.Location = new System.Drawing.Point(81, 432);
            this.roombox_l.Name = "roombox_l";
            this.roombox_l.Size = new System.Drawing.Size(58, 23);
            this.roombox_l.TabIndex = 20;
            this.roombox_l.Text = "Room";
            // 
            // widthbox_l
            // 
            this.widthbox_l.AutoSize = true;
            this.widthbox_l.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthbox_l.Location = new System.Drawing.Point(225, 432);
            this.widthbox_l.Name = "widthbox_l";
            this.widthbox_l.Size = new System.Drawing.Size(62, 23);
            this.widthbox_l.TabIndex = 21;
            this.widthbox_l.Text = "Width";
            // 
            // heightbox_l
            // 
            this.heightbox_l.AutoSize = true;
            this.heightbox_l.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightbox_l.Location = new System.Drawing.Point(367, 432);
            this.heightbox_l.Name = "heightbox_l";
            this.heightbox_l.Size = new System.Drawing.Size(66, 23);
            this.heightbox_l.TabIndex = 22;
            this.heightbox_l.Text = "Height";
            // 
            // Pricebox_l
            // 
            this.Pricebox_l.AutoSize = true;
            this.Pricebox_l.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricebox_l.Location = new System.Drawing.Point(545, 433);
            this.Pricebox_l.Name = "Pricebox_l";
            this.Pricebox_l.Size = new System.Drawing.Size(52, 23);
            this.Pricebox_l.TabIndex = 23;
            this.Pricebox_l.Text = "Price";
            this.Pricebox_l.Click += new System.EventHandler(this.label4_Click);
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(25, 45);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(67, 23);
            this.Discount.TabIndex = 27;
            this.Discount.Text = "Discount";
            this.Discount.Click += new System.EventHandler(this.Discount_Click);
            // 
            // main_box
            // 
            this.main_box.Location = new System.Drawing.Point(119, 19);
            this.main_box.Name = "main_box";
            this.main_box.Size = new System.Drawing.Size(100, 20);
            this.main_box.TabIndex = 28;
            // 
            // d_box
            // 
            this.d_box.Location = new System.Drawing.Point(119, 45);
            this.d_box.Name = "d_box";
            this.d_box.Size = new System.Drawing.Size(100, 20);
            this.d_box.TabIndex = 30;
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(119, 78);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 29);
            this.count.TabIndex = 32;
            this.count.Text = "Count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // grand_t
            // 
            this.grand_t.AutoSize = true;
            this.grand_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grand_t.Location = new System.Drawing.Point(116, 130);
            this.grand_t.Name = "grand_t";
            this.grand_t.Size = new System.Drawing.Size(52, 17);
            this.grand_t.TabIndex = 33;
            this.grand_t.Text = "label2";
            // 
            // total0
            // 
            this.total0.AutoSize = true;
            this.total0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total0.Location = new System.Drawing.Point(65, 25);
            this.total0.Name = "total0";
            this.total0.Size = new System.Drawing.Size(40, 17);
            this.total0.TabIndex = 34;
            this.total0.Text = "Total";
            // 
            // tax0
            // 
            this.tax0.AutoSize = true;
            this.tax0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax0.Location = new System.Drawing.Point(4, 54);
            this.tax0.Name = "tax0";
            this.tax0.Size = new System.Drawing.Size(101, 17);
            this.tax0.TabIndex = 35;
            this.tax0.Text = "Tax(HST) 13%";
            this.tax0.Click += new System.EventHandler(this.label3_Click);
            // 
            // depositl
            // 
            this.depositl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depositl.AutoSize = true;
            this.depositl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositl.Location = new System.Drawing.Point(6, 167);
            this.depositl.Name = "depositl";
            this.depositl.Size = new System.Drawing.Size(46, 17);
            this.depositl.TabIndex = 36;
            this.depositl.Text = "label4";
            this.depositl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.depositl.Click += new System.EventHandler(this.depositl_Click);
            // 
            // balancel
            // 
            this.balancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balancel.AutoSize = true;
            this.balancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancel.Location = new System.Drawing.Point(6, 211);
            this.balancel.Name = "balancel";
            this.balancel.Size = new System.Drawing.Size(46, 17);
            this.balancel.TabIndex = 37;
            this.balancel.Text = "label5";
            this.balancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // line_l
            // 
            this.line_l.AutoSize = true;
            this.line_l.Location = new System.Drawing.Point(65, 104);
            this.line_l.Name = "line_l";
            this.line_l.Size = new System.Drawing.Size(133, 13);
            this.line_l.TabIndex = 38;
            this.line_l.Text = "_____________________";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total1.Location = new System.Drawing.Point(116, 25);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(46, 17);
            this.total1.TabIndex = 39;
            this.total1.Text = "label6";
            this.total1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tax1
            // 
            this.tax1.AutoSize = true;
            this.tax1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax1.Location = new System.Drawing.Point(116, 54);
            this.tax1.Name = "tax1";
            this.tax1.Size = new System.Drawing.Size(46, 17);
            this.tax1.TabIndex = 40;
            this.tax1.Text = "label7";
            this.tax1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainl);
            this.groupBox1.Controls.Add(this.Discount);
            this.groupBox1.Controls.Add(this.main_box);
            this.groupBox1.Controls.Add(this.d_box);
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Location = new System.Drawing.Point(442, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 120);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total0);
            this.groupBox2.Controls.Add(this.grand_t);
            this.groupBox2.Controls.Add(this.tax0);
            this.groupBox2.Controls.Add(this.tax1);
            this.groupBox2.Controls.Add(this.depositl);
            this.groupBox2.Controls.Add(this.total1);
            this.groupBox2.Controls.Add(this.balancel);
            this.groupBox2.Controls.Add(this.line_l);
            this.groupBox2.Location = new System.Drawing.Point(442, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 250);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // pile_cbox
            // 
            this.pile_cbox.FormattingEnabled = true;
            this.pile_cbox.Items.AddRange(new object[] {
            "3",
            "2.5",
            "2",
            "1"});
            this.pile_cbox.Location = new System.Drawing.Point(260, 68);
            this.pile_cbox.Name = "pile_cbox";
            this.pile_cbox.Size = new System.Drawing.Size(100, 21);
            this.pile_cbox.TabIndex = 43;
            this.pile_cbox.Visible = false;
            // 
            // ext_button
            // 
            this.ext_button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_button.Location = new System.Drawing.Point(14, 65);
            this.ext_button.Name = "ext_button";
            this.ext_button.Size = new System.Drawing.Size(72, 28);
            this.ext_button.TabIndex = 44;
            this.ext_button.Text = "Add !";
            this.ext_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ext_button.UseVisualStyleBackColor = true;
            this.ext_button.Click += new System.EventHandler(this.ext_button_Click);
            // 
            // extra_box
            // 
            this.extra_box.Location = new System.Drawing.Point(14, 34);
            this.extra_box.Name = "extra_box";
            this.extra_box.Size = new System.Drawing.Size(72, 20);
            this.extra_box.TabIndex = 45;
            // 
            // extra_label
            // 
            this.extra_label.AutoSize = true;
            this.extra_label.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra_label.Location = new System.Drawing.Point(28, 8);
            this.extra_label.Name = "extra_label";
            this.extra_label.Size = new System.Drawing.Size(47, 23);
            this.extra_label.TabIndex = 46;
            this.extra_label.Text = "Extra";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.extra_box);
            this.groupBox3.Controls.Add(this.ext_button);
            this.groupBox3.Controls.Add(this.extra_label);
            this.groupBox3.Location = new System.Drawing.Point(154, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 102);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // no_lbox
            // 
            this.no_lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_lbox.FormattingEnabled = true;
            this.no_lbox.ItemHeight = 18;
            this.no_lbox.Location = new System.Drawing.Point(12, 458);
            this.no_lbox.Name = "no_lbox";
            this.no_lbox.Size = new System.Drawing.Size(31, 148);
            this.no_lbox.TabIndex = 49;
            // 
            // rem_bo
            // 
            this.rem_bo.Location = new System.Drawing.Point(651, 459);
            this.rem_bo.Name = "rem_bo";
            this.rem_bo.Size = new System.Drawing.Size(73, 20);
            this.rem_bo.TabIndex = 50;
            // 
            // rem_b
            // 
            this.rem_b.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem_b.Location = new System.Drawing.Point(651, 485);
            this.rem_b.Name = "rem_b";
            this.rem_b.Size = new System.Drawing.Size(73, 33);
            this.rem_b.TabIndex = 51;
            this.rem_b.Text = "Remove";
            this.rem_b.UseVisualStyleBackColor = true;
            this.rem_b.Click += new System.EventHandler(this.rem_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "No";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rem_b);
            this.Controls.Add(this.rem_bo);
            this.Controls.Add(this.no_lbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pile_cbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pricebox_l);
            this.Controls.Add(this.heightbox_l);
            this.Controls.Add(this.widthbox_l);
            this.Controls.Add(this.roombox_l);
            this.Controls.Add(this.price_lbox);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.room_box);
            this.Controls.Add(this.height_lbox);
            this.Controls.Add(this.width_lbox);
            this.Controls.Add(this.room_lbox);
            this.Controls.Add(this.kind_label);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.height_box);
            this.Controls.Add(this.width_box);
            this.Controls.Add(this.qty_box);
            this.Controls.Add(this.price);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.qty);
            this.Name = "Form1";
            this.Text = "Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox qty_box;
        private System.Windows.Forms.TextBox width_box;
        private System.Windows.Forms.TextBox height_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.ComboBox kind;
        private System.Windows.Forms.Label kind_label;
        private System.Windows.Forms.Label mainl;
        private System.Windows.Forms.ListBox room_lbox;
        private System.Windows.Forms.ListBox width_lbox;
        private System.Windows.Forms.ListBox height_lbox;
        private System.Windows.Forms.TextBox room_box;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.ListBox price_lbox;
        private System.Windows.Forms.Label roombox_l;
        private System.Windows.Forms.Label widthbox_l;
        private System.Windows.Forms.Label heightbox_l;
        private System.Windows.Forms.Label Pricebox_l;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox main_box;
        private System.Windows.Forms.TextBox d_box;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label grand_t;
        private System.Windows.Forms.Label total0;
        private System.Windows.Forms.Label tax0;
        private System.Windows.Forms.Label depositl;
        private System.Windows.Forms.Label balancel;
        private System.Windows.Forms.Label line_l;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.Label tax1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox pile_cbox;
        private System.Windows.Forms.Button ext_button;
        private System.Windows.Forms.TextBox extra_box;
        private System.Windows.Forms.Label extra_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox no_lbox;
        private System.Windows.Forms.TextBox rem_bo;
        private System.Windows.Forms.Button rem_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

