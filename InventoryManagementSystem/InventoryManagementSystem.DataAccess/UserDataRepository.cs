using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class UserDataRepository
    {
        private readonly UserContext _userContext;
        
        public UserDataRepository(){
            _userContext = new UserContext();
        }
        public List<User> GetAllUsers() {

            return _userContext.GetAllUsers().ToList(); ;
        }
        public User GetUsersLoginInfo(string adminId,out string error)
        {
            return _userContext.GetUsersLoginInfo(adminId,out error);
        }
        public bool CreateNewUser(User user,out string error) {
            error = string.Empty;
            try {
                if (user != null)
                {
                    if (_userContext.CreateNewUser(user, out error))
                    {
                        return true;
                    }
                    return false;
                }
                else return false;
            }catch(Exception ex){
                error = ex.Message;
                return false;
            }
        }

        public bool updateSelectedUser(User user,out string error) {
            if (_userContext.updateSelectedUser(user, out error)) return true;
            return false;
        }
        public bool deleteSelectedUser(User user, out string error)
        {
            if (_userContext.deleteSelectedUser(user, out error)) return true;
            return false;
        }
        public User GetUserById(string userId, out string error) {
            try {
                return _userContext.GetUserById(userId, out error);
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public List<User> GetUserByName(string userName, out string error)
        {
            try
            {
                return _userContext.GetUserByName(userName, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
}
