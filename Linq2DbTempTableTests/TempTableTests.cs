using System.Collections.Generic;
using FluentAssertions;
using LinqToDB;
using LinqToDB.EntityFrameworkCore;
using Xunit;

namespace Linq2DbTempTableTests
{
    public class TempTableTests
    {
        [Fact]
        public void Table_Is_Created_And_Populated_When_Custom_Table_Name_Is_Provided()
        {
            var factory = new TestDatabaseFactory();
            var context = factory.GenerateDbContext();

            using var connection = context.CreateLinqToDbConnection();

            var source = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe"},
                new Person {FirstName = "Jane", LastName = "Doe"}
            };

            var table = connection.CreateTempTable(source, tableName: "#TestPersonTable");

            // Never completes.
            table.Should().BeEquivalentTo(source);
        }
    }
}
