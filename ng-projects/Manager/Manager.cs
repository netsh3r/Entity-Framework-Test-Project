using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
public class UserManager
{
    public void Add(User user)
    {
        using(var context = new ApplicationContext())
        {
            context.Add(user);
            context.SaveChanges();
        }
    }

    //TODO : Exception when Id is null ( does not exist in table ) 
    public void Delete(int Id)
    {
        using (var context = new ApplicationContext())
        {
            var user = FindById(Id); 
            context.Remove(user);
            context.SaveChanges();
        }
    }

    public void Edit(User user)
    {
        using (var context = new ApplicationContext())
        {
            context.Users.Update(user);
            context.SaveChanges();
        }
    }

    public User FindById(int Id)
    {
        try
        {
            using (var context = new ApplicationContext())
            {
                return context.Find<User>(Id);
            }
        }
        catch(Exception ex)
        {
            return null;
        }
    }


}
