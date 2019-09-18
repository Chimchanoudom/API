using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Unwrap
{
    interface IUnwrappable
    {
        object unwrap(params object[] data);

       

    }
}
