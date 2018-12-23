using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Alus.Models;
using Alus.Services;

namespace Alus.Helpers
{
    public class AUsers
    {
        static SQLiteConnection db = AData.database;

        public AUsers()
        {

        }

        // Test query
        public static List<AUser> GetIt()
        {
            return db.Query<AUser>("SELECT * FROM [AUser]").ToList();
        }

        //Get all items in the database
        public static List<AUser> GetAll()
        {
            return db.Table<AUser>().ToList();
        }

        //Get a specific item from the database
        public static AUser Get(int Id)
        {
            return db.Table<AUser>().FirstOrDefault(x => x.UserId == Id);
        }

        //Add an item to the database
        public static int Add(AUser item)
        {
            return db.Insert(item);
        }

        //Add multiple items at once (better than looping through a collection)
        public static void Add(IEnumerable<AUser> items)
        {
            db.InsertAll(items, true);
        }

        //Remove a book
        public static void Remove(int Id)
        {
            db.Delete<AUser>(Id);
        }

        //Remove all books
        public static void RemoveAll()
        {
            db.DeleteAll<AUser>();
        }

        //Create sample data
        public static void CreateSampleData()
        {
            //Remove all users
            RemoveAll();

            //Add some sample users
            Add(new AUser()
            {
                UserId = 1,
                UserName = "User 1",
                UserIsActive = true,
                UserEmail = "nobody@nowhere.com",
                UserPhone = "555-555-5555"
            });

            Add(new AUser()
            {
                UserId = 2,
                UserName = "User 2",
                UserIsActive = true,
                UserEmail = "nobody@nowhere.com",
                UserPhone = "555-555-5555"
            });

            Add(new AUser()
            {
                UserId = 3,
                UserName = "User 2",
                UserIsActive = true,
                UserEmail = "nobody@nowhere.com",
                UserPhone = "555-555-5555"
            });

        }

    }


}