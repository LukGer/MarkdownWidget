using System.Collections.Generic;

namespace DL.Contract.Model
{
    using System;

    public class MarkdownDocument
    {
        public int                 Id                  { get; set; }
        public string              Title               { get; set; }
        public DateTime            LastChangeTimestamp { get; set; }
        public IList<MarkdownPage> Pages               { get; set; }
    }
}