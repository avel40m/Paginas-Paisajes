using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Paisajes.Data;
using Paisajes.Models;
using Turismo.Models;

namespace Paisajes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<PaisajeModel> listaPaisaje = _context.PaisajeModel.Where(c => c.paisModel.Nombre == "Argentina").OrderByDescending(p => p.Valoracion).Take(3).ToList();
            ViewBag.Pais = listaPaisaje;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paisajeModel = await _context.PaisajeModel
                .Include(p => p.ciudadModel)
                .Include(p => p.paisModel)
                .Include(p => p.provinciaModel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paisajeModel == null)
            {
                return NotFound();
            }

            return View(paisajeModel);
        }

        public IActionResult Argentina(){
            var argentina = _context.PaisajeModel.ToList();
            return View(argentina);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
