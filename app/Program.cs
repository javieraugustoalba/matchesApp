using app.Models;
using app.Service;
using Newtonsoft.Json;
using RestSharp; // javier.alba commented on 11/25/2021 :: I used RestSharp for manage Rest api Request
using System;
using System.Collections.Generic;


namespace app
{
	class Program
	{
		private static Service.IPlayerService _playerService = new PlayerService();
		static void Main(string[] args)
		{
			Console.WriteLine("Insert Height");
			Int32 height = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.Write(_playerService.GetNBAPlayerHeights(height));
			Console.WriteLine("Press any Key To Continue...");
			Console.ReadKey();
		}

	}
}
