using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class User
    {
        public string username { get; set; }
        public BindingList<Player> players { get; set; }
        public BindingList<Channel> channels { get; set; }

        public User(string username)
        {
            this.username = username;
            players = new BindingList<Player>();
        }

        public static User CreateDefaultUser()
        {
            User user = new User("DefaultUser");
            //user.players.Add(new Player("Player1"));
            //user.players.Add(new Player("Player2"));
            return user;
        }
    }
}
