using NUnit.Framework;
using Signal_Block_Design_Tool.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cannot find mysql.data

namespace Signal_blocktool.Unit_tests.Database
{
    /**
     * Precondition: 
     * MySQL server must be running on your computer to test the databse connection.
     * */

    [TestFixture]
    class Database_Test
    {

        [Test]
        public void databaseConnected()
        {
            DatabaseConnection connection = new DatabaseConnection(  
                "andrew.cs.fit.edu",
                    3306,
                    "signalblockdesign",
                    "signalblockdesig",
                    "E2SnzbV922m6R51");

            bool connected = false;

           
                connection.openConnection();
                connected = true;
                Assert.True(connected);
        }
       
        [Test]
        public void closeDatabaseConnection()
        {
            bool isClosed = false;
            DatabaseConnection connection = new DatabaseConnection(
               "andrew.cs.fit.edu",
                   3306,
                   "signalblockdesign",
                   "signalblockdesig",
                   "E2SnzbV922m6R51");

            connection.openConnection();

            connection.closeConnection();
            isClosed = true;

            Assert.True(isClosed);
        }
    }
}
