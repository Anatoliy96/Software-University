using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Detail_Printer.Interfaces
{
    public interface IDocuments
    {
        IReadOnlyCollection<string> Documents { get; }
    }
}
