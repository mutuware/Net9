namespace CS13
{
    public class Params
    {
        public string Join(params List<char> chars)
        {
            var ret = string.Empty;

            foreach (char c in chars)
            {
                ret += $"{c}-";
            }

            return ret;
        }

        public string JoinFirst(char first, params List<char> chars)
        {
            var ret = first.ToString();

            foreach (char c in chars)
            {
                ret += $"{c}-";
            }

            return ret;
        }

        public List<T> OmitLast<T>(params List<T> list)
        {
            var ret = new List<T>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                T t = list[i];
                ret.Add(t);
            }

            return ret;

        }
        //public void CantUseDictionary<TKey, TValue>(params Dictionary<TKey, TValue> dict) { }
    }
}