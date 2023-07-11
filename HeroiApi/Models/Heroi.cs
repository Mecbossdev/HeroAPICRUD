using System;
namespace HeroiApi.Models
{
	public class Heroi
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Armas>? Armas { get; set; }
	}
}

