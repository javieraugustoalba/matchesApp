using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
	public class Player
	{
		public string first_name { get; set; }
		public string h_in { get; set; }
		public string h_meters { get; set; }
		public string last_name { get; set; }
	}
	public class NBAPlayerHeights
	{
		public List<Player> values { get; set; }
	}
}
