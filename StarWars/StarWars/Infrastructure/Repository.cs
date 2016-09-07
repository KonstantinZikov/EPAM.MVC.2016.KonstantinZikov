using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Infrastructure
{
    public static class Repository
    {
        static Repository()
        {
            users = new List<User>(){
                new User{Id=0,Fraction=Fraction.Empire,PersonInfo="Info" },
                new User{Id=1,Fraction=Fraction.Empire,PersonInfo="Info" },
                new User{Id=2,Fraction=Fraction.Empire,PersonInfo="Info" },
                new User{Id=3,Fraction=Fraction.Rebels,PersonInfo="Info" },
                new User{Id=4,Fraction=Fraction.Rebels,PersonInfo="Info" },
                new User{Id=5,Fraction=Fraction.Rebels,PersonInfo="Info" },
            };
        }

        public static User Get(int id)
        {
            return users.FirstOrDefault((u) => u.Id == id);
        }

        private static List<User> users;
    }
}