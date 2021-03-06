#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DotnetExam.Data;
using DotnetExam.Models;
using Microsoft.AspNetCore.Authorization;

namespace DotnetExam.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {
        private readonly DotnetExamContext _context;

        public AlbumsController(DotnetExamContext context)
        {
            _context = context;
        }

        // GET: Albums
        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchString)
        {
            var albums = from a in _context.Album select a;
           
           

            if (!String.IsNullOrEmpty(searchString))
            {
                albums = albums.Where(a => a.Name.Contains(searchString));
            }

            return View(await albums.ToListAsync());
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album.Include(s => s.Songs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var album = await _context.Album.Where(a => a.Id == id).ToListAsync();

            var album = await _context.Album.Include(s => s.Songs).FirstAsync(a => a.Id == id);


            ViewData["Songs"] = new SelectList(_context.Song, "Id", "Name");

            if (album == null)
            {
                return NotFound();
            }
            return View(new AlbumSongDTO() { Album = album });
        }



        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Album album)
        {
            if (id != album.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(album);
                await _context.SaveChangesAsync();
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.Id))
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
            return RedirectToAction("Edit", new { @id = id });

        }

        //////////////////////////////
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addSong(int id, [Bind("SongId")] AlbumSongDTO album)
        {
            var selectedAlbum = await _context.Album.Where(a => a.Id == id).Include(a => a.Songs).FirstOrDefaultAsync();

            var selectedSong = await _context.Song.FindAsync(album.SongId);

            selectedAlbum.Songs.Add(selectedSong);

            await _context.SaveChangesAsync();


            return RedirectToAction("Edit", new { @id = id });
        }

        //////////////////////////////
        [HttpPost]
        public async Task<IActionResult> RemoveSong(int id, [Bind("SongId")] AlbumSongDTO album)
        {
            var selectedAlbum = await _context.Album.Where(a => a.Id == id).Include(a => a.Songs).FirstOrDefaultAsync();

            var selectedSong = await _context.Song.FindAsync(album.SongId);

            selectedAlbum.Songs.Remove(selectedSong);

            await _context.SaveChangesAsync();

            return RedirectToAction("Edit", new { @id = id });

            //"Edit","controller", new {@id=id}
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Album.FindAsync(id);
            _context.Album.Remove(album);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
            return _context.Album.Any(e => e.Id == id);
        }
    }
}