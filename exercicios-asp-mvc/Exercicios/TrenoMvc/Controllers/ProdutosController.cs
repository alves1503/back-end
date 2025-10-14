using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrenoMvc.Models;

namespace TrenoMvc.Controllers
{
    public class ProdutosController : Controller
    {







        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }







        //Exibir
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Produtos.ToListAsync();
            return View(dados);
        }







        //Criar Produto
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Produto produto)
        {

            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View();
        }
    }
}
