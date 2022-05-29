using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotnetExam.Data;
using DotnetExam.Models;

namespace DotnetExam.Controllers
{
    public class SongsController : Controller
    {
        private readonly DotnetExamContext _context;

        public SongsController(DotnetExamContext context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index()
        {
            var dotnetExamContext = _context.Song.Include(a => a.artist);
            return View(await dotnetExamContext.ToListAsync());

            //return _context.Song != null ? 
            //            View(await _context.Song.ToListAsync()) :
            //            Problem("Entity set 'DotnetExamContext.Song'  is null.");
        }

        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.Include(s => s.comments)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }
           
            return View(song);
        }

        // GET: Songs/Create
        [HttpGet]
        public IActionResult Create()
        {

                ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name");
 
                //ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name", song.artist.Id);
        

            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ArtistId")] Song song)
        {

            //if (song.artist == null)
            //{
            //    ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name");
            //}
            //else
            //{
            //    ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name", song.artist.Id);
            //}

            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("index");
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.Where(s => s.Id == id).Include(a => a.artist).FirstOrDefaultAsync();


            
            
            if(song.artist == null)
            {
                ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name");
            }
            else
            {
                ViewData["Artists"] = new SelectList(_context.Artist, "Id", "Name", song.artist.Id);
            }
            



            if (song == null)
            {
                return NotFound();
            }
            return View(new SongArtistDTO { Song = song});
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Song song)
        {
            if (id != song.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.Id))
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
            return View(song);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetArtistOnSong(int id, [Bind("ArtistId")] SongArtistDTO songDTO) 
        {
            var selectedSong = await _context.Song.Where(s => s.Id == id).Include(a => a.artist).FirstOrDefaultAsync();

            var selectedArtist = await _context.Artist.FindAsync(songDTO.ArtistId);

            selectedSong.artist = selectedArtist;

            await _context.SaveChangesAsync();
            

            return RedirectToAction("Edit", new { @Id = id });
        }


        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Song == null)
            {
                return Problem("Entity set 'DotnetExamContext.Song'  is null.");
            }
            var song = await _context.Song.FindAsync(id);
            if (song != null)
            {
                _context.Song.Remove(song);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
          return (_context.Song?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
