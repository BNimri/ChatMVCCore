namespace ChatMVCCore.Models
{
    public class MessageModel
    {
        public string Sender { set; get; }
        public string Receiver { set; get; }
        public MessageDetailsModel MessageDetails { set; get; }
        public string Message { set; get; }

    }
}
