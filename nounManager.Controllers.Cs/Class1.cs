using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nounManager.Controllers.Cs
{
    public class Calculator Tests
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            Calculator calc = new Calculator();

            int actual = calc.Add("");

            Assert.AreEqual(0, actual);
        }
    }
}
    //No Console interatction here
    //This Class Calls the view to interact with the user(input/output)
    //This Class Calls the Data (Repository) to Load/Save data (Nouns)
    public class Nouncontroller
    {
        public void Run()
        {
            //Get menu Choice
            //Decide Which other Method To Do Based on User Choice
        }
        private void CreateNoun()
        { 
            //Call view Method to Get Info
            //Take Info And Pass to Data Repository
            //Pass Item to view to Confirm Added
}
        private void DisplayNouns()
        {
            //Get Data from Repository
            //Give Data To View to Display All
        }
        private void SearchNoun()
        {
            //Call View, Get Desired ID From User
            //Take Info and Pass to Data Repository to Get By ID
            //take Data and Pass to View to Display to User
        }
        private void EditNoun()
        {
            //Call View, Get Desired ID From User
            //Take Info and Pass tp Data Repository to Get By ID
            //Call View, Walk Thru edit Process
            //Take Data and pass to Dqata Repository to be Updated
        }
        private void RemoveNoun()
        {
            //call View, Get Desired ID From User
            //Take Info and pass to Data Repository to Get By ID
            //Call View to Confirm remove
            //Take Info and Pass to Data Repository to Remove
        }
    }
}