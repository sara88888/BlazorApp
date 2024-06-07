namespace BlazorApp.Utils
{
    public class Pagination
    {
        private int _itemsPerPage = 5;
        public int ItemsPerPage 
        { 
            get { return _itemsPerPage;}
            set { _itemsPerPage = value; }
        }

        public int PageCount { get; set; } = 0;

        private int _totalItems;
        public int TotalItems
        {
            get { return _totalItems; }
            set 
            {
                _totalItems = value;
                PageCount=(TotalItems/ItemsPerPage)+(TotalItems%ItemsPerPage!=0?1:0);   
            }
        }

        public int StartRow { get; set; } = 0;

        private int _currentPage=1;
        public int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                StartRow = _currentPage == 1 ? 0 : ((_currentPage-1)*ItemsPerPage);
            }
        }

        private int _previousPage;
        public int PreviousPage
        {
            get {
                if (CurrentPage > 1)
                    return CurrentPage - 1;
                else return 0;
            }
        }

        private int _nextPage;
        public int NextPage
        {
            get
            {
                if (CurrentPage < PageCount)
                    return CurrentPage + 1;
                else return 0;
            }
        }
    }
}
