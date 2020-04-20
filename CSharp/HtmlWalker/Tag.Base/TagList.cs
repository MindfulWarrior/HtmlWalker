using HtmlWalker.Platform;
using HtmlWalker.Tag.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   Acts as a functional collection of <see cref="ITag"/>
    /// </summary>
    public class TagList : IList<ITag>
    {
        internal List<ITag> Tags = new List<ITag>();

        /// <summary>
        ///   ITag owning elements of this collection
        /// </summary>
        protected readonly BaseTag Owner;

        /// <summary>
        ///   Node object that owns the nodes contained by the <see cref="ITag"/>.
        ///   The <see cref="Owner"/> can be the same but not always.
        /// </summary>
        protected readonly BaseTag NodeOwner;

        internal TagList(BaseTag owner) : this(owner, owner) { }

        internal TagList(BaseTag owner, BaseTag nodeOwner)
        {
            Owner = owner;
            NodeOwner = nodeOwner;
        }

        internal TagList Initialize(WalkerPlatform.WalkerFactory factory)
        {
            var content = factory.CreateContent(Owner);
            foreach (var item in content)
            {
                var adapter = factory.CreateAdapter(Owner, item);
                if (!factory.ProvideEol || adapter.Name != "#text" || !adapter.TextValue.Contains(Environment.NewLine))
                    Tags.Add(adapter);
                else
                {
                    var original = adapter.TextValue;
                    int endEols = 0;

                    // Handle extra item when EOL is at end
                    while (original.EndsWith(Environment.NewLine))
                    {
                        original = original.Substring(0, original.Length - Environment.NewLine.Length);
                        endEols++;
                    }

                    if (!String.IsNullOrEmpty(original))
                    {
                        var lines = original.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        for (int n = 0; n < lines.Length - 1; n++)
                        {
                            if (!String.IsNullOrEmpty(lines[n]))
                                Tags.Add(new Text(factory, lines[n]));
                            Tags.Add(new Eol(factory, Environment.NewLine) { Owner = Owner });
                        }
                        Tags.Add(new Text(factory, lines[lines.Length - 1]));

                    }

                    // Add EOLs back if needed
                    for (int n = 0; n < endEols; n++)
                        Tags.Add(new Eol(factory, Environment.NewLine) { Owner = Owner });
                }
            }

            return this;
        }

        #region IList<ITag> implementations

        IEnumerator IEnumerable.GetEnumerator() { return Tags.GetEnumerator(); }

        /// <summary>
        ///   Implements <see cref="IEnumerable{ITag}.GetEnumerator"/>
        /// </summary>
        public IEnumerator<ITag> GetEnumerator() { return Tags.GetEnumerator(); }

        /// <summary>
        ///  Implements <see cref="ICollection.Count"/>
        /// </summary>
        public int Count => Tags.Count;

        /// <summary>
        ///   Implements <see cref="this[int]"/>
        /// </summary>
        public ITag this[int index]
        {
            get => Tags[index];
            set => Replace(index, ref value);
        }

        /// <summary>
        ///   Implements <see cref="IList{T}.IndexOf(T)"/>
        /// </summary>
        public int IndexOf(ITag adapter) { return Tags.IndexOf(adapter); }

        /// <summary>
        ///   Implements <see cref="ICollection{T}.Contains(T)"/>
        /// </summary>
        public bool Contains(ITag item) { return Tags.Contains(item); }

        /// <summary>
        ///   Implements <see cref="ICollection{T}.Add(T) "/>
        /// </summary>
        public void Add(ITag adapter)
        {
            Tags.Add(adapter);
            NodeOwner?.Api.Add(NodeOwner.Tag, adapter);
            ((BaseTag)adapter).Owner = Owner;
        }

        public void Insert(int index, ITag adapter)
        {
            Tags.Insert(index, adapter);
            NodeOwner?.Api.Insert(NodeOwner.Tag, index, adapter);
            ((BaseTag)adapter).Owner = Owner;
        }

        public void RemoveAt(int index)
        {
            Remove(Tags[index]);
        }

        public void Clear()
        {
            foreach (var adapter in Tags)
                Remove(adapter);
        }

        public void CopyTo(ITag[] array, int arrayIndex)
        {
            Tags.CopyTo(array, arrayIndex);
        }

        /// <summary>
        ///  Implements <see cref="ICollection{T}.Remove(T)"/>
        /// </summary>
        public bool Remove(ITag adapter)
        {
            Owner.Api.Remove(Owner.Tag, adapter);
            ((BaseTag)adapter).Owner = null;
            return Tags.Remove(adapter);
        }

        public bool IsReadOnly => throw new NotImplementedException();

        #endregion

        public ITag[] ToArray()
        {
            return Tags.ToArray();
        }

        public List<ITag> ToList()
        {
            return new List<ITag>(Tags.AsReadOnly());
        }

        public void Replace<T>(int index, ref T replacement) where T : ITag
        {
            if (index >= 0)
            {
                var original = this[index];
                for (index = 0; index < original.OwnedTags.Count; index++)
                    replacement.OwnedTags.Add(original.OwnedTags[index]);

                RemoveAt(index);
                Insert(index, replacement);

                replacement.TextValue = original.TextValue;
            }
        }

        public void Replace<T0, T1>(ref T0 original, ref T1 replacement)
            where T0 : ITag where T1 : ITag => Replace(IndexOf(original), ref replacement);
    }
}
