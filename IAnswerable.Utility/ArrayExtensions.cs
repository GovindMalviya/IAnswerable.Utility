namespace IAnswerable.Utility
{
    using System;

    public static class ArrayExtensions
    {
        /// <summary>
        /// Remove element from array at given index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            T[] destination = new T[source.Length - 1];


            if (index > 0)
                Array.Copy(source, 0, destination, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, destination, index, source.Length - index - 1);

            return destination;
        }

        public static void CopyTo<T>(this T[] source, T[] destination, int length)
        {
            Array.Copy(source, destination, length);
        }
    }
}
