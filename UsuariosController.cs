using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Integrador.Models;

namespace Projeto_Integrador.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                // Remova a chamada para o método GetByEmailAndPassword

                // Redirecione diretamente para a página inicial
                return RedirectToAction("Index", "Home");
            }

            return View(loginViewModel);
        }
    }
}
