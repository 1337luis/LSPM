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
        public enum DataIcon
        {
            Black,
            Blue,
            Green,
            Orange,
            Pink,
            Purple,
            Red,
            White,
            Yellow
        }

        public Guid Id { get; set; }
        [BsonField("username")]
        public string lUser { get; set; }
        [BsonField( "password" )]
        public string lPass { get; set; }
        [BsonField( "alias" )]
        public string lAlias { get; set; }
        [BsonField( "userFastAccess" )]
        public bool lUserFastAccess { get; set; }
        [BsonField( "passwordFastAccess" )]
        public bool lPasswordFastAccess { get; set; }
        [BsonField( "dataIcon" )]
        public DataIcon lDataIcon { get; set; }

        public LSPMData( string user, string password, string alias, bool userFastAccess = false, bool passwordFastAccess = false, DataIcon dataIcon = DataIcon.Pink )
        {
            lUser = user;
            lPass = password;
            lAlias = alias;
            lUserFastAccess = userFastAccess;
            lPasswordFastAccess = passwordFastAccess;
            lDataIcon = dataIcon;
        }

        public LSPMData()
        {
            lUser = "NULL";
            lPass = "NULL";
            lAlias = "NULL";
            lUserFastAccess = false;
            lPasswordFastAccess = false;
        }
    }
}
