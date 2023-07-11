using System;
namespace HeroiApi.Models
{
	public class Batalhas
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Description { get; set; }

		public DateTime DtInicio { get; set; }

		public DateTime DtFim { get; set; }
	}
}

