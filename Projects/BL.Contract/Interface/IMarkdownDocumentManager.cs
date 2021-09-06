using System.Threading.Tasks;
using BL.Contract.DTO;

namespace BL.Contract.Interface
{
    public interface IMarkdownDocumentManager
    {
        public Task<MarkdownDocumentDto> GetMarkdownDocumentByIdAsync(int id);
    }
}