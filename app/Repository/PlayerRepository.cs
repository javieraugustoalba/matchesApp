using app.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Repository
{
	public class PlayerRepository : IPlayerRepository
	{
		public string GetNBAPlayerHeights(Int32 height)
		{
			string matches = String.Empty;
			Player player1 = new Player();
			Player player2 = new Player();
			NBAPlayerHeights nbaPlayerHeights = new NBAPlayerHeights();
			var client = new RestClient("https://mach-eight.uc.r.appspot.com/");
			var request = new RestRequest(string.Empty);
			var response = client.Execute(request);
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				string rawResponse = response.Content;
				nbaPlayerHeights = JsonConvert.DeserializeObject<NBAPlayerHeights>(rawResponse); // Serialize response to C# Model created called NBAPlayerHeights
			}

			if (nbaPlayerHeights.values != null && nbaPlayerHeights.values.Count > 0)
			{
				for (int i = 0; i < nbaPlayerHeights.values.Count; i++) // O(Log N) with binary search more faster than O(N^2)
				{
					player1 = nbaPlayerHeights.values[i];
					for (int j = 1; j < nbaPlayerHeights.values.Count; j++)
					{
						player2 = nbaPlayerHeights.values[j];
						if (height == (Convert.ToInt32(player1.h_in) + Convert.ToInt32(player2.h_in)))
						{
							matches = matches + String.Format("{0} {1}", player1.first_name, player1.last_name) 
												+ System.Environment.NewLine 
												+ String.Format("{0} {1}", player2.first_name, player2.last_name)
												+ System.Environment.NewLine
												+ System.Environment.NewLine;
						}
					}
					nbaPlayerHeights.values.Remove(player1); // Removed last searched element in first for for reduce logarithm search and convert to O(N^2)
				}

			}

			return !string.IsNullOrEmpty(matches) ? matches : "No matches found";
		}
	}
}
