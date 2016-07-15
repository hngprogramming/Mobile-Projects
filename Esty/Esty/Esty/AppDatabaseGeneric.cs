using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using System.Linq;

namespace Esty
{
    public class AppDatabaseGeneric
    {
        static object locker = new object();
        SQLiteConnection database;

        public AppDatabaseGeneric()
        {
            database = new SQLite.SQLiteConnection(databasePath);
            database.CreateTable<Routine>();
            database.CreateTable<Plan>();
            database.CreateTable<Period>();
        }

        protected string databasePath {
            get
            {
                var dbName = "ItemsSQLite.db3";
                #if __IOS__
				string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal); 
				folder = Path.Combine (folder, "..", "Library"); 
				var databasePath = Path.Combine(folder, dbName);
                #else
                #if __ANDROID__
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var databasePath = Path.Combine(folder, dbName);
                #else
				// WinPhone
				var databasePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, dbName);;
                #endif
                #endif

                return databasePath;
            }
        }

        public IEnumerable<T> GetObjects<T>() where T : IObject, new()
        {
            lock (locker)
            {
                return ( from i in database.Table<T>() select i).ToList();
            }
        }

        public T GetObject<T>(int id) where T : IObject, new()
        {
            lock (locker)
            {
                return database.Table<T>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveObject<T>(T obj) where T : IObject
        {
            lock (locker)
            {
                if (obj.ID != 0)
                {
                    database.Update(obj);
                    return obj.ID;
                }
                else
                {
                    return database.Insert(obj);
                }
            }
        }

        public int DeleteObject<T>(int id) where T : IObject, new()
        {
            lock (locker)
            {
                return database.Delete<T>(id);
            }
        }

        public void DeleteAllObjects<T>()
        {
            lock (locker)
            {
                database.DropTable<T>();
                database.CreateTable<T>();
            }
        }

    }
}
