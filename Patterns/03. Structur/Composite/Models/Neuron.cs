using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns._03._Structur.Composite.Models
{
    public class Neuron : IEnumerable<Neuron>
    {
        #region Public Constructors

        public Neuron(string name)
        {
            Name = name;
            Into = new List<Neuron>();
            Out = new List<Neuron>();
        }

        #endregion Public Constructors

        #region Public Properties

        public string Name { get; private set; }

        #endregion Public Properties

        #region Private Properties

        private List<Neuron> Into { get; set; }
        private List<Neuron> Out { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void ConnectTo(Neuron other)
        {
            Out.Add(other);
            other.Into.Add(this);
        }

        public void DoWork()
        {
            Console.WriteLine(Name);
            foreach (var item in this)
            {
                item.DoWork();
            }
        }

        public IEnumerator<Neuron> GetEnumerator()
        {
            return this.Out.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion Public Methods
    }
}