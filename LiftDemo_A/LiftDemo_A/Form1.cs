using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

		bool isClosing = false;
		bool isOpening = false;
		int doorSpeed = 5;
		int doorMaxOpenWidth;

		
		DataTable dt = new DataTable();

		DBContext dbContext = new DBContext();
		public Form1()
		{
			InitializeComponent();
			doorMaxOpenWidth = mainElevator.Width / 2 - 30;

			dataGridViewLogs.ColumnCount = 2;

			dataGridViewLogs.Columns[0].Name = "Time";
			dataGridViewLogs.Columns[1].Name = "Events";

			dt.Columns.Add("LogTime");
			dt.Columns.Add("EventDescription");
		}



		private void logEvents(string message)
		{
			string currentTime = DateTime.Now.ToString("hh:mm:ss");

			dt.Rows.Add(currentTime,message);
			dataGridViewLogs.Rows.Add(currentTime, message);

			dbContext.InsertLogsIntoDB(dt);
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			dbContext.loadLogsFromDB(dt, dataGridViewLogs);
		}

		





		public void btn_1_click(object sender, EventArgs e)
		{
			isMovingUp = true;
			isMovingDown = false;
			liftTimer.Start();
			btn_G.Enabled = false;
			logEvents("Lift Jadai xa!!!");
		}

		public void btn_G_click(object sender, EventArgs e)
		{
			isMovingUp=false;
			isMovingDown=true;
			liftTimer.Start();
			btn_1.Enabled = false;
			logEvents("Lift Khasdai xa!!!");
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
					mainElevator.Top = 0;
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

		private void btn_Open_Click(object sender, EventArgs e)
		{
			isOpening=true;
			isClosing=false;
			doorTimer.Start();
			btn_Close.Enabled = false;

			logEvents("Lift Khuldai xa!!!");
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			isOpening =false;
			isClosing=true;
			doorTimer.Start();
			logEvents("Lift Banda hudai xa!!!");
		}

		private void door_Timer_Tick(object sender, EventArgs e)

		{
			if (mainElevator.Top != 0)
			{
				if (isOpening)
				{
					if (doorLeft_G.Left > doorMaxOpenWidth / 2)
					{
						doorLeft_G.Left -= doorSpeed;
						doorRight_G.Left += doorSpeed;
					}
					else
					{
						doorTimer.Stop();
						btn_Close.Enabled = true;
					}
				}

				if (isClosing)
				{
					if (doorLeft_G.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
					{
						doorLeft_G.Left += doorSpeed;
						doorRight_G.Left -= doorSpeed;
					}
					else
					{
						doorTimer.Stop();

					}
				}
			}

			else
			{
				if (isOpening)
				{
					if (doorLeft_1.Left > doorMaxOpenWidth / 2)
					{
						doorLeft_1.Left -= doorSpeed;
						doorRight_1.Left += doorSpeed;
					}
					else
					{
						doorTimer.Stop();
						btn_Close.Enabled = true;
					}
				}

				if (isClosing)
				{
					if (doorLeft_1.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
					{
						doorLeft_1.Left += doorSpeed;
						doorRight_1.Left -= doorSpeed;
					}
					else
					{
						doorTimer.Stop();

					}
				}
			}
		}
	}
}
