namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtension
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
        {
            if (value == null)
            {
                return false;
            }

            if (value.Count() == 0)
            {
                return false;
            }

            return true;
        }

        public static Boolean IsEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null)
                return true;
            return !source.Any();
        }

        public static IEnumerable<T> MoveUp<T>(this IEnumerable<T> enumerable, int itemIndex)
        {
            int i = 0;

            IEnumerator<T> enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                i++;

                if (itemIndex.Equals(i))
                {
                    T previous = enumerator.Current;

                    if (enumerator.MoveNext())
                    {
                        yield return enumerator.Current;
                    }

                    yield return previous;

                    break;
                }

                yield return enumerator.Current;
            }

            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException("items");
            if (predicate == null) throw new ArgumentNullException("predicate");

            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }
            return -1;
        }

        public static void ForEach<T>(this IEnumerable<T> value, Action<T> handle)
        {
            foreach (var item in value) handle(item);
        }

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> pSeq)
        {
            return pSeq ?? Enumerable.Empty<T>();
        }
    }
}
