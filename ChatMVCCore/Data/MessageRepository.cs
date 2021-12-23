using ChatMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVCCore.Data
{
    public class MessageRepository : IMessageInterface
    {
        private readonly MessageContext _messageContext;
        public MessageRepository(MessageContext messageContext)
        {
            _messageContext = messageContext;
        }

        public void CreateNewMessage(MessageModel msg)
        {
            if (msg == null)
            {
                throw new ArgumentNullException(nameof(msg));
            }
            _messageContext.Messages.Add(msg);
        }

        public IEnumerable<MessageModel> GetAllMessages()
        {
            return _messageContext.Messages.ToList();
        }

        public bool SaveChanges()
        {
            return (_messageContext.SaveChanges() >= 0);
        }
    }
}
