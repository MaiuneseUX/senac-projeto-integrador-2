using System.Collections.Generic;
using System.Linq;

namespace Projeto_Integrador.Models
{
    public class UsuarioRepository
    {
        private List<Usuario> usuarios;

        public UsuarioRepository()
        {
            // Inicializa a lista de usuários
            usuarios = new List<Usuario>();
        }

        public void Add(Usuario usuario)
        {
            // Adiciona um novo usuário à lista
            usuarios.Add(usuario);
        }

        public Usuario GetByEmail(string email)
        {
            // Retorna o usuário com o email especificado
            return usuarios.FirstOrDefault(u => u.Email == email);
        }

        public Usuario GetByEmailAndPassword(string email, string senha)
        {
            // Retorna o usuário com o email e senha especificados
            return usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario GetByCredentials(string email, string senha)
        {
            // Retorna o usuário com as credenciais de login especificadas
            return usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
