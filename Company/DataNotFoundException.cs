using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class DataNotFoundException:Exception
    {
        public DataNotFoundException() : base("User not found.")
        {

        }
    }
}
