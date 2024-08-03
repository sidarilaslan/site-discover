using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Paging;

namespace SiteDiscover.Application.extensions
{
    public static class IQueryablePaginateExtensions
    {
        public static async Task<IPaginate<T>> ToPaginateAsync<T>(this IQueryable<T> source, int index, int size, CancellationToken cancellationToken)
        {

            int count = await source.CountAsync(cancellationToken).ConfigureAwait(false);
            List<T>? items = await source.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

            int pages = (int)Math.Ceiling(count / (double)size);

            return new Paginate<T>
            {
                Count = count,
                Items = items,
                Index = index,
                Pages = pages,
                Size = size,
                HasNext = index < pages,
                HasPrevious = index > 0
            };
        }
    }
}
