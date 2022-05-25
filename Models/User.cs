using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RoomChat.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {
            Chats = new List<ChatUser>();
        }
        public ICollection<ChatUser> Chats { get; set; }
    }
}