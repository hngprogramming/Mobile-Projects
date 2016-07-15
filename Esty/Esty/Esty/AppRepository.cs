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

        public IEnumerable<Plan> GetPlans()
        {
            return AppDatabase.GetObjects<Plan>();
        }

        public int SavePlan(Plan plan)
        {
            return AppDatabase.SaveObject<Plan>(plan);
        }

        public int DeletePlan(int id)
        {
            return AppDatabase.DeleteObject<Plan>(id);
        }

        public void DeleteAllPlans()
        {
            AppDatabase.DeleteAllObjects<Plan>();
        }

        public Unit GetPeriod(int id)
        {
            return AppDatabase.GetObject<Unit>(id);
        }

        public IEnumerable<Unit> GetPeriods()
        {
            return AppDatabase.GetObjects<Unit>();
        }

        public int SavePeriod(Unit Unit)
        {
            return AppDatabase.SaveObject<Unit>(Unit);
        }

        public int DeletePeriod(int id)
        {
            return AppDatabase.DeleteObject<Unit>(id);
        }

        public void DeleteAllPeriods()
        {
            AppDatabase.DeleteAllObjects<Unit>();
        }
    }
}
