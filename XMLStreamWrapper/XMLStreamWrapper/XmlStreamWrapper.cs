using System;
using System.Xml.Serialization;
using System.Threading;
using System.Diagnostics;

namespace XMLStreamWrapper
{
    public class XmlSerializerWrapper<ObjectType>
    {
        public XmlSerializer Serializer { get; set; }       // Xmlシリアライザ
        public string FileName { get; set; }                // 保存先ファイル名
        public ObjectType TargetObject { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="type"></param>
        public XmlSerializerWrapper(in ObjectType serializeTarget, in string fileName)
        {
            Serializer = new XmlSerializer(typeof(ObjectType));
            TargetObject = serializeTarget;
            FileName = fileName;
        }
    }
}
