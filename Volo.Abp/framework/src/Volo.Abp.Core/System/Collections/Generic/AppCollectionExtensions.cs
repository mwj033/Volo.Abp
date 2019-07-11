using JetBrains.Annotations;
using System.Linq;
using Volo.Abp;

namespace System.Collections.Generic
{
    public static class AppCollectionExtensions
    {
        public static bool IsNullOrEmpty<T>([CanBeNull] this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }

        public static bool AddIfNotContains<T>([NotNull]this ICollection<T> source, T item)
        {
            Check.NotNull(source, nameof(source));

            if (source.Contains(item))
            {
                return false;
            }

            source.Add(item);
            return true;
        }

        public static IEnumerable<T> AddIfNotContains<T>([NotNull]this ICollection<T> source, [NotNull] IEnumerable<T> items)
        {
            Check.NotNull(source, nameof(source));
            Check.NotNull(items, nameof(items));

            var addedItems = new List<T>();

            foreach (var item in items)
            {
                if (source.Contains(item))
                {
                    continue;
                }

                source.Add(item);
                addedItems.Add(item);
            }

            return addedItems;
        }

        public static bool AddIfNotContains<T>([NotNull]this ICollection<T> source,[NotNull] Func<T,bool> predicate, [NotNull] Func<T> itemFactory)
        {
            Check.NotNull(source, nameof(source));
            Check.NotNull(predicate, nameof(predicate));
            Check.NotNull(itemFactory, nameof(itemFactory));

            if (source.Any(predicate))//每一个元素都满足:true, 存在不满足的则为false
            {
                return false;
            }

            source.Add(itemFactory());
            return true;
        }

        public static IList<T> RemoveAll<T>([NotNull] this ICollection<T> source, Func<T, bool> predicate)
        {
            var items = source.Where(predicate).ToList();

            foreach (var item in items)
            {
                source.Remove(item);
            }

            return items;
        }
    }
}
