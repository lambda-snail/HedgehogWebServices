# HedgehogWebServices

A simple cloud service for creating online stores

<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
***
***
***
*** To avoid retyping too much info. Do a search and replace for the following:
*** github_username, repo_name, twitter_handle, email, project_title, project_description
-->


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/lambda-snail/HedgehogWebServices">
    <img src="https://github.com/lambda-snail/HedgehogWebServices/blob/stable/Hedgehog.UI/wwwroot/media/hedgehog-svgrepo-com.svg" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Hedgehog Web Services</h3>

  <p align="center">
    A simple cloud service for creating online stores
    <br />
    <a href="https://github.com/lambda-snail/HedgehogWebServices"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/lambda-snail/HedgehogWebServices/issues">Report Bug</a>
    ·
    <a href="https://github.com/lambda-snail/HedgehogWebServices/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
        <li><a href="#what-i-learned">What I learned</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This is the final project for the first part of the course at [Lexicon](https://www.lexicon.se/Businesscenters/Lexicon-Malmo/). It was created during an intense two-week period from April 26 to May 10, 2021. It consists of almost 10,000 lines of physical code, and about 2,000 lines of executable code (according to the built-in metrics of Visual Studio).

It is an implementation of a simple cloud service, that lets you register your own web store. You can also register as a customer of an already existing store and make simple purchases. The idea is very similar to [Quickbutik](https://quickbutik.com/sv) or maybe [Jetshop](https://www.jetshop.io/). Of course, since this was a two-week project, the features are a bit lacking compared to those two.

### Built With

* Visual Studio 2019 Community Edition
* ASP.NET MVC
* A little bit of JavaScript
* Lots of coffee :)

### What I learned

I have learned, among other things:

* That time management is a crucial skill for a developer; with limited time and an infinity of features, you really need to choose well which features you implement, so that you meet your functionality goals AND honor the deadline at the same time.
  * So, no major refactorings the last few days :)
* To organize a larger project, and use an issue tracking system (Trello) to maintain continuity in the development process.
* That larger projects really need good naming conventions, otherwise you spend too much time looking for stuff in the folders.
* That having more than one subclass of IdentituUser is a pain.
* Separating the storage of users and other application data might be a good idea (this should be a natural choice if following SOLID principles).


Of the two weeks, about half of the time has been spent on trying to resolve errors in the framework (mostly Identity).

<!-- GETTING STARTED -->
## Getting Started

Unfortunately, to try this out you will need to use some kind of development environment. To get started you need to:

1. Clone this repository
    ```sh
    git clone https://github.com/lambda-snail/HedgehogWebServices.git
    ```

2. Build the project in development mode.

3. Navigate to the Infrastructure project in the solution and create the database:
    ```sh
    update-database
    ```
4. Now you can start the project either from your IDE or the command line.


<!-- USAGE EXAMPLES -->
## Usage

There are two roles in the service:

1. Store owners

2. Customers

* A web store is accessed through an url of the form "base/storeName".

Registering and log in is based on the location from which you press the respective button.

* To log in/register in as a store owner, navigate to the starting screen of the project, and press log in/register.

  * Before you do anything else, you should create your store by navigating to the "my page" by clicking on your user name in the upper right corner. When registering the system will also provide a link to this screen and a prompt to create your store, so you cannot miss it.

* To log in/register as a customer, you must first navigate to the store of interest: baseUrl/storeName, and then press the relevant button there.

  * Loggin in is still possible from any screen, but you might be faced with an "access denied" screen - I am aware of this issue, but did not have time to fix it within the time constraints of the project. However, even though you see this screen, you have actually been logged in, and can navigate to your home store as normal!

* The shopping cart can be populated without loggin in. In this case, proceeding to checkout will prompt you to log in before payment.


<!-- ROADMAP -->
## Roadmap

Although the project is still very bare bones, I have decided to not continue development after the project is completed.

To see how the development process was organized, please visit the [Trello board](https://trello.com/b/f00NL1fp/hedgehog-service-roadmap).

See the [open issues](https://github.com/github_username/repo_name/issues) for a list of proposed features (and known issues).


<!-- LICENSE -->
## License
Distributed under the MIT License. See `LICENSE` for more information.


<!-- CONTACT -->
## Contact

[HedgehogWebServices](https://github.com/lambda-snail/HedgehogWebServices)
[Linkedin](https://www.linkedin.com/in/niclas-blomberg-b7a05211a/) 

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

* I would like to thank my teachers and course mates at lexicon for supporting me during the project.
* Thank you you Ernst Ras for providing the idea to the project, and for pushing me outside my comfort zone.
