using System;
using System.Linq;
using Proxy.Business;
using Proxy.Entity;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("------- Proxy Pattern Sample in .Net Core -------\n\n");

            UserRepositoryProxy userRepositoryProxy = new UserRepositoryProxy();

            var users = userRepositoryProxy.GetUsers();

            if (!users.Any())
            {
                Console.Write("Users now empty\n");
            }

            var demoUser = new User()
            {
                Id = Guid.NewGuid().ToString("D"),
                Age = 10,
                Address = "Test address 1",
                Firstname = "Test Firstname",
                Lastname = "TestLastname",
                ModifiedAt = null
            };

            var demoUser2 = new User()
            {
                Id = Guid.NewGuid().ToString("D"),
                Age = 11,
                Address = "Test address 2",
                Firstname = "Test Firstname2",
                Lastname = "TestLastname2",
                ModifiedAt = null
            };

            var demoUserInsertResult = userRepositoryProxy.Insert(demoUser);
            var demoUserInsertResult2 = userRepositoryProxy.Insert(demoUser2);

            if (demoUserInsertResult && demoUserInsertResult2)
            {
                Console.Write("\nUsers are now inserted\n");
            }

            var demoUserEntity = userRepositoryProxy.GetUser(demoUser.Id);

            Console.Write("\n----- Demo User -----\n\n");

            Console.Write($" Id : ${demoUserEntity.Id}\n " +
                          $"First Name : {demoUserEntity.Firstname}\n " +
                          $"Last Name : {demoUserEntity.Lastname}\n " +
                          $"Age : {demoUserEntity.Age}\n " +
                          $"Address : {demoUserEntity.Address}\n " +
                          $"Created Date : {demoUserEntity.CreatedAt}\n");

            Console.Write("\n----- Demo All Users -----\n");

            users = userRepositoryProxy.GetUsers();
            foreach (var user in users)
            {
                Console.Write($" Id : ${user.Id}\n " +
                              $"First Name : {user.Firstname}\n " +
                              $"Last Name : {user.Lastname}\n " +
                              $"Age : {user.Age}\n " +
                              $"Address : {user.Address}\n " +
                              $"Created Date : {user.CreatedAt}\n" +
                              $" Modified Date : {user.ModifiedAt}\n\n");
            }


            demoUser.Firstname = "New Test Firstname";
            demoUser.Lastname = "New Test Lastname";
            demoUser.Age = 25;
            demoUser.Address = "Test address";

            demoUserEntity = userRepositoryProxy.Update(demoUser);

            userRepositoryProxy.Remove(demoUser2.Id);

            users = userRepositoryProxy.GetUsers();

            Console.Write("\n----- Demo All Users After CRUD -----\n");

            foreach (var user in users)
            {
                Console.Write($" Id : ${user.Id}\n " +
                              $"First Name : {user.Firstname}\n " +
                              $"Last Name : {user.Lastname}\n " +
                              $"Age : {user.Age}\n " +
                              $"Address : {user.Address}\n " +
                              $"Created Date : {user.CreatedAt}\n" +
                              $" Modified Date : {user.ModifiedAt}\n\n");
            }

            Console.Write("\n------- Press Any Key To Terminate Sample -------\n");
            Console.Read();
        }
    }
}
