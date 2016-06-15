using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Data;



namespace Application.Service.Services
{
    public class HookService : IHookService


    {

        private SalimTestDBEntities2 db = new SalimTestDBEntities2();

        public bool DeleteHook(int id)
        {
            try
            {
                var hook = db.Hooks.Where(x => x.ID == id);
                if (hook == null) return false;
                db.Entry(hook).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return true;
              
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }

        public Hook GetHook(int id)
        {
            return db.Hooks.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Hook> GetHooks()
        {
            return db.Hooks.ToList();
        }

        public bool UpdateHook(Hook hook)
        {
            try
            {
                db.Entry(hook).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        bool IHookService.Add(Hook hook)
        {
            try
            {
                db.Hooks.Add(hook);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
