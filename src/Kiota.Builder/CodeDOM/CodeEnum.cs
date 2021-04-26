using System;
using System.Collections.Generic;
using System.Linq;

namespace Kiota.Builder
{
    public class CodeEnum : CodeElement, IDocumentedElement, ITypeDefinition {
        public CodeEnum(CodeElement parent) : base(parent)
        {
            
        }
        public override IList<CodeElement> GetChildElements()
        {
            return Enumerable.Empty<CodeElement>().ToList();
        }
        public List<string> Options { get; set; } = new List<string>();
        public bool Flags { get; set; }
        public string Description {get; set;}
    }
}
