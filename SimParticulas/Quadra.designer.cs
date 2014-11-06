using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gravity_Simulation
{
    partial class Quadra
    {

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
        private System.Windows.Forms.NumericUpDown n5;
        private System.Windows.Forms.NumericUpDown n6;
        private System.Windows.Forms.NumericUpDown n7;
        private System.Windows.Forms.NumericUpDown n8;
        private System.Windows.Forms.NumericUpDown n9;
        private System.Windows.Forms.NumericUpDown n10;
        private System.Windows.Forms.NumericUpDown n11;
        private System.Windows.Forms.NumericUpDown n12;
        private System.Windows.Forms.MenuItem menuItem9;
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
        private System.Windows.Forms.Button hide1_btn;
        private System.Windows.Forms.Button hide2_btn;
        private System.Windows.Forms.Button hide3_btn;
        private System.Windows.Forms.Button ok1_btn;
        private System.Windows.Forms.Button ok2_btn;
        private System.Windows.Forms.Button ok3_btn;
        private System.ComponentModel.IContainer components;

        		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadra));
            this.timer = new System.Timers.Timer();
            this.ball = new System.Windows.Forms.PictureBox();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
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
            this.groupBall1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.acc_one = new System.Windows.Forms.NumericUpDown();
            this.hide1_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.n1 = new System.Windows.Forms.TrackBar();
            this.n2 = new System.Windows.Forms.TrackBar();
            this.n3 = new System.Windows.Forms.TrackBar();
            this.n4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            this.groupBall1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_one)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20D;
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
            this.ball2.Location = new System.Drawing.Point(322, 240);
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
            this.ball3.Location = new System.Drawing.Point(429, 188);
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
            this.menuItem5});
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
            // groupBall1
            // 
            this.groupBall1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBall1.Controls.Add(this.n4);
            this.groupBall1.Controls.Add(this.n3);
            this.groupBall1.Controls.Add(this.n2);
            this.groupBall1.Controls.Add(this.n1);
            this.groupBall1.Controls.Add(this.label13);
            this.groupBall1.Controls.Add(this.acc_one);
            this.groupBall1.Controls.Add(this.hide1_btn);
            this.groupBall1.Controls.Add(this.label4);
            this.groupBall1.Controls.Add(this.label3);
            this.groupBall1.Controls.Add(this.label2);
            this.groupBall1.Controls.Add(this.label1);
            this.groupBall1.Controls.Add(this.ok1_btn);
            this.groupBall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBall1.Location = new System.Drawing.Point(670, 6);
            this.groupBall1.Name = "groupBall1";
            this.groupBall1.Size = new System.Drawing.Size(401, 327);
            this.groupBall1.TabIndex = 8;
            this.groupBall1.TabStop = false;
            this.groupBall1.Text = "Ball 1";
            this.groupBall1.Visible = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(16, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "acc1";
            // 
            // acc_one
            // 
            this.acc_one.Location = new System.Drawing.Point(84, 213);
            this.acc_one.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.acc_one.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_one.Name = "acc_one";
            this.acc_one.Size = new System.Drawing.Size(56, 20);
            this.acc_one.TabIndex = 13;
            this.acc_one.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // hide1_btn
            // 
            this.hide1_btn.Location = new System.Drawing.Point(14, 271);
            this.hide1_btn.Name = "hide1_btn";
            this.hide1_btn.Size = new System.Drawing.Size(48, 23);
            this.hide1_btn.TabIndex = 12;
            this.hide1_btn.Text = "Hide";
            this.hide1_btn.Click += new System.EventHandler(this.hide1_btn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "y pos";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "x pos";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "y speed";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "x speed";
            // 
            // ok1_btn
            // 
            this.ok1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ok1_btn.Location = new System.Drawing.Point(100, 268);
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
            this.groupBall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBall2.Location = new System.Drawing.Point(651, 370);
            this.groupBall2.Name = "groupBall2";
            this.groupBall2.Size = new System.Drawing.Size(144, 176);
            this.groupBall2.TabIndex = 9;
            this.groupBall2.TabStop = false;
            this.groupBall2.Text = "Ball 2";
            this.groupBall2.Visible = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(16, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "acc2";
            // 
            // acc_two
            // 
            this.acc_two.Location = new System.Drawing.Point(72, 112);
            this.acc_two.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.acc_two.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_two.Name = "acc_two";
            this.acc_two.Size = new System.Drawing.Size(56, 20);
            this.acc_two.TabIndex = 12;
            this.acc_two.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "y pos";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "x pos";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(16, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "y speed";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "x speed";
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(72, 88);
            this.n5.Maximum = new decimal(new int[] {
            509,
            0,
            0,
            0});
            this.n5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(56, 20);
            this.n5.TabIndex = 7;
            this.n5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(72, 64);
            this.n6.Maximum = new decimal(new int[] {
            580,
            0,
            0,
            0});
            this.n6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(56, 20);
            this.n6.TabIndex = 6;
            this.n6.Value = new decimal(new int[] {
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
            this.n7.Value = new decimal(new int[] {
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
            this.n8.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ok2_btn
            // 
            this.ok2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ok2_btn.Location = new System.Drawing.Point(88, 144);
            this.ok2_btn.Name = "ok2_btn";
            this.ok2_btn.Size = new System.Drawing.Size(40, 23);
            this.ok2_btn.TabIndex = 3;
            this.ok2_btn.Text = "Ok";
            this.ok2_btn.Click += new System.EventHandler(this.ok2_btn_Click);
            // 
            // hide2_btn
            // 
            this.hide2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.groupBall3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBall3.Location = new System.Drawing.Point(927, 370);
            this.groupBall3.Name = "groupBall3";
            this.groupBall3.Size = new System.Drawing.Size(144, 176);
            this.groupBall3.TabIndex = 10;
            this.groupBall3.TabStop = false;
            this.groupBall3.Text = "Ball 3";
            this.groupBall3.Visible = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(16, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "acc3";
            // 
            // acc_three
            // 
            this.acc_three.Location = new System.Drawing.Point(72, 112);
            this.acc_three.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.acc_three.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_three.Name = "acc_three";
            this.acc_three.Size = new System.Drawing.Size(56, 20);
            this.acc_three.TabIndex = 14;
            this.acc_three.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(16, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "y pos";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(16, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "x pos";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(16, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "y speed";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "x speed";
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(72, 88);
            this.n9.Maximum = new decimal(new int[] {
            509,
            0,
            0,
            0});
            this.n9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(56, 20);
            this.n9.TabIndex = 7;
            this.n9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n10
            // 
            this.n10.Location = new System.Drawing.Point(72, 64);
            this.n10.Maximum = new decimal(new int[] {
            580,
            0,
            0,
            0});
            this.n10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n10.Name = "n10";
            this.n10.Size = new System.Drawing.Size(56, 20);
            this.n10.TabIndex = 6;
            this.n10.Value = new decimal(new int[] {
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
            this.ok3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ok3_btn.Location = new System.Drawing.Point(88, 144);
            this.ok3_btn.Name = "ok3_btn";
            this.ok3_btn.Size = new System.Drawing.Size(40, 23);
            this.ok3_btn.TabIndex = 3;
            this.ok3_btn.Text = "Ok";
            this.ok3_btn.Click += new System.EventHandler(this.ok3_btn_Click);
            // 
            // hide3_btn
            // 
            this.hide3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            // n1
            // 
            this.n1.LargeChange = 10;
            this.n1.Location = new System.Drawing.Point(78, 16);
            this.n1.Maximum = 100;
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(304, 45);
            this.n1.SmallChange = 10;
            this.n1.TabIndex = 15;
            this.n1.TickFrequency = 10;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(78, 55);
            this.n2.Maximum = 100;
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(304, 45);
            this.n2.SmallChange = 10;
            this.n2.TabIndex = 16;
            this.n2.TickFrequency = 10;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(78, 107);
            this.n3.Maximum = 580;
            this.n3.Minimum = 1;
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(304, 45);
            this.n3.SmallChange = 20;
            this.n3.TabIndex = 17;
            this.n3.TickFrequency = 20;
            this.n3.Value = 1;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(78, 158);
            this.n4.Maximum = 509;
            this.n4.Minimum = 1;
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(304, 45);
            this.n4.SmallChange = 20;
            this.n4.TabIndex = 18;
            this.n4.TickFrequency = 20;
            this.n4.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1083, 553);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            this.groupBall1.ResumeLayout(false);
            this.groupBall1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_one)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n4)).EndInit();
            this.ResumeLayout(false);

		}

                public Quadra()
                {
                    //
                    // Required for Windows Form Designer support
                    //
                    InitializeComponent();

                    //
                    // TODO: Add any constructor code after InitializeComponent call
                    //
                }

                protected override void Dispose(bool disposing)
                {
                    if (disposing)
                    {
                        if (components != null)
                        {
                            components.Dispose();
                        }
                    }
                    base.Dispose(disposing);
                }

                private System.Windows.Forms.TrackBar n1;
                private System.Windows.Forms.TrackBar n4;
                private System.Windows.Forms.TrackBar n3;
                private System.Windows.Forms.TrackBar n2;

    }
}
