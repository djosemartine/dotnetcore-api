using BaseAPI.Models;
using BaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _noteRepository;
        public NotesController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository ?? throw new ArgumentNullException(nameof(noteRepository));
        }

        /// <summary>
        /// Get All Notes
        /// </summary>
        /// <returns>Notes</returns>
        [HttpGet]
        public Task<IEnumerable<Note>> GetNotes()
        {
            return _noteRepository.GetNotesAsync();
        }

        /// <summary>
        /// Add a note
        /// </summary>
        /// <param name="note">Note to be added</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            _noteRepository.AddNoteAsync(note);
            return NoContent();
        }
    }
}
