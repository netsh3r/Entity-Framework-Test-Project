using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ng_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();

            var manager = new UserManager();


            while (line != "exit")
            {

                var arrgs = line.Split(new char[] { ' ' });
                var meth = arrgs[0];
                switch (meth)
                {
                    case "Add":
                        var user = new User();
                        user.Name = arrgs[1];
                        user.Age = Convert.ToInt32(arrgs[2]);
                        manager.Add(user);
                        break;
                    case "Delete":
                        var id = Convert.ToInt32(arrgs[1]);
                        manager.Delete(id);
                        break;
                    case "Edit":
                        var userEdit = new User();
                        userEdit.Id = Convert.ToInt32(arrgs[1]);
                        userEdit.Name = arrgs[2];
                        userEdit.Age = Convert.ToInt32(arrgs[3]);
                        manager.Edit(userEdit);
                        break;
                }
                line = Console.ReadLine();
            }

        }
    }
}

/*
 * Реализовать автозаполнение и получения данных
 * Перенестси базу данных на сайт
 */