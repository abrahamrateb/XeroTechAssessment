# XeroTestAssessment
Test Assessment Using Specflow + NUnit + Selenium WebDriver

# CLEAN UP - STEP ZERO
- After running tests, ensure to clean up and delete the account to leave the Xero Production Demo in the same state it originally was. 
- To do this you'll need to navigate to the [Xero Login Portal > Accounting > Chart of Accounts](https://go.xero.com/GeneralLedger/ChartOfAccounts.aspx?Start=1&PageSize=200), 
  and login with either your demo account or abrahamrateb@gmail.com and xero1234 as the password. 
- **BY DESIGN, THE ACCOUNT IS NOT DELETED SO YOU CAN MANUALLY VERIFY THE RESULT. PLEASE MAKE SURE TO DELETE THE ACCOUNT IF YOU WANT TO RERUN THE TEST**
- The reason for this design, is in the case you run the test in a pipeline or via a container locally, it wil be headless and you may not see the test executing, however
  an account created in the XERO Portal verifies that the test run in the pipeline/container has actually affected the System Under Test. 
- This design also allows for negative testing, for example, if you change the test Account Name or Number so the given parameters are incorrect in the test, you can see the test
  failing as expected on the Assertion step, even though the account is created successfully. 
## ENSURE YOU DELETE THE ABRAHAM TEST ACCOUNT AFTER EVERY TEST RUN PLEASE TO LEAVE XERO PRODUCTION PORTAL IN IT'S CURRENT STATE
## TESTS WILL FAIL IF CLEAN UP IS NOT PERFORMED

# Running Tests Locally
- If you want to run and debug the tests/negative test locally, you can browse to (https://dev.azure.com/abrahamrateb/_git/XeroTestAssessment) and Clone the repo. 
- If this does not work, you can clone from the GitHub Repo instead (https://github.com/abrahamrateb/XeroTechAssessment). 
- Simply open **Visual Studio 2019 > Clone Repository >** and paste the GitHub Link to clone the repo.
You can then run the tests from inside of Visual Studio, by building the solution, right clicking on the Specflow test and selecting run. 
You can also Ctrl + Shift + B to build the solution followed by Ctrl + R then T to run the tests. 

# Running Tests on Azure DevOps Pipeline
- You can also run tests directly from the pipeline. For this you navigate to (https://dev.azure.com/abrahamrateb/XeroTestAssessment/_build), login using your Azure DevOps credentials,
then you can investigate the pipeline and trigger a run. **YOU CAN ALSO REVIEW THE COMMIT AND PIPELINE HISTORY**.
- In Production we would implement a clean up script to delete the Abraham Test Account or a snapshot to return the portal to it's state prior to the test. 
- **If you cannot view the Edit/Run Pipeline button, please request permission from abrahamrateb@gmail.com**

# Cross Browser Testing on the Pipeline
- If you want to change the browser - you can click into the **Xero Specflow Tests Pipeline > Edit > Variables** and then you can add/modify **browserToTest** variable to the following: 
    1. **Chrome** will run the tests on the Chrome WebDriver
    2. **Firefox** will run the test on the Firefox GeckoDriver
    3. **Docker** will run the tests on a docker container (for this we would need a docker selenium/standalone-chrome container exposed to http://localhost:4444). \
        a. This will not currently run on the pipeline, however if running locally, you'll need to have docker installed and run\
        `docker run -d -p 4444:4444 --shm-size 2g -p 5900:5900 selenium/standalone-chrome`\
        b. If this is successful, you should be able to navigate to http://localhost:4444 and see the Selenium Grid page\
        c. You'll also need to [Install Docker](https://docs.docker.com/docker-for-windows/install/)\
        d. If done locally, you will also need to create an environment variable called **browserToTest** with a value of **Docker**. You may need to restart your machine. 
    4. If **NO browserToTest** variable is specified - then the tests will run on the Chrome WebDriver.

# Other Useful Tidbits
- RemoteDriver and running with a Docker container is only implemented as a proof of concept and can work if building and running the tests and the docker container is up 
  and running locally with the correct ports exposed as above.
- This proof of concept can also extend the tests to either run on a Selenium Grid, or run via Selenium Grid on Docker (this would need more modifications) and some configuration

