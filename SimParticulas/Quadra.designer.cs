using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gravity_Simulation
{
    partial class Quadra
    {
        private System.Timers.Timer timer;
        private System.Windows.Forms.MainMenu mainMenu;

        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemToolBox1;
        private System.Windows.Forms.MenuItem menuItemToolBox2;
        private System.Windows.Forms.MenuItem menuItemToolBox3;
        private System.Windows.Forms.MenuItem menuItemExit;

        private System.Windows.Forms.MenuItem menuItemOptions;
        private System.Windows.Forms.MenuItem menuItemAddBall;
        private System.Windows.Forms.MenuItem menuItemTempoMore;
        private System.Windows.Forms.MenuItem menuItemTempoLess;

        private System.Windows.Forms.Label label1x_spd;
        private System.Windows.Forms.Label label1y_spd;
        private System.Windows.Forms.Label label1x_pos;
        private System.Windows.Forms.Label label1y_pos;
        private System.Windows.Forms.Label label2y_pos;
        private System.Windows.Forms.Label label2x_pos;
        private System.Windows.Forms.Label label2y_spd;
        private System.Windows.Forms.Label label2x_spd;
        private System.Windows.Forms.Label label3y_pos;
        private System.Windows.Forms.Label label3x_pos;
        private System.Windows.Forms.Label label3y_spd;
        private System.Windows.Forms.Label label3x_spd;
        private System.Windows.Forms.Label label1acc;
        private System.Windows.Forms.Label label2acc;
        private System.Windows.Forms.Label label3acc;
        private System.Windows.Forms.GroupBox groupBall1;
        private System.Windows.Forms.GroupBox groupBall2;
        private System.Windows.Forms.GroupBox groupBall3;
        private System.Windows.Forms.TrackBar Bar_xspd;
        private System.Windows.Forms.TrackBar Bar_yspd;
        private System.Windows.Forms.TrackBar Bar_xpos;
        private System.Windows.Forms.TrackBar Bar_ypos;
        private System.Windows.Forms.NumericUpDown n5;
        private System.Windows.Forms.NumericUpDown n6;
        private System.Windows.Forms.NumericUpDown n7;
        private System.Windows.Forms.NumericUpDown n8;
        private System.Windows.Forms.NumericUpDown n9;
        private System.Windows.Forms.NumericUpDown n10;
        private System.Windows.Forms.NumericUpDown n11;
        private System.Windows.Forms.NumericUpDown n12;
        private System.Windows.Forms.NumericUpDown acc_one;
        private System.Windows.Forms.NumericUpDown acc_two;
        private System.Windows.Forms.NumericUpDown acc_three;
        private System.Windows.Forms.Button hide1_btn;
        private System.Windows.Forms.Button hide2_btn;
        private System.Windows.Forms.Button hide3_btn;
        private System.Windows.Forms.Button ok1_btn;
        private System.Windows.Forms.Button ok2_btn;
        private System.Windows.Forms.Button ok3_btn;
        private System.Windows.Forms.Panel wall;
        private System.ComponentModel.IContainer components;



        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadra));
            this.timer = new System.Timers.Timer();

            this.mainMenu           = new System.Windows.Forms.MainMenu(this.components);

            this.menuItemView       = new System.Windows.Forms.MenuItem();
            this.menuItemToolBox1   = new System.Windows.Forms.MenuItem();
            this.menuItemToolBox2   = new System.Windows.Forms.MenuItem();
            this.menuItemToolBox3   = new System.Windows.Forms.MenuItem();
            this.menuItemExit       = new System.Windows.Forms.MenuItem();

            this.menuItemOptions    = new System.Windows.Forms.MenuItem();
            this.menuItemAddBall    = new System.Windows.Forms.MenuItem();
            this.menuItemTempoMore  = new System.Windows.Forms.MenuItem();
            this.menuItemTempoLess  = new System.Windows.Forms.MenuItem();

            this.groupBall1 = new System.Windows.Forms.GroupBox();
            this.acc_one    = new System.Windows.Forms.NumericUpDown();
            this.hide1_btn  = new System.Windows.Forms.Button();
            this.ok1_btn    = new System.Windows.Forms.Button();
            this.label1acc      = new System.Windows.Forms.Label();
            this.label1y_pos    = new System.Windows.Forms.Label();
            this.label1x_pos    = new System.Windows.Forms.Label();
            this.label1y_spd    = new System.Windows.Forms.Label();
            this.label1x_spd    = new System.Windows.Forms.Label();
            this.Bar_xspd = new System.Windows.Forms.TrackBar();
            this.Bar_yspd = new System.Windows.Forms.TrackBar();
            this.Bar_xpos = new System.Windows.Forms.TrackBar();
            this.Bar_ypos = new System.Windows.Forms.TrackBar();

            this.groupBall2 = new System.Windows.Forms.GroupBox();
            this.acc_two    = new System.Windows.Forms.NumericUpDown();
            this.hide2_btn  = new System.Windows.Forms.Button();
            this.ok2_btn    = new System.Windows.Forms.Button();
            this.label2acc      = new System.Windows.Forms.Label();
            this.label2y_pos    = new System.Windows.Forms.Label();
            this.label2x_pos    = new System.Windows.Forms.Label();
            this.label2y_spd    = new System.Windows.Forms.Label();
            this.label2x_spd    = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.NumericUpDown();
            this.n6 = new System.Windows.Forms.NumericUpDown();
            this.n7 = new System.Windows.Forms.NumericUpDown();
            this.n8 = new System.Windows.Forms.NumericUpDown();

            this.groupBall3 = new System.Windows.Forms.GroupBox();
            this.acc_three  = new System.Windows.Forms.NumericUpDown();
            this.ok3_btn    = new System.Windows.Forms.Button();
            this.hide3_btn  = new System.Windows.Forms.Button();
            this.label3acc      = new System.Windows.Forms.Label();
            this.label3y_pos    = new System.Windows.Forms.Label();
            this.label3x_pos    = new System.Windows.Forms.Label();
            this.label3y_spd    = new System.Windows.Forms.Label();
            this.label3x_spd    = new System.Windows.Forms.Label();
            this.n9 = new System.Windows.Forms.NumericUpDown();
            this.n10 = new System.Windows.Forms.NumericUpDown();
            this.n11 = new System.Windows.Forms.NumericUpDown();
            this.n12 = new System.Windows.Forms.NumericUpDown();

            this.wall = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();

            this.groupBall1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_xspd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_yspd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_xpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ypos)).BeginInit();

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
            this.timer.Interval = 20D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // ball
            // 
            b1.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            // 
            // ball2
            // 
            b2.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
            // 
            // ball3
            // 
            b3.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball3.Image")));
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItemView,
                                                                                    this.menuItemOptions});
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 0;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItemToolBox1,
                                                                                    this.menuItemToolBox2,
                                                                                    this.menuItemToolBox3,
                                                                                    this.menuItemExit});
            this.menuItemView.Text = "&View";
            // 
            // menuItemToolBox1
            // 
            this.menuItemToolBox1.Index = 0;
            this.menuItemToolBox1.Text = "Ball1 ToolBox";
            this.menuItemToolBox1.Click += new System.EventHandler(this.menuItemShowToolBox1_Click);
            // 
            // menuItemToolBox2
            // 
            this.menuItemToolBox2.Index = 1;
            this.menuItemToolBox2.Text = "Ball2 ToolBox";
            this.menuItemToolBox2.Click += new System.EventHandler(this.menuItemShowToolBox2_Click);
            // 
            // menuItemToolBox3
            // 
            this.menuItemToolBox3.Index = 2;
            this.menuItemToolBox3.Text = "Ball3 ToolBox";
            this.menuItemToolBox3.Click += new System.EventHandler(this.menuItemShowToolBox3_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.Index = 1;
            this.menuItemOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItemAddBall,
                                                                                    this.menuItemTempoMore,
                                                                                    this.menuItemTempoLess});
            this.menuItemOptions.Text = "&Options";
            // 
            // menuItemAddBall
            // 
            this.menuItemAddBall.Index = 0;
            this.menuItemAddBall.Text = "Add ball";
            this.menuItemAddBall.Click += new System.EventHandler(this.menuItemAddBall_Click);
            // 
            // menuItemTempoMore
            // 
            this.menuItemTempoMore.Index = 1;
            this.menuItemTempoMore.Text = "Tempo ++";
            this.menuItemTempoMore.Click += new System.EventHandler(this.menuItemTempoMore_Click);
            // 
            // menuItemTempoLess
            // 
            this.menuItemTempoLess.Index = 2;
            this.menuItemTempoLess.Text = "Tempo --";
            this.menuItemTempoLess.Click += new System.EventHandler(this.menuItemTempoLess_Click);
            
            // 
            // groupBall1
            // 
            this.groupBall1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBall1.Controls.Add(this.Bar_xspd);
            this.groupBall1.Controls.Add(this.Bar_yspd);
            this.groupBall1.Controls.Add(this.Bar_xpos);
            this.groupBall1.Controls.Add(this.Bar_ypos);
            this.groupBall1.Controls.Add(this.acc_one);
            this.groupBall1.Controls.Add(this.hide1_btn);
            this.groupBall1.Controls.Add(this.label1x_spd);
            this.groupBall1.Controls.Add(this.label1y_spd);
            this.groupBall1.Controls.Add(this.label1x_pos);
            this.groupBall1.Controls.Add(this.label1y_pos);
            this.groupBall1.Controls.Add(this.label1acc);
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
            // acc_one
            // 
            this.acc_one.Location = new System.Drawing.Point(84, 213);
            this.acc_one.Maximum = new decimal(new int[] {50,0,0,0});
            this.acc_one.Minimum = new decimal(new int[] {1,0,0,0});
            this.acc_one.Name = "acc_one";
            this.acc_one.Size = new System.Drawing.Size(56, 20);
            this.acc_one.TabIndex = 13;
            this.acc_one.Value = new decimal(new int[] {10,0,0,0});
            // 
            // hide1_btn
            // 
            this.hide1_btn.Location = new System.Drawing.Point(14, 271);
            this.hide1_btn.Name = "hide1_btn";
            this.hide1_btn.Size = new System.Drawing.Size(48, 23);
            this.hide1_btn.TabIndex = 12;
            this.hide1_btn.Text = "Hide";
            this.hide1_btn.Click += new System.EventHandler(this.hideToolBox1_Click);
            // 
            // label1acc
            // 
            this.label1acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1acc.Location = new System.Drawing.Point(16, 215);
            this.label1acc.Name = "label13";
            this.label1acc.Size = new System.Drawing.Size(56, 23);
            this.label1acc.TabIndex = 14;
            this.label1acc.Text = "acc1";
            // 
            // label1y_pos
            // 
            this.label1y_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1y_pos.Location = new System.Drawing.Point(16, 158);
            this.label1y_pos.Name = "label4";
            this.label1y_pos.Size = new System.Drawing.Size(56, 23);
            this.label1y_pos.TabIndex = 11;
            this.label1y_pos.Text = "y pos";
            // 
            // label1x_pos
            // 
            this.label1x_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1x_pos.Location = new System.Drawing.Point(16, 103);
            this.label1x_pos.Name = "label3";
            this.label1x_pos.Size = new System.Drawing.Size(56, 23);
            this.label1x_pos.TabIndex = 10;
            this.label1x_pos.Text = "x pos";
            // 
            // label1y_spd
            // 
            this.label1y_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1y_spd.Location = new System.Drawing.Point(16, 58);
            this.label1y_spd.Name = "label2";
            this.label1y_spd.Size = new System.Drawing.Size(56, 23);
            this.label1y_spd.TabIndex = 9;
            this.label1y_spd.Text = "y speed";
            // 
            // label1x_spd
            // 
            this.label1x_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1x_spd.Location = new System.Drawing.Point(16, 16);
            this.label1x_spd.Name = "label1";
            this.label1x_spd.Size = new System.Drawing.Size(56, 23);
            this.label1x_spd.TabIndex = 8;
            this.label1x_spd.Text = "x speed";
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
            //------END groupBall1------
            
            // 
            // groupBall2
            // 
            this.groupBall2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBall2.Controls.Add(this.label2acc);
            this.groupBall2.Controls.Add(this.acc_two);
            this.groupBall2.Controls.Add(this.label2y_pos);
            this.groupBall2.Controls.Add(this.label2x_pos);
            this.groupBall2.Controls.Add(this.label2y_spd);
            this.groupBall2.Controls.Add(this.label2x_spd);
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
            // label2acc
            // 
            this.label2acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2acc.Location = new System.Drawing.Point(16, 112);
            this.label2acc.Name = "label14";
            this.label2acc.Size = new System.Drawing.Size(56, 23);
            this.label2acc.TabIndex = 13;
            this.label2acc.Text = "acc2";
            // 
            // acc_two
            // 
            this.acc_two.Location = new System.Drawing.Point(72, 112);
            this.acc_two.Maximum = new decimal(new int[] {50,0,0,0});
            this.acc_two.Minimum = new decimal(new int[] {1,0,0,0});
            this.acc_two.Name = "acc_two";
            this.acc_two.Size = new System.Drawing.Size(56, 20);
            this.acc_two.TabIndex = 12;
            this.acc_two.Value = new decimal(new int[] {10,0,0,0});
            // 
            // label2y_pos
            // 
            this.label2y_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2y_pos.Location = new System.Drawing.Point(16, 88);
            this.label2y_pos.Name = "label5";
            this.label2y_pos.Size = new System.Drawing.Size(56, 23);
            this.label2y_pos.TabIndex = 11;
            this.label2y_pos.Text = "y pos";
            // 
            // label2x_pos
            // 
            this.label2x_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2x_pos.Location = new System.Drawing.Point(16, 64);
            this.label2x_pos.Name = "label6";
            this.label2x_pos.Size = new System.Drawing.Size(56, 23);
            this.label2x_pos.TabIndex = 10;
            this.label2x_pos.Text = "x pos";
            // 
            // label2y_spd
            // 
            this.label2y_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2y_spd.Location = new System.Drawing.Point(16, 40);
            this.label2y_spd.Name = "label7";
            this.label2y_spd.Size = new System.Drawing.Size(56, 23);
            this.label2y_spd.TabIndex = 9;
            this.label2y_spd.Text = "y speed";
            // 
            // label8
            // 
            this.label2x_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2x_spd.Location = new System.Drawing.Point(16, 16);
            this.label2x_spd.Name = "label8";
            this.label2x_spd.Size = new System.Drawing.Size(56, 23);
            this.label2x_spd.TabIndex = 8;
            this.label2x_spd.Text = "x speed";
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(72, 88);
            this.n5.Maximum = new decimal(new int[] {509,0,0,0});
            this.n5.Minimum = new decimal(new int[] {1,0,0,0});
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(56, 20);
            this.n5.TabIndex = 7;
            this.n5.Value = new decimal(new int[] {1,0,0,0});
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(72, 64);
            this.n6.Maximum = new decimal(new int[] {580,0,0,0});
            this.n6.Minimum = new decimal(new int[] {1,0,0,0});
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(56, 20);
            this.n6.TabIndex = 6;
            this.n6.Value = new decimal(new int[] {580,0,0,0});
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(72, 40);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(56, 20);
            this.n7.TabIndex = 5;
            this.n7.Value = new decimal(new int[] {40,0,0,0});
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(72, 16);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(56, 20);
            this.n8.TabIndex = 4;
            this.n8.Value = new decimal(new int[] {30,0,0,0});
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
            this.hide2_btn.Click += new System.EventHandler(this.hideToolBox2_Click);
            //------END groupBall2------

            // 
            // groupBall3
            // 
            this.groupBall3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBall3.Controls.Add(this.label3acc);
            this.groupBall3.Controls.Add(this.acc_three);
            this.groupBall3.Controls.Add(this.label3y_pos);
            this.groupBall3.Controls.Add(this.label3x_pos);
            this.groupBall3.Controls.Add(this.label3y_spd);
            this.groupBall3.Controls.Add(this.label3x_spd);
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
            // label3acc
            // 
            this.label3acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3acc.Location = new System.Drawing.Point(16, 112);
            this.label3acc.Name = "label3acc";
            this.label3acc.Size = new System.Drawing.Size(56, 23);
            this.label3acc.TabIndex = 15;
            this.label3acc.Text = "acc3";
            // 
            // acc_three
            // 
            this.acc_three.Location = new System.Drawing.Point(72, 112);
            this.acc_three.Maximum = new decimal(new int[] {50,0,0,0});
            this.acc_three.Minimum = new decimal(new int[] {1,0,0,0});
            this.acc_three.Name = "acc_three";
            this.acc_three.Size = new System.Drawing.Size(56, 20);
            this.acc_three.TabIndex = 14;
            this.acc_three.Value = new decimal(new int[] {10,0,0,0});
            // 
            // label3y_pos
            // 
            this.label3y_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3y_pos.Location = new System.Drawing.Point(16, 88);
            this.label3y_pos.Name = "label3y_pos";
            this.label3y_pos.Size = new System.Drawing.Size(56, 23);
            this.label3y_pos.TabIndex = 11;
            this.label3y_pos.Text = "y pos";
            // 
            // label3x_pos
            // 
            this.label3x_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3x_pos.Location = new System.Drawing.Point(16, 64);
            this.label3x_pos.Name = "label3x_pos";
            this.label3x_pos.Size = new System.Drawing.Size(56, 23);
            this.label3x_pos.TabIndex = 10;
            this.label3x_pos.Text = "x pos";
            // 
            // label3y_spd
            // 
            this.label3y_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3y_spd.Location = new System.Drawing.Point(16, 40);
            this.label3y_spd.Name = "label3y_spd";
            this.label3y_spd.Size = new System.Drawing.Size(56, 23);
            this.label3y_spd.TabIndex = 9;
            this.label3y_spd.Text = "y speed";
            // 
            // label12
            // 
            this.label3x_spd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3x_spd.Location = new System.Drawing.Point(16, 16);
            this.label3x_spd.Name = "label3x_spd";
            this.label3x_spd.Size = new System.Drawing.Size(56, 23);
            this.label3x_spd.TabIndex = 8;
            this.label3x_spd.Text = "x speed";
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(72, 88);
            this.n9.Maximum = new decimal(new int[] {509,0,0,0});
            this.n9.Minimum = new decimal(new int[] {1,0,0,0});
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(56, 20);
            this.n9.TabIndex = 7;
            this.n9.Value = new decimal(new int[] {1,0,0,0});
            // 
            // n10
            // 
            this.n10.Location = new System.Drawing.Point(72, 64);
            this.n10.Maximum = new decimal(new int[] {580,0,0,0});
            this.n10.Minimum = new decimal(new int[] {1,0,0,0});
            this.n10.Name = "n10";
            this.n10.Size = new System.Drawing.Size(56, 20);
            this.n10.TabIndex = 6;
            this.n10.Value = new decimal(new int[] {1,0,0,0});
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
            this.hide3_btn.Click += new System.EventHandler(this.hideToolBox3_Click);
            // 
            // panel1
            // 
            this.wall.BackColor = System.Drawing.Color.Brown;
            this.wall.Location = new System.Drawing.Point(632, -24);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(8, 600);
            this.wall.TabIndex = 11;
            // 
            // n1
            // 
            this.Bar_xspd.LargeChange = 10;
            this.Bar_xspd.Location = new System.Drawing.Point(78, 16);
            this.Bar_xspd.Maximum = 100;
            this.Bar_xspd.Name = "Bar_xspd";
            this.Bar_xspd.Size = new System.Drawing.Size(304, 45);
            this.Bar_xspd.SmallChange = 10;
            this.Bar_xspd.TabIndex = 15;
            this.Bar_xspd.TickFrequency = 10;
            // 
            // n2
            // 
            this.Bar_yspd.Location = new System.Drawing.Point(78, 55);
            this.Bar_yspd.Maximum = 100;
            this.Bar_yspd.Name = "Bar_yspd";
            this.Bar_yspd.Size = new System.Drawing.Size(304, 45);
            this.Bar_yspd.SmallChange = 10;
            this.Bar_yspd.TabIndex = 16;
            this.Bar_yspd.TickFrequency = 10;
            // 
            // n3
            // 
            this.Bar_xpos.Location = new System.Drawing.Point(78, 107);
            this.Bar_xpos.Maximum = 580;
            this.Bar_xpos.Minimum = 1;
            this.Bar_xpos.Name = "Bar_xpos";
            this.Bar_xpos.Size = new System.Drawing.Size(304, 45);
            this.Bar_xpos.SmallChange = 20;
            this.Bar_xpos.TabIndex = 17;
            this.Bar_xpos.TickFrequency = 20;
            this.Bar_xpos.Value = 1;
            // 
            // n4
            // 
            this.Bar_ypos.Location = new System.Drawing.Point(78, 158);
            this.Bar_ypos.Maximum = 509;
            this.Bar_ypos.Minimum = 1;
            this.Bar_ypos.Name = "Bar_ypos";
            this.Bar_ypos.Size = new System.Drawing.Size(304, 45);
            this.Bar_ypos.SmallChange = 20;
            this.Bar_ypos.TabIndex = 18;
            this.Bar_ypos.TickFrequency = 20;
            this.Bar_ypos.Value = 1;
            //------END groupBall2------

            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1083, 553);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.groupBall3);
            this.Controls.Add(this.groupBall2);
            this.Controls.Add(this.groupBall1);
            this.Controls.Add(b3.ball);
            this.Controls.Add(b2.ball);
            this.Controls.Add(b1.ball);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravity and collision simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(b1.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(b2.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(b3.ball)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Bar_xspd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_yspd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_xpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ypos)).EndInit();
            this.ResumeLayout(false);
		}

        public Quadra()
        {
            InitializeComponent();
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

    }
}
