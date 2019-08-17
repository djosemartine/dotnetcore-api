using BaseAPI.DBContexts;
using BaseAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteContext _context;

        public NoteRepository(NoteContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddNoteAsync(Note note)
        {
            using (var db = _context)
            {
                await db.Notes.AddAsync(note);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Note>> GetNotesAsync()
        {
            using (var db = _context)
            {
                return await db.Notes.ToListAsync();
            }
        }
    }
}
