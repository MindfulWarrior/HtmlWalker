using System;
using System.Net;
using System.Xml;

namespace ConsoleApplication2
{
    class Program
    {
        public class HtmlResolver : XmlUrlResolver
        {
            public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
            {
                if (absoluteUri.AbsoluteUri.Equals("urn:XHTMLEntities", StringComparison.OrdinalIgnoreCase))
                {
                    //ensure the embedded resource is suitably namespaced
                    return System.Reflection.Assembly.GetExecutingAssembly().
                        GetManifestResourceStream("ConsoleApplication2.xhtml-entities.ent");
                }
                return base.GetEntity(absoluteUri, role, ofObjectToReturn);
            }

            public override Uri ResolveUri(Uri baseUri, string relativeUri)
            {
                //make all the XHTML urls resolve to the single "dtd" which is actually just the entities
                if (relativeUri.Equals("-//W3C//DTD XHTML 1.0 Transitional//EN", StringComparison.OrdinalIgnoreCase)
                    || relativeUri.Equals("-//W3C//DTD XHTML 1.0 Strict//EN", StringComparison.OrdinalIgnoreCase)
                    || relativeUri.Equals("-//W3C//DTD XHTML 1.0 Frameset//EN", StringComparison.OrdinalIgnoreCase)
                    || relativeUri.Equals("-//W3C//DTD XHTML 1.1//EN", StringComparison.OrdinalIgnoreCase))
                {
                    return new Uri("urn:XHTMLEntities");
                }
                return base.ResolveUri(baseUri, relativeUri);
            }
        }

        static void Main(string[] args)
        {
            XmlResolver resolver = new HtmlResolver();
            //resolver.Credentials = CredentialCache.DefaultCredentials;
            
            XmlDocument input = new XmlDocument();
            input.XmlResolver = resolver;

            //XmlNamespaceManager ns = new XmlNamespaceManager(input.NameTable);
            //ns.AddNamespace("html", "http://www.w3.org/1999/xhtml");

            XmlTextReader reader = new XmlTextReader("test.xhtml");
            reader.XmlResolver = resolver;

            input.Load(reader);
        }
    }
}
