using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public class AppConfiguration
    {
        public string Language { get; protected set; }

        public AppConfiguration(string filePath)
        {
            LoadConfiguration(filePath);
        }

        protected virtual void LoadConfiguration(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
