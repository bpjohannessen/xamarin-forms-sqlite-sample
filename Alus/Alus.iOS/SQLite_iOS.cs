using System;
using Xamarin.Forms;
using Alus.iOS;
using System.IO;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace Alus.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {

        }

        //private static bool _initiated = false;

        // Place the sqlite file in the Resources directory (Alus.iOS/Resources)

        #region ISQLite implementation
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "database.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);

            // This is where we copy in the prepopulated database
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Copy(sqliteFilename, path);
            }
            else
            {
                File.Delete(path);
                File.Copy(sqliteFilename, path);
            }

            var conn = new SQLite.SQLiteConnection(path);

            // Return the database connection
            return conn;
        }
        #endregion

        //public SQLite.SQLiteConnection GetConnection()
        //{
        //    //Build the path for storing the iOS database
        //    var sqliteFilename = "database.db3";
        //    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
        //    string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
        //    var path = Path.Combine(libraryPath, sqliteFilename);

        //    // Copy the database (and replace it if it exists)
        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //        File.Copy(sqliteFilename, path);
        //    }

        //    Console.WriteLine(path);

        //    if (!_initiated)
        //    {
        //        //do things just once while the app is running
        //        _initiated = true;
        //    }

        //    // Create the connection
        //    var conn = new SQLite.SQLiteConnection(path);
        //    // Return the database connection
        //    return conn;
        //}
    }
}