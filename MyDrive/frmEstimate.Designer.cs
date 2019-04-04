namespace patio {
    partial class frmEstimate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblExchange = new System.Windows.Forms.Label();
            this.tbExchangeRate = new System.Windows.Forms.TextBox();
            this.lblCurency = new System.Windows.Forms.Label();
            this.lblPricePerSqMe = new System.Windows.Forms.Label();
            this.tbBrickPrice = new System.Windows.Forms.TextBox();
            this.tbConcretePrice = new System.Windows.Forms.TextBox();
            this.tbTarmacPrice = new System.Windows.Forms.TextBox();
            this.tbGravelPrice = new System.Windows.Forms.TextBox();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rbGravel = new System.Windows.Forms.RadioButton();
            this.rbTarmac = new System.Windows.Forms.RadioButton();
            this.rbConcrete = new System.Windows.Forms.RadioButton();
            this.rbBrick = new System.Windows.Forms.RadioButton();
            this.cmdStart = new System.Windows.Forms.Button();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rbExtraDeep = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMetres = new System.Windows.Forms.Label();
            this.lblMetres2 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbGbpPrice = new System.Windows.Forms.TextBox();
            this.lblGbp = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.tbEuroPrice = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpType.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Red;
            this.lblHeading.Location = new System.Drawing.Point(146, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(234, 26);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Euro Drives or Patios";
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Location = new System.Drawing.Point(39, 77);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(122, 13);
            this.lblExchange.TabIndex = 1;
            this.lblExchange.Text = "EXCHANGE RATE £1 =";
            // 
            // tbExchangeRate
            // 
            this.tbExchangeRate.Location = new System.Drawing.Point(167, 74);
            this.tbExchangeRate.Name = "tbExchangeRate";
            this.tbExchangeRate.Size = new System.Drawing.Size(33, 20);
            this.tbExchangeRate.TabIndex = 2;
            this.tbExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurency
            // 
            this.lblCurency.AutoSize = true;
            this.lblCurency.Location = new System.Drawing.Point(206, 77);
            this.lblCurency.Name = "lblCurency";
            this.lblCurency.Size = new System.Drawing.Size(45, 13);
            this.lblCurency.TabIndex = 3;
            this.lblCurency.Text = "EUROS";
            // 
            // lblPricePerSqMe
            // 
            this.lblPricePerSqMe.AutoSize = true;
            this.lblPricePerSqMe.Location = new System.Drawing.Point(148, 113);
            this.lblPricePerSqMe.Name = "lblPricePerSqMe";
            this.lblPricePerSqMe.Size = new System.Drawing.Size(153, 13);
            this.lblPricePerSqMe.TabIndex = 4;
            this.lblPricePerSqMe.Text = "PRICE PER SQUARE METER";
            // 
            // tbBrickPrice
            // 
            this.tbBrickPrice.Location = new System.Drawing.Point(151, 129);
            this.tbBrickPrice.Name = "tbBrickPrice";
            this.tbBrickPrice.Size = new System.Drawing.Size(100, 20);
            this.tbBrickPrice.TabIndex = 5;
            this.tbBrickPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbConcretePrice
            // 
            this.tbConcretePrice.Location = new System.Drawing.Point(151, 155);
            this.tbConcretePrice.Name = "tbConcretePrice";
            this.tbConcretePrice.Size = new System.Drawing.Size(100, 20);
            this.tbConcretePrice.TabIndex = 6;
            this.tbConcretePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTarmacPrice
            // 
            this.tbTarmacPrice.Location = new System.Drawing.Point(151, 181);
            this.tbTarmacPrice.Name = "tbTarmacPrice";
            this.tbTarmacPrice.Size = new System.Drawing.Size(100, 20);
            this.tbTarmacPrice.TabIndex = 7;
            this.tbTarmacPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGravelPrice
            // 
            this.tbGravelPrice.Location = new System.Drawing.Point(151, 207);
            this.tbGravelPrice.Name = "tbGravelPrice";
            this.tbGravelPrice.Size = new System.Drawing.Size(100, 20);
            this.tbGravelPrice.TabIndex = 8;
            this.tbGravelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbGravel);
            this.grpType.Controls.Add(this.rbTarmac);
            this.grpType.Controls.Add(this.rbConcrete);
            this.grpType.Controls.Add(this.rbBrick);
            this.grpType.Location = new System.Drawing.Point(25, 113);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(117, 123);
            this.grpType.TabIndex = 9;
            this.grpType.TabStop = false;
            this.grpType.Text = "Materials";
            // 
            // rbGravel
            // 
            this.rbGravel.AutoSize = true;
            this.rbGravel.Location = new System.Drawing.Point(4, 88);
            this.rbGravel.Name = "rbGravel";
            this.rbGravel.Size = new System.Drawing.Size(68, 17);
            this.rbGravel.TabIndex = 3;
            this.rbGravel.TabStop = true;
            this.rbGravel.Text = "GRAVEL";
            this.rbGravel.UseVisualStyleBackColor = true;
            this.rbGravel.CheckedChanged += new System.EventHandler(this.rbGravel_CheckedChanged);
            // 
            // rbTarmac
            // 
            this.rbTarmac.AutoSize = true;
            this.rbTarmac.Location = new System.Drawing.Point(6, 65);
            this.rbTarmac.Name = "rbTarmac";
            this.rbTarmac.Size = new System.Drawing.Size(70, 17);
            this.rbTarmac.TabIndex = 2;
            this.rbTarmac.TabStop = true;
            this.rbTarmac.Text = "TARMAC";
            this.rbTarmac.UseVisualStyleBackColor = true;
            this.rbTarmac.CheckedChanged += new System.EventHandler(this.rbTarmac_CheckedChanged);
            // 
            // rbConcrete
            // 
            this.rbConcrete.AutoSize = true;
            this.rbConcrete.Location = new System.Drawing.Point(6, 42);
            this.rbConcrete.Name = "rbConcrete";
            this.rbConcrete.Size = new System.Drawing.Size(84, 17);
            this.rbConcrete.TabIndex = 1;
            this.rbConcrete.TabStop = true;
            this.rbConcrete.Text = "CONCRETE";
            this.rbConcrete.UseVisualStyleBackColor = true;
            this.rbConcrete.CheckedChanged += new System.EventHandler(this.rbConcrete_CheckedChanged);
            // 
            // rbBrick
            // 
            this.rbBrick.AutoSize = true;
            this.rbBrick.Location = new System.Drawing.Point(6, 19);
            this.rbBrick.Name = "rbBrick";
            this.rbBrick.Size = new System.Drawing.Size(57, 17);
            this.rbBrick.TabIndex = 0;
            this.rbBrick.TabStop = true;
            this.rbBrick.Text = "BRICK";
            this.rbBrick.UseVisualStyleBackColor = true;
            this.rbBrick.CheckedChanged += new System.EventHandler(this.rbBrick_CheckedChanged);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(201, 469);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 10;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rbExtraDeep);
            this.grpFoundations.Controls.Add(this.rbStandard);
            this.grpFoundations.Location = new System.Drawing.Point(301, 128);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(112, 67);
            this.grpFoundations.TabIndex = 11;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            // 
            // rbExtraDeep
            // 
            this.rbExtraDeep.AutoSize = true;
            this.rbExtraDeep.Location = new System.Drawing.Point(14, 44);
            this.rbExtraDeep.Name = "rbExtraDeep";
            this.rbExtraDeep.Size = new System.Drawing.Size(93, 17);
            this.rbExtraDeep.TabIndex = 1;
            this.rbExtraDeep.TabStop = true;
            this.rbExtraDeep.Text = "EXTRA DEEP";
            this.rbExtraDeep.UseVisualStyleBackColor = true;
            this.rbExtraDeep.CheckedChanged += new System.EventHandler(this.rbExtraDeep_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(14, 21);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(85, 17);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "STANDARD";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(94, 265);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 13);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "LENGTH";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(101, 293);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 13);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "WIDTH";
            // 
            // lblMetres
            // 
            this.lblMetres.AutoSize = true;
            this.lblMetres.Location = new System.Drawing.Point(257, 265);
            this.lblMetres.Name = "lblMetres";
            this.lblMetres.Size = new System.Drawing.Size(52, 13);
            this.lblMetres.TabIndex = 14;
            this.lblMetres.Text = "METRES";
            // 
            // lblMetres2
            // 
            this.lblMetres2.AutoSize = true;
            this.lblMetres2.Location = new System.Drawing.Point(257, 293);
            this.lblMetres2.Name = "lblMetres2";
            this.lblMetres2.Size = new System.Drawing.Size(52, 13);
            this.lblMetres2.TabIndex = 15;
            this.lblMetres2.Text = "METRES";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(151, 258);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 20);
            this.tbLength.TabIndex = 16;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(151, 286);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 20);
            this.tbWidth.TabIndex = 17;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGbpPrice
            // 
            this.tbGbpPrice.Location = new System.Drawing.Point(85, 340);
            this.tbGbpPrice.Name = "tbGbpPrice";
            this.tbGbpPrice.Size = new System.Drawing.Size(100, 20);
            this.tbGbpPrice.TabIndex = 18;
            this.tbGbpPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGbp
            // 
            this.lblGbp.AutoSize = true;
            this.lblGbp.Location = new System.Drawing.Point(50, 347);
            this.lblGbp.Name = "lblGbp";
            this.lblGbp.Size = new System.Drawing.Size(29, 13);
            this.lblGbp.TabIndex = 19;
            this.lblGbp.Text = "GBP";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(238, 347);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(38, 13);
            this.lblEuro.TabIndex = 20;
            this.lblEuro.Text = "EURO";
            // 
            // tbEuroPrice
            // 
            this.tbEuroPrice.Location = new System.Drawing.Point(282, 340);
            this.tbEuroPrice.Name = "tbEuroPrice";
            this.tbEuroPrice.Size = new System.Drawing.Size(100, 20);
            this.tbEuroPrice.TabIndex = 21;
            this.tbEuroPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(85, 366);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(328, 26);
            this.lblOutput.TabIndex = 22;
            this.lblOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(100, 429);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(100, 23);
            this.cmdCalculate.TabIndex = 23;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(260, 429);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 24;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 504);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbEuroPrice);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblGbp);
            this.Controls.Add(this.tbGbpPrice);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lblMetres2);
            this.Controls.Add(this.lblMetres);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbBrickPrice);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblPricePerSqMe);
            this.Controls.Add(this.lblCurency);
            this.Controls.Add(this.tbExchangeRate);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.tbConcretePrice);
            this.Controls.Add(this.tbTarmacPrice);
            this.Controls.Add(this.tbGravelPrice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Estimates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.TextBox tbExchangeRate;
        private System.Windows.Forms.Label lblCurency;
        private System.Windows.Forms.Label lblPricePerSqMe;
        private System.Windows.Forms.TextBox tbBrickPrice;
        private System.Windows.Forms.TextBox tbConcretePrice;
        private System.Windows.Forms.TextBox tbTarmacPrice;
        private System.Windows.Forms.TextBox tbGravelPrice;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rbGravel;
        private System.Windows.Forms.RadioButton rbTarmac;
        private System.Windows.Forms.RadioButton rbConcrete;
        private System.Windows.Forms.RadioButton rbBrick;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rbExtraDeep;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMetres;
        private System.Windows.Forms.Label lblMetres2;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbGbpPrice;
        private System.Windows.Forms.Label lblGbp;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox tbEuroPrice;
        private System.Windows.Forms.TextBox lblOutput;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        }
    }

