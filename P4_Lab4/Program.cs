
using Microsoft.EntityFrameworkCore;
using P4_Lab4;

using (var db = new BooksDB())
{
    db.Autors.Add(new Autor {Name = "name1", SurName = "surname1" });
    db.Books.Add(new Book {Title = "nazwa1", YerPremiere = 2000, AutorID = 1 });
    db.Autors.Add(new Autor { Name = "name2", SurName = "surname2" });
    db.Books.Add(new Book { Title = "test", YerPremiere = 2002, AutorID = 2 });
    db.Autors.Add(new Autor { Name = "name3", SurName = "surname3" });
    db.Books.Add(new Book { Title = "test3", YerPremiere = 2002, AutorID = 3 });
    db.Autors.Add(new Autor { Name = "name4", SurName = "surname4" });
    db.Books.Add(new Book { Title = "test4", YerPremiere = 2002, AutorID = 4 });
    db.Autors.Add(new Autor { Name = "name4", SurName = "surname4" });
    db.Books.Add(new Book { Title = "test5", YerPremiere = 2005, AutorID = 5 });
    db.Autors.Add(new Autor { Name = "name6", SurName = "surname6" });
    db.Books.Add(new Book { Title = "test6", YerPremiere = 2006, AutorID = 6 });
    db.Autors.Add(new Autor { Name = "name7", SurName = "surname7" });
    db.Books.Add(new Book { Title = "test7", YerPremiere = 2002, AutorID = 7 });
    db.Autors.Add(new Autor { Name = "name8", SurName = "surname8" });
    db.Books.Add(new Book { Title = "test8", YerPremiere = 2002, AutorID = 8 });


    db.SaveChanges();


    Console.WriteLine("Podaj title");
    string title = Console.ReadLine();

    var findBook = (from b in db.Books
                    join a in db.Autors on b.AutorID equals a.ID
                    where b.Title == title
                    select new
                    {
                        id = a.ID,
                        name = a.Name,
                        title = b.Title
                    }).ToList();


    foreach (var b in findBook)
    {
        Console.WriteLine(b);
    }

    Console.WriteLine("Podaj name");
    string name = Console.ReadLine();

    var findName = (from b in db.Books
                    join a in db.Autors on b.AutorID equals a.ID
                    where a.Name == name
                    select new
                    {
                        id = a.ID,
                        name = a.Name,
                        title = b.Title
                    }).ToList();

    foreach (var a in findName)
    {
        Console.WriteLine(a);
    }


}