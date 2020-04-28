using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bd_testing.tests
{
    [TestClass]
    public class BdRegresionTests
    {        
        [TestMethod]
        public void Validates_RegressionTable_Row_Count_Is_2()
        {
            //Arrange
            string command = "Select Name, Value FROM RegressionTable";

            //Act            
            var dt = SqlHelper.GetDataTable(command);
            int rowCountResult = dt.Rows.Count;
            
            //Assert
            Assert.AreEqual(2, rowCountResult);
        }

        [TestMethod]
        public void Validates_Regression_Table_Has_Columns_Name_and_Value()
        {
            //Arrange
            //Set parameters to run the test
            string command = "Select * FROM RegressionTable";

            //Act            
            var dt = SqlHelper.GetDataTable(command);

            bool hasNameColumn = dt.Columns.Contains("Name");
            bool hasValueColumn = dt.Columns.Contains("Value");

            //Assert
            Assert.IsTrue(hasNameColumn);
            Assert.IsTrue(hasValueColumn);
        }

        [TestMethod]
        public void Validates_Regression_Table_3rd_Record_Has_Value_91011()
        {
            //Arrange
            string command = "spGetRegressionTable";

            //Act            
            var dt = SqlHelper.GetDataTableFromStoredProcedure(command);
            int result = Convert.ToInt32(dt.Rows[2]["Value"]);           

            //Assert
            Assert.AreEqual(91011, result);            
        }
    }
}
