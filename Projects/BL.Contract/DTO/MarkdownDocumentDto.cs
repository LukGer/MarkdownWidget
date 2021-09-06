using System;
using System.Collections.Generic;

namespace BL.Contract.DTO
{
    public class MarkdownDocumentDto
    {
        public int                    Id                  { get; set; }
        public string                 Title               { get; set; }
        public IList<MarkdownPageDto> Pages               { get; set; }
        public DateTime               LastChangeTimestamp { get; set; }
    }
}