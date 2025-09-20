using JovenProgramadorWed.Data.Mapiamento.Repositorio.Interfaces;
using JovenProgramadorWed.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovenProgramadorWed.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

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
                    TempData["MsgErro"] = "Usuário ou senha inválidos! Tente novamente...";
                }
            }
            catch (Exception)
            {

                TempData["MsgErro"] = "Usuário ou senha inválidos! Tente novamente...";
            }
            return View("Index");
        }

        public IActionResult Cadastro(Usuario usuario)
        {
            return View();
        }

        public IActionResult CadastrarUsuario(Usuario usuario)

        {

            try
            {
                _usuarioRepositorio.CadastrarUsuario(usuario);
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                TempData["MsgErro"] = "Erro ao cadastrar usuário";
            }
            return View("Index");
        }
    }
}
