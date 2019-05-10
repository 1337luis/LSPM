using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPM
{
    class LSPMDatabase
    {
        public LiteCollection<LSPMData> data;
        public LSPMDatabase( string pwd )
        {
            ConnectionString connectionString = new ConnectionString( @"./LSPM.db" )
            {
                Password = pwd,
            };

            using( LiteDatabase db = new LiteDatabase( connectionString ) )
            {
                data = db.GetCollection<LSPMData>( "accounts" );
            }
        }
    }
}
