using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace XhtmlXsd
{
    public class XhtmlEntityResolver : XmlUrlResolver
    {
        public static readonly XhtmlEntityResolver Instance = new XhtmlEntityResolver();

        public static XmlDocument CreateXmlDocument()
        {
            var dom = new XmlDocument() { XmlResolver = Instance };
            return dom;
        }

        private XhtmlEntityResolver() { }

        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            if (absoluteUri == null)
                throw new ArgumentNullException("absoluteUri");

            Stream stream = null;

            if (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                if (absoluteUri.AbsoluteUri.Equals("urn:XHTMLEntities", StringComparison.OrdinalIgnoreCase))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml-entities.ent");
                else if (absoluteUri.AbsolutePath.ToLower().EndsWith("xhtml1-transitional.xsd"))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml1-transitional.xsd");
                else if (absoluteUri.AbsolutePath.ToLower().EndsWith("xhtml1-transitional.dtd"))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml1-transitional.dtd");
                else if (absoluteUri.AbsolutePath.ToLower().EndsWith("xhtml-lat1.ent"))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml-lat1.ent");
                else if (absoluteUri.AbsolutePath.ToLower().EndsWith("xhtml-symbol.ent"))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml-symbol.ent");
                else if (absoluteUri.AbsolutePath.ToLower().EndsWith("xhtml-special.ent"))
                    stream = assembly.GetManifestResourceStream("XhtmlXsd.xhtml-special.ent");
            }

            if (null == stream)
                return base.GetEntity(absoluteUri, role, ofObjectToReturn);
            return stream;
        }

        public override Uri ResolveUri(Uri baseUri, string relativeUri)
        {
            if (relativeUri.Equals("-//W3C//DTD XHTML 1.0 Transitional//EN", StringComparison.OrdinalIgnoreCase)
                || relativeUri.Equals("-//W3C//DTD XHTML 1.0 Strict//EN", StringComparison.OrdinalIgnoreCase)
                || relativeUri.Equals("-//W3C//DTD XHTML 1.0 Frameset//EN", StringComparison.OrdinalIgnoreCase)
                || relativeUri.Equals("-//W3C//DTD XHTML 1.1//EN", StringComparison.OrdinalIgnoreCase))
            {
                return new Uri("urn:XHTMLEntities");
            }
            return base.ResolveUri(baseUri, relativeUri);
        }

        public XmlReader GetSchemaResource(string resource)
        {
            Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(resource);
            XmlTextReader reader = new XmlTextReader(stream);
            return reader;
        }
    }
}