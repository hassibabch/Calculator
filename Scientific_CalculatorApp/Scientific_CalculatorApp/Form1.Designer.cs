namespace Scientific_CalculatorApp
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
            this.btnBS = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClearEntery = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnx2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnx3 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btninx = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnPs = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.Color.DimGray;
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.ForeColor = System.Drawing.Color.Black;
            this.btnBS.Location = new System.Drawing.Point(26, 121);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(96, 83);
            this.btnBS.TabIndex = 0;
            this.btnBS.Text = "←";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(26, 57);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(867, 40);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.UseWaitCursor = true;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnClearEntery
            // 
            this.btnClearEntery.BackColor = System.Drawing.Color.DimGray;
            this.btnClearEntery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntery.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClearEntery.Location = new System.Drawing.Point(128, 121);
            this.btnClearEntery.Name = "btnClearEntery";
            this.btnClearEntery.Size = new System.Drawing.Size(96, 83);
            this.btnClearEntery.TabIndex = 2;
            this.btnClearEntery.Text = "CE";
            this.btnClearEntery.UseVisualStyleBackColor = false;
            this.btnClearEntery.Click += new System.EventHandler(this.btnClearEntery_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DimGray;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Black;
            this.btnDiv.Location = new System.Drawing.Point(332, 121);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(96, 83);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.NumberOperators);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClear.Location = new System.Drawing.Point(230, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 83);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.DimGray;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.Black;
            this.btnMult.Location = new System.Drawing.Point(332, 210);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(96, 83);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.NumberOperators);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkGray;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn9.Location = new System.Drawing.Point(230, 210);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(96, 83);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkGray;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn8.Location = new System.Drawing.Point(128, 210);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(96, 83);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkGray;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn7.Location = new System.Drawing.Point(26, 210);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(96, 83);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.DimGray;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.Black;
            this.btnSub.Location = new System.Drawing.Point(332, 299);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(96, 83);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.NumberOperators);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkGray;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn6.Location = new System.Drawing.Point(230, 299);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(96, 83);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkGray;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn5.Location = new System.Drawing.Point(128, 299);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(96, 83);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkGray;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn4.Location = new System.Drawing.Point(26, 299);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(96, 83);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(332, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 83);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.NumberOperators);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkGray;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn3.Location = new System.Drawing.Point(230, 388);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(96, 83);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkGray;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn2.Location = new System.Drawing.Point(128, 388);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 83);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkGray;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn1.Location = new System.Drawing.Point(26, 388);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(96, 83);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.IndianRed;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(332, 477);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(96, 83);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.DarkGray;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(230, 477);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(96, 83);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkGray;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn0.Location = new System.Drawing.Point(128, 477);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 83);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.DarkGray;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.Black;
            this.btnPM.Location = new System.Drawing.Point(26, 477);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(96, 83);
            this.btnPM.TabIndex = 17;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.DimGray;
            this.btnPi.Font = new System.Drawing.Font("Centaur", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.Black;
            this.btnPi.Location = new System.Drawing.Point(491, 121);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(96, 83);
            this.btnPi.TabIndex = 22;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.DimGray;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(593, 121);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(96, 83);
            this.btnLog.TabIndex = 23;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnx2
            // 
            this.btnx2.BackColor = System.Drawing.Color.DimGray;
            this.btnx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx2.ForeColor = System.Drawing.Color.Black;
            this.btnx2.Location = new System.Drawing.Point(797, 121);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(96, 83);
            this.btnx2.TabIndex = 25;
            this.btnx2.Text = "x²";
            this.btnx2.UseVisualStyleBackColor = false;
            this.btnx2.Click += new System.EventHandler(this.btnx2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.DimGray;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Black;
            this.btnSqrt.Location = new System.Drawing.Point(695, 121);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(96, 83);
            this.btnSqrt.TabIndex = 24;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnx3
            // 
            this.btnx3.BackColor = System.Drawing.Color.DimGray;
            this.btnx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx3.ForeColor = System.Drawing.Color.Black;
            this.btnx3.Location = new System.Drawing.Point(797, 210);
            this.btnx3.Name = "btnx3";
            this.btnx3.Size = new System.Drawing.Size(96, 83);
            this.btnx3.TabIndex = 29;
            this.btnx3.Text = "x³";
            this.btnx3.UseVisualStyleBackColor = false;
            this.btnx3.Click += new System.EventHandler(this.btnx3_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.DimGray;
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.ForeColor = System.Drawing.Color.Black;
            this.btnDec.Location = new System.Drawing.Point(695, 210);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(96, 83);
            this.btnDec.TabIndex = 28;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.DimGray;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.Black;
            this.btnSin.Location = new System.Drawing.Point(593, 210);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(96, 83);
            this.btnSin.TabIndex = 27;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.Color.DimGray;
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.ForeColor = System.Drawing.Color.Black;
            this.btnSinh.Location = new System.Drawing.Point(491, 210);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(96, 83);
            this.btnSinh.TabIndex = 26;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.DimGray;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1x.ForeColor = System.Drawing.Color.Black;
            this.btn1x.Location = new System.Drawing.Point(797, 299);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(96, 83);
            this.btn1x.TabIndex = 33;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.Color.DimGray;
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.ForeColor = System.Drawing.Color.Black;
            this.btnBin.Location = new System.Drawing.Point(695, 299);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(96, 83);
            this.btnBin.TabIndex = 32;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.DimGray;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.Black;
            this.btnCos.Location = new System.Drawing.Point(593, 299);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(96, 83);
            this.btnCos.TabIndex = 31;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.Color.DimGray;
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.ForeColor = System.Drawing.Color.Black;
            this.btnCosh.Location = new System.Drawing.Point(491, 299);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(96, 83);
            this.btnCosh.TabIndex = 30;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btninx
            // 
            this.btninx.BackColor = System.Drawing.Color.DimGray;
            this.btninx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninx.ForeColor = System.Drawing.Color.Black;
            this.btninx.Location = new System.Drawing.Point(797, 388);
            this.btninx.Name = "btninx";
            this.btninx.Size = new System.Drawing.Size(96, 83);
            this.btninx.TabIndex = 37;
            this.btninx.Text = "In x";
            this.btninx.UseVisualStyleBackColor = false;
            this.btninx.Click += new System.EventHandler(this.btninx_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.DimGray;
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.ForeColor = System.Drawing.Color.Black;
            this.btnHex.Location = new System.Drawing.Point(695, 388);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(96, 83);
            this.btnHex.TabIndex = 36;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.BackColor = System.Drawing.Color.DimGray;
            this.BtnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTan.ForeColor = System.Drawing.Color.Black;
            this.BtnTan.Location = new System.Drawing.Point(593, 388);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(96, 83);
            this.BtnTan.TabIndex = 35;
            this.BtnTan.Text = "Tan";
            this.BtnTan.UseVisualStyleBackColor = false;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.Color.DimGray;
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.ForeColor = System.Drawing.Color.Black;
            this.btnTanh.Location = new System.Drawing.Point(491, 388);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(96, 83);
            this.btnTanh.TabIndex = 34;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnPs
            // 
            this.btnPs.BackColor = System.Drawing.Color.DimGray;
            this.btnPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPs.ForeColor = System.Drawing.Color.Black;
            this.btnPs.Location = new System.Drawing.Point(797, 477);
            this.btnPs.Name = "btnPs";
            this.btnPs.Size = new System.Drawing.Size(96, 83);
            this.btnPs.TabIndex = 41;
            this.btnPs.Text = "%";
            this.btnPs.UseVisualStyleBackColor = false;
            this.btnPs.Click += new System.EventHandler(this.btnPs_Click);
            // 
            // btnOct
            // 
            this.btnOct.BackColor = System.Drawing.Color.DimGray;
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOct.ForeColor = System.Drawing.Color.Black;
            this.btnOct.Location = new System.Drawing.Point(695, 477);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(96, 83);
            this.btnOct.TabIndex = 40;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = false;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.DimGray;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(593, 477);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(96, 83);
            this.btnMod.TabIndex = 39;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.NumberOperators);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.DimGray;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.Color.Black;
            this.btnExp.Location = new System.Drawing.Point(491, 477);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(96, 83);
            this.btnExp.TabIndex = 38;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.NumberOperators);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(931, 580);
            this.Controls.Add(this.btnPs);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btninx);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnx3);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnx2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntery);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClearEntery;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnx2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnx3;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btninx;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnPs;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExp;
    }
}

