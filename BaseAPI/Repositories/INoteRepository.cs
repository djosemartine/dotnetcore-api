using BaseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Repositories
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetNotesAsync();
        Task AddNoteAsync(Note note);
    }
}
