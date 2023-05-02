using Microsoft.Playwright;
using NUnit.Framework;

namespace qathingy_playwright_dotnet;

public class LoginTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Login_ExpectFailure()
    {
        // Playwright
        using var playwright = await Playwright.CreateAsync();
        // Browser
        await using var browser = await playwright.Chromium.LaunchAsync();
        // Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("http://zero.webappsecurity.com/index.html");
        await page.ClickAsync("#signin_button");

        await page.TypeAsync("#user_login", "some username");
        await page.TypeAsync("#user_password", "some password");
        await page.ClickAsync("text=Sign in");

        string message;
        page.Dialog += (_, dialog) =>
        {
            message = dialog.Message;
            Assert.That(message, Is.SameAs("Login and/or password are wrong."));
            dialog.AcceptAsync();
        };
    }
}