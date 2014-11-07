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

		Ballinstance b1 = new Ballinstance(true);
		Ballinstance b2 = new Ballinstance();
		Ballinstance b3 = new Ballinstance();

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			b1.play();
			ball.Left = (int)b1.newxpos;
			ball.Top = (int)(ground - b1.newypos);

			b2.play();
			ball2.Left = (int)b2.newxpos;
            ball2.Top = (int)(ground - b2.newypos);

			b3.play();
            ball3.Left = (int)b3.newxpos;
            ball3.Top = (int)(ground - b3.newypos);

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

				if(Math.Abs(b1.xspeed) < 0.5 && Math.Abs(b1.xspeed) >= 0)
					b1.xspeed = b2.xspeed;
				else if(b1.xspeed > 0 )
					b1.xspeed *= -0.9;
				else
					b1.xspeed *= 1.35;

                if (Math.Abs(b2.xspeed) < 0.5 && Math.Abs(b2.xspeed) >= 0)
                    b2.xspeed = b1.xspeed;
                else if (b2.xspeed > 0)
                    b2.xspeed *= 1.35;
				else
                    b2.xspeed *= -0.9;
			}

			// ball hits ball2 from the left, and we don't know the direction of ball2 nor ball
			if(((ball.Left > ball2.Left && ball.Left < ball2.Right) && ((ball.Top >= ball2.Top && ball.Top <= ball2.Bottom) || (ball.Top <= ball2.Top && ball.Bottom >= ball2.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed2 = xspeed` + xspeed2`

                if (Math.Abs(b1.xspeed) < 0.5 && Math.Abs(b1.xspeed) >= 0)
                    b1.xspeed = b2.xspeed;
                else if (b1.xspeed < 0)
                    b1.xspeed *= -0.9;
				else
                    b1.xspeed *= 1.35;

                if (Math.Abs(b2.xspeed) < 0.5 && Math.Abs(b2.xspeed) >= 0)
                    b2.xspeed = b1.xspeed;
                else if (b2.xspeed < 0)
                    b2.xspeed *= 1.35;
				else
                    b2.xspeed *= -0.9;
			}
			#endregion ball and ball2

			#region ball and ball3
			// ball hits ball3 from the right, and we don't know the direction of ball3 nor ball
			if(((ball.Right > ball3.Left && ball.Right < ball3.Right) && ((ball.Top >= ball3.Top && ball.Top <= ball3.Bottom) || (ball.Top <= ball3.Top && ball.Bottom >= ball3.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

                if (Math.Abs(b1.xspeed) < 0.5 && Math.Abs(b1.xspeed) >= 0)
                    b1.xspeed = b3.xspeed;
                else if (b1.xspeed > 0)
                    b1.xspeed *= -0.9;
				else
                    b1.xspeed *= 1.35;

                if (Math.Abs(b3.xspeed) < 0.5 && Math.Abs(b3.xspeed) >= 0)
                    b3.xspeed = b1.xspeed;
                else if (b3.xspeed > 0)
                    b3.xspeed *= 1.35;
				else
                    b3.xspeed *= -0.9;
			}

			// ball hits ball3 from the left, and we don't know the direction of ball3 nor ball
			if(((ball.Left > ball3.Left && ball.Left < ball3.Right) && ((ball.Top >= ball3.Top && ball.Top <= ball3.Bottom) || (ball.Top <= ball3.Top && ball.Bottom >= ball3.Top))))
			{
				// xspeed either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed, by the "preserved momentum law", knowing that the have the same mass -> xspeed + xspeed3 = xspeed` + xspeed3`

                if (Math.Abs(b1.xspeed) < 0.5 && Math.Abs(b1.xspeed) >= 0)
                    b1.xspeed = b3.xspeed;
                else if (b1.xspeed < 0)
                    b1.xspeed *= -0.9;
				else
                    b1.xspeed *= 1.35;

                if (Math.Abs(b3.xspeed) < 0.5 && Math.Abs(b3.xspeed) >= 0)
                    b3.xspeed = b1.xspeed;
                else if (b3.xspeed < 0)
                    b3.xspeed *= 1.35;
				else
                    b3.xspeed *= -0.9;
			}
			#endregion ball and ball3

			#region ball2 and ball3
			// ball2 hits ball3 from the right, and we don't know the direction of ball3 nor ball2
			if(((ball2.Right > ball3.Left && ball2.Right < ball3.Right) && ((ball2.Top >= ball3.Top && ball2.Top <= ball3.Bottom) || (ball2.Top <= ball3.Top && ball2.Bottom >= ball3.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

                if (Math.Abs(b2.xspeed) < 0.5 && Math.Abs(b2.xspeed) >= 0)
                    b2.xspeed = b3.xspeed;
                else if (b2.xspeed > 0)
                    b2.xspeed *= -0.9;
				else
                    b2.xspeed *= 1.35;

                if (Math.Abs(b3.xspeed) < 0.5 && Math.Abs(b3.xspeed) >= 0)
                    b3.xspeed = b2.xspeed;
                else if (b3.xspeed > 0)
                    b3.xspeed *= 1.35;
				else
                    b3.xspeed *= -0.9;
			}

			// ball2 hits ball3 from the left, and we don't know the direction of ball3 nor ball2
			if(((ball2.Left > ball3.Left && ball2.Left < ball3.Right) && ((ball2.Top >= ball3.Top && ball2.Top <= ball3.Bottom) || (ball2.Top <= ball3.Top && ball2.Bottom >= ball3.Top))))
			{
				// xspeed2 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// xspeed3 either will decrease or increase at the same or the oppisite direction, depends on its direction
				// hit with the same direction, the power of hit depends on the xspeed2, by the "preserved momentum law", knowing that the have the same mass -> xspeed2 + xspeed3 = xspeed2` + xspeed3`

                if (Math.Abs(b2.xspeed) < 0.5 && Math.Abs(b2.xspeed) >= 0)
                    b2.xspeed = b3.xspeed;
                else if (b2.xspeed < 0)
                    b2.xspeed *= -0.9;
				else
                    b2.xspeed *= 1.35;

                if (Math.Abs(b3.xspeed) < 0.5 && Math.Abs(b3.xspeed) >= 0)
                    b3.xspeed = b2.xspeed;
                else if (b3.xspeed < 0)
                    b3.xspeed *= 1.35;
				else
                    b3.xspeed *= -0.9;
			}
			#endregion ball2 and ball3
		}
		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//sw = new StreamWriter("trace.txt");
			b1.t = b2.t = b3.t= 0;
			b1.acc = b2.acc = b3.acc = 10;
			// Hide the balls
            b2.newxpos = b3.newxpos = 2000;
            b2.newypos = b3.newypos = 2000;

            Painel painel = new Painel();
            painel.Show();

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
					b1.dragging = true;
                    b1.newxpos = e.X;
                    b1.newypos = e.Y;
                    b1.xmouse = e.X;
                    b1.ymouse = e.Y;
					break;
				case 2:
					b2.dragging = true;
                    b2.newxpos = e.X;
                    b2.newypos = e.Y;
                    b2.xmouse = e.X;
                    b2.ymouse = e.Y;
					break;
				case 3:
                    b3.dragging = true;
                    b3.newxpos = e.X;
                    b3.newypos = e.Y;
                    b3.xmouse = e.X;
					b3.ymouse = e.Y;
					break;
			}
		}
		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
					b1.dragging = false;
					break;
				case 2:
					b2.dragging = false;
					break;
				case 3:
					b3.dragging = false;
					break;
			}
		}
		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(choice)
			{
				case 1:
					b1.xmouse = e.X;
					b1.ymouse = e.Y;
					break;
				case 2:
					b2.xmouse = e.X;
					b2.ymouse = e.Y;
					break;
				case 3:
                    b3.xmouse = e.X;
                    b3.ymouse = e.Y;
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
			b1.xspeed = (double)n1.Value;
            b1.yspeed = (double)n2.Value;
            b1.newxpos = (double)n3.Value;
            b1.newypos = (double)n4.Value;
			b1.acc = (double)acc_one.Value;
            b1.dragging = false;
		}
		private void ok2_btn_Click(object sender, System.EventArgs e)
		{
		
			b2.xspeed = (double)n8.Value;
            b2.yspeed = (double)n7.Value;
            b2.newxpos = (double)n6.Value;
            b2.newypos = (double)n5.Value;
            b2.acc = (double)acc_two.Value;
            b2.dragging = false;
		}
		private void ok3_btn_Click(object sender, System.EventArgs e)
		{
		
			b3.xspeed = (double)n12.Value;
            b3.yspeed = (double)n11.Value;
            b3.newxpos = (double)n10.Value;
            b3.newypos = (double)n9.Value;
            b3.acc = (double)acc_three.Value;
            b3.dragging = false;
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
		
		}

	}

}
