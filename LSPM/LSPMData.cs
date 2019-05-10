using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPM
{
    class LSPMData
    {
        public Guid Id { get; set; }
        [BsonField("username")]
        public string lUser { get; set; }
        [BsonField( "password" )]
        public string lPass { get; set; }
        [BsonField( "name" )]
        public string lName { get; set; }

        public LSPMData( string user, string password, string name)
        {
            lUser = user;
            lPass = password;
            lName = name;
        }
    }
}
