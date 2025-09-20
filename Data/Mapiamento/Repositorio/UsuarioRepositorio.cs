using JovenProgramadorWed.Data.Mapiamento.Repositorio.Interfaces;
using JovenProgramadorWed.Models;

namespace JovenProgramadorWed.Data.Mapiamento.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            _bancoContexto.Usuario.Add(usuario);
            _bancoContexto.SaveChanges();
        }
        
    }
}
