using System.Xml.Serialization;

XmlSerializer inst = new XmlSerializer(typeof(object));
TextWriter writer = new StreamWriter(@ "C:\Users\admin\Desktop\check.xml");
inst.Serialize(writer, c);
writer.Close();