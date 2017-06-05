using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConcepts
{
    interface IBase
    {
        string VersionName { get; }
    }

    public abstract class Base : IBase
    {
        public virtual string VersionName { get { return ""; } }
    }
}
