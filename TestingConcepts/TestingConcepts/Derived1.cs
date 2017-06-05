using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConcepts
{
    public class Derived1 : Base
    {
        private const string version = "SCA2014SP2";

        public override string VersionName
        {
            get { return VersionHelper.GetVersion(version); }
        }
    }
}
