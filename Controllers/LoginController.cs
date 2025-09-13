using JovenProgramadorWed.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovenProgramadorWed.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                if(usuario.Email == "Francisco@gmail" && usuario.Senha == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Msgerro"] = "Erro ao buscar dados do usuario";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View("Index");
        }
    }
}
