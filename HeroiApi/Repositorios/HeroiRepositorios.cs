using System;
using HeroiApi.Data;
using HeroiApi.Models;
using HeroiApi.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeroiApi.Repositorios
{
    public class HeroiRepositorios : IHeroiRepositorios
    {
        private readonly HeroiDbContext _context;
        public HeroiRepositorios(HeroiDbContext context) {
            _context = context;
        }


        public async Task<List<Heroi>> BuscarPorTodos()
        {
            return await _context.Herois.ToListAsync();
        }

        public async Task<Heroi> BuscarPorId(int id)
        {
            return await _context.Herois.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<Heroi> Adicionar(Heroi heroi)
        {
            await _context.Herois.AddAsync(heroi);
            await _context.SaveChangesAsync();

            return heroi;
        }

        public async Task<Heroi> Atualizar(Heroi heroi, int id)
        {
            Heroi heroiPutId = await BuscarPorId(id);

            if(heroiPutId == null)
            {
                throw new NotImplementedException($"O {id} não foi encontrado");
            }

            heroiPutId.Name = heroi.Name;
            heroiPutId.Armas = heroi.Armas;

            _context.Herois.Update(heroiPutId);
            await _context.SaveChangesAsync();

            return heroiPutId;
        }

        public async Task<bool> Apagar(int id)
        {
            Heroi heroiPutId = await BuscarPorId(id);

            if (heroiPutId == null)
            {
                throw new NotImplementedException($"O {id} não foi encontrado");
            }

            _context.Remove(heroiPutId);
            await _context.SaveChangesAsync();

            return true;
        }



    }
}

