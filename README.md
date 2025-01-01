# App_Lidra
<ins>**Description:**</ins>
A web app that offers users the possibility to share and manage expenses with friends.

<ins>**Features:**</ins>
- An authentification system that allows you to create an account with an e-mail, a password and a username and then log in with your e-mail and password ;
- A dark mode option ;
- When connected, you have access to a list of projects you participate in. If you are the owner of a project, a little crown is visible next to the project's name ;
- When you select a project, you have access to 4 different tabs:
    - **Project Details**: A tab that allows you to see and, if you are the owner, modify some details of the project: its name and the collaborators involved ;
    - **Add Expense**: A tab that allows you to add a new expense, that you are supposed to have payed. You will be able to precise the name of the expense, its date, the amount you payed, and the shares of each collaborator in this expense. The shares must add up to 1. You can then save to add this expense, or cancel this operation ;
    - **Expenses**: A tab that shows you all the expenses of the project, from the newer one to the oldest. It will display all the informations of each expense (name, date, author, amount and shares). You can modify or delete an expense if you are the owner of the project ;
    - **Visualization**: A tab that contains two sub-tabs:
        - **Distribution**: A tab that displays pie chart representing the amounts payed by each collaborator (to have a global idea) ;
        - **Recap**: A tab that displays a bar chart that shows how much each collaborator owes each one (with positive values for the ones that will receive money and negative values for the ones that owe).
- If you delete a collaborator from a project, the shares are equally redistributed to the other collaborators.
- For now, it is local, but everything is set up to launch it if needed.

<ins>**Installation guide:**</ins>
- The app is unfortunately not deployed so you will have to run it by yourself :(
- Clone this repository on your machine ;
- Open the solution fie AppLidra.sln in Visual Studio 2022 to the latest version(it was developped and tested on 17.10.5 so if you have a problem, try going back to this version).
- There are 3 projects in this solution:
    - A Library that contains the useful
    - A Server app is a web REST API that is called to do pretty much everything
    - A Client app that calls the server
- Go to "Project" in the top left section of Visual Studio
- Select: Configure start-up projects
- Select: Multiple start-up projects
- Select :"Start" for AppLidra.Client and AppLidra.Server, leave AppLidra.Shared to "None"
- Apply and press "OK"
- Then click on Run. Both the server and the client project will launch at the same time.
- Two pages should open:
    - A swagger page generated by OpenAPI that describes every routes of the AppLidra API;
    - The real web app, the client side where you can do everything.
- There you go, now you are free to use the web app.
