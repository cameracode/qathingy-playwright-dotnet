# qathingy-playwright-dotnet
.NET6 Playwright Skeleton

# Windows x64 - Installation
[Playwright Documentation | Installation](https://playwright.dev/dotnet/docs/intro)
* Create the .NET 6.0 Project
  * ```dotnet new nunit -n qathingy-playwright-dotnet```
* In order to run the playwright browser install, must Set-ExecutionPolicy correctly, from elevated PowerShell window run - 
  * ``` Set-ExecutionPolicy Unrestricted -Force```
* In a PowerShell terminal run - 
  * ```.\/bin/Debug/net6.0/playwright.ps1 install```

# Running Tests
[Playwright Documentation | Running Tests](https://playwright.dev/dotnet/docs/running-tests)
* Running all tests
  * ```dotnet test```
* Run all tests with threads defined
  * ```dotnet test -- NUnit.NumberOfTestWorkers=5```
* Running a single test file
  * ```dotnet test --filter "LoginTests"```
* Run a set of test files
  * ```dotnet test --filter "LoginTests|SendMoneyTests"```
* Run the test with the title
  * ```dotnet test --filter "Name~Login_ExpectFailure"