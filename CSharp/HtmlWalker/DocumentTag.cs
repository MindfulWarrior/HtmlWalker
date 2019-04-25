using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Tag.Html;
using HtmlWalker.Visitor;

namespace HtmlWalker
{
    public class DocumentTag : ContentUtilTag
    {
        private TagList tags = null;
        private TagHtml html = null;
        private TagHead head = null;
        private TagBody body = null;

        public DocumentTag(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        public override string TextValue { get => null; set { } }

        /// <summary>
        ///   Impleents <see cref="ITag.OwnedTags"/>
        /// </summary>
        public override TagList OwnedTags
        {
            get
            {
                if (this.tags == null)
                    this.tags = new TagList(this).Initialize(Factory);
                return this.tags;
            }
        }

        /// <summary>
        ///   Implement <see cref="ITag.OwnedText"/>
        /// </summary>
        public override string OwnedText => Api.OwnedText(Tag);

        public override void Visit(ITagVoidVisitor visitor) { visitor.Visit(this); }

        public override T Visit<T>(ITagGenericVisitor<T> visitor) { return visitor.Visit(this); }

        public override string Name => "#document";

        public TagHtml HtmlTag
        {
            get
            {
                if (this.html == null)
                    this.html = OwnedTags.ToList().Find(t => t.Name == "html") as TagHtml;
                return this.html;
            }
        }

        public TagHead HeadTag
        {
            get
            {
                if (this.head == null)
                    this.head = HtmlTag.OwnedTags.ToList().Find(t => t.Name == "head") as TagHead;
                return this.head;
            }
        }

        public TagBody BodyTag
        {
            get
            {
                if (this.body == null)
                    this.body = HtmlTag.OwnedTags.ToList().Find(t => t.Name == "body") as TagBody;
                return this.body;
            }
        }
    }
}
