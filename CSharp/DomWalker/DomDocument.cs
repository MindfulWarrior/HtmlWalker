using System.IO;
using System.Text;
using static HtmlWalker.Platform.WalkerPlatform;

namespace DomWalker
{
    public abstract class DomDocument<F, A, D> : WalkerDocument where F : DomFactory<A, D> where A : DomApi<D>
    {
        private readonly F factory;

        protected DomDocument(F factory) : base() { this.factory = factory; }

        protected D Dom { get => this.factory.Dom; set => this.factory.Dom = value; }

        protected override object DocumentNode
            => this.factory.DApi.DocumentNode(Dom);

        public override string Html => this.factory.DApi.Html(Dom);

        public override WalkerFactory Factory => factory;

        public override WalkerDocument Load(string path)
        {
            this.factory.DApi.Load(Dom, path);
            return this;
        }

        public override WalkerDocument Load(TextReader reader)
        {
            this.factory.DApi.Load(Dom, reader);
            return this;
        }

        public override WalkerDocument LoadHtml(string html)
        {
            this.factory.DApi.LoadHtml(Dom, html);
            return this;
        }

        public override void Save(string path, Encoding encoding) => this.factory.DApi.Save(Dom, path, Encoding);

        public override void Save(string path) => this.factory.DApi.Save(Dom, path);

        public override void Save(TextWriter writer) => this.factory.DApi.Save(Dom, writer);

        public override void Close()
        {
            base.Close();
            this.factory.Close();
        }
    }
}
