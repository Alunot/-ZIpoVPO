using System;
using System.Collections.Generic;
using System.Text;

namespace Antimalware.DomainObjects.ScanObjectAbstraction
{
    public interface IObjectContent
    {
        ulong Size { get; }
        bool Read(ulong Position, byte[] data, out uint readBytesCount);
    }
}
