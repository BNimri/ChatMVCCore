using ChatMVCCore.Models;
using System.Collections.Generic;

namespace ChatMVCCore.Data
{
    public interface IMessageInterface
    {
        IEnumerable<MessageModel> GetAllMessages();
        void CreateNewMessage(MessageModel msg);
        bool SaveChanges();
    }
}