using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Gravity_simulation
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		// ball 1
		double xspeed,yspeed,newyspeed,startingypos;
		double newxpos,newypos,oldxpos,oldypos;
		double newx,oldx,newy,oldy;
		double acc,t;
		const int ground = 500;
		int xmouse,ymouse;
		bool dragging=true,trace,collisiony;

		// ball 2
		double xspeed2,yspeed2,newyspeed2,startingypos2;
		double newxpos2,newypos2,oldxpos2,oldypos2;
		double newx2,oldx2,newy2,oldy2;
		double acc2,t2;
		int xmouse2,ymouse2;
		bool dragging2,trace2,collisiony2;
		
		// ball 3
		double xspeed3,yspeed3,newyspeed3,startingypos3;
		double newxpos3,newypos3,oldxpos3,oldypos3;
		double newx3,oldx3,newy3,oldy3;
		double acc3,t3;
		int xmouse3,ymouse3;
		bool dragging3,trace3,collisiony3;

		int choice = 1;
		int numberofballs = 1;

		Ballinstance b1 = new Ballinstance();
		Ballinstance b2 = new Ballinstance();
		Ballinstance b3 = new Ballinstance();

		//StreamWriter sw;

		private System.Timers.Timer timer;
		private System.Windows.Forms.PictureBox ball;
		private System.Windows.Forms.PictureBox ball2;
		private System.Windows.Forms.PictureBox ball3;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.GroupBox groupBall1;
		private System.Windows.Forms.GroupBox groupBall2;
		private System.Windows.Forms.GroupBox groupBall3;
		private System.Windows.Forms.NumericUpDown n1;
		private System.Windows.Forms.NumericUpDown n2;
		private System.Windows.Forms.NumericUpDown n3;
		private System.Windows.Forms.NumericUpDown n4;
		private System.Windows.Forms.NumericUpDown n5;
		private System.Windows.Forms.NumericUpDown n6;
		private System.Windows.Forms.NumericUpDown n7;
		private System.Windows.Forms.NumericUpDown n8;
		private System.Windows.Forms.NumericUpDown n9;
		private System.Windows.Forms.NumericUpDown n10;
		private System.Windows.Forms.NumericUpDown n11;
		private System.Windows.Forms.NumericUpDown n12;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown acc_one;
		private System.Windows.Forms.NumericUpDown acc_two;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown acc_three;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.Button hide1_btn;
		private System.Windows.Forms.Button hide2_btn;
		private System.Windows.Forms.Button hide3_btn;
		private System.Windows.Forms.Button ok1_btn;
		private System.Windows.Forms.Button ok2_btn;
		private System.Windows.Forms.Button ok3_btn;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.timer = new System.Timers.Timer();
			this.ball = new System.Windows.Forms.PictureBox();
			this.ball2 = new System.Windows.Forms.PictureBox();
			this.ball3 = new System.Windows.Forms.PictureBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.groupBall1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.acc_one = new System.Windows.Forms.NumericUpDown();
			this.hide1_btn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.n4 = new System.Windows.Forms.NumericUpDown();
			this.n3 = new System.Windows.Forms.NumericUpDown();
			this.n2 = new System.Windows.Forms.NumericUpDown();
			this.n1 = new System.Windows.Forms.NumericUpDown();
			this.ok1_btn = new System.Windows.Forms.Button();
			this.groupBall2 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.acc_two = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.n5 = new System.Windows.Forms.NumericUpDown();
			this.n6 = new System.Windows.Forms.NumericUpDown();
			this.n7 = new System.Windows.Forms.NumericUpDown();
			this.n8 = new System.Windows.Forms.NumericUpDown();
			this.ok2_btn = new System.Windows.Forms.Button();
			this.hide2_btn = new System.Windows.Forms.Button();
			this.groupBall3 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.acc_three = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.n9 = new System.Windows.Forms.NumericUpDown();
			this.n10 = new System.Windows.Forms.NumericUpDown();
			this.n11 = new System.Windows.Forms.NumericUpDown();
			this.n12 = new System.Windows.Forms.NumericUpDown();
			this.ok3_btn = new System.Windows.Forms.Button();
			this.hide3_btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
			this.groupBall1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.acc_one)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
			this.groupBall2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.acc_two)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n8)).BeginInit();
			this.groupBall3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.acc_three)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n12)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 20;
			this.timer.SynchronizingObject = this;
			this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
			// 
			// ball
			// 
			this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
			this.ball.Location = new System.Drawing.Point(224, 64);
			this.ball.Name = "ball";
			this.ball.Size = new System.Drawing.Size(56, 56);
			this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ball.TabIndex = 0;
			this.ball.TabStop = false;
			// 
			// ball2
			// 
			this.ball2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ball2.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
			this.ball2.Location = new System.Drawing.Point(188, 236);
			this.ball2.Name = "ball2";
			this.ball2.Size = new System.Drawing.Size(56, 56);
			this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ball2.TabIndex = 4;
			this.ball2.TabStop = false;
			// 
			// ball3
			// 
			this.ball3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ball3.Image = ((System.Drawing.Image)(resources.GetObject("ball3.Image")));
			this.ball3.Location = new System.Drawing.Point(284, 188);
			this.ball3.Name = "ball3";
			this.ball3.Size = new System.Drawing.Size(56, 56);
			this.ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ball3.TabIndex = 5;
			this.ball3.TabStop = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem5,
																					  this.menuItem10});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem12,
																					  this.menuItem11});
			this.menuItem1.Text = "&View";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Ball1 ToolBox";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Ball2 ToolBox";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "Ball3 ToolBox";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 3;
			this.menuItem12.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 4;
			this.menuItem11.Text = "Exit";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem14,
																					  this.menuItem7,
																					  this.menuItem13,
																					  this.menuItem8,
																					  this.menuItem9});
			this.menuItem5.Text = "&Run";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "Add ball";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 1;
			this.menuItem14.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "Trace";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "Tempo ++";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 5;
			this.menuItem9.Text = "Tempo --";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem15});
			this.menuItem10.Text = "Help";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.Text = "About";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// groupBall1
			// 
			this.groupBall1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBall1.Controls.Add(this.label13);
			this.groupBall1.Controls.Add(this.acc_one);
			this.groupBall1.Controls.Add(this.hide1_btn);
			this.groupBall1.Controls.Add(this.label4);
			this.groupBall1.Controls.Add(this.label3);
			this.groupBall1.Controls.Add(this.label2);
			this.groupBall1.Controls.Add(this.label1);
			this.groupBall1.Controls.Add(this.n4);
			this.groupBall1.Controls.Add(this.n3);
			this.groupBall1.Controls.Add(this.n2);
			this.groupBall1.Controls.Add(this.n1);
			this.groupBall1.Controls.Add(this.ok1_btn);
			this.groupBall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.groupBall1.Location = new System.Drawing.Point(648, 4);
			this.groupBall1.Name = "groupBall1";
			this.groupBall1.Size = new System.Drawing.Size(144, 176);
			this.groupBall1.TabIndex = 8;
			this.groupBall1.TabStop = false;
			this.groupBall1.Text = "Ball 1";
			this.groupBall1.Visible = false;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label13.Location = new System.Drawing.Point(16, 112);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 14;
			this.label13.Text = "acc1";
			// 
			// acc_one
			// 
			this.acc_one.Location = new System.Drawing.Point(72, 112);
			this.acc_one.Maximum = new System.Decimal(new int[] {
																	50,
																	0,
																	0,
																	0});
			this.acc_one.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.acc_one.Name = "acc_one";
			this.acc_one.Size = new System.Drawing.Size(56, 20);
			this.acc_one.TabIndex = 13;
			this.acc_one.Value = new System.Decimal(new int[] {
																  10,
																  0,
																  0,
																  0});
			// 
			// hide1_btn
			// 
			this.hide1_btn.Location = new System.Drawing.Point(24, 144);
			this.hide1_btn.Name = "hide1_btn";
			this.hide1_btn.Size = new System.Drawing.Size(48, 23);
			this.hide1_btn.TabIndex = 12;
			this.hide1_btn.Text = "Hide";
			this.hide1_btn.Click += new System.EventHandler(this.hide1_btn_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "y pos";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "x pos";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "y speed";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "x speed";
			// 
			// n4
			// 
			this.n4.Location = new System.Drawing.Point(72, 88);
			this.n4.Maximum = new System.Decimal(new int[] {
															   509,
															   0,
															   0,
															   0});
			this.n4.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.n4.Name = "n4";
			this.n4.Size = new System.Drawing.Size(56, 20);
			this.n4.TabIndex = 7;
			this.n4.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			// 
			// n3
			// 
			this.n3.Location = new System.Drawing.Point(72, 64);
			this.n3.Maximum = new System.Decimal(new int[] {
															   580,
															   0,
															   0,
															   0});
			this.n3.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.n3.Name = "n3";
			this.n3.Size = new System.Drawing.Size(56, 20);
			this.n3.TabIndex = 6;
			this.n3.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			// 
			// n2
			// 
			this.n2.Location = new System.Drawing.Point(72, 40);
			this.n2.Name = "n2";
			this.n2.Size = new System.Drawing.Size(56, 20);
			this.n2.TabIndex = 5;
			this.n2.Value = new System.Decimal(new int[] {
															 40,
															 0,
															 0,
															 0});
			// 
			// n1
			// 
			this.n1.Location = new System.Drawing.Point(72, 16);
			this.n1.Name = "n1";
			this.n1.Size = new System.Drawing.Size(56, 20);
			this.n1.TabIndex = 4;
			this.n1.Value = new System.Decimal(new int[] {
															 30,
															 0,
															 0,
															 0});
			// 
			// ok1_btn
			// 
			this.ok1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ok1_btn.Location = new System.Drawing.Point(88, 144);
			this.ok1_btn.Name = "ok1_btn";
			this.ok1_btn.Size = new System.Drawing.Size(40, 23);
			this.ok1_btn.TabIndex = 3;
			this.ok1_btn.Text = "Ok";
			this.ok1_btn.Click += new System.EventHandler(this.ok1_btn_Click);
			// 
			// groupBall2
			// 
			this.groupBall2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBall2.Controls.Add(this.label14);
			this.groupBall2.Controls.Add(this.acc_two);
			this.groupBall2.Controls.Add(this.label5);
			this.groupBall2.Controls.Add(this.label6);
			this.groupBall2.Controls.Add(this.label7);
			this.groupBall2.Controls.Add(this.label8);
			this.groupBall2.Controls.Add(this.n5);
			this.groupBall2.Controls.Add(this.n6);
			this.groupBall2.Controls.Add(this.n7);
			this.groupBall2.Controls.Add(this.n8);
			this.groupBall2.Controls.Add(this.ok2_btn);
			this.groupBall2.Controls.Add(this.hide2_btn);
			this.groupBall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.groupBall2.Location = new System.Drawing.Point(648, 188);
			this.groupBall2.Name = "groupBall2";
			this.groupBall2.Size = new System.Drawing.Size(144, 176);
			this.groupBall2.TabIndex = 9;
			this.groupBall2.TabStop = false;
			this.groupBall2.Text = "Ball 2";
			this.groupBall2.Visible = false;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label14.Location = new System.Drawing.Point(16, 112);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 13;
			this.label14.Text = "acc2";
			// 
			// acc_two
			// 
			this.acc_two.Location = new System.Drawing.Point(72, 112);
			this.acc_two.Maximum = new System.Decimal(new int[] {
																	50,
																	0,
																	0,
																	0});
			this.acc_two.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.acc_two.Name = "acc_two";
			this.acc_two.Size = new System.Drawing.Size(56, 20);
			this.acc_two.TabIndex = 12;
			this.acc_two.Value = new System.Decimal(new int[] {
																  10,
																  0,
																  0,
																  0});
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label5.Location = new System.Drawing.Point(16, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "y pos";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label6.Location = new System.Drawing.Point(16, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "x pos";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label7.Location = new System.Drawing.Point(16, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "y speed";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label8.Location = new System.Drawing.Point(16, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "x speed";
			// 
			// n5
			// 
			this.n5.Location = new System.Drawing.Point(72, 88);
			this.n5.Maximum = new System.Decimal(new int[] {
															   509,
															   0,
															   0,
															   0});
			this.n5.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.n5.Name = "n5";
			this.n5.Size = new System.Drawing.Size(56, 20);
			this.n5.TabIndex = 7;
			this.n5.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			// 
			// n6
			// 
			this.n6.Location = new System.Drawing.Point(72, 64);
			this.n6.Maximum = new System.Decimal(new int[] {
															   580,
															   0,
															   0,
															   0});
			this.n6.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.n6.Name = "n6";
			this.n6.Size = new System.Drawing.Size(56, 20);
			this.n6.TabIndex = 6;
			this.n6.Value = new System.Decimal(new int[] {
															 580,
															 0,
															 0,
															 0});
			// 
			// n7
			// 
			this.n7.Location = new System.Drawing.Point(72, 40);
			this.n7.Name = "n7";
			this.n7.Size = new System.Drawing.Size(56, 20);
			this.n7.TabIndex = 5;
			this.n7.Value = new System.Decimal(new int[] {
															 40,
															 0,
															 0,
															 0});
			// 
			// n8
			// 
			this.n8.Location = new System.Drawing.Point(72, 16);
			this.n8.Name = "n8";
			this.n8.Size = new System.Drawing.Size(56, 20);
			this.n8.TabIndex = 4;
			this.n8.Value = new System.Decimal(new int[] {
															 30,
															 0,
															 0,
															 0});
			// 
			// ok2_btn
			// 
			this.ok2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ok2_btn.Location = new System.Drawing.Point(88, 144);
			this.ok2_btn.Name = "ok2_btn";
			this.ok2_btn.Size = new System.Drawing.Size(40, 23);
			this.ok2_btn.TabIndex = 3;
			this.ok2_btn.Text = "Ok";
			this.ok2_btn.Click += new System.EventHandler(this.ok2_btn_Click);
			// 
			// hide2_btn
			// 
			this.hide2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.hide2_btn.Location = new System.Drawing.Point(24, 144);
			this.hide2_btn.Name = "hide2_btn";
			this.hide2_btn.Size = new System.Drawing.Size(48, 23);
			this.hide2_btn.TabIndex = 10;
			this.hide2_btn.Text = "Hide";
			this.hide2_btn.Click += new System.EventHandler(this.hide2_btn_Click);
			// 
			// groupBall3
			// 
			this.groupBall3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBall3.Controls.Add(this.label15);
			this.groupBall3.Controls.Add(this.acc_three);
			this.groupBall3.Controls.Add(this.label9);
			this.groupBall3.Controls.Add(this.label10);
			this.groupBall3.Controls.Add(this.label11);
			this.groupBall3.Controls.Add(this.label12);
			this.groupBall3.Controls.Add(this.n9);
			this.groupBall3.Controls.Add(this.n10);
			this.groupBall3.Controls.Add(this.n11);
			this.groupBall3.Controls.Add(this.n12);
			this.groupBall3.Controls.Add(this.ok3_btn);
			this.groupBall3.Controls.Add(this.hide3_btn);
			this.groupBall3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.groupBall3.Location = new System.Drawing.Point(648, 372);
			this.groupBall3.Name = "groupBall3";
			this.groupBall3.Size = new System.Drawing.Size(144, 176);
			this.groupBall3.TabIndex = 10;
			this.groupBall3.TabStop = false;
			this.groupBall3.Text = "Ball 3";
			this.groupBall3.Visible = false;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label15.Location = new System.Drawing.Point(16, 112);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 15;
			this.label15.Text = "acc3";
			// 
			// acc_three
			// 
			this.acc_three.Location = new System.Drawing.Point(72, 112);
			this.acc_three.Maximum = new System.Decimal(new int[] {
																	  50,
																	  0,
																	  0,
																	  0});
			this.acc_three.Minimum = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  0});
			this.acc_three.Name = "acc_three";
			this.acc_three.Size = new System.Drawing.Size(56, 20);
			this.acc_three.TabIndex = 14;
			this.acc_three.Value = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	0});
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label9.Location = new System.Drawing.Point(16, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 11;
			this.label9.Text = "y pos";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label10.Location = new System.Drawing.Point(16, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "x pos";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label11.Location = new System.Drawing.Point(16, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 9;
			this.label11.Text = "y speed";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label12.Location = new System.Drawing.Point(16, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 8;
			this.label12.Text = "x speed";
			// 
			// n9
			// 
			this.n9.Location = new System.Drawing.Point(72, 88);
			this.n9.Maximum = new System.Decimal(new int[] {
															   509,
															   0,
															   0,
															   0});
			this.n9.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.n9.Name = "n9";
			this.n9.Size = new System.Drawing.Size(56, 20);
			this.n9.TabIndex = 7;
			this.n9.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			// 
			// n10
			// 
			this.n10.Location = new System.Drawing.Point(72, 64);
			this.n10.Maximum = new System.Decimal(new int[] {
																580,
																0,
																0,
																0});
			this.n10.Minimum = new System.Decimal(new int[] {
																1,
																0,
																0,
																0});
			this.n10.Name = "n10";
			this.n10.Size = new System.Drawing.Size(56, 20);
			this.n10.TabIndex = 6;
			this.n10.Value = new System.Decimal(new int[] {
															  1,
															  0,
															  0,
															  0});
			// 
			// n11
			// 
			this.n11.Location = new System.Drawing.Point(72, 40);
			this.n11.Name = "n11";
			this.n11.Size = new System.Drawing.Size(56, 20);
			this.n11.TabIndex = 5;
			// 
			// n12
			// 
			this.n12.Location = new System.Drawing.Point(72, 16);
			this.n12.Name = "n12";
			this.n12.Size = new System.Drawing.Size(56, 20);
			this.n12.TabIndex = 4;
			// 
			// ok3_btn
			// 
			this.ok3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ok3_btn.Location = new System.Drawing.Point(88, 144);
			this.ok3_btn.Name = "ok3_btn";
			this.ok3_btn.Size = new System.Drawing.Size(40, 23);
			this.ok3_btn.TabIndex = 3;
			this.ok3_btn.Text = "Ok";
			this.ok3_btn.Click += new System.EventHandler(this.ok3_btn_Click);
			// 
			// hide3_btn
			// 
			this.hide3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.hide3_btn.Location = new System.Drawing.Point(24, 144);
			this.hide3_btn.Name = "hide3_btn";
			this.hide3_btn.Size = new System.Drawing.Size(48, 23);
			this.hide3_btn.TabIndex = 10;
			this.hide3_btn.Text = "Hide";
			this.hide3_btn.Click += new System.EventHandler(this.hide3_btn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Brown;
			this.panel1.Location = new System.Drawing.Point(632, -24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(8, 600);
			this.panel1.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(792, 553);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBall3);
			this.Controls.Add(this.groupBall2);
			this.Controls.Add(this.groupBall1);
			this.Controls.Add(this.ball3);
			this.Controls.Add(this.ball2);
			this.Controls.Add(this.ball);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gravity and collision simulation";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
			this.groupBall1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.acc_one)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
			this.groupBall2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.acc_two)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n8)).EndInit();
			this.groupBall3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.acc_three)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n12)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			b1.play(ref xspeed,ref yspeed,ref newyspeed,ref startingypos,ref newxpos,ref newypos,ref oldxpos,ref oldypos,ref newx,ref oldx,ref newy,ref oldy,ref acc,ref t,ref xmouse,ref ymouse,ref dragging,ref trace,ref collisiony);
			ball.Left = (int)newxpos;
			ball.Top = (int)(ground - newypos);

			b2.play(ref xspeed2,ref yspeed2,ref newyspeed2,ref startingypos2,ref newxpos2,ref newypos2,ref oldxpos2,ref oldypos2,ref newx2,ref oldx2,ref newy2,ref oldy2,ref acc2,ref t2,ref xmouse2,ref ymouse2,ref dragging2,ref trace2,ref collisiony2);
			ball2.Left = (int)newxpos2;
			ball2.Top = (int)(ground - newypos2);

			b3.play(ref xspeed3,ref yspeed3,ref newyspeed3,ref startingypos3,ref newxpos3,ref newypos3,ref oldxpos3,ref oldypos3,ref newx3,ref oldx3,ref newy3,ref oldy3,ref acc3,ref t3,ref xmouse3,ref ymouse3,ref dragging3,ref trace3,ref collisiony3);
			ball3.Left = (int)newxpos3;
			ball3.Top = (int)(ground - newypos3);

			Collision();
		}

		private void Collision()
		{
			#region ball and ball2
			// ball hits ball2 from the right, and we don't know the direction of ball2 nor ball
			if(((ball.Right > ball2.Left && ball.Right < ball2.Right) && ((ball.Top >= ball2.Top && ball.Top <= ball2.Bottom) || (ball.Top <= ball2.Top && ball.Bottom >= ball2.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that they have the same mass -> xspeed + xspeed2 = xspeed` + xspeed2`

				if(Math.Abs(xspeed) < 0.5 && Math.Abs(xspeed) >= 0)
					xspeed = xspeed2;
				else if(xspeed > 0 )
					xspeed *= -0.9;
				else
					xspeed *= 1.35;
				
				if(Math.Abs(xspeed2) < 0.5 && Math.Abs(xspeed2) >= 0)
					xspeed2 = xspeed;
				else if(xspeed2 > 0 )	
					xspeed2 *= 1.35;
				else
					xspeed2 *= -0.9;
			}

			// ball hits ball2 from the left, and we don't know the direction of ball2 nor ball
			if(((ball.Left > ball2.Left && ball.Left < ball2.Right) && ((ball.Top >= ball2.Top && ball.Top <= ball2.Bottom) || (ball.Top <= ball2.Top && ball.Bottom >= ball2.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed2 = xspeed` + xspeed2`

				if(Math.Abs(xspeed) < 0.5 && Math.Abs(xspeed) >= 0)
					xspeed = xspeed2;
				else if(xspeed < 0)
					xspeed *= -0.9;
				else
					xspeed *= 1.35;
				
				if(Math.Abs(xspeed2) < 0.5 && Math.Abs(xspeed2) >= 0)
					xspeed2 = xspeed;
				else if(xspeed2 < 0 )	
					xspeed2 *= 1.35;
				else
					xspeed2 *= -0.9;
			}
			#endregion ball and ball2

			#region ball and ball3
			// ball hits ball3 from the right, and we don't know the direction of ball3 nor ball
			if(((ball.Right > ball3.Left && ball.Right < ball3.Right) && ((ball.Top >= ball3.Top && ball.Top <= ball3.Bottom) || (ball.Top <= ball3.Top && ball.Bottom >= ball3.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

				if(Math.Abs(xspeed) < 0.5 && Math.Abs(xspeed) >= 0)
					xspeed = xspeed3;
				else if(xspeed > 0)
					xspeed *= -0.9;
				else
					xspeed *= 1.35;
				
				if(Math.Abs(xspeed3) < 0.5 && Math.Abs(xspeed3) >= 0)
					xspeed3 = xspeed;
				else if(xspeed3 > 0 )	
					xspeed3 *= 1.35;
				else
					xspeed3 *= -0.9;
			}

			// ball hits ball3 from the left, and we don't know the direction of ball3 nor ball
			if(((ball.Left > ball3.Left && ball.Left < ball3.Right) && ((ball.Top >= ball3.Top && ball.Top <= ball3.Bottom) || (ball.Top <= ball3.Top && ball.Bottom >= ball3.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

				if(Math.Abs(xspeed) < 0.5 && Math.Abs(xspeed) >= 0)
					xspeed = xspeed3;
				else if(xspeed < 0)
					xspeed *= -0.9;
				else
					xspeed *= 1.35;
				
				if(Math.Abs(xspeed3) < 0.5 && Math.Abs(xspeed3) >= 0)
					xspeed3 = xspeed;
				else if(xspeed3 < 0 )	
					xspeed3 *= 1.35;
				else
					xspeed3 *= -0.9;
			}
			#endregion ball and ball3

			#region ball2 and ball3
			// ball2 hits ball3 from the right, and we don't know the direction of ball3 nor ball2
			if(((ball2.Right > ball3.Left && ball2.Right < ball3.Right) && ((ball2.Top >= ball3.Top && ball2.Top <= ball3.Bottom) || (ball2.Top <= ball3.Top && ball2.Bottom >= ball3.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

				if(Math.Abs(xspeed2) < 0.5 && Math.Abs(xspeed2) >= 0)
					xspeed2 = xspeed3;
				else if(xspeed2 > 0)
					xspeed2 *= -0.9;
				else
					xspeed2 *= 1.35;
				
				if(Math.Abs(xspeed3) < 0.5 && Math.Abs(xspeed3) >= 0)
					xspeed3 = xspeed2;
				else if(xspeed3 > 0 )	
					xspeed3 *= 1.35;
				else
					xspeed3 *= -0.9;
			}

			// ball2 hits ball3 from the left, and we don't know the direction of ball3 nor ball2
			if(((ball2.Left > ball3.Left && ball2.Left < ball3.Right) && ((ball2.Top >= ball3.Top && ball2.Top <= ball3.Bottom) || (ball2.Top <= ball3.Top && ball2.Bottom >= ball3.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

				if(Math.Abs(xspeed2) < 0.5 && Math.Abs(xspeed2) >= 0)
					xspeed2 = xspeed3;
				else if(xspeed2 < 0)
					xspeed2 *= -0.9;
				else
					xspeed2 *= 1.35;
				
				if(Math.Abs(xspeed3) < 0.5 && Math.Abs(xspeed3) >= 0)
					xspeed3 = xspeed2;
				else if(xspeed3 < 0 )	
					xspeed3 *= 1.35;
				else
					xspeed3 *= -0.9;
			}
			#endregion ball2 and ball3
		}
		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//sw = new StreamWriter("trace.txt");
			t = t2 = t3= 0;
			acc = acc2 = acc3 = 10;
			// Hide the balls
			newxpos2 = newxpos3 = 2000;
			newypos2 = newypos3 = 2000;

		}


		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Pick a ball randomly
			// Random rnd = new Random(DateTime.Now.Second);
			// Choice = rnd.Next(1,numberofballs);

			if(numberofballs == 1)
				choice = 1;
			else if(numberofballs == 2)
				choice = (choice == 1)? 2: 1;
			else	// 3 balls available
			{
				if(choice == 1)
					choice = 2;
				else if(choice == 2)
					choice = 3;
				else
					choice = 1;
			}
			

			switch(choice)
			{
				case 1:
					dragging = true;
					newxpos  = e.X;
					newypos  = e.Y;
					xmouse = e.X;
					ymouse = e.Y;
					break;
				case 2:
					dragging2 = true;
					newxpos2  = e.X;
					newypos2  = e.Y;
					xmouse2 = e.X;
					ymouse2 = e.Y;
					break;
				case 3:
					dragging3 = true;
					newxpos3  = e.X;
					newypos3  = e.Y;
					xmouse3 = e.X;
					ymouse3 = e.Y;
					break;
			}
		}


		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
					dragging = false;
					break;
				case 2:
					dragging2 = false;
					break;
				case 3:
					dragging3 = false;
					break;
			}
		}

		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
					xmouse = e.X;
					ymouse = e.Y;
					break;
				case 2:
					xmouse2 = e.X;
					ymouse2 = e.Y;
					break;
				case 3:
					xmouse3 = e.X;
					ymouse3 = e.Y;
					break;
			}
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if(numberofballs != 3)
				numberofballs++;
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			//trace = !trace;
			//Form1.ActiveForm.Refresh();
		}

		private void hide1_btn_Click(object sender, System.EventArgs e)
		{
			groupBall1.Visible=false;
		}

		private void hide2_btn_Click(object sender, System.EventArgs e)
		{
			groupBall2.Visible=false;
		}

		private void hide3_btn_Click(object sender, System.EventArgs e)
		{
			groupBall3.Visible=false;
		}

		private void ok1_btn_Click(object sender, System.EventArgs e)
		{
			xspeed = (double)n1.Value;
			yspeed = (double)n2.Value;
			newxpos =   (double)n3.Value;
		    newypos =   (double)n4.Value;
			acc = (double)acc_one.Value;
		    dragging=false;
		}

		private void ok2_btn_Click(object sender, System.EventArgs e)
		{
		
			xspeed2 = (double)n8.Value;
			yspeed2 = (double)n7.Value;
			newxpos2 =   (double)n6.Value;
			newypos2 =   (double)n5.Value;
			acc2 = (double)acc_two.Value;
			dragging=false;
		}

		private void ok3_btn_Click(object sender, System.EventArgs e)
		{
		
			xspeed3 = (double)n12.Value;
			yspeed3 = (double)n11.Value;
			newxpos3 =   (double)n10.Value;
			newypos3 =   (double)n9.Value;
			acc3 = (double)acc_three.Value;
			dragging=false;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			groupBall1.Visible = true;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		    if(1 < numberofballs)
			groupBall2.Visible = true;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if(2 < numberofballs)
			groupBall3.Visible = true;
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			timer.Interval *= 0.5;
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			timer.Interval *= 2;
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this,"This demo is programed by:\n\nSouhieb N. Rawashdeh\nsouhieb@yahoo.com","About");
		}

	}

	public class Ballinstance
	{
		int xpos,ypos;
		const int ground = 500;

		public Ballinstance()
		{
		}
		

		public void play(ref double xspeed,ref double yspeed,ref double newyspeed,ref double startingypos,ref double newxpos,ref double newypos,ref double oldxpos,ref double oldypos,ref double newx,ref double oldx,ref double newy,ref double oldy,ref double acc,ref double t,ref int xmouse,ref int ymouse,ref bool dragging,ref bool trace,ref bool collisiony)
		{

			xpos = (int)newxpos;
			ypos = (int)newypos;
		
			// This code will be visited 50 times per second while dragging
			if (dragging) 
			{
				// Grip the center of the ball when dragging
				xpos = xmouse;
				ypos = ymouse;

				// While dragging the starting y-axis position of the ball is ball.Top
				startingypos = ground - ypos;

				// Calculate the x and y speed based on the mouse movement within 20 msec
				// speed = distance/time  ->  time = 20 millisecond
				// the speed is the change in the displacement with respect to time which
				// is already running (the code is within the timer), so we don't have to divide 
				// by time.
				newx = xpos;
				newy = ground - ypos;
				xspeed = (newx-oldx)/1;
				yspeed = (newy-oldy)/1;
				oldx = newx;
				oldy = newy;

				// The time -while dragging- will not start yet
				t=0;
	
			} 
			else 
			{
				/*if(trace)
				{
					Size s = new Size(6,6);
					Point p = new Point(ball.Right,ball.Bottom);
					Rectangle r = new Rectangle(p,s);
					Pen pen = new Pen(Color.Blue,1);
					Graphics graphics = CreateGraphics();
					graphics.DrawRectangle(pen,r);
				}*/

				// This code will be visited 50 times per second while not dragging
				// The ball position is where it's last dragged
				oldxpos = xpos;
				// X-axis motion
				if(xpos < 580 && 0 < xpos)
				{
					newxpos = oldxpos + xspeed;
				} 
				else 
				{
					// Here the ball will hits the wall
					// Ball xspeed will decrease every time it hits the wall
					// Minus sign: to change the ball direction when it collides with the wall
					xspeed *= -0.9;	// Wall resistance	
					newxpos = oldxpos + xspeed;
				}
		
				// Y-axis motion
				if(0 < newypos || collisiony)
				{				 
					newyspeed = yspeed - (acc*t);
					newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
					collisiony = false;
				} 
				else 
				{
					// Here the ball will hits the ground
					// Initialize the ball variables again
					startingypos = -1;	
					// Here set startingypos=-1 not 0, because if 0 newypos will be 0 every time the ball 
					// Hits the ground so no bouncing will happens to the ball, evaluate to the 
					// eguation below for newypos when t = 0
					t = 0;
					// Ball yspeed will decrease every time it hits the ground
					// 0.75 is the elasticity coefficient - assumption
					// The initial speed(yspeed) is 0.75 of the final speed(newyspeed)
					yspeed = newyspeed * -0.75;
					newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
					collisiony = true;
				}
				// Always
				// Ball xspeed will always decrease, even if it didn't hit the wall
				xspeed *= 0.99;	// Air resistance

				if(xspeed > -0.5 && xspeed < 0)
					xspeed = 0;
				
				#region Explination of xspeed condition above
				// This condition is to stop the ball when it heading to the left, you can notice that removeing
				// this condition will make the ball never stop while its heading to the left until it will
				// hit the left wall, to know why, run the simulation under the debuging mode and watch
				// the value of newxpos
				// newxpos = oldxpos + xspeed
				// when 0 < xspeed < 1 (the ball heading right), ball.left = (int)newxpos, the casting 
				// forces the ball left position value to be the same as its previous value, because oldxpos and newxpos are equals, and hence the ball will stop.
				// but when -1 < xspeed < 0 (the ball heading left), ball.left = (int)newxpos, the casting
				// here will not work correctly, because the value of oldxpos(which is integer value see line 185) will always 
				// be decremented by the xspeed, this will force the newxpos also to be always decremented by xspeed and hence
				// ball.left will always decremented by 1 (int) casting, and hence the ball will never stop.
				#endregion

				// Update the ball position
				xpos = (int)newxpos;
				ypos = (int)(ground - newypos);
				// Increase the time
				t += 0.3;
			}
		}

}
}
