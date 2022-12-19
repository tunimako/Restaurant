using RestaurantLibrary.Repositories;
using RestaurantLibrary.Models;
using Xunit;

namespace RestaurantLibrary.Tests
{
    public class TableRepositoryTests
    {
        TableRepository TableRepository = new();

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ReturnTable_ConfimsThatTableExists(int test)
        {
            //Act
            Table actual = TableRepository.ReturnTable(test);

            //Assert
            Assert.True(actual.TableId > 0 && actual.TableId <= TableRepository.Tables.Count);
        }

        [Theory]
        [InlineData(true)]
        public void IsTableAvailable_ReturnsTrue(bool test)
        {
            //Act
            Table table = new Table(1, 5, test, Table.STATUS_EMPTY);
            bool actual = TableRepository.IsTableAvailable(table, "test");

            //Assert
            Assert.True(actual);
        }
    }
}
