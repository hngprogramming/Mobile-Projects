using System;
using System.Collections.Generic;
using System.Text;

namespace Esty
{
    public class AppRepository
    {
        AppDatabaseGeneric AppDatabase = null;

        public AppRepository()
        {
            AppDatabase = new AppDatabaseGeneric();
        }

        public Routine GetRoutine(int id)
        {
            return AppDatabase.GetObject<Routine>(id);
        }

        public IEnumerable<Routine> GetRoutines()
        {
            return AppDatabase.GetObjects<Routine>();
        }

        public int SaveRoutine(Routine Routine)
        {
            return AppDatabase.SaveObject<Routine>(Routine);
        }

        public int DeleteRoutine(int id)
        {
            return AppDatabase.DeleteObject<Routine>(id);
        }

        public void DeleteAllRoutines()
        {
            AppDatabase.DeleteAllObjects<Routine>();
        }

        public Plan GetPlan(int id)
        {
            return AppDatabase.GetObject<Plan>(id);
        }
    }
}
