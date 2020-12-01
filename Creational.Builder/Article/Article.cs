using System.Collections.Generic;

namespace Creational.Builder.Article
{
    public class Article
    {
        private List<object> _articleParts = new List<object>();

        public void Add(string part)
        {
            _articleParts.Add(part);
        }

        public string GetArticleParts()
        {
            string result = "Article parts: ";

            foreach(var part in _articleParts)
            {
                result += part + " ";
            }

            return result;
        }
    }
}
