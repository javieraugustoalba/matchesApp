using app.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Service
{
	public class PlayerService : IPlayerService
	{
		private IPlayerRepository _playerRepository = new PlayerRepository();
		public string GetNBAPlayerHeights(int height)
		{
			string matches;
			try
			{
				matches = _playerRepository.GetNBAPlayerHeights(height);
			}
			catch (Exception ex)
			{

				matches = ex.ToString();
			}
			return matches;
		}
	}
}
