using JovenProgramadorWed.Data.Mapeamento.Repositorio.Interfaces;
using JovenProgramadorWed.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovenProgramadorWed.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAluno();

            return View(aluno);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult CadastrarAluno(Aluno aluno)
        {

            try
            {
                _alunoRepositorio.CadastrarAluno(aluno);

                TempData["Msgok"] = "Aluno Cadastrado com sucesso!!!";

                return RedirectToAction("Index", "aluno");

            }
            catch (Exception e)
            {

                TempData["MsgErro"] = "Erro ao cadastrar Aluno";
            }


            return View("Index");
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult EditarAluno(Aluno aluno)
        {
            _alunoRepositorio.EditarAluno(aluno);
            return RedirectToAction("Index");
        }
        
        public IActionResult ExcluirAluno(Aluno aluno)
        {
            {
                _alunoRepositorio.ExcluirAluno(aluno);
                return RedirectToAction("Index");
            }

        }
    }
}
