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
		bool isClosing = false;
		bool isOpening = false;

		int doorMaxOpenWidth;
		int doorSpeed = 5;
		int liftSpeed = 5;

		private Lift lift;
		DataTable dt = new DataTable();
		DBContext dbContext = new DBContext();

		public Form1()
		{
			InitializeComponent();

			lift = new Lift(mainElevator, btn_1, btn_G, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown);


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

			dt.Rows.Add(currentTime, message);
			dataGridViewLogs.Rows.Add(currentTime, message);

			dbContext.InsertLogsIntoDB(dt);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			dbContext.loadLogsFromDB(dt, dataGridViewLogs);
		}


		public void btn_1_click(object sender, EventArgs e)
		{
			lift.SetState(new MovingUpState());
			lift.LiftTimerUp.Start();
			btn_G.Enabled = false;
			logEvents("Lift Jadai xa!!!");
		}

		public void btn_G_click(object sender, EventArgs e)
		{
			lift.SetState(new MovingDownState());

			lift.LiftTimerDown.Start();
			logEvents("Lift Khasdai xa!!!");
		}

		public void liftTimerUp_Tick(object sender, EventArgs e)
		{
			lift.MovingUp();
		}

		public void liftTimerDown_Tick(object sender, EventArgs e)
		{
			lift.MovingDown();
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
