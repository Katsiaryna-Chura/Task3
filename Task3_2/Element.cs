using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{

    public class Element : ILoggable
    {
        public string Name { get; private set; }

        public virtual bool Click()
        {
            return false;
        }

        public void Log(string text)
        {
            //throw new NotImplementedException();
        }

        public virtual bool SetText(string text)
        {
            return false;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

}
