using System;
using System.Collections.Generic;
using System.Linq;

namespace FeWo_Verwaltung_Core.Database.DatenQuellen
{
    public class EfDataSource : IDatenVerwalter, IDisposable
    {
        public void AddMietWohnungToDataSource(MietWohnung w)
        {
            using (var db = new VerwaltungContext())
            {
                db.MietWohnungen.Add(w);
                db.SaveChanges();
            }
        }

        public void AddUserToDataSource(User u)
        {
            using (var db = new VerwaltungContext())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
        }

        public void RemoveUseFromDataSource(User u)
        {
            using (var db = new VerwaltungContext())
            {
                db.Users.Remove(u);
                db.SaveChanges();
            }
        }

        public void RemoveMietWohnungFromDataSource(MietWohnung w)
        {
            using (var db = new VerwaltungContext())
            {
                db.MietWohnungen.Remove(w);
                db.SaveChanges();
            }
        }

        public List<MietWohnung> GetMietWohnungFromDataSource(SearchingParmeterMietwohnung s)
        {
            List<MietWohnung> returnvalue;
            using (var db = new VerwaltungContext())
            {
                returnvalue = db.MietWohnungen.Where(m => 
                    m.Name == s.Name || 
                    m.Beschreibung == s.Beschreibung ||
                    m.Ort == s.Ort)
                    .ToList();
            }
            return returnvalue;
        }

        public List<User> GetUserFromDataSource(SearchingParmeterUser s)
        {
            List<User> returnvalue;
            using (var db = new VerwaltungContext())
            {
                returnvalue = db.Users.Where(u => 
                        u.Vorname == s.Vorname ||
                        u.Nachname == s.Nachname ||
                        u.Email == s.Email)
                    .ToList();
            }

            return returnvalue;
        }

        public List<MietWohnung> GetMietWohnungFromDataSourceList()
        {
            List<MietWohnung> returnvalue;
            using (var db = new VerwaltungContext())
            {
                returnvalue = db.MietWohnungen.ToList();
            }

            return returnvalue;
        }

        public List<User> GetUserFromDataSourceList()
        {
            List<User> returnvalue;
            using (var db = new VerwaltungContext())
            {
                returnvalue = db.Users.ToList();
            }

            return returnvalue;
        }

        public void UpdateMietWohnungFromDataSource(MietWohnung m)
        {
            using (var db = new VerwaltungContext())
            {
                db.MietWohnungen.Update(m);
                db.SaveChanges();
            }
        }

        public void UpdateUserFromDataSource(User u)
        {
            using (var db = new VerwaltungContext())
            {
                db.Users.Update(u);
                db.SaveChanges();
            }
        }

        public void Dispose() { }
    }
}