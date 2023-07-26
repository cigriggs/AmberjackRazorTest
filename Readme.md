# Amberjack Razor Test

This solution contains 
- asp.net razor project
- xunit based unit test project

All razor based work can be carried out in the Index.cshtml & Index.cshtml.cs files. Any Javascript written can be placed in the site.js file.

The Index.cshtml.cs file contains some pre-written code that could be used to write the stories below.

## Task Stories

Please complete each story in order

### Story 1
As a user
I need to be able to enter my title, first name, last name and email address
So that the system contains my correct information

#### Acceptance criteria 

- The title list is generated from the enum in Index.cshtml.cs
- The user is able to select their title using a drop down list
- The user is able to enter their first name
- The user is able to enter their last name
- The user is able to enter their email address

### Story 2
As a user
I need to be shown validation messages if information is missing or invalid
So that I enter the correct information into the system

#### Acceptance criteria 

- If last name is not supplied then the user is shown a message informing them the field is missing
- If email address is not supplied then the user is shown a message informing them the field is missing
- If an invalid email address is supplied then the user is shown a message informing them that they should enter a valid email address
- A unit test should be created to show the email address working for valid & invalid email addresses.


### Story 3
As a user
I need to see confirmation of details given

#### Acceptance criteria
- After the user has entered their information and the post back event has taken place the screen displays a string saying "Hello {title} {firstname} {lastname} ({email})".
- If first name is not supplied then the return string should be changed so that there not extra spaces shown to the user


### Story 4
As a user
I need to be able to enter my qualifications

#### Acceptance criteria
- The page should contain a Qualifications section
- The qualification section should contain a "add qualification button"
- Once clicked the add qualification button should dynamically add (using javascript) a Name textbox and a Grade textbox to the qualifications section.
- The user can add up to 8 qualifications on the page.
- On post back the screen should repeat the qualifications back to the user.