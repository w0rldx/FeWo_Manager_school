using System.Collections.Generic;

namespace FeWo_Verwaltung_Core.Database
{
    public interface IDatenVerwalter
    {
        //ADD
        void AddMietWohnungToDataSource(MietWohnung w);
        void AddUserToDataSource(User u);
        
        
        //REMOVE
        void RemoveUseFromDataSource(User u);
        void RemoveMietWohnungFromDataSource(MietWohnung w);
        
        
        //GET
        MietWohnung GetMietWohnungFromDataSource();
        User GetUserFromDataSource();
        
        List<MietWohnung> GetMietWohnungFromDataSource(SearchingParmeterMietwohnung s);
        List<User> GetUserFromDataSource(SearchingParmeterUser s);

        List<MietWohnung> GetMietWohnungFromDataSourceList();
        List<User> GetUserFromDataSourceList();

        
        //UPDATE
        void UpdateMietWohnungFromDataSource(MietWohnung m);
        void UpdateUserFromDataSource(User u);
    }
}