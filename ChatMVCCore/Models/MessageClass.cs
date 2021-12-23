namespace ChatMVCCore.Models
{
    public class MessageClass
    {
        public void Msgs()
        {
            MessageModel msgModel = new MessageModel();
            MessageDetailsModel msgDetails = new MessageDetailsModel();

            msgModel.Sender = "Bashar";
            msgModel.Receiver = "Ibra";

            msgDetails.MessageType = 1;
            msgDetails.MessageRecordID = 123;
            msgDetails.MessageContent = "Hello this is a message";

            string signalRMsg = Newtonsoft.Json.JsonConvert.SerializeObject(msgModel);
        }
    }
}
