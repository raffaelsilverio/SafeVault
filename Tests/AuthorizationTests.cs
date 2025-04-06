using NUnit.Framework;

[TestFixture]
public class AuthorizationTests
{
    private AuthorizationHandler authzHandler;

    [SetUp]
    public void SetUp()
    {
        authzHandler = new AuthorizationHandler();
    }

    [Test]
    public void TestAdminAccess()
    {
        // Simulate a username with "Admin" role
        string adminUsername = "adminuser";
        string requiredRole = "Admin";

        bool hasAccess = authzHandler.HasAccess(adminUsername, requiredRole);

        Assert.IsTrue(hasAccess, "Admin should have access to Admin Dashboard.");
    }

    [Test]
    public void TestUserAccessDenied()
    {
        // Simulate a username with "User" role
        string regularUsername = "regularuser";
        string requiredRole = "Admin";

        bool hasAccess = authzHandler.HasAccess(regularUsername, requiredRole);

        Assert.IsFalse(hasAccess, "Regular user should not have access to Admin Dashboard.");
    }

    [Test]
    public void TestUserRoleAccess()
    {
        // Simulate a username with "User" role accessing user-level features
        string regularUsername = "regularuser";
        string requiredRole = "User";

        bool hasAccess = authzHandler.HasAccess(regularUsername, requiredRole);

        Assert.IsTrue(hasAccess, "Regular user should have access to User-level features.");
    }
}
