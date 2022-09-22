namespace c_assignment_5._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelnumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.lablemodify = new System.Windows.Forms.Label();
            this.lableitem = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNUmber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnModifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Location = new System.Drawing.Point(12, 9);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.Size = new System.Drawing.Size(67, 20);
            this.labelnumber.TabIndex = 0;
            this.labelnumber.Text = "Number ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(250, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "DATE";
            // 
            // lablemodify
            // 
            this.lablemodify.AutoSize = true;
            this.lablemodify.Location = new System.Drawing.Point(594, 9);
            this.lablemodify.Name = "lablemodify";
            this.lablemodify.Size = new System.Drawing.Size(66, 20);
            this.lablemodify.TabIndex = 2;
            this.lablemodify.Text = "modifier";
            this.lablemodify.Click += new System.EventHandler(this.lablemodify_Click);
            // 
            // lableitem
            // 
            this.lableitem.AutoSize = true;
            this.lableitem.Location = new System.Drawing.Point(12, 82);
            this.lableitem.Name = "lableitem";
            this.lableitem.Size = new System.Drawing.Size(84, 20);
            this.lableitem.TabIndex = 3;
            this.lableitem.Text = "Item name ";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(27, 166);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(48, 20);
            this.labelcount.TabIndex = 4;
            this.labelcount.Text = "Count";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(250, 166);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(45, 20);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(-3, 222);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(143, 29);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.BackColorChanged += new System.EventHandler(this.button1_Click);
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Image = ((System.Drawing.Image)(resources.GetObject("buttoncancel.Image")));
            this.buttoncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncancel.Location = new System.Drawing.Point(226, 222);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(143, 29);
            this.buttoncancel.TabIndex = 7;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.BackgroundImageChanged += new System.EventHandler(this.button1_Click);
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-3, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(-3, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(208, 189);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnNumber,
            this.ClmnDate,
            this.dataGridViewTextBoxColumn1,
            this.ClmnItemNumber,
            this.ClmnCount,
            this.ClmnPrice});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 249);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClmnNumber
            // 
            this.ClmnNumber.HeaderText = "Number";
            this.ClmnNumber.MinimumWidth = 6;
            this.ClmnNumber.Name = "ClmnNumber";
            this.ClmnNumber.Width = 125;
            // 
            // ClmnDate
            // 
            this.ClmnDate.HeaderText = "Date";
            this.ClmnDate.MinimumWidth = 6;
            this.ClmnDate.Name = "ClmnDate";
            this.ClmnDate.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Modifier";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ClmnItemNumber
            // 
            this.ClmnItemNumber.HeaderText = "Itemnumber";
            this.ClmnItemNumber.MinimumWidth = 6;
            this.ClmnItemNumber.Name = "ClmnItemNumber";
            this.ClmnItemNumber.Width = 125;
            // 
            // ClmnCount
            // 
            this.ClmnCount.HeaderText = "Count";
            this.ClmnCount.MinimumWidth = 6;
            this.ClmnCount.Name = "ClmnCount";
            this.ClmnCount.Width = 125;
            // 
            // ClmnPrice
            // 
            this.ClmnPrice.HeaderText = "Price";
            this.ClmnPrice.MinimumWidth = 6;
            this.ClmnPrice.Name = "ClmnPrice";
            this.ClmnPrice.Width = 125;
            // 
            // ClmNUmber
            // 
            this.ClmNUmber.HeaderText = "Number";
            this.ClmNUmber.MinimumWidth = 6;
            this.ClmNUmber.Name = "ClmNUmber";
            this.ClmNUmber.Width = 125;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 125;
            // 
            // ClmnModifier
            // 
            this.ClmnModifier.HeaderText = "Modifier";
            this.ClmnModifier.MinimumWidth = 6;
            this.ClmnModifier.Name = "ClmnModifier";
            this.ClmnModifier.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.lableitem);
            this.Controls.Add(this.lablemodify);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelnumber;
        private Label labelDate;
        private Label lablemodify;
        private Label lableitem;
        private Label labelcount;
        private Label lblprice;
        private Button buttonAdd;
        private Button buttoncancel;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ClmnNumber;
        private DataGridViewTextBoxColumn ClmnDate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ClmnItemNumber;
        private DataGridViewTextBoxColumn ClmnCount;
        private DataGridViewTextBoxColumn ClmnPrice;
        private DataGridViewTextBoxColumn ClmNUmber;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn ClmnModifier;
    }
}