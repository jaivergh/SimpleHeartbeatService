using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleHeartbeatService
{
	public class HeartBeat
	{
		private readonly Timer _timer;

		public HeartBeat()
		{
			_timer = new Timer(1000) { AutoReset = true };
			_timer.Elapsed += timerElapsed;
		}

		private void timerElapsed(object sender, ElapsedEventArgs e)
		{
			string[] lines = new string[] { DateTime.Now.ToString() };
			File.AppendAllLines(@"C:\Users\JAIVER\source\repos\SimpleHeartbeatService\SimpleHeartbeatService\bin\Debug\HeartBeat.txt", lines);
		}

		public void Start()
		{
			_timer.Start();
		}

		public void Stop()
		{
			_timer.Stop();
		}
	}
}
