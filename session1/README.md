## Session 1 - Microsoft Azure & Visual Studio Team Services Overview in Developers prospective

**Lab List**

1. Create an end-to-end DevOps Pipeline by using Azure DevOps Project
2. Create an end-to-end VSTS Project with VSTS DemoGenerator
3. Use Visual Studio Code (on Mac) to debug Asp.net Core (C#) Web Application
4. Use Visual Studio 2017 (on Windows) to debug the same code base
5. Create an Azure Function App and integrate with the Web Application
6. Use Application Insight to monitor and track telemetry data

**Hands-on Lab Instructions**

### Lab 01. Create an end-to-end DevOps Pipeline by using Azure DevOps Project & VSTS DemoGenerator

Go to https://azure.microsoft.com/en-us/features/devops-projects/ and click on **Try it Now**

![](images/devopsproject-01.png)

On **Runtime** page, choose **.NET**

![](images/devopsproject-02.png)

On **Framework** page, choose **ASP.NET Core**

![](images/devopsproject-03.png)

On **Service** page, choose **Web App for Containers**

![](images/devopsproject-04.png)

On **Create** page, Fill in the following information

| parameter | value                    | description                                          |
| --------- | ------------------------ | ---------------------------------------------------- |
| Account   | {your VSTS Account Name} | Choose Create Name or Using an existing VSTS account |
| Project   | {your Project name}      | Type in a new project name                           |

![](images/devopsproject-05.png)

Click on **Create** button, this process will take up to 10 mins.

Navigate to your newly created DevOps Project, you will see everything you need for developing, deploying and monitoring your project in one single page.

![](images/devopsproject-06.png)

### Lab 02. Create an end-to-end VSTS Project with VSTS DemoGenerator

Please follow the instructions from https://almvm.devopshub.cn/labs/vsts/VSTSDemoGenerator/ to create a VSTS project with the following feature all configured and ready to learn.

1. Dashboard
2. Product Backlog & Sprint Backlog
3. Kanban
4. Test Plan & Test Cases
5. Continues Integration Build Definition
6. Continues Deployment Pipeline Release Definition

Here is a quick 3 steps guide for using VSTS DemoGeneator

![Demo Generator](images/vstsdemogenerator-1.png)

![Demo Generator](images/vstsdemogenerator-2.png)

![Demo Generator](images/vstsdemogenerator-3.png)

### Lab 03. Use Visual Studio Code (on Mac) to debug Asp.net Core (C#) Web Application

If you are running a MacBook like me, you will wondering if it's possible to work with the code that we just created by DevOps Project. Because we chosed ASP.NET Core as our Framework, it's possible to use any platform as your development workstation to start coding, debugging and testing your application.

From the **DevOps Project Home** page, click on **Repositories** button on the top.

![](images/devopsproject-07.png)

You will navigate into the VSTS Project that is created for you and git repo is showing up

![](images/devopsproject-08.png)

Now, you can get the repo URL and clone the code to your MacOS.

![](images/devopsproject-09.png)

Use [Visual Studio Code](https://code.visualstudio.com/) open the git repo, vscode will start to install necessary tools and restore your dependencis.

![](images/devopsproject-10.png)

When the installation and restoring process finishes, you can navigate to the debug tab and click on the start debugging button.

![](images/devopsproject-11.png)

The Application will run the show up in your browser like this

![](images/devopsproject-12.png)

You can even setup a break point in your code and see vscode break into that point, then you can step into your code to view the varibles.

![](images/devopsproject-13.png)

You can also make changes to your code and push the code up to VSTS, then the CI/CD process will be triggered and eventually the Web App in Azure is updated automatically. 

This could happen because Azure DevOps Project has setup the whole pipeline for you so you don't have to worry about configure the CI/CD and write any scripts.

![](images/devopsproject-14.png)

![](images/devopsproject-15.png)

![](images/devopsproject-16.png)

If you remember that we chosed Web App with Container when we setup this Azure DevOps Project, you should know that there are Azure Container Registry behind the sense to support our CI/CD pipeline, you can navigate to this ACR from the DevOps Project home page as well to see the container images that we have been built and pushed.

![](images/devopsproject-17.png)

### Lab04. Use Visual Studio 2017 (on Windows) to debug the same code base

As mentioned before, ASP.NET Core is cross platform. You can use a Windows Machine with Visual Studio installed to open the same code base that we have modified on MacOS and debug the code without any changes.

From the VSTS git repo and choose **Clone** on the top right, you will see a list of supported IDEs; choose Visual Studio and Visual Studio will pop up and start cloneing the code.

![](images/devopsproject-18.png)

This operation will setup your Visual Studio to connect to the VSTS Project and make the code ready for developing.

![](images/devopsproject-19.png)

Press **F5** and now you are debugging the same code that we have been using from MacOS just a while ago.

![](images/devopsproject-20.png)

### Lab05. Create an Azure Function App and integrate with the Web Application

