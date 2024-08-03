namespace SiteDiscover.Application.Paging
{
    public interface IPaginate<T>
    {
        int Index { get; }
        int Size { get; }
        int Pages { get; }
        int Count { get; }
        bool HasPrevious { get; }
        bool HasNext { get; }
        IList<T> Items { get; }
    }
}
