namespace Sales_Project
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
        /// 
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;



        private System.Windows.Forms.ComboBox cboPayment;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_Click = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.Print_Click = new System.Windows.Forms.Button();
            this.Pay_Click = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarCode
            // 
            this.lblBarCode.Location = new System.Drawing.Point(0, 0);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(100, 23);
            this.lblBarCode.TabIndex = 0;
            // 
            // lblCash
            // 
            this.lblCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCash.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblCash.Location = new System.Drawing.Point(208, 78);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(177, 26);
            this.lblCash.TabIndex = 0;
            this.lblCash.Text = "0";
            this.lblCash.Click += new System.EventHandler(this.lblCash_Click);
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(208, 130);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(177, 26);
            this.lblChange.TabIndex = 5;
            this.lblChange.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(144, 30);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(177, 26);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTax.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(144, 78);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(177, 26);
            this.lblTax.TabIndex = 4;
            this.lblTax.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(144, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(177, 26);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.C_Click);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 443);
            this.panel1.TabIndex = 0;
            // 
            // C_Click
            // 
            this.C_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.C_Click.Location = new System.Drawing.Point(217, 287);
            this.C_Click.Name = "C_Click";
            this.C_Click.Size = new System.Drawing.Size(93, 81);
            this.C_Click.TabIndex = 11;
            this.C_Click.Text = "C";
            this.C_Click.UseVisualStyleBackColor = true;
            this.C_Click.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(118, 287);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 81);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(19, 287);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 81);
            this.button12.TabIndex = 9;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(217, 200);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 81);
            this.button7.TabIndex = 8;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(118, 200);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 81);
            this.button8.TabIndex = 7;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(19, 200);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 81);
            this.button9.TabIndex = 6;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(217, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 81);
            this.button4.TabIndex = 5;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(118, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(19, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 81);
            this.button6.TabIndex = 3;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(217, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(118, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.button28);
            this.panel2.Controls.Add(this.button29);
            this.panel2.Controls.Add(this.button30);
            this.panel2.Controls.Add(this.button31);
            this.panel2.Controls.Add(this.button32);
            this.panel2.Controls.Add(this.button33);
            this.panel2.Controls.Add(this.button34);
            this.panel2.Controls.Add(this.button35);
            this.panel2.Controls.Add(this.button36);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Location = new System.Drawing.Point(715, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 443);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button25
            // 
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button25.ForeColor = System.Drawing.SystemColors.Control;
            this.button25.Location = new System.Drawing.Point(520, 287);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(93, 81);
            this.button25.TabIndex = 35;
            this.button25.Text = "Rs.3000";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button26.ForeColor = System.Drawing.SystemColors.Control;
            this.button26.Location = new System.Drawing.Point(421, 287);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(93, 81);
            this.button26.TabIndex = 34;
            this.button26.Text = "Rs.2890";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button27.ForeColor = System.Drawing.SystemColors.Control;
            this.button27.Location = new System.Drawing.Point(322, 287);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(93, 81);
            this.button27.TabIndex = 33;
            this.button27.Text = "Rs.2000";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button28.ForeColor = System.Drawing.SystemColors.Control;
            this.button28.Location = new System.Drawing.Point(520, 200);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(93, 81);
            this.button28.TabIndex = 32;
            this.button28.Text = "Rs.8500";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button29.ForeColor = System.Drawing.SystemColors.Control;
            this.button29.Location = new System.Drawing.Point(421, 200);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(93, 81);
            this.button29.TabIndex = 31;
            this.button29.Text = "Rs.5400";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button30.ForeColor = System.Drawing.SystemColors.Control;
            this.button30.Location = new System.Drawing.Point(322, 200);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(93, 81);
            this.button30.TabIndex = 30;
            this.button30.Text = "Rs.2500";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button31.ForeColor = System.Drawing.SystemColors.Control;
            this.button31.Location = new System.Drawing.Point(520, 113);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(93, 81);
            this.button31.TabIndex = 29;
            this.button31.Text = "Rs.2500";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button32.ForeColor = System.Drawing.SystemColors.Control;
            this.button32.Location = new System.Drawing.Point(421, 113);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(93, 81);
            this.button32.TabIndex = 28;
            this.button32.Text = "Rs.4600";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button33.ForeColor = System.Drawing.SystemColors.Control;
            this.button33.Location = new System.Drawing.Point(322, 113);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(93, 81);
            this.button33.TabIndex = 27;
            this.button33.Text = "Rs.3000";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button34.BackgroundImage")));
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button34.ForeColor = System.Drawing.SystemColors.Control;
            this.button34.Location = new System.Drawing.Point(520, 26);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(93, 81);
            this.button34.TabIndex = 26;
            this.button34.Text = "Rs.4200";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button35.BackgroundImage")));
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button35.ForeColor = System.Drawing.SystemColors.Control;
            this.button35.Location = new System.Drawing.Point(421, 26);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(93, 81);
            this.button35.TabIndex = 25;
            this.button35.Text = "Rs.9000";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button36.BackgroundImage")));
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button36.ForeColor = System.Drawing.SystemColors.Control;
            this.button36.Location = new System.Drawing.Point(322, 26);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(93, 81);
            this.button36.TabIndex = 24;
            this.button36.Text = "Rs.5500";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(213, 287);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 81);
            this.button13.TabIndex = 23;
            this.button13.Text = "Rs.3000";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(114, 287);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(93, 81);
            this.button14.TabIndex = 22;
            this.button14.Text = "Rs.6500";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button15.ForeColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(15, 287);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(93, 81);
            this.button15.TabIndex = 21;
            this.button15.Text = "Rs.3900";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button16.ForeColor = System.Drawing.SystemColors.Control;
            this.button16.Location = new System.Drawing.Point(213, 200);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(93, 81);
            this.button16.TabIndex = 20;
            this.button16.Text = "Rs.5400";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button17.ForeColor = System.Drawing.SystemColors.Control;
            this.button17.Location = new System.Drawing.Point(114, 200);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(93, 81);
            this.button17.TabIndex = 19;
            this.button17.Text = "Rs.5000";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button18.ForeColor = System.Drawing.SystemColors.Control;
            this.button18.Location = new System.Drawing.Point(15, 200);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(93, 81);
            this.button18.TabIndex = 18;
            this.button18.Text = "Rs.5500";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button19.ForeColor = System.Drawing.SystemColors.Control;
            this.button19.Location = new System.Drawing.Point(213, 113);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(93, 81);
            this.button19.TabIndex = 17;
            this.button19.Text = "Rs.2000";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button20.ForeColor = System.Drawing.SystemColors.Control;
            this.button20.Location = new System.Drawing.Point(114, 113);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(93, 81);
            this.button20.TabIndex = 16;
            this.button20.Text = "Rs.4000";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.Control;
            this.button21.Location = new System.Drawing.Point(15, 113);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(93, 81);
            this.button21.TabIndex = 15;
            this.button21.Text = "Rs.3500";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button22.ForeColor = System.Drawing.SystemColors.Control;
            this.button22.Location = new System.Drawing.Point(213, 26);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(93, 81);
            this.button22.TabIndex = 14;
            this.button22.Text = "Rs.3000";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button23.ForeColor = System.Drawing.SystemColors.Control;
            this.button23.Location = new System.Drawing.Point(114, 26);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(93, 81);
            this.button23.TabIndex = 13;
            this.button23.Text = "Rs.2500";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.Control;
            this.button24.Location = new System.Drawing.Point(15, 26);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(93, 81);
            this.button24.TabIndex = 12;
            this.button24.Text = "Rs.4500";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(12, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1335, 251);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.RemoveItem);
            this.panel6.Controls.Add(this.button39);
            this.panel6.Controls.Add(this.Print_Click);
            this.panel6.Controls.Add(this.Pay_Click);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(893, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 174);
            this.panel6.TabIndex = 2;
            // 
            // RemoveItem
            // 
            this.RemoveItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem.Location = new System.Drawing.Point(208, 93);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(123, 63);
            this.RemoveItem.TabIndex = 3;
            this.RemoveItem.Text = "Remove";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click_Click);
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(208, 21);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(123, 63);
            this.button39.TabIndex = 2;
            this.button39.Text = "Reset";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // Print_Click
            // 
            this.Print_Click.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Click.Location = new System.Drawing.Point(40, 93);
            this.Print_Click.Name = "Print_Click";
            this.Print_Click.Size = new System.Drawing.Size(127, 63);
            this.Print_Click.TabIndex = 1;
            this.Print_Click.Text = "Print";
            this.Print_Click.UseVisualStyleBackColor = true;
            this.Print_Click.Click += new System.EventHandler(this.button38_Click);
            // 
            // Pay_Click
            // 
            this.Pay_Click.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Click.Location = new System.Drawing.Point(40, 21);
            this.Pay_Click.Name = "Pay_Click";
            this.Pay_Click.Size = new System.Drawing.Size(127, 63);
            this.Pay_Click.TabIndex = 0;
            this.Pay_Click.Text = "Pay";
            this.Pay_Click.UseVisualStyleBackColor = true;
            this.Pay_Click.Click += new System.EventHandler(this.button37_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.lblCash);
            this.panel5.Controls.Add(this.cboPayment);
            this.panel5.Controls.Add(this.lblChange);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(437, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 174);
            this.panel5.TabIndex = 1;
            // 
            // cboPayment
            // 
            this.cboPayment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(208, 27);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(177, 32);
            this.cboPayment.TabIndex = 5;
            this.cboPayment.SelectedIndexChanged += new System.EventHandler(this.cboPayment_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Change";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Payment Method";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblTax);
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(19, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 174);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "  Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(354, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 380);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("C39HrP24DlTt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "lblBarCode";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button C_Click;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Panel panel3;
        //private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button Print_Click;
        private System.Windows.Forms.Button Pay_Click;
        private System.Windows.Forms.Panel panel5;
        //private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

