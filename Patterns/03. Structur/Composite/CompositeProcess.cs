using Patterns._03._Structur.Composite.Models;
using Patterns.Interfaces;

namespace Patterns._03._Structur.Composite
{
    public class CompositeProcess : IExampleService
    {
        #region Public Methods

        public void StartExample()
        {
            var neuron1 = new Neuron("Neuron-1");
            var neuron11 = new Neuron("Neuron-1-1");
            var neuron12 = new Neuron("Neuron-1-2");
            var neuron13 = new Neuron("Neuron-1-3");
            var neuron14 = new Neuron("Neuron-1-4");

            var neuron121 = new Neuron("Neuron-1-2-1");
            var neuron122 = new Neuron("Neuron-1-2-2");
            var neuron123 = new Neuron("Neuron-1-2-3");
            var neuron124 = new Neuron("Neuron-1-2-4");

            var neuron1241 = new Neuron("Neuron-1-2-4-1");
            var neuron1242 = new Neuron("Neuron-1-2-4-2");
            var neuron1243 = new Neuron("Neuron-1-2-4-3");
            var neuron1244 = new Neuron("Neuron-1-2-4-4");

            neuron1.ConnectTo(neuron11);
            neuron1.ConnectTo(neuron12);
            neuron1.ConnectTo(neuron13);
            neuron1.ConnectTo(neuron14);

            neuron12.ConnectTo(neuron121);
            neuron12.ConnectTo(neuron122);
            neuron12.ConnectTo(neuron123);
            neuron12.ConnectTo(neuron124);

            neuron124.ConnectTo(neuron1241);
            neuron124.ConnectTo(neuron1242);
            neuron124.ConnectTo(neuron1243);
            neuron124.ConnectTo(neuron1244);

            neuron1.DoWork();
        }

        #endregion Public Methods
    }
}