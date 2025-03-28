// See https://aka.ms/new-console-template for more information
using EFWorkshopExercises.Exercises.Model;
using Microsoft.EntityFrameworkCore;

try
{
	using (var ctx = new EftestDbContext())
	{
        //liczba userów
        Console.WriteLine(ctx.Users.Count());

        //dodajcie nowego usera
        var newUser = new User
        {
            Name = "Kuba",
            Password = "Secret123",
            IsActive = true
        };
        ctx.Users.Add(newUser);
        //save
        ctx.SaveChanges();

        //liczba userów
        var newUserNumber = ctx.Users.Count();

        //wypisz na consoli jakie uprawnienia mają poszczególne grupy

        foreach (var group in ctx.Groups.Include( x => x.Permissions))
        {
            foreach (var perm in group.Permissions)
            {
                Console.WriteLine( $"{group.Name} : {perm.Permission1}");
            }
        }

        ctx.Groups
    .Include(g => g.Permissions)
    .ToList()
    .ForEach(g =>
    {
        Console.WriteLine($"Grupa : {g.Name}");

        if (g.Permissions.Any())
        {
            g.Permissions
            .ToList()
            .ForEach(p => Console.WriteLine($" - Uprawnienie: {p.Permission1}, {p.Description}"));
        }
        else
        {
            Console.WriteLine(" brak uprawnień");
        }
        Console.WriteLine();
    });


        var groupRights = ctx.Groups
    .Include(g => g.Permissions)
    .Select(g => new
    {
        group = g.Name,
        rights = g.Permissions
        .Select(p => new
        {
            name = p.Permission1,
            desc = p.Description
        })
    })
    .ToList();


        var users = ctx.Users.ToList();
        var users2 = ctx.Users.AsNoTracking().ToList();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}