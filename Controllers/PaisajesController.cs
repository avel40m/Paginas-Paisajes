using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Paisajes.Data;
using Turismo.Models;

namespace Paisajes.Controllers
{
    public class PaisajesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PaisajesController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment )
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Paisajes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PaisajeModel.Include(p => p.ciudadModel).Include(p => p.paisModel).Include(p => p.provinciaModel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Paisajes/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Paisajes/Create
        public IActionResult Create()
        {
            ViewData["IdCiudad"] = new SelectList(_context.CiudadModel, "Id", "Nombre");
            ViewData["IdPais"] = new SelectList(_context.PaisModel, "Id", "Nombre");
            ViewData["IdProvincia"] = new SelectList(_context.ProvinciaModel, "Id", "Nombre");
            return View();
        }

        // POST: Paisajes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Lugar,Direccion,Descripcion,ImageFile,Valoracion,IdPais,IdProvincia,IdCiudad")] PaisajeModel paisajeModel)
        {
            if (ModelState.IsValid)
            {

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(paisajeModel.ImageFile.FileName);
                string extension = Path.GetExtension(paisajeModel.ImageFile.FileName);
                paisajeModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await paisajeModel.ImageFile.CopyToAsync(fileStream);
                }

                _context.Add(paisajeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCiudad"] = new SelectList(_context.CiudadModel, "Id", "Nombre", paisajeModel.IdCiudad);
            ViewData["IdPais"] = new SelectList(_context.PaisModel, "Id", "Nombre", paisajeModel.IdPais);
            ViewData["IdProvincia"] = new SelectList(_context.ProvinciaModel, "Id", "Nombre", paisajeModel.IdProvincia);
            return View(paisajeModel);
        }

        // GET: Paisajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paisajeModel = await _context.PaisajeModel.FindAsync(id);
            if (paisajeModel == null)
            {
                return NotFound();
            }
            ViewData["IdCiudad"] = new SelectList(_context.CiudadModel, "Id", "Nombre", paisajeModel.IdCiudad);
            ViewData["IdPais"] = new SelectList(_context.PaisModel, "Id", "Nombre", paisajeModel.IdPais);
            ViewData["IdProvincia"] = new SelectList(_context.ProvinciaModel, "Id", "Nombre", paisajeModel.IdProvincia);
            return View(paisajeModel);
        }

        // POST: Paisajes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Lugar,Direccion,Descripcion,ImageName,Valoracion,IdPais,IdProvincia,IdCiudad")] PaisajeModel paisajeModel)
        {
            if (id != paisajeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paisajeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaisajeModelExists(paisajeModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCiudad"] = new SelectList(_context.CiudadModel, "Id", "Nombre", paisajeModel.IdCiudad);
            ViewData["IdPais"] = new SelectList(_context.PaisModel, "Id", "Nombre", paisajeModel.IdPais);
            ViewData["IdProvincia"] = new SelectList(_context.ProvinciaModel, "Id", "Nombre", paisajeModel.IdProvincia);
            return View(paisajeModel);
        }

        // GET: Paisajes/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Paisajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paisajeModel = await _context.PaisajeModel.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath,"Image",paisajeModel.ImageName);

            if(System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            
            _context.PaisajeModel.Remove(paisajeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PaisajeModelExists(int id)
        {
            return _context.PaisajeModel.Any(e => e.Id == id);
        }
    }
}
