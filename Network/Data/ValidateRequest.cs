﻿namespace DevProLauncher.Network.Data
{
    internal class ValidateRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int Version { get; set; }
        public string UID { get; set; }
        public string HID { get; set; }
    }
}