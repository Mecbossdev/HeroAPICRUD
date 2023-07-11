using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroiApi.Models;
using HeroiApi.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HeroiApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IHeroiRepositorios _repo;
        public ValuesController(IHeroiRepositorios repo)
        {
            _repo = repo;
        }


        [HttpGet]

        public async Task<ActionResult<List<Heroi>>> BuscarPorTodos()
        {
            List<Heroi> heroi = await _repo.BuscarPorTodos();
            return Ok(heroi);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Heroi>> BuscarPorId(int id)
        {
            Heroi heroi = await _repo.BuscarPorId(id);
            return Ok(heroi);
        }

        [HttpPost]

        public async Task<ActionResult<Heroi>> Cadastrar([FromBody] Heroi heroi) {

            Heroi herois = await _repo.Adicionar(heroi);
            return (herois);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Heroi>> Atualizar([FromBody] Heroi heroi, int id)
        {
            heroi.Id = id;
            Heroi herois = await _repo.Atualizar(heroi, id);
            return (herois);
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult<Heroi>> Delete(int id)
        {
            bool heroi = await _repo.Apagar(id);
            return heroi;
        }
    }
}

