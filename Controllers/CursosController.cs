using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaAc.Data;
using SistemaAc.ModelCategorias;
using SistemaAc.Models;

namespace SistemaAc.Controllers
{
    public class CursosController : Controller
    {
        private readonly ApplicationDbContext _context;
        CursoModels cursoModels;
        public CursosController(ApplicationDbContext context)
        {
            _context = context;
            cursoModels = new CursoModels(context);
        }



        public List<Categoria> getCategorias()
        {
            return cursoModels.getCategorias();
        }

        public List<IdentityError> agregarCurso(int id, string nombre, string descripcion, byte creditos, byte horas, decimal costo, Boolean estado, int categoria, string funcion)
        {
            return cursoModels.agregarCurso(id, nombre, descripcion, creditos, horas, costo, estado, categoria, funcion);
        }

        public List<object[]> filtrarCurso(int numPagina, string valor, string order)
        {
            return cursoModels.filtrarCurso(numPagina, valor, order);
        }
        // GET: Cursos
        public async Task<IActionResult> Index()
        {
          
            return View();
        }

        public List<Curso> getCursos(int id)
        {
            return cursoModels.getCursos(id);
        }

        public List<IdentityError> editarCurso(int id, string nombre, string descripcion, byte creditos, byte horas, decimal costo, Boolean estado, int categoria, int funcion)
        {
            return cursoModels.editarCurso(id, nombre, descripcion, creditos, horas, costo, estado, categoria, funcion);
        }
        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso
                .Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // GET: Cursos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaID"] = new SelectList(_context.Categoria, "CategoriaID", "Nombre");
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CursoID,Nombre,Descripcion,Creditos,Horas,Costo,Estado,CategoriaID")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categoria, "CategoriaID", "Nombre", curso.CategoriaID);
            return View(curso);
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categoria, "CategoriaID", "Nombre", curso.CategoriaID);
            return View(curso);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CursoID,Nombre,Descripcion,Creditos,Horas,Costo,Estado,CategoriaID")] Curso curso)
        {
            if (id != curso.CursoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoExists(curso.CursoID))
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
            ViewData["CategoriaID"] = new SelectList(_context.Categoria, "CategoriaID", "Nombre", curso.CategoriaID);
            return View(curso);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso
                .Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curso = await _context.Curso.FindAsync(id);
            _context.Curso.Remove(curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoExists(int id)
        {
            return _context.Curso.Any(e => e.CursoID == id);
        }
    }
}
