using System.IO;
using System.Text;

namespace HtmlWalker.Platform
{
    public abstract partial class WalkerPlatform
    {
        public abstract class WalkerDocument
        {
            private DocumentTag documentTag = null;

            internal protected WalkerDocument() { }

            public DocumentTag DocumentTag
            {
                get
                {
                    if (this.documentTag == null)
                        this.documentTag = new DocumentTag(Factory, DocumentNode);
                    return this.documentTag;
                }
            }

            /// <summary>
            ///   The <see cref="WalkerPlatform"/> associated with this document
            /// </summary>
            public WalkerPlatform Platform => Factory.Platform;

            public bool ProvideEol
            {
                get => Factory.ProvideEol;
                set => Factory.ProvideEol = value;
            }

            public bool ConvertToEntities
            {
                get => Factory.ConvertToEntities;
                set => Factory.ConvertToEntities = value;
            }

            public Encoding Encoding { get; set; } = null;

            public virtual void Close() => this.documentTag = null;

            /// <summary>
            ///   Access to the root doucment node
            /// </summary>
            protected abstract object DocumentNode { get; }

            public abstract WalkerFactory Factory { get; }

            public abstract string Html { get; }

            public abstract WalkerDocument Load(string path);

            public abstract WalkerDocument Load(TextReader reader);

            public abstract WalkerDocument LoadHtml(string html);

            public abstract void Save(string path, Encoding encoding);

            public abstract void Save(string path);

            public abstract void Save(TextWriter writer);
        }
    }
}
