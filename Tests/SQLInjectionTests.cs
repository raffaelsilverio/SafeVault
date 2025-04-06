using NUnit.Framework;

[TestFixture]
public class SQLInjectionTests
{
    [Test]
    public void TestSQLInjectionAttack()
    {
        var dbHandler = new DatabaseHandler();
        string maliciousInput = "'; DROP TABLE Users; --";
        Assert.Throws<SqlException>(() => dbHandler.GetUserByUsername(maliciousInput));
    }
}
