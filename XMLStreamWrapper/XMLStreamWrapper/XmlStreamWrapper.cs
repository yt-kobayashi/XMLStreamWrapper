using System;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

namespace XMLStreamWrapper
{
    public class SimpleXmlSerializerWrapper<ObjectType>
    {
        public ObjectType TargetObject { get; set; }        // シリアライズ対象オブジェクト
        public XmlSerializer Serializer { get; set; }       // Xmlシリアライザ
        public string FilePath { get; set; }                // 保存先ファイルパス

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="serializeTarget">シリアライズオブジェクト</param>
        /// <param name="filePath">保存ファイルパス</param>
        public SimpleXmlSerializerWrapper(in ObjectType serializeTarget, in string filePath)
        {
            Serializer = new XmlSerializer(typeof(ObjectType));
            TargetObject = serializeTarget;
            FilePath = filePath;
        }

        /// <summary>
        /// シリアライズメソッド
        /// </summary>
        public void Serialize()
        {
            StreamWriter stream = new StreamWriter(FilePath, false, Encoding.UTF8);
            Serializer.Serialize(stream, TargetObject);
            stream.Close();
        }

        /// <summary>
        /// デシリアライズメソッド
        /// </summary>
        /// <returns>読み込んだオブジェクト</returns>
        public ObjectType Deserialize()
        {
            StreamReader reader = new StreamReader(FilePath, Encoding.UTF8);
            TargetObject = (ObjectType)Serializer.Deserialize(reader);
            reader.Close();

            return TargetObject;
        }
    }
}
