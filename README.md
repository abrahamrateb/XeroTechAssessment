# XeroTestAssessment
Test Assessment Using Specflow + NUnit + Selenium WebDriver

# CLEAN UP - STEP ZERO
- There is a known issue within Azure DevOps where [tests run twice on the pipeline](https://developercommunity.visualstudio.com/content/problem/891521/tests-are-running-twice-in-azure-devops-pipeline.html)
- This is supposed to have been fixed but looks like it doesn't. This will result in the second test on the pipeline failing unless the ANZ account is deleted before the 2nd test is run.
- After running tests, ensure to clean up and delete the account to leave the Xero Production Demo in the same state it originally was. 
- To do this you'll need to navigate to the [Xero Login Portal > Accounting > Chart of Accounts](https://go.xero.com/GeneralLedger/ChartOfAccounts.aspx?Start=1&PageSize=200), 
  and login with either your demo account or abrahamrateb@gmail.com and xero1234 as the password. 
  #ENSURE YOU DELETE THE ABRAHAM TEST ACCOUNT AFTER EVERY TEST RUN PLEASE TO LEAVE XERO PRODUCTION PORTAL IN IT'S CURRENT STATE
  #TESTS WILL FAIL IF CLEAN UP IS NOT PERFORMED

# Running Tests Locally
- If you want to run and debug the tests/negative test locally, you can browse to (https://dev.azure.com/abrahamrateb/_git/XeroTestAssessment) and Clone the repo. 
You can then run the tests from inside of Visual Studio, by building the solution, right clicking on the Specflow test and selecting run. 
You can also Ctrl + Shift + B to build the solution followed by Ctrl + R then T to run the tests. 

# Running Tests on Azure DevOps Pipeline
- You can also run tests directly from the pipeline. For this you navigate to (https://dev.azure.com/abrahamrateb/XeroTestAssessment/_build), login using your Azure DevOps credentials,
then you can investigate the pipeline and trigger a run. **YOU CAN ALSO REVIEW THE COMMIT AND PIPELINE HISTORY**.
- If running from the pipeline, please ensure to CLEAN UP by deleting the Abraham Test account AFTER the first test is run and BEFORE the second test is run in the pipeline. 
- In Production we would implement a clean up script to delete the Abraham Test Account or a snapshot to return the portal to it's state prior to the test. 

# Cross Browser Testing on the Pipeline
- If you want to change the browser - you can click into the Xero Specflow Tests Pipeline > Edit > Variables and then you can add/modify browserToTest variable to the following: 
    1. **Chrome** will run the tests on the Chrome WebDriver
    2. **Firefox** will run the test on the Firefox GeckoDriver
    3. **Docker** will run the tests on a docker container (for this we would need a docker selenium/standalone-chrome container exposed to http://localhost:4444).
        a. This will not currently run on the pipeline, however if running locally, you'll need to have docker installed and run\
        `docker run -d -p 4444:4444 --shm-size 2g -p 5900:5900 selenium/standalone-chrome`\
        b. If this is successful, you should be able to navigate to http://localhost:4444 and see the Selenium Grid page\
        c. You'll also need to [Install Docker](https://docs.docker.com/docker-for-windows/install/)
    4. If no browserToTest variable is specified - then the tests will run on the Chrome WebDriver.

# Other Useful Tidbits
- RemoteDriver and running with a Docker container is only implemented as a proof of concept and can work if building and running the tests and the docker container is up 
  and running locally with the correct ports exposed as above.
- This proof of concept can also extend the tests to either run on a Selenium Grid, or run via Selenium Grid on Docker (this would need more modifications) and some configuration

