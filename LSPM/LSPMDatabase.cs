using LiteDB;
using System;
using System.Security.Cryptography;
using System.Text;

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

        public LiteCollection<LSPMData> getDBCollection()
        {
            return data;
        }

        public void insert( LSPMData dataInsert )
        {
            data.Insert( dataInsert );
        }

        public static string hashString( String texto )
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes( texto );
            Byte[] hash = sha1.ComputeHash( textOriginal );
            StringBuilder cadena = new StringBuilder();
            foreach( byte i in hash )
            {
                cadena.AppendFormat( "{0:x2}", i );
            }
            return cadena.ToString();
        }
    }
}
