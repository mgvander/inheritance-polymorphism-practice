using cis237_inclass_3;

namespace cis237_inclass_3_unittest
{
    [TestClass]
    public class SalaryEmployeeUnitTest
    {
        [TestMethod]
        public void GetFormattedYearlySalaryTest()
        {
            // Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee(
                "David",
                "Barnes",
                250m,
                200m);

            string expected = "$13,200.00";

            // Act
            string actual = salaryEmployee.FormattedYearlySalary();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SalaryEmployeeToStringTest()
        {
            // Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee(
                "David",
                "Barnes",
                250m,
                200m);

            string expected = "David Barnes $250.00";

            // Act
            string actual = salaryEmployee.ToString();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SalaryEmployeeTest()
        {
            // Arrange
            string expectedFirstName = "David";
            string expectedLastName = "Barnes";
            decimal expectedYearlySalary = (250m * 52) + 200m;

            // Act
            SalaryEmployee salaryEmployee = new SalaryEmployee(
                "David",
                "Barnes",
                250m,
                200m);

            // Assert
            Assert.AreEqual(expectedFirstName, salaryEmployee.FirstName);
            Assert.AreEqual(expectedLastName, salaryEmployee.LastName);
            Assert.AreEqual(expectedYearlySalary, salaryEmployee.YearlySalary);

        }

    }

}