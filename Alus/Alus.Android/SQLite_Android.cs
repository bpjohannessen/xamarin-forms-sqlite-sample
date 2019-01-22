using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Alus.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace Alus.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {

        }

        #region ISQLite implementation
        public SQLite.SQLiteConnection GetConnection()
        {
            //Build the path for storing the Android database
            var sqliteFilename = "database.db3";
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, sqliteFilename);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open(sqliteFilename)))
            {
                using (var bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }

            var conn = new SQLiteConnection(path);
            return conn;
        }
        #endregion
    }
}