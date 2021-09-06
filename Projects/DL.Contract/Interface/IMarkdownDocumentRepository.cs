using System.Threading.Tasks;
using DL.Contract.Model;

namespace DL.Contract.Interface
{
    public interface IMarkdownDocumentRepository
    {
        public Task<MarkdownDocument> GetMarkdownDocumentByIdAsync(int id);
    }
}