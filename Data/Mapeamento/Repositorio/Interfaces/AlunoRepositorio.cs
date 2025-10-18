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
        public List<Aluno> BuscarAluno()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }

}
