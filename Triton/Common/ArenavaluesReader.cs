namespace Triton.Common
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;

    public class ArenavaluesReader
    {
        public Dictionary<string, int> ArenaValues = new Dictionary<string, int>();
        private static ArenavaluesReader arenavaluesReader_0 = null;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private const string string_0 = "./ArenaValues.xml";

        public void ReadXML()
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(new StringReader(File.ReadAllText("./ArenaValues.xml"))))
                {
                    while (reader.ReadToFollowing("arena-value"))
                    {
                        try
                        {
                            reader.MoveToFirstAttribute();
                            string key = reader.Value;
                            reader.MoveToNextAttribute();
                            int num = int.Parse(reader.Value);
                            this.ArenaValues.Add(key, num);
                            continue;
                        }
                        catch (Exception exception)
                        {
                            ilog_0.Error("Error during arenavalues parsing : " + exception.Message);
                            continue;
                        }
                    }
                }
            }
            catch (Exception exception2)
            {
                ilog_0.Error("Error during ./ArenaValues.xml parsing : " + exception2.Message);
            }
        }

        public static ArenavaluesReader Get
        {
            get
            {
                if (arenavaluesReader_0 == null)
                {
                    arenavaluesReader_0 = new ArenavaluesReader();
                    arenavaluesReader_0.ReadXML();
                }
                return arenavaluesReader_0;
            }
        }
    }
}

