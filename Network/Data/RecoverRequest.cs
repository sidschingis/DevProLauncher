namespace DevProLauncher.Network.Data
{
    public class RecoverRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int Version { get; set; }
        public string UID { get; set; }
    }
}
