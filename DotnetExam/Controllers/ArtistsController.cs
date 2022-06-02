#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotnetExam.Data;
using DotnetExam.Models;
using Microsoft.AspNetCore.Authorization;

namespace DotnetExam.Controllers
{
    [Authorize]
    public class ArtistsController : Controller
    {
        private readonly DotnetExamContext _context;

        public ArtistsController(DotnetExamContext context)
        {
            _context = context;
        }

        // GET: Artists
        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchString)
        {

            var artists =  from a in _context.Artist select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                artists = artists.Where(a => a.Name.Contains(searchString));
            }

            //_context.Song.Where(s => s.Id == id)

            return View(await artists.ToListAsync());
        }



        // GET: Artists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artist = await _context.Artist.Include(s => s.Songs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        // GET: Artists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artist);
        }

        // GET: Artists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //Variable artist der indeholder = fra context - fra artist -

            var artist = await _context.Artist.
                Include(s => s.Songs).
                FirstAsync(a => a.Id == id);

            //ViewData["Songs"] = new SelectList(_context.Song, "id", "Name");

            ViewData["Songs"] = _context.Song.ToList();

            if (artist == null)
            {
                return NotFound();
            }


            return View(new ArtistSongDTO() { Artist = artist });
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //spørg christian vedrørende 'bind'
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Artist artist)
        {

            if (id != artist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistExists(artist.Id))
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
            return View(artist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addSong(int id, [Bind("SongId")] ArtistSongDTO artist)
        {
            var selectedArtist = await _context.Artist.Where(a => a.Id == id).Include(a => a.Songs).FirstOrDefaultAsync();

            var selectedSong = await _context.Song.FindAsync(artist.SongId);

            selectedArtist.Songs.Add(selectedSong);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        // GET: Artists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artist = await _context.Artist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artist = await _context.Artist.FindAsync(id);

            var songs = await _context.Song.Where(x => x.ArtistId == id).ToListAsync();

            foreach (var song in songs)
            {
                song.ArtistId = null;
            }

            _context.UpdateRange(songs);
            _context.Artist.Remove(artist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistExists(int id)
        {
            return _context.Artist.Any(e => e.Id == id);
        }
    }
}