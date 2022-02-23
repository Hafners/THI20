using System.Xml;
using System.Xml.Serialization;

namespace quickTest
{
    public class Program
    {
        public static string GetXMLFromObject(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter? tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }
        public static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch (Exception exp)
            {
                //Handle Exception Code
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }

        public static void Main()
        {
            Employee emp = new Employee();
            emp.FirstName = "Code";
            emp.LastName = "Handbook";

            string xml = GetXMLFromObject(emp);
            Console.WriteLine(xml);
            var path = "D:\\SE\\csLernen\\quickTest\\text.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Employee));
            writer.Serialize(file, emp);
            file.Close();

            Object obj = ObjectToXML(xml, typeof(Employee));
            Console.WriteLine(obj.GetType());

        }
    }

}