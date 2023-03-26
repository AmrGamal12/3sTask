namespace Task.pagination
{
    public class Paginationfilter
    { public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public Paginationfilter()
        {
          this.PageNumber = 1;
            this.PageSize = 10;

        }
        public Paginationfilter(int pageNumber, int pageSize)
        {
            this.PageNumber=pageNumber<1 ? 1:pageNumber ;
            this.PageSize=pageSize<1 ? 10:pageSize;
        }
    }
}
