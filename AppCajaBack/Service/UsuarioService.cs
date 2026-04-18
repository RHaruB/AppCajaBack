using ApiCaja.Data;
using AppCajaBack.Data;
using AppCajaBack.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AppCajaBack.Service
{

    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public Usuario Create(Usuario user)
        {
            if (_context.Usuarios.Any(u => u.Username == user.Username))
                throw new Exception("El usuario ya existe");

            _context.Usuarios.Add(user);
            _context.SaveChanges();

            return user;
        }

        public Usuario Update(int id, Usuario user)
        {
            var existing = _context.Usuarios.Find(id);

            if (existing == null)
                return null;

            existing.Username = user.Username;
            existing.Rol = user.Rol;
            existing.Activo = user.Activo;

            _context.SaveChanges();

            return existing;
        }

        public bool Delete(int id)
        {
            var user = _context.Usuarios.Find(id);

            if (user == null)
                return false;

            _context.Usuarios.Remove(user);
            _context.SaveChanges();

            return true;
        }
    }
}