Commands:

Allure
Open cmd on {solutionPath.bin.debug.net6}
To clean results>:
allure generate allure-results --clean -o allure-report
to run browser>:
allure serve allure-results 


Mobile:
Open any app in your mobile once it with adb and run>:
adb shell dumpsys window | find "mCurrentFocus"
s
Install uiautomator2
adb uninstall io.appium.uiautomator2.server
adb uninstall io.appium.uiautomator2.server.test

