using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCSharpConsoleNET.Samples.Class;

namespace BasicCSharpConsoleNET.Exercises
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public UserRole[] Roles { get; set; }

        public override string ToString()
        {
            return Id + ":" + Name;
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;

            if (user == null) return false;


            return Id == user.Id &&
                Name == user.Name &&
                Password == user.Name;
        }

        public override int GetHashCode()
        {
            return Id * Name.GetHashCode() * Password.GetHashCode();
        }
    }


    class TestUser
    {
        public void Execute(string s)
        {
            var user1 = new User() { Id = 1, IsActive = true};
            var user2 = new User() { Id = 1, IsActive = true };

            var areEqual = user1.Equals(user2); // true
            areEqual = user1 == user2; // false

            var users = CreateCollection.GetUsers().ToArray();

            var dict = new Dictionary<bool, List<User>>();

            //IEnumerable<string> s;

            var activeUsers = dict[true];


            var list = new List<Car>();
            var arr = new User[10];

            list.Add(new Car(10));
            var c = list[3];

            Func<User, bool> myDelegateVariable = GetIsActive;


            var groupActiveUSers = users
                .GroupBy(x => x.IsActive)
                .ToDictionary(k => k.Key, v => v.Count());

            int id;
            bool isActive;

            (id, isActive) = Execute();


            var top5ActiveUsers = users
                 //.Where(GetIsActive)
                //.Where(u => u.IsActive)
                .Where(u => u.IsActive || u.Password is not null)
                .Take(5).ToArray();
        }

        public static (int, bool) Execute()
        {

            var (myVariable1, myVar2) = (1, false); 


            return (1, true);
        }


        //private bool GetIsActive(User u) { return u.IsActive; }  //Func<User, bool>
        private bool GetIsActive(User u) => u.IsActive;
    }

    public class SuperUser : User
    {
        public bool IsAdmin { get; set; }
    }

    public record UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string RoleName { get; set; }
    }

    public static class CreateCollection
    {
        public static IEnumerable<User> GetUsers()
        {
            yield return new User { Id = 1, Name = "John", IsActive = true, Password = "Password" };
            yield return new User { Id = 7, Name = "Susan", IsActive = true, Password = "qwerasdf" };
            yield return new User { Id = 2, Name = "Andrew", IsActive = true, Password = "qwerty" };
            yield return new User { Id = 4, Name = "Anthony", IsActive = false, Password = "1qazXSW@" };
            yield return new SuperUser { Id = 11, Name = "Stephan", IsActive = true, Password = "aaa", IsAdmin = false };
            yield return new SuperUser { Id = 15, Name = "Susan", IsActive = true, Password = "qwerasdf", IsAdmin = false };
            yield return new User { Id = 9, Name = "Mark", IsActive = true, Password = "" };
            yield return new User { Id = 5, Name = "Jason", IsActive = true, Password = "ASD!@#" };
            yield return new User { Id = 14, Name = "Adam", IsActive = true, Password = "z" };
            yield return new User { Id = 6, Name = "Phil", IsActive = true, Password = "!@#$$%" };
            yield return new SuperUser { Id = 12, Name = "Tom", IsActive = true, Password = "!@#$$%", IsAdmin = true };
            yield return null;
            yield return new User { Id = 3, Name = "Paul", IsActive = true, Password = "QWERTY" };
            yield return new User { Id = 8, Name = "Adam", IsActive = false, Password = null };
            yield return new User { Id = 10, Name = "Sara", IsActive = true, Password = "6yhnMJU&" };
            yield return new SuperUser { Id = 13, Name = "Catherine", IsActive = false, Password = "password", IsAdmin = true };
        }

        public static IEnumerable<UserRole> GetUserRoles()
        {
            yield return new UserRole { Id = 1, UserId = 1, RoleName = "EndUser" };
            yield return new UserRole { Id = 2, UserId = 1, RoleName = "PowerUser" };
            yield return new UserRole { Id = 3, UserId = 2, RoleName = "EndUser" };
            yield return new UserRole { Id = 4, UserId = 3, RoleName = "PowerUser" };
        }
    }
}
