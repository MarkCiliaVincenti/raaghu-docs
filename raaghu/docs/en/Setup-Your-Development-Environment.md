Getting Started
===============

This tutorial assumes that you’ve already purchased an [ABP Commercial license](https://commercial.abp.io/pricing) and have an active ABP Commercial account.

This document assumes that you refer to use raaghu-react Pages as the UI framework and Entity Framework Core as the database provider.

Setup development environment
-----------------------------

Let’s setup your development environment before creating the first project.

### Pre-requirements

The following tools should be installed on your development machine.

* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (v17.3+) for Windows / [Visual Studio for Mac. 1](https://visualstudio.microsoft.com/vs/mac/)
* [.NET 7.0+](https://dotnet.microsoft.com/en-us/download/dotnet)
* [Node v18](https://nodejs.org/en) or above
* npm v8 and above or [Yarn v1.20+ (not v2) 2](https://classic.yarnpkg.com/en/docs/install#windows-stable).

### Install the ABP CLI

[ABP CLI](https://docs.abp.io/en/abp/latest/CLI) is a command line interface that is used to automate some common tasks for ABP based solutions.

[ABP CLI](https://docs.abp.io/en/abp/latest/CLI) is a free & open source tool for the ABP framework. It is also used for ABP Commercial application development.

First, you need to install the ABP CLI using the following command:

```
  dotnet tool install -g Volo.Abp.Cli
```

If you've already installed, you can update it using the following command:

```
  dotnet tool update -g Volo.Abp.Cli
```

### Login to your account

In order to use ABP Commercial features, you need to login your account using the ABP CLI:

```
abp login username 
```

It will ask a password, so you must enter the password of your account.

You can freely create a new account from the ABP Account web site. However, your account should be registered to an organization as a developer to be able to use the ABP Commercial. If your company has an ABP Commercial license, ask your manager to add your account to the developer list of the organization.

### Install the ABP Suite

[ABP Suite](https://docs.abp.io/en/commercial/7.2/abp-suite/index) is an application aims to assist you on your development.

First, you need to install the ABP Suite:

```
abp suite install
```

If you’ve already installed , you can update it:

```
  abp suite update
```

### Next Step

* [Creating a new solution](Creating-A-New-Solution.md)
