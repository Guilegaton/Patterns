using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._03._Structur.Adapter
{
    public class AdapterProcess : IExampleService
    {
        public void StartExample()
        {
            var jsonAdapter = new JsonToXmlAdapter(@"C:\Users\julii.vedkal\source\repos\Patterns\Patterns\JsonFile.json");
            jsonAdapter.PrintXml();
        }
    }
}
