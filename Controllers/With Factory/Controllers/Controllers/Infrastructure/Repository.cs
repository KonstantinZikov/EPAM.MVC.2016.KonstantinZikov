using System.Collections.Generic;

namespace Controllers.Infrastructure
{
    public static class Repository
    {
        public static List<User> Users { get; private set; } = new List<User>();
        public static int Count { get; set; }
    }
}