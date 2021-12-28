using System.ComponentModel.DataAnnotations;

namespace ChatMVCCore.Models
{
    public class MessageModel
    {
        [Key]
        public int RecordID { get; set; }
        public string Sender { set; get; }
        public string Receiver { set; get; }
        public MessageDetailsModel MessageDetails { set; get; }

    }
}
