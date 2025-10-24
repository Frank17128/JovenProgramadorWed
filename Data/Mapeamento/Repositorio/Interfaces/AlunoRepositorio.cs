using JovenProgramadorWed.Models;
namespace JovenProgramadorWed.Data.Mapeamento.Repositorio.Interfaces
{
    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void CadastrarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }
        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public void ExclirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        List<Aluno> IAlunoRepositorio.BuscarAluno()
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.ExcluirAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }

}
