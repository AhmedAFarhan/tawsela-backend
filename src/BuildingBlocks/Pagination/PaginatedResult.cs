namespace BuildingBlocks.Pagination
{
    public class PaginatedResult<TEntity>(int pageIndex, int pageSize, long count, IEnumerable<TEntity> data) where TEntity : class
    {
        public int PageIndex { get; } = pageIndex;
        public int PageSize { get; } = pageSize;
        public long Count { get; } = count;
        public IEnumerable<TEntity> Data { get; } = data;
    }

    /*
     {
        "PageIndex" : 3,
        "PageSize" : 10,
        "Count" : 1000,
        "Data" : [ {}, {}, {} ],
     }
     */
}
