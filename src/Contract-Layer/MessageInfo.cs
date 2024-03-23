namespace Contract_Layer
{
    public class MessageInfo {
        public MessageInfo(string messageText, string tells)
        {
            this.messageText = messageText;
            Tells = tells;
        }

        public string messageText { get; set; } 
        public string Tells { get; set; } 
    }
}
