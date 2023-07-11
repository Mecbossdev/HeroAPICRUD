using System;
using HeroiApi.Models;

namespace HeroiApi.Repositorios.Interfaces
{
	public interface IHeroiRepositorios
	{
		Task<List<Heroi>> BuscarPorTodos();

		Task<Heroi> BuscarPorId(int id);

		Task<Heroi> Adicionar(Heroi heroi);

		Task<Heroi> Atualizar(Heroi heroi, int id);

		Task<bool> Apagar(int id);

	}
}

