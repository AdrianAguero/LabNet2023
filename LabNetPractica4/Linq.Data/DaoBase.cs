namespace Linq.Data
{
    public abstract class DaoBase<T>: IBase<T>
    {
        protected NorthwindContext _context;
        public DaoBase()
        {
            _context = new NorthwindContext();
        }

    }
}
