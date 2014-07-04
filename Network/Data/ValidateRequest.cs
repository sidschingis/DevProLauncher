using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProLauncher.Network.Data
{
    class ValidateRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int Version { get; set; }
        public string UID { get; set; }
    }
}
