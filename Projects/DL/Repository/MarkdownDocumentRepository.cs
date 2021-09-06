using System.Threading.Tasks;
using DL.Contract.Interface;
using DL.Contract.Model;

namespace DL.Repository
{
    public class MarkdownDocumentRepository : IMarkdownDocumentRepository
    {
        public Task<MarkdownDocument> GetMarkdownDocumentByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}