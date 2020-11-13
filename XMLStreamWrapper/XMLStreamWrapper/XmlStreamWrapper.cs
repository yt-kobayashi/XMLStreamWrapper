using System;
using System.Xml.Serialization;

namespace XMLStreamWrapper
{
    public class XmlSerializerWrapper<ObjectType>
    {
        public XmlSerializer Serializer { get; set; }       // Xmlシリアライザ
        public string FileName { get; set; }                // 保存先ファイル名

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="type"></param>
        public XmlSerializerWrapper(in ObjectType serializeTarget, in string fileName)
        {
            Serializer = new XmlSerializer(typeof(ObjectType));
            FileName = fileName;
        }
    }
}
