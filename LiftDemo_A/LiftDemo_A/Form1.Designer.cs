namespace LiftDemo_A
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.liftTimer = new System.Windows.Forms.Timer(this.components);
			this.doorRight_G = new System.Windows.Forms.PictureBox();
			this.doorLeft_G = new System.Windows.Forms.PictureBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Open = new System.Windows.Forms.Button();
			this.btn_G = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.liftPanel = new System.Windows.Forms.PictureBox();
			this.mainElevator = new System.Windows.Forms.PictureBox();
			this.doorRight_1 = new System.Windows.Forms.PictureBox();
			this.doorLeft_1 = new System.Windows.Forms.PictureBox();
			this.doorTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
			this.SuspendLayout();
			// 
			// liftTimer
			// 
			this.liftTimer.Interval = 50;
			this.liftTimer.Tick += new System.EventHandler(this.liftTimer_Tick);
			// 
			// doorRight_G
			// 
			this.doorRight_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_right;
			this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorRight_G.Location = new System.Drawing.Point(174, 356);
			this.doorRight_G.Name = "doorRight_G";
			this.doorRight_G.Size = new System.Drawing.Size(81, 208);
			this.doorRight_G.TabIndex = 7;
			this.doorRight_G.TabStop = false;
			// 
			// doorLeft_G
			// 
			this.doorLeft_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_left;
			this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorLeft_G.Location = new System.Drawing.Point(93, 356);
			this.doorLeft_G.Name = "doorLeft_G";
			this.doorLeft_G.Size = new System.Drawing.Size(83, 208);
			this.doorLeft_G.TabIndex = 6;
			this.doorLeft_G.TabStop = false;
			// 
			// btn_Close
			// 
			this.btn_Close.BackgroundImage = global::LiftDemo_A.Properties.Resources.closedoorsbutton;
			this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Close.Location = new System.Drawing.Point(513, 356);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(80, 77);
			this.btn_Close.TabIndex = 5;
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Open
			// 
			this.btn_Open.BackgroundImage = global::LiftDemo_A.Properties.Resources.opendoorbutton;
			this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Open.Location = new System.Drawing.Point(409, 356);
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.Size = new System.Drawing.Size(80, 77);
			this.btn_Open.TabIndex = 4;
			this.btn_Open.UseVisualStyleBackColor = true;
			this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
			// 
			// btn_G
			// 
			this.btn_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.Groundfloorbutton;
			this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_G.Location = new System.Drawing.Point(460, 208);
			this.btn_G.Name = "btn_G";
			this.btn_G.Size = new System.Drawing.Size(80, 77);
			this.btn_G.TabIndex = 3;
			this.btn_G.UseVisualStyleBackColor = true;
			this.btn_G.Click += new System.EventHandler(this.btn_G_click);
			// 
			// btn_1
			// 
			this.btn_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.firstfloorbutton;
			this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_1.Location = new System.Drawing.Point(460, 96);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(80, 77);
			this.btn_1.TabIndex = 2;
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_1_click);
			// 
			// liftPanel
			// 
			this.liftPanel.BackgroundImage = global::LiftDemo_A.Properties.Resources.panel;
			this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.liftPanel.Location = new System.Drawing.Point(389, 28);
			this.liftPanel.Name = "liftPanel";
			this.liftPanel.Size = new System.Drawing.Size(218, 509);
			this.liftPanel.TabIndex = 1;
			this.liftPanel.TabStop = false;
			// 
			// mainElevator
			// 
			this.mainElevator.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_transparent;
			this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mainElevator.Location = new System.Drawing.Point(93, 356);
			this.mainElevator.Name = "mainElevator";
			this.mainElevator.Size = new System.Drawing.Size(162, 208);
			this.mainElevator.TabIndex = 0;
			this.mainElevator.TabStop = false;
			// 
			// doorRight_1
			// 
			this.doorRight_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_right;
			this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorRight_1.Location = new System.Drawing.Point(174, 0);
			this.doorRight_1.Name = "doorRight_1";
			this.doorRight_1.Size = new System.Drawing.Size(81, 208);
			this.doorRight_1.TabIndex = 9;
			this.doorRight_1.TabStop = false;
			// 
			// doorLeft_1
			// 
			this.doorLeft_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.lift_door_left;
			this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorLeft_1.Location = new System.Drawing.Point(93, 0);
			this.doorLeft_1.Name = "doorLeft_1";
			this.doorLeft_1.Size = new System.Drawing.Size(83, 208);
			this.doorLeft_1.TabIndex = 8;
			this.doorLeft_1.TabStop = false;
			// 
			// doorTimer
			// 
			this.doorTimer.Tick += new System.EventHandler(this.door_Timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 565);
			this.Controls.Add(this.doorRight_1);
			this.Controls.Add(this.doorLeft_1);
			this.Controls.Add(this.doorRight_G);
			this.Controls.Add(this.doorLeft_G);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Open);
			this.Controls.Add(this.btn_G);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.liftPanel);
			this.Controls.Add(this.mainElevator);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox mainElevator;
		private System.Windows.Forms.PictureBox liftPanel;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_G;
		private System.Windows.Forms.Button btn_Open;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Timer liftTimer;
		private System.Windows.Forms.PictureBox doorLeft_G;
		private System.Windows.Forms.PictureBox doorRight_G;
		private System.Windows.Forms.PictureBox doorRight_1;
		private System.Windows.Forms.PictureBox doorLeft_1;
		private System.Windows.Forms.Timer doorTimer;
	}
}

