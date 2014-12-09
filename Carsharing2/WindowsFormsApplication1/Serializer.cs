using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Carsharing
{
    [Serializable]
    public static class Serializer
    {
        // Speichern
        public static void SaveObject(object o, string file)
        {
            FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, o);
            fs.Close();
        }
        // Laden
        public static object LoadObject(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Object o = bf.Deserialize(fs);
            fs.Close();
            return o;
        }
    }
}
