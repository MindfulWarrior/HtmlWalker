using System.Collections;
using System.Collections.Generic;
using System.Linq;

using static HtmlWalker.Platform.WalkerPlatform;

namespace HtmlWalker.Core
{
    // TODO: Change attribute value to an object
    public class TagAttributes : IDictionary<string, string>
    {
        protected ITagApi Api { get; }
        protected ITag Tag { get; }

        private IDictionary<string, string> dictionary = null;

        private IDictionary<string, string> attributes
        {
            get
            {
                if (dictionary == null)
                    dictionary = Api.GetAttributes(Tag.Tag);
                return dictionary;
            }
        }

        private string getAttribute(string attr)
            => Api.Platform.HandleEntities(Api.GetAttribute(Tag.Tag, attr), true);

        private void setAttribute(string attr, string value)
        {
            attr = attr.ToLower().Trim();
            if (value == null)
            {
                if (dictionary != null)
                    dictionary.Remove(attr);
                Api.SetAttribute(Tag.Tag, attr, null);
            }
            else
            {
                if (dictionary != null)
                {
                    if (dictionary.ContainsKey(attr))
                        dictionary[attr] = value;
                    else
                        dictionary.Add(attr, value);
                }
                Api.SetAttribute(Tag.Tag, attr, Api.Platform.HandleEntities(value, true));
            }
        }

        internal TagAttributes(ITag tag, ITagApi api)
        {
            Api = api;
            Tag = tag;
        }

        /// <summary>
        ///   Implementation of the index opertator using the attribute as the index.
        ///   If the attribute does not exist, the 'get' returns null.
        /// </summary>
        /// <param name="attr"></param>
        /// <returns>string if 'get'</returns>
        public string this[string attr]
        {
            get => getAttribute(attr);
            set
            {
                if (value == null)
                    Remove(attr);
                else if (!ContainsKey(attr))
                    Add(attr, value);
                else
                    setAttribute(attr, value);
            }
        }

        public ICollection<string> Keys => attributes.Keys;

        public ICollection<string> Values => attributes.Values;

        public int Count => attributes.Count;

        public bool IsReadOnly => attributes.IsReadOnly;

        public void Add(string attr, string value) => setAttribute(attr, value);

        public void Add(KeyValuePair<string, string> item) => setAttribute(item.Key, item.Value);

        public void Clear()
        {
            while (Keys.Count > 0)
                Remove(Keys.Last());
        }

        public bool Contains(KeyValuePair<string, string> item)
        {
            var value = getAttribute(item.Key);
            return value != null && value == item.Value;
        }

        public bool ContainsKey(string attr) => getAttribute(attr) != null;

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            int index = arrayIndex;
            foreach (var item in attributes)
            {
                if (index >= array.Length)
                    break;
                array[index++] = item;
            }
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => attributes.GetEnumerator();

        public bool Remove(string attr)
        {
            var value = getAttribute(attr);
            if (value == null)
                return false;
            setAttribute(attr, null);
            return true;
        }

        public bool Remove(KeyValuePair<string, string> item)
        {
            var value = getAttribute(item.Key);
            if (value == null)
                return false;
            setAttribute(item.Key, null);
            return true;
        }

        public bool TryGetValue(string attr, out string value)
        {
            value = getAttribute(attr);
            return (value != null);
        }

        IEnumerator IEnumerable.GetEnumerator() => attributes.GetEnumerator();
    }
}
