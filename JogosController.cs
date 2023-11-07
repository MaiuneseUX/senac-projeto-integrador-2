using Microsoft.AspNetCore.Mvc;
using Projeto_Integrador.Models;
using System.Collections.Generic;

namespace Projeto_Integrador.Controllers
{
    public class JogosController : Controller
    {
        private readonly JogoRepository jogoRepository;

        public JogosController()
        {
            jogoRepository = new JogoRepository();
        }

        public IActionResult Index()
        {
            var jogos = jogoRepository.GetAll();
            return View(jogos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                jogoRepository.Add(jogo);
                return RedirectToAction("Index");
            }
            return View(jogo);
        }

        public IActionResult Edit(int id)
        {
            var jogo = jogoRepository.GetById(id);
            if (jogo != null)
            {
                return View(jogo);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                jogoRepository.Update(jogo);
                return RedirectToAction("Index");
            }
            return View(jogo);
        }

        public IActionResult Delete(int id)
        {
            jogoRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
