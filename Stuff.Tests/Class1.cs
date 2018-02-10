using NUnit.Framework;
using Stuff.App;

namespace Stuff.Tests
{
    [TestFixture] //will need to add NUnit using statement
    public class NameRegistrationTests
    {
        //write test code before writting actual code in the .App
        [Test]
        public void Entering_one_name_results_in_the_first_name_being_filled_out()
        //Given Cher is registering for our application
        //When entering her name
        //Then the first name should be Cher
        //nAd the middle name should be empty
        //And the last name should be empty
        {
            //Arrange
            var name = "Cher";
            var nameParser = new NameParser(); //will need to add class call NameParser to Stuff.App and make it public, then right click on NameParser in this file and add using statement

            //Act
            var result = nameParser.Parse(name); //will need to generate method my right click . on Parse

            //Assert
            Assert.AreEqual("Cher", result.FirstName);
            Assert.IsNull(result.MiddleName);
            Assert.IsNull(result.LastName);
        }
        //write test code before writting actual code in the .App
        [Test]
        public void Entering_two_names_results_in_the_first_name_being_filled_out_and_the_last_name_filled_out()
        //Given John Doe is registering for our application
        //When entering His name
        //Then the first name should be John
        //And the middle name should be empty
        //And the last name should be Doe
        {
            //Arrange
            var name = "John Doe";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name); 

            //Assert
            Assert.AreEqual("John", result.FirstName);
            Assert.IsNull(result.MiddleName);
            Assert.AreEqual("Doe", result.LastName);
        }

        [Test]
        public void Entering_three_names_results_in_the_first_name_and_middle_name_and_last_name_filled_out()
        //Given John Richard Doe is registering for our application
        //When entering His name
        //Then the first name should be John
        //And the middle name should be Richard
        //And the last name should be Doe
        {
            //Arrange
            var name = "John Richard Doe";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name);

            //Assert
            Assert.AreEqual("John", result.FirstName);
            Assert.AreEqual("Richard", result.MiddleName);
            Assert.AreEqual("Doe", result.LastName);
        }
    }
}
