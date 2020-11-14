using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace WrapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            XMLStreamWrapper.SimpleXmlSerializerWrapper<Sample> xmlSerializer = new XMLStreamWrapper.SimpleXmlSerializerWrapper<Sample>(sample, "age.xml");
            xmlSerializer.Serialize();
            List<Type> types = new List<Type>();

            foreach(Type type in types)
            {
                Console.WriteLine(type.Name);
            }
        }
    }

    public class Sample
    {
        public string Name { get; set; } = "No Name";
        public short Age { get; set; } = 20;
        private string _name;

        public Sample() {
            _name = "Name";
        }
    }
}
