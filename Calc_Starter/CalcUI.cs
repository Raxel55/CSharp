using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private ToolTip toolTip1;
        private IContainer components;

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//

			VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(260, 169);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.toolTip1.SetToolTip(this.KeyDate, "Current date");
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(12, 217);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.toolTip1.SetToolTip(this.KeyOne, "1");
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(12, 57);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(304, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.VersionInfo, "Version");
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(108, 169);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.toolTip1.SetToolTip(this.KeySix, "6");
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(60, 169);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.toolTip1.SetToolTip(this.KeyFive, "5");
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(260, 265);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip1.SetToolTip(this.KeyEqual, "Calculate");
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(60, 217);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.toolTip1.SetToolTip(this.KeyTwo, "2");
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(12, 265);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.toolTip1.SetToolTip(this.KeyZero, "0");
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(108, 217);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.toolTip1.SetToolTip(this.KeyThree, "3");
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(156, 265);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "+");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(260, 217);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.KeyExit, "Exit");
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(108, 265);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.toolTip1.SetToolTip(this.KeySign, "Change sign");
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(12, 121);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.toolTip1.SetToolTip(this.KeySeven, "7");
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(60, 265);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.toolTip1.SetToolTip(this.KeyPoint, ".");
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(108, 121);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.toolTip1.SetToolTip(this.KeyNine, "9");
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.Aqua;
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(12, 89);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(304, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.OutputDisplay, "Result");
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(156, 217);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "-");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(60, 121);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.toolTip1.SetToolTip(this.KeyEight, "8");
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(156, 169);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "*");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(12, 169);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.toolTip1.SetToolTip(this.KeyFour, "4");
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(260, 121);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.toolTip1.SetToolTip(this.KeyClear, "Reset");
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(156, 121);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "/");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(202, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 23;
            this.button1.TabStop = false;
            this.button1.Text = "^";
            this.toolTip1.SetToolTip(this.button1, "^");
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(202, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 24;
            this.button2.TabStop = false;
            this.button2.Text = "_/";
            this.toolTip1.SetToolTip(this.button2, "root");
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(202, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 25;
            this.button3.TabStop = false;
            this.button3.Text = "1/x";
            this.toolTip1.SetToolTip(this.button3, "1/x");
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(202, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 26;
            this.button4.TabStop = false;
            this.button4.Text = "^2";
            this.toolTip1.SetToolTip(this.button4, "^2");
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(304, 26);
            this.textBox1.TabIndex = 27;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBox1, "Factorial");
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(12, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(304, 40);
            this.button5.TabIndex = 28;
            this.button5.TabStop = false;
            this.button5.Text = "Factorial";
            this.toolTip1.SetToolTip(this.button5, "Factorial (takes 3 sec)");
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(324, 358);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eStepen);
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eKoren);
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eObrat);
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eKvadrat);
        }

        protected async void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = await CalcEngine.GetFactorial();
        }
    }
}
