namespace ModCommader.ModLoader
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Serialization;

    public static class Extensions
    {
        #region XML related

        public static string GetInnerTextSave(this XmlDocument doc, string xpath)
        {
            XmlNode node = doc.SelectSingleNode(xpath);
            if (node == null)
                return string.Empty;
            else
                return node.InnerText;
        }

        public static string GetInnerTextNormalized(this XmlDocument doc, string xpath)
        {
            string result = doc.GetInnerTextSave(xpath);
            NormalizeText(ref result);
            return result;
        }

        public static string GetInnerTextSave(this XmlNode node, string xpath)
        {
            XmlNode selectedNode = node.SelectSingleNode(xpath);
            if (selectedNode == null)
                return string.Empty;
            else
                return selectedNode.InnerText;
        }

        public static string GetInnerTextNormalized(this XmlNode node, string xpath)
        {
            string result = node.GetInnerTextSave(xpath);
            NormalizeText(ref result);
            return result;
        }

        #endregion XML related

        #region XML Serialization

        #region Private fields
        private static readonly Dictionary<RuntimeTypeHandle, XmlSerializer> ms_serializers = new Dictionary<RuntimeTypeHandle, XmlSerializer>();
        #endregion

        #region Public methods
        /// <summary>
        ///   Serialize object to xml string by <see cref = "XmlSerializer" />
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "value"></param>
        /// <returns></returns>
        public static string ToXml<T>(this T value)
            where T : new()
        {
            var _serializer = GetValue(typeof(T));
            using (var _stream = new MemoryStream())
            {
                using (var _writer = new XmlTextWriter(_stream, new UTF8Encoding()))
                {
                    _serializer.Serialize(_writer, value);
                    return Encoding.UTF8.GetString(_stream.ToArray());
                }
            }
        }
        /// <summary>
        ///   Serialize object to stream by <see cref = "XmlSerializer" />
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "value"></param>
        /// <param name = "stream"></param>
        public static void ToXml<T>(this T value, Stream stream)
            where T : new()
        {
            var _serializer = GetValue(typeof(T));
            _serializer.Serialize(stream, value);
        }

        /// <summary>
        ///   Deserialize object from string
        /// </summary>
        /// <typeparam name = "T">Type of deserialized object</typeparam>
        /// <param name = "srcString">Xml source</param>
        /// <returns></returns>
        public static T FromXml<T>(this string srcString)
            where T : new()
        {
            var _serializer = GetValue(typeof(T));
            using (var _stringReader = new StringReader(srcString))
            {
                using (XmlReader _reader = new XmlTextReader(_stringReader))
                {
                    return (T)_serializer.Deserialize(_reader);
                }
            }
        }
        /// <summary>
        ///   Deserialize object from stream
        /// </summary>
        /// <typeparam name = "T">Type of deserialized object</typeparam>
        /// <param name = "source">Xml source</param>
        /// <returns></returns>
        public static T FromXml<T>(this Stream source)
            where T : new()
        {
            var _serializer = GetValue(typeof(T));
            return (T)_serializer.Deserialize(source);
        }
        #endregion

        #region Private methods
        private static XmlSerializer GetValue(Type type)
        {
            XmlSerializer _serializer;
            if (!ms_serializers.TryGetValue(type.TypeHandle, out _serializer))
            {
                lock (ms_serializers)
                {
                    if (!ms_serializers.TryGetValue(type.TypeHandle, out _serializer))
                    {
                        _serializer = new XmlSerializer(type);
                        ms_serializers.Add(type.TypeHandle, _serializer);
                    }
                }
            }
            return _serializer;
        }
        #endregion

        #endregion XMl Serialization

        #region String operations

        public static string Args(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string NormalizeText(this string s)
        {
            NormalizeText(ref s);
            return s;
        }

        static void NormalizeText(ref string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                s = s.Replace("\r\n", " ");
                s = s.Replace("\t", " ");
                s = new Regex(@"\s+", RegexOptions.Compiled).Replace(s, " ");
                s = new Regex(@"\A\s+", RegexOptions.Compiled).Replace(s, string.Empty);
            }
        }

        #endregion String operations

        #region IO

        public static string CalcMD5(this FileInfo fileInfo)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var input = File.OpenRead(fileInfo.FullName))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    md5.TransformBlock(buffer, 0, bytesRead, buffer, 0);
                }

                byte[] filenameBytes = Encoding.GetEncoding(28591).GetBytes(Path.GetFileNameWithoutExtension(fileInfo.Name));

                md5.TransformBlock(filenameBytes, 0, filenameBytes.Length, buffer, 0);

                // We have to call TransformFinalBlock, but we don't have any more data - just provide 0 bytes.
                md5.TransformFinalBlock(buffer, 0, 0);

                byte[] md5Hash = md5.Hash;

                return BitConverter.ToString(md5Hash).Replace("-", "").ToLower();
            }
        }

        #endregion
    }
}
