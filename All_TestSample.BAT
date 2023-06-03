@ECHO OFF
ECHO Demo Automation Executed Started.

set summaryPath=C:\Testing

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

//ALL
//VSTest.Console.exe C:\Selenium_POM\Selenium_POM\bin\Debug\Selenium_POM.dll /Logger:"trx;LogFileName=C:\Selenium_POM\TestSummaryReport\ir002.trx"

//WITH TEST METHOD NAME
VSTest.Console.exe C:\Selenium_POM\Selenium_POM\bin\Debug\Selenium_POM.dll /Tests:LoginWithValidUsernamePassword_TC003 /Logger:"trx;LogFileName=C:\Selenium_POM\TestSummaryReport\ir001.trx"


//WITH TEST CATEGORY
//VSTest.Console.exe C:\Selenium_POM\Selenium_POM\bin\Debug\Selenium_POM.dll /TestCaseFilter:"TestCategory=Login" /Logger:"trx;LogFileName=C:\Selenium_POM\TestSummaryReport\ir001.trx"



cd C:\Selenium_POM\Selenium_POM\bin\Debug\

TrxToHTML.exe %summaryPath%

PAUSE

