using JovenProgramadorWed.Models;

namespace JovenProgramadorWed.Data.Mapiamento.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public void CadastrarUsuario(Usuario usuario);
        object ValidarUsuario(Usuario usuario);
    }
}
