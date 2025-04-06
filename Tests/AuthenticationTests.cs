using NUnit.Framework;

[TestFixture]
public class AuthenticationTests
{
    private AuthenticationHandler authHandler;

    [SetUp]
    public void SetUp()
    {
        authHandler = new AuthenticationHandler();
    }

    [Test]
    public void TestValidLogin()
    {
        // Simulate a valid username and password
        string username = "validuser";
        string password = "validpassword";

        // Simulate storing the hashed password in the database (pseudo-logic)
        string hashedPassword = authHandler.HashPassword(password);
        // Assume the hashed password is stored in the database

        bool isAuthenticated = authHandler.AuthenticateUser(username, password);

        Assert.IsTrue(isAuthenticated, "Valid login attempt failed.");
    }

    [Test]
    public void TestInvalidLogin()
    {
        // Simulate invalid username and password
        string username = "invaliduser";
        string password = "wrongpassword";

        // This should fail authentication since the credentials are incorrect
        bool isAuthenticated = authHandler.AuthenticateUser(username, password);

        Assert.IsFalse(isAuthenticated, "Invalid login attempt succeeded.");
    }

    [Test]
    public void TestPasswordHashMatch()
    {
        // Test that the hash generated matches when verified
        string password = "securepassword123";
        string hashedPassword = authHandler.HashPassword(password);

        bool isMatching = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

        Assert.IsTrue(isMatching, "Password hash verification failed.");
    }
}
