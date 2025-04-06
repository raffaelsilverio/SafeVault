using System;
using System.Text.RegularExpressions;
using System.Net;

public class InputValidator
{
    public static bool IsValidUsername(string username)
    {
        var regex = new Regex(@"^[a-zA-Z0-9]{3,20}$");
        return regex.IsMatch(username);
    }

    public static bool IsValidEmail(string email)
    {
        var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        return regex.IsMatch(email);
    }

    public static string SanitizeInput(string input)
    {
        return WebUtility.HtmlEncode(input);
    }
}