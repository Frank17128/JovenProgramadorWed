using JovenProgramadorWed.Models;

namespace JovenProgramadorWed.Data.Mapeamento.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {

        void CadastrarAluno(Aluno aluno);

        List<Aluno> BuscarAluno();
        
    }
}
