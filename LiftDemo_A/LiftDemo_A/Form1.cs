﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
	public partial class Form1 : Form
	{
		bool isMovingUp = false;
		bool isMovingDown = false;
		int liftSpeed = 5;
		public Form1()
		{
			InitializeComponent();
		}





		public void btn_1_click(object sender, EventArgs e)
		{
			isMovingUp = true;
			isMovingDown = false;
			liftTimer.Start();
			btn_G.Enabled = false;
		}

		public void btn_G_click(object sender, EventArgs e)
		{
			isMovingUp=false;
			isMovingDown=true;
			liftTimer.Start();
			btn_1.Enabled = false;
		}

		public void liftTimer_Tick(object sender, EventArgs e)
		{
			if(isMovingUp)
			{
				btn_G.BackColor = Color.Gray;
				btn_1.BackColor = Color.LightGreen;
				if(mainElevator.Top > 0)
				{
					mainElevator.Top -= liftSpeed;
				}
				else
				{
					liftTimer.Stop();
					btn_G.Enabled=true;
				}
			}

			if(isMovingDown)
			{
				btn_1.BackColor = Color.Gray;
				btn_G.BackColor = Color.LightGreen;
				if(mainElevator.Bottom < this.ClientSize.Height)
				{
					mainElevator.Top += liftSpeed;
				}
				else
				{
					liftTimer.Stop();
					btn_1.Enabled=true;
				}
			}
		}

	}
}
