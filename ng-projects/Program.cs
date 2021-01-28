using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ng_projects
{
    public class Program
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
 * solid, ооп - ( нас, инкапс, полим ) 
 * Unit-тесты + ( nUnit ) 
 * Доделать Project, Command ( вынести id в отдельный класс+ ) 
 * Ammend last commit
 * Разобраться с Интерфейсом и комментарями к методам
 * Реализовать автозаполнение и получения данных
 * Перенестси базу данных на сайт
 * реализовать автозаполенние через чтения из файла***
 */


//using System;
//using Xunit;

//namespace ng_projects.Tests
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public void DeleteTestMethod()
//        {
//            var manager = new UserManager();

//            string line = "Delete 3";

//            var arrgs = line.Split(new char[] { ' ' });

//            var id = Convert.ToInt32(arrgs[1]);

//            object expected = null;

//            object actual =




//           Assert.Equal(expected, );


//        }
//    }
//}