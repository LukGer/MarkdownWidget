using System.Threading.Tasks;
using AutoMapper;
using BL.Contract.DTO;
using BL.Contract.Interface;
using DL.Contract.Interface;

namespace BL.Manager
{
    public class MarkdownDocumentManager : IMarkdownDocumentManager
    {
        private readonly IMarkdownDocumentRepository _repo;
        private readonly IMapper                     _mapper;

        public MarkdownDocumentManager(
            IMarkdownDocumentRepository repo,
            IMapper mapper)
        {
            _repo   = repo;
            _mapper = mapper;
        }

        public async Task<MarkdownDocumentDto> GetMarkdownDocumentByIdAsync(int id)
        {
            return _mapper.Map<MarkdownDocumentDto>(await _repo.GetMarkdownDocumentByIdAsync(id));
        }
    }
}