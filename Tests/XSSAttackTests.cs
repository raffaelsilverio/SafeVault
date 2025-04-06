using NUnit.Framework;

[TestFixture]
public class XSSAttackTests
{
    [Test]
    public void TestXSSAttackPrevention()
    {
        string maliciousInput = "<script>alert('XSS');</script>";
        string sanitizedInput = InputValidator.SanitizeInput(maliciousInput);
        Assert.AreEqual("&lt;script&gt;alert('XSS');&lt;/script&gt;", sanitizedInput);
    }
}
