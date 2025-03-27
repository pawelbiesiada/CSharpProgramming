using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCSharpConsoleNET.Samples.Class;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class LinqExercises
    {
        public void Execute()
        {
            var users = CreateCollection.GetUsers();
            
            var hasAnyUsers = users.Any(x => x.IsActive);  //users.Count() == 0;

            int notNullCount = users.Where(u => u != null).Count();

            //users = users.Where(u => u != null && string.IsNullOrEmpty(u.Name));

            // ?. - null propagator
            // ?? - null coalescing
            var mUsers = users.Where(u => u?.Name?.StartsWith("M") ?? false).ToList(); 
            var firstFiveSorted = users
                .Where(u => u != null && string.IsNullOrEmpty(u.Name))
                .OrderBy(u => u.Name)
                .Take(5)
                .ToList();

            var secondFiveSorted = users
                .Where(u => u != null && u.Name != null)
                .OrderBy(u => u.Name)
                .Skip(5)
                .Take(5)
                .ToList();


            var pageNr = 3;
            var elementsPerPage = 20;
            var elements = users.Skip(elementsPerPage * (pageNr - 1)).Take(pageNr);


            var distinctName = users
                       .Where(u => u != null && u.Name != null)
                       .Select(u => u.Name)
                       .Distinct()
                       .ToList();

            var names = from u in users
                        where u.Name != null && string.IsNullOrEmpty(u.Name)     
                        orderby u.Id
                        select u.Name;


            var duplicateNames = users
                .Where(u => u != null && u.Name != null)
                .GroupBy(u => u.Name)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();


            var superUsers = users
                .OfType<SuperUser>();

            foreach (var superUser in superUsers)
            {
                Console.WriteLine($"SU: {superUser.Name}");
            }

            var activeAdmins = users
                .OfType<SuperUser>()
                .Where(su => su.IsActive && su.IsAdmin);

            foreach (var admin in activeAdmins)
            {
                Console.WriteLine($"Admin: {admin.Name} (Id: {admin.Id})");
            }

            var firstAdmin = users
                .OfType<SuperUser>()                
                .FirstOrDefault(su => su.IsAdmin);

            if (firstAdmin != null)
            {
                Console.WriteLine($"Pierwszy admin: {firstAdmin.Name} (Id: {firstAdmin.Id})");
            }
            else
            {
                Console.WriteLine("Brak administratora.");
            }


            var nameCountDictionary = users
                .GroupBy(u => u.Name)
                .ToDictionary(g => g.Key, g => g.Count());

            Console.WriteLine("Liczba użytkowników o tym samym imieniu:");
            foreach (var kvp in nameCountDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


            var usersWithRoles = users.SelectMany(u => u.Roles.Select(r => new {u.Name, r.RoleName}));

            var somelist = usersWithRoles.Select(x => x.RoleName).ToList();
        }
    }
}
