using AppCajaBack.Data;

namespace AppCajaBack.Service.Interface
{
    public interface IUsuarioService
    {
        List<Usuario> GetAll();
        Usuario GetById(int id);
        Usuario Create(Usuario user);
        Usuario Update(int id, Usuario user);
        bool Delete(int id);
    }
}
