using System;
using Xunit;

namespace ng_projects.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var manager = new UserManager();

            string line = "Delete 2";

            var arrgs = line.Split(new char[] { ' ' });

            var id = Convert.ToInt32(arrgs[1]);

            object expected = null;

            manager.Delete(id);

            object actual = manager.FindById(id);

            Assert.Equal(expected, actual);

        }
    }
}
