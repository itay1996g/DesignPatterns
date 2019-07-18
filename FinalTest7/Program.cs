using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest7
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessageBroadcast(string message, IUser sender);
        void SendMessageUnicast(string message, IUser sender);
    }
    
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessageBroadcast(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }

        public void SendMessageUnicast(string message, IUser sendTo)
        {
            sendTo.ReceiveMessage(message);
        }
    }

    public interface IUser
    {
        void SendMessageBroadcast(string message);
        void SendMessageUnicast(string message, IUser sendTo);
        void ReceiveMessage(string message);
    }

    public class User : IUser
    {
        string name;
        IChatMediator chatMediator;

        public User(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public void SendMessageBroadcast(string message)
        {
            chatMediator.SendMessageBroadcast(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Basic -- " + name + "; received message: " + message);
        }
        public void SendMessageUnicast(string message, IUser sendTo)
        {
            sendTo.ReceiveMessage(message);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            // create users and add them to chat mediator's user list
            IUser Moshe = new User(chatMediator, "Moshe");
            IUser Itzik = new User(chatMediator, "Itzik");
            chatMediator.AddUser(Moshe);
            chatMediator.AddUser(Itzik);
            // send message
            Moshe.SendMessageBroadcast("Hello Everyone!");
            Itzik.SendMessageUnicast("Hey Moshe!", Moshe);
            Console.ReadLine();
        }
    }
}
