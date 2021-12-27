using System.ComponentModel.DataAnnotations;

namespace ChatMVCCore.Models
{
    public class MessageDetailsModel
    {
        [Key]
        public long MessageRecordID { set; get; }
        public int MessageType { get; set; }
        public string MessageContent { set; get; }
    }
}