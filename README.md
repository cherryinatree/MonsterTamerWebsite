
# MonsterTamerWebsite
 Website for the video game Monster Tamer's Journey
## Overview

This website is meant to serve as the central advertising point of the video game “The Monster Tamer’s Journey”. It will provide images and trailers of the game, answer frequently asked questions, and have a registration for media personnel such as journalists, streamers, and influencers to contact and receive free copies of the game. The website will also provide news and updates about the video game. 

#### Design: 
The website is taking inspiration from the Slime Rancher video game website. The website is going to have 12 pages.
Pages:
1.	Home
2.	News
3.	Media
4.	Press
5.	Support
6.	FAQ
7.	Contact Us
8.	Third Party Licenses
9.	Privacy Policy
10.	Credits
11.	Log In
12.	Media information
13.	Media interact

The website log in page won’t have a link to reach it from any other page. The only purpose of the log in page is for the site master to easily edit the pages without having to hard code things on the website. There will need to be a second version of the website for the logged-in site master that allows each area to be edited. The site master will also have access to a page that gives information about media personnel that have signed up for a free copy. The site master will be able to click on one of the media personnel to enter information about verification and interactions with the media personnel. 
	
#### Database:  
The database will have 3 main sections, admins, media, and content. The admins will be the only accounts on the website, and they will have permission to edit the website. The media will be people who have submitted to receive a free copy of the game. The content is what is displayed on the webpages, primarily text. 

The admin tables will include a main table with ID, email, and password. For security purposes, I think the admin should have another table that logs when they logged on. There should be another table that says what the admin changed and when they changed it. If there are several admins, then if there is a compromised account, this will make it easier to know which account it is and take action to prevent any more malicious interactions.  

The media tables will include a main table with name, email, password, organization. There will need to be another table to determine if the media personnel have been verified. This will consist of Boolean values. The values include contacted, verified, sent a copy. There will need to be a table of notes about the media personnel so the site master can document their interactions with them.
	
The final section of the database is the content. This section will have a main table that has the ID, a title field, a text field, and a Boolean for if the text is news. There may be another table for images, but at the moment, hard coding the images and videos appears fine since this is a single player game and not a constantly evolving online game. Just having text editable will reduce scope, making the website a little more manageable since website will mainly just have text edited.

#### Conclusion:  
The video game websites I looked have most of the relevant information to the user above the fold on the home page. The information includes an appealing image of the game, the title of the game, a trailer of the game, where to buy the game, and a nav bar for more information. The website will have a site map at the footer of every page and a nav bar at the top. Below the fold will be news about the game. The news will be the last 10 pieces of news appearing in the order it was created from newest to oldest. The new page will have the rest of the news. This should be everything the user needs to know and be SEO ready so Google should have everything it needs to answer peoples questions. 



## Solution Architecture Diagram


## Wireframe diagrams

An image: ![Alt](README_images/WebsiteAdminCreatorList.png)

## User Stories


## Initial Use Cases


## Use Case Diagram


