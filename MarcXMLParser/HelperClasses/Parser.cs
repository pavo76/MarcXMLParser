using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using MarcXMLParser.Models;

namespace MarcXMLParser.HelperClasses
{
    public class Parser
    {
        public static Record Parse(string xml)
        {
            Record record = new Record();
            XElement root = XElement.Parse(xml);
            IEnumerable<XElement> nodes =
                from el in root.Elements()
                select el;

            foreach(XElement node in nodes)
            {
                if(node.Name.LocalName== "leader")
                {
                     record.Leader= node.Value;
                }
                if(node.Name.LocalName=="controlfield" && node.Attribute("tag").Value=="008")
                {
                    record.ControlField008 = node.Value;
                }
                if(node.Name.LocalName == "datafield" && node.Attribute("tag").Value == "040")
                {
                    record.Datafield040 = new Datafield040();
                    IEnumerable<XElement> subnodes =
                        from el in node.Elements()
                        select el;
                    foreach(XElement subnode in subnodes)
                    {
                        if(subnode.Name.LocalName=="subfield" && subnode.Attribute("code").Value=="a")
                        {
                            record.Datafield040.SubfieldA = subnode.Value;
                        }
                        if (subnode.Name.LocalName == "subfield" && subnode.Attribute("code").Value == "b")
                        {
                            record.Datafield040.SubfieldB = subnode.Value;
                        }
                        if (subnode.Name.LocalName == "subfield" && subnode.Attribute("code").Value == "c")
                        {
                            record.Datafield040.SubfieldC = subnode.Value;
                        }
                        if (subnode.Name.LocalName == "subfield" && subnode.Attribute("code").Value == "e")
                        {
                            record.Datafield040.SubfieldE = subnode.Value;
                        }
                    }
                }

            }
            return record;
        }
    }
}