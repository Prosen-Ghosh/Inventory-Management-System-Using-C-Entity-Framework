using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class UserContext
    {
        public List<User> GetAllUsers()
        {

            using (var dbContext = new InventoryManagementSystemDataContext())
            {
                return dbContext.Users.ToList();
            }
        }
        public User GetUsersLoginInfo(string adminId,out string error)
        {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    User admin = dbContext.Users.Where(x => x.UserId == adminId && (x.UserType.Equals("Admin"))).SingleOrDefault();
                    return admin;
                }
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        
        public bool CreateNewUser(User user, out string error) {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }
        public bool updateSelectedUser(User user, out string error) {

            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var userToUpdate = dbContext.Users.SingleOrDefault(u => u.UserId == user.UserId);
                    userToUpdate.UserId = user.UserId;
                    userToUpdate.UserName = user.UserName;
                    userToUpdate.UserPassword = user.UserPassword;
                    userToUpdate.UserEmail = user.UserEmail;
                    userToUpdate.UserType = user.UserType;
                    userToUpdate.UserPhone = user.UserPhone;
                    userToUpdate.UserAddress = user.UserAddress;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool deleteSelectedUser(User user, out string error) {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var userToDelete = dbContext.Users.Find(user.UserId);
                    dbContext.Users.Remove(userToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public User GetUserById(string userId, out string error)
        {

            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    return dbContext.Users.Where(u => u.UserId.Contains(userId)).SingleOrDefault();
                }
                
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public List<User> GetUserByName(string userName, out string error)
        {

            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    return dbContext.Users.Where(u => u.UserName.Contains(userName)).ToList();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

    }
}
