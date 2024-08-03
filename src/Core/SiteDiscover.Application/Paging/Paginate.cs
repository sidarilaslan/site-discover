
namespace SiteDiscover.Application.Paging
{
    public class Paginate<T> : IPaginate<T>
    {
        public int Index { get; set; }

        public int Size { get; set; }

        public int Pages { get; set; }

        public int Count { get; set; }

        public bool HasPrevious { get; set; }

        public bool HasNext { get; set; }

        public IList<T> Items { get; set; }
        public Paginate()
        => Items = new List<T>();

        public Paginate(IEnumerable<T> source, int index, int size)
        {

            if (source is IQueryable<T> query)
            {
                Count = query.Count();
                Items = query.Skip(index * size).Take(size).ToList();
            }
            else
            {
                List<T>? enumerable = source as List<T> ?? new List<T>();
                Count = enumerable.Count();
                Items = enumerable.Skip(index * size).Take(size).ToList();
            }

            Index = index;
            Size = size;
            Pages = (int)Math.Ceiling(Count / (double)size);
            HasNext = Index < Pages;
            HasPrevious = Index > 0;
        }

    }
}
