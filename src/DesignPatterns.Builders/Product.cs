namespace DesignPatterns.Builders
{
    public class Product
    {
        private List<object> _parts = [];

        /// <summary>
        /// Add a part to the list
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            this._parts.Add(part);
        }

        /// <summary>
        /// List all parts added
        /// </summary>
        /// <returns></returns>
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}