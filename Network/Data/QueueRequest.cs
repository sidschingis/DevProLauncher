namespace DevProLauncher.Network.Data
{
    public class QueueRequest
    {
        public string rule { get; set; }
        public string mode { get; set; }

        public QueueRequest()
        {
            rule = "";
            mode = "";
        }

        public QueueRequest(string rule, string mode)
        {
            this.rule = rule;
            this.mode = mode;
        }
    }
}