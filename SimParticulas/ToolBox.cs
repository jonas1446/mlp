using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gravity_Simulation
{
    class ToolBox : System.Windows.Forms.GroupBox
    {
        public System.Windows.Forms.TrackBar n1;
        public System.Windows.Forms.TrackBar n2;
        public System.Windows.Forms.TrackBar n3;
        public System.Windows.Forms.TrackBar n4;
        public System.Windows.Forms.NumericUpDown acc;
        public System.Windows.Forms.Button hide_btn;
        public System.Windows.Forms.Button ok_btn;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;

        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.NumericUpDown();
            this.hide_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.TrackBar();
            this.n2 = new System.Windows.Forms.TrackBar();
            this.n3 = new System.Windows.Forms.TrackBar();
            this.n4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n4)).BeginInit();


            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ok_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Location = new System.Drawing.Point(670, 6);
            this.Name = "groupBall1";
            this.Size = new System.Drawing.Size(401, 327);
            this.TabIndex = 8;
            this.TabStop = false;
            this.Text = "Ball 1";
            this.Visible = false;

            // 
            // label13
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(16, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "acc1";
            // 
            // acc_one
            // 
            this.acc.Location = new System.Drawing.Point(84, 213);
            this.acc.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.acc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.acc.Name = "acc_one";
            this.acc.Size = new System.Drawing.Size(56, 20);
            this.acc.TabIndex = 13;
            this.acc.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // hide1_btn
            // 
            this.hide_btn.Location = new System.Drawing.Point(14, 271);
            this.hide_btn.Name = "hide1_btn";
            this.hide_btn.Size = new System.Drawing.Size(48, 23);
            this.hide_btn.TabIndex = 12;
            this.hide_btn.Text = "Hide";
            this.hide_btn.Click += new System.EventHandler(this.hideToolBox1_Click);
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
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ok_btn.Location = new System.Drawing.Point(100, 268);
            this.ok_btn.Name = "ok1_btn";
            this.ok_btn.Size = new System.Drawing.Size(40, 23);
            this.ok_btn.TabIndex = 3;
            this.ok_btn.Text = "Ok";
            this.ok_btn.Click += new System.EventHandler(this.ok1_btn_Click);


            ((System.ComponentModel.ISupportInitialize)(this.acc)).EndInit();



    
        }


        private void hideToolBox1_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
        }
        private void ok1_btn_Click(object sender, System.EventArgs e)
        {
            b1.xspeed = (double)n1.Value;
            b1.yspeed = (double)n2.Value;
            b1.newxpos = (double)n3.Value;
            b1.newypos = (double)n4.Value;
            b1.acc = (double)acc_one.Value;
            b1.dragging = false;
        }
    }
}
