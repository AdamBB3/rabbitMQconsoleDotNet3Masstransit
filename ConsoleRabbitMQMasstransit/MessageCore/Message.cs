using System;
using System.Collections.Generic;
using System.Text;

namespace MessageCore
{
    public class Message
    {
        public int IdMessage { get; set; }
        public string Name { get; set; }
        public DateTime DateCreation { get; set; }
        public Message(int id, string name, DateTime dateCreation)
        {
            IdMessage = id;
            Name = name;
            DateCreation = dateCreation;
        }
    }
}
