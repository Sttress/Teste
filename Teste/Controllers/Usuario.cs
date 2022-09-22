using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Teste.Data;

namespace Teste.Controllers
{
    public class Usuario : Controller
    {
        private readonly ApplicationContext _db;

        public Usuario(ApplicationContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var teste = _db.Usuarios.ToList();
            return View(teste);
        }
    }
}
