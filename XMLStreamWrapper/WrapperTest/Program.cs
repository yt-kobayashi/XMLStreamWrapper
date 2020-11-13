using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WrapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Write("Hello! Debug!!");

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("dic1", "DIC1");
            dic.Add("dic2", "DIC2");
            dic.Add("dic3", "DIC3");
            dic.Add("dic4", "DIC4");
            dic.Add("dic5", "DIC5");
            dic.Add("dic6", "DIC6");
            dic.Add("dic7", "DIC7");
            dic.Add("dic8", "DIC8");

            XMLStreamWrapper.XmlSerializerWrapper<Dictionary<string, string>> wrapper = new XMLStreamWrapper.XmlSerializerWrapper<Dictionary<string, string>>(dic, "aaa");
        }
    }
}
