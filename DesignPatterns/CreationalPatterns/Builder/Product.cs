using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string productPart)
        {
            _parts.Add(productPart);
        }

        public string Show()
        {
            StringBuilder result = new StringBuilder("Product Parts: ");

            foreach (string p in _parts)
            {
                result.Append(p);
            }

            return result.ToString();
        }
    }
}