namespace UniversityAutomatization.Core
{
    public static class Helper
    {
        private static Context _context;

        public static Context GetContext()
        {
            if (_context == null) _context = new Context();
            return _context;
        }
    }
}