using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICore.Commands
{
    class CreateIDFile : ICommand
    {
        public object Execute()
        {
            dynamic id = new IdentityGenerator().GenerateJson();
        }
    }
}
