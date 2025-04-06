using NUnit.Framework;

[TestFixture]
public class SecurityTests
{
    [Test]
    public void TestSQLInjection()
    {
        var dbHandler = new DatabaseHandler();
        string maliciousUsername = "'; DROP TABLE Users; --";
        Assert.Throws<SqlException>(() =>
        {
            dbHandler.GetUserByUsername(maliciousUsername);
        });
    }

    [Test]
    public void TestXSSAttack()
    {
        string maliciousInput = "<script>alert('XSS');</script>";
        var sanitizedInput = InputValidator.SanitizeInput(maliciousInput);
        Assert.AreEqual("&lt;script&gt;alert('XSS');&lt;/script&gt;", sanitizedInput);
    }
}
