using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class Form1 : Form
	{

		public Form1()
		{



			InitializeComponent();

			var button = new Button
			{
				Location = new Point(65, 175),
				Size = new Size(100,100),
				Text = "CLICK!"
			};

			var clicks = new Label
			{
				Location = new Point(100, 20),
				Size = new Size(100, 100),
				Text = "0"
			};

			var label = new Label
			{
				Location = new Point(20,80),
				Size = new Size(200, 100),
				Text = "CPS PER SECONDS"
			};

			var clicksPerSecond = new Label
			{
				Location = new Point(150, label.Height-20),
				Size = new Size(80, 80),
				Text = "0.0"
			};

			myTimer.Interval = 1000;

			clicksPerSecond.Font = new Font(clicksPerSecond.Font.Name, 20F, FontStyle.Bold);
			Controls.Add(clicksPerSecond);

		


			button.Font = new Font(button.Font.Name, 15F);
			clicks.Font = new Font(clicks.Font.Name, 20F, FontStyle.Bold);
			label.Font = new Font(label.Font.Name, 15F);
			Controls.Add(button);
			Controls.Add(label);
			Controls.Add(clicks);



			button.Click += (sender, args) =>
			{
				myTimer.Start();
				clicks.Text = (int.Parse(clicks.Text) + 1).ToString();
			};

			myTimer.Tick += (sender,args) =>
			{
				tick++;
				clicksPerSecond.Text = ((double)(int.Parse(clicks.Text) / tick)).ToString();

			};
		}
		static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		private int tick = 1;

	}
}
