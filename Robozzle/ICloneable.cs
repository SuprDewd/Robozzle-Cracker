using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robozzle
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}