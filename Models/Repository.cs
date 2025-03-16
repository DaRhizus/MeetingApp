using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        public static List<UserInfo> _users = new();
        

        static Repository(){
            _users.Add(new UserInfo(){Name = "Alp", Email = "kelesa30@gmail.com",Number="05411431807", Participate=true});
        }
        public static List<UserInfo> Users {
            get { return _users; }
        }

        public static void CreateUser(UserInfo user){
            user.Id = (_users.LastOrDefault()?.Id ?? 0) + 1;
            _users.Add(user);
        }

        public static UserInfo? BringUserById(int? id){
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}