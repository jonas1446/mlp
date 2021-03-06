using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Gravity_Simulation
{

    public partial class Quadra : System.Windows.Forms.Form
	{
        const int ground = 500;
		int choice = 1;
		int numberofballs = 1;

        Ballinstance b1 = new Ballinstance("ball", 0, true);
        Ballinstance b2 = new Ballinstance("ball2", 4);
        Ballinstance b3 = new Ballinstance("ball3", 5);

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			b1.play();
            b1.ball.Left = (int)b1.get_newxpos();
            b1.ball.Top = (int)(ground - b1.get_newypos());

			b2.play();
            b2.ball.Left = (int)b2.get_newxpos();
            b2.ball.Top = (int)(ground - b2.get_newypos());

			b3.play();
            b3.ball.Left = (int)b3.get_newxpos();
            b3.ball.Top = (int)(ground - b3.get_newypos());

			Collision();
		}

		private void Collision()
		{
			#region ball and ball2
			// ball hits ball2 from the right, and we don't know the direction of ball2 nor ball
            if (((b1.ball.Right > b2.ball.Left && b1.ball.Right < b2.ball.Right) && ((b1.ball.Top >= b2.ball.Top && b1.ball.Top <= b2.ball.Bottom) || (b1.ball.Top <= b2.ball.Top && b1.ball.Bottom >= b2.ball.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that they have the same mass -> xspeed + xspeed2 = xspeed` + xspeed2`

                if (Math.Abs(b1.get_xspeed()) < 0.5 && Math.Abs(b1.get_xspeed()) >= 0)
					b1.set_xspeed(b2.get_xspeed());
                else if (b1.get_xspeed() > 0)
					b1.set_xspeed(b1.get_xspeed() * -0.9);
				else
                    b1.set_xspeed(b1.get_xspeed() * 1.35);

                if (Math.Abs(b2.get_xspeed()) < 0.5 && Math.Abs(b2.get_xspeed()) >= 0)
                    b2.set_xspeed(b1.get_xspeed());
                else if (b2.get_xspeed() > 0)
                    b2.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b2.set_xspeed(b2.get_xspeed() * -0.9);
			}

			// ball hits ball2 from the left, and we don't know the direction of ball2 nor ball
            if (((b1.ball.Left > b2.ball.Left && b1.ball.Left < b2.ball.Right) && ((b1.ball.Top >= b2.ball.Top && b1.ball.Top <= b2.ball.Bottom) || (b1.ball.Top <= b2.ball.Top && b1.ball.Bottom >= b2.ball.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed2 = xspeed` + xspeed2`

                if (Math.Abs(b1.get_xspeed()) < 0.5 && Math.Abs(b1.get_xspeed()) >= 0)
                    b1.set_xspeed(b2.get_xspeed());
                else if (b1.get_xspeed() < 0)
                    b1.set_xspeed(b1.get_xspeed() * -0.9);
				else
                    b1.set_xspeed(b1.get_xspeed() * 1.35);

                if (Math.Abs(b2.get_xspeed()) < 0.5 && Math.Abs(b2.get_xspeed()) >= 0)
                    b2.set_xspeed(b1.get_xspeed());
                else if (b2.get_xspeed() < 0)
                    b2.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b2.set_xspeed(b2.get_xspeed() * -0.9);
			}
			#endregion ball and ball2

			#region ball and ball3
			// ball hits ball3 from the right, and we don't know the direction of ball3 nor ball
            if (((b1.ball.Right > b3.ball.Left && b1.ball.Right < b3.ball.Right) && ((b1.ball.Top >= b3.ball.Top && b1.ball.Top <= b3.ball.Bottom) || (b1.ball.Top <= b3.ball.Top && b1.ball.Bottom >= b3.ball.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

                if (Math.Abs(b1.get_xspeed()) < 0.5 && Math.Abs(b1.get_xspeed()) >= 0)
                    b1.set_xspeed(b3.get_xspeed());
                else if (b1.get_xspeed() > 0)
                    b1.set_xspeed(b1.get_xspeed() * -0.9);
				else
                    b1.set_xspeed(b1.get_xspeed() * 1.35);

                if (Math.Abs(b3.get_xspeed()) < 0.5 && Math.Abs(b3.get_xspeed()) >= 0)
                    b3.set_xspeed(b1.get_xspeed());
                else if (b3.get_xspeed() > 0)
                    b3.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b3.set_xspeed(b2.get_xspeed() * -0.9);
			}

			// ball hits ball3 from the left, and we don't know the direction of ball3 nor ball
            if (((b1.ball.Left > b3.ball.Left && b1.ball.Left < b3.ball.Right) && ((b1.ball.Top >= b3.ball.Top && b1.ball.Top <= b3.ball.Bottom) || (b1.ball.Top <= b3.ball.Top && b1.ball.Bottom >= b3.ball.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

                if (Math.Abs(b1.get_xspeed()) < 0.5 && Math.Abs(b1.get_xspeed()) >= 0)
                    b1.set_xspeed(b3.get_xspeed());
                else if (b1.get_xspeed() < 0)
                    b1.set_xspeed(b1.get_xspeed() * -0.9);
				else
                    b1.set_xspeed(b1.get_xspeed() * 1.35);

                if (Math.Abs(b3.get_xspeed()) < 0.5 && Math.Abs(b3.get_xspeed()) >= 0)
                    b3.set_xspeed(b1.get_xspeed());
                else if (b3.get_xspeed() < 0)
                    b3.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b3.set_xspeed(b2.get_xspeed() * -0.9);
			}
			#endregion ball and ball3

			#region ball2 and ball3
			// ball2 hits ball3 from the right, and we don't know the direction of ball3 nor ball2
            if (((b2.ball.Right > b3.ball.Left && b2.ball.Right < b3.ball.Right) && ((b2.ball.Top >= b3.ball.Top && b2.ball.Top <= b3.ball.Bottom) || (b2.ball.Top <= b3.ball.Top && b2.ball.Bottom >= b3.ball.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

                if (Math.Abs(b2.get_xspeed()) < 0.5 && Math.Abs(b2.get_xspeed()) >= 0)
                    b2.set_xspeed(b3.get_xspeed());
                else if (b2.get_xspeed() > 0)
                    b2.set_xspeed(b2.get_xspeed() * -0.9);
				else
                    b2.set_xspeed(b2.get_xspeed() * 1.35);

                if (Math.Abs(b3.get_xspeed()) < 0.5 && Math.Abs(b3.get_xspeed()) >= 0)
                    b3.set_xspeed(b2.get_xspeed());
                else if (b3.get_xspeed() > 0)
                    b3.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b3.set_xspeed(b2.get_xspeed() * -0.9);
			}

			// ball2 hits ball3 from the left, and we don't know the direction of ball3 nor ball2
            if (((b2.ball.Left > b3.ball.Left && b2.ball.Left < b3.ball.Right) && ((b2.ball.Top >= b3.ball.Top && b2.ball.Top <= b3.ball.Bottom) || (b2.ball.Top <= b3.ball.Top && b2.ball.Bottom >= b3.ball.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

                if (Math.Abs(b2.get_xspeed()) < 0.5 && Math.Abs(b2.get_xspeed()) >= 0)
                    b2.set_xspeed(b3.get_xspeed());
                else if (b2.get_xspeed() < 0)
                    b2.set_xspeed(b2.get_xspeed() * -0.9);
				else
                    b2.set_xspeed(b2.get_xspeed() * 1.35);

                if (Math.Abs(b3.get_xspeed()) < 0.5 && Math.Abs(b3.get_xspeed()) >= 0)
                    b3.set_xspeed(b2.get_xspeed());
                else if (b3.get_xspeed() < 0)
                    b3.set_xspeed(b2.get_xspeed() * 1.35);
				else
                    b3.set_xspeed(b2.get_xspeed() * -0.9);
			}
			#endregion ball2 and ball3
		}
		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			b1.set_t(0); 
            b2.set_t(0);
            b3.set_t(0);
            b1.set_acc(10);
            b2.set_acc(10);
            b3.set_acc(10);
			// Hide the balls
            b2.set_newxpos(2000); 
            b3.set_newxpos(2000);
            b2.set_newypos(2000);
            b3.set_newypos(2000);

		}

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
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
					b1.set_dragging(true);
                    b1.set_newxpos(e.X);
                    b1.set_newypos(e.Y);
                    b1.set_xmouse(e.X);
                    b1.set_ymouse(e.Y);
					break;
				case 2:
                    b2.set_dragging(true);
                    b2.set_newxpos(e.X);
                    b2.set_newypos(e.Y);
                    b2.set_xmouse(e.X);
                    b2.set_ymouse(e.Y);
					break;
				case 3:
                    b3.set_dragging(true);
                    b3.set_newxpos(e.X);
                    b3.set_newypos(e.Y);
                    b3.set_xmouse(e.X);
                    b3.set_ymouse(e.Y);
					break;
			}
		}
		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
                    b1.set_dragging(false);
					break;
				case 2:
                    b2.set_dragging(false);
					break;
				case 3:
                    b3.set_dragging(false);
					break;
			}
		}
		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
                    b1.set_xmouse(e.X);
                    b1.set_ymouse(e.Y);
					break;
				case 2:
                    b2.set_xmouse(e.X);
                    b2.set_ymouse(e.Y);
					break;
				case 3:
                    b3.set_xmouse(e.X);
                    b3.set_ymouse(e.Y);
					break;
			}
		}

		private void menuItemAddBall_Click(object sender, System.EventArgs e)
		{
			if(numberofballs != 3)
				numberofballs++;
		}
        private void menuItemTempoMore_Click(object sender, System.EventArgs e)
        {
            timer.Interval *= 0.5;
        }
        private void menuItemTempoLess_Click(object sender, System.EventArgs e)
        {
            timer.Interval *= 2;
        }

        private void menuItemShowToolBox1_Click(object sender, System.EventArgs e)
        {
            groupBall1.Visible = true;
        }
        private void menuItemShowToolBox2_Click(object sender, System.EventArgs e)
        {
            if (1 < numberofballs)
                groupBall2.Visible = true;
        }
        private void menuItemShowToolBox3_Click(object sender, System.EventArgs e)
        {
            if (2 < numberofballs)
                groupBall3.Visible = true;
        }

        private void hideToolBox1_Click(object sender, System.EventArgs e)
		{
			groupBall1.Visible=false;
		}
		private void hideToolBox2_Click(object sender, System.EventArgs e)
		{
			groupBall2.Visible=false;
		}
		private void hideToolBox3_Click(object sender, System.EventArgs e)
		{
			groupBall3.Visible=false;
		}
		
        private void ok1_btn_Click(object sender, System.EventArgs e)
		{
			b1.set_xspeed((double)Bar_xspd.Value);
            b1.set_yspeed((double)Bar_yspd.Value);
            b1.set_newxpos((double)Bar_xpos.Value);
            b1.set_newypos((double)Bar_ypos.Value); 
			b1.set_acc((double)acc_one.Value);
            b1.set_dragging(false);
		}
		private void ok2_btn_Click(object sender, System.EventArgs e)
		{

            b2.set_xspeed((double)n8.Value);
            b2.set_yspeed((double)n7.Value);
            b2.set_newxpos((double)n6.Value);
            b2.set_newypos((double)n5.Value);
            b2.set_acc((double)acc_two.Value);
            b2.set_dragging(false);
		}
		private void ok3_btn_Click(object sender, System.EventArgs e)
		{

            b3.set_xspeed((double)n12.Value);
            b3.set_yspeed((double)n11.Value);
            b3.set_newxpos((double)n10.Value);
            b3.set_newypos((double)n9.Value);
            b3.set_acc((double)acc_three.Value);
            b3.set_dragging(false);
		}
		
        private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

	}

}
