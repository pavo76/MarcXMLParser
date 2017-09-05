using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MarcXMLParser.HelperClasses
{
    public class ParserDict
    {

        public static Dictionary<string, string> Parse(string xml)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();


            XElement root = XElement.Parse(xml);
            IEnumerable<XElement> nodes =
                from el in root.Elements()
                select el;
            foreach(XElement node in nodes)
            {
                if(!node.HasAttributes && !node.HasElements)
                {
                    if(!dict.ContainsKey(node.Name.LocalName))
                    {
                        dict[node.Name.LocalName] = node.Value;
                    }
                }

                if (node.HasAttributes && !node.HasElements)
                {
                    if (!dict.ContainsKey(node.Name.LocalName +"_"+ node.Attribute("tag").Value))
                    {
                        dict[node.Name.LocalName+node.Attribute("tag").Value] = node.Value;
                    }
                }

                if (node.HasAttributes && node.HasElements)
                {
                    IEnumerable<XElement> subnodes =
                            from el in node.Elements()
                            select el;
                    
                    foreach (XElement subnode in subnodes)
                    {
                        if (!dict.ContainsKey(node.Name.LocalName +"_"+ node.Attribute("tag").Value + "_"+subnode.Attribute("code").Value))
                        {
                            dict[node.Name.LocalName +"_"+ node.Attribute("tag").Value + "_" + subnode.Attribute("code").Value] = subnode.Value;
                        }
                        else
                        {
                            dict[node.Name.LocalName +"_"+ node.Attribute("tag").Value + "_" + subnode.Attribute("code").Value] += " && " + subnode.Value;
                        }
                    }
                    
                }
            }


            return dict;
        }
    }
}