using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConcepts
{
    public class Derived2 : Derived1
    {
        private const string version = "7.5.23";

        public override string VersionName
        {
            get { return VersionHelper.GetVersion(version); }
        }
    }
}
