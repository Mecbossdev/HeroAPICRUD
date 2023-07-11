using System;
namespace HeroiApi.Models
{
	public class Armas
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public int HeroiId { get; set; }

		public Heroi? Heroi { get; set; }
	}
}

