using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProLauncher.Network.Data
{
    [Serializable]
    public class EmailRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Version { get; set; }
        public string UID { get; set; }
    }
}
