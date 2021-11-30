# VentureForge
- Maitham Alghamgham
- Jacob Morris
- Adam Fischer

## Product Overview

While various products allow for users to create characters for existing TTRPG systems, few allow their users the freedom to create their own systems and character creators that other people can use. This is the focus of VentureForge, platform that allows for the creation, use, and sharing of modules that contain rules, lore, and sheet creators for any TTRPG systems. In short, this means that anyone with access to VentureForge can let their imagination run wild as they create their own games and characters or create characters in any existing system, such as Dungeons & Dragons, Call of Cthulhu, or Cyberpunk.


## Software Assignment Overviews
### Assignment 1: Design the Box

The first step in the software development process was the process of outlining the potential product based on its general concept. In order to accomplish this, we completed a journal that gave a brief overview of the product and its intended audience. Additionally, we created and presented a box that contained information that allowed us to quicky and concisely present the core concept of VentureForge. Based on these two components, we were able to develop a Product Vision, which allowed us to clearly state our intentions for the product.
 In the end, the following became our vision statement:
 #### VentureForge Product Vision
For overwhelmed newcomers to tabletop role-playing games (TTRPGs) as well as experienced game masters or players who want to use and contribute to character creation tools, but need this process to be user-friendly, versatile, and effective, Venture Forge is a character creation platform that allows for experienced players to generate and adapt character creators based on their own campaigns, and also allows for newcomers to use these player-made systems to generate their own characters and get acquainted with TTRPG systems. Unlike other character creation tools such as D&D Beyond or Roll20, our product encourages one to create, use, and modify character creation tools for any TTRPG system. 

### Assignment 2: Design Artifacts Document

In this phase of development for VentureForge, we identified the features and components that should be implemented in order to create the product that we envisioned. However, this process also required a clear understanding of the types of potential users of the product and their needs, which led us to create personas of three archetypes of users: experienced game masters, experienced players, and newcomers to TTRPGs. From there, we were able to develop scenarios that elaborated on their needs through stories about how these personas might engage with the VentureForge product. These allowed us to clearly express what our features should be able to accomplish as we extrapolated user stories from these scenarios, giving us a series of concise statements about the needed functionality of the product.

### Assignment 3: Architectural Design

Finally, we determined the architecture of the product, which helped to establish the "how" behind the "what" portrayed in the Design Artifacts Document. This design process involved research into possible languages, databases, services, or general components that could be used in order to actually construct and implement VentureForge. While the final prototype only demonstrates some of the potential functionality of the front-end, the final architectural design for VentureForge included Microsoft Azure servers, SQLite databases, and Java Spring Boot microservices.

### Assignment 4: Prototype

Armed with the core concept for the product, specifications on its features, and an understanding of its architecture, we set out to actually implement the front end UI portion of VentureForge with C# and xaml. In all, our goal for the prototype is to demonstrate how users could create their own modules and sheets within those modules as well as save these and bring them back up to use or edit from a different page of the program, meaning that the most in-depth classes will be those related to creating modules and creating sheets. Overall, we hope that this will be a sufficent demonstration of the potential for VentureForge to encapsulate the ability for users to create and use their own TTRPG content.

## Docker Instructions

## DockerHub Link

## NUnit Instructions

The VentureForge prototype contains two instances of unit testing: the first is in the VentureForge project and runs tests on the objects and functionality of the UI program and the second takes place within our Docker container, giving us a place to focus on the non-UI components of VentureForge as well as gain an understanding of how Docker works with unit testing.

In order to run tests in the VentureForge solution in Visual Studio, one must open the project within VentureForge and click on *Test Explorer* under the *Test* tab. This will also require NUnit to be installed. From there, you can click the *Run All Tests in View* option, which will run all of the tests in the UnitTests.cs class. This series of tests seeks to demonstrate and verify the functionality of objects such as the Sheet, Module, and Container, which are all vital to the creation and storage of character sheets and system modules.

This bit is about docker stuff?? we'll see

## Demonstration Video

## Reflection

From the very beginning, this series of assignments has challenged our understanding of the software development process and provided us invaluable lessons about the aspects that one typically ignores when thinking about software development. For instance, the first project that we undertook was unrelated to the actual code of the project, instead focusing on the core concept behind VentureForge and challenging us to develop and clarify for ourselves what the actual functionality of this project would be. In a buinsness sense, software development should include a focus on the interests of customers in order to establish who the audience is and what they want as well as to ensure that the product would be successful enough to justify its development. In this way, we noted that, while software develpment seems far divorced from the world of buisness, it has similar focuses to that of regular product development. Additionally, working in groups as we began this development process was an interesting experince as the first project required us to come up with a collection of  ideas and decide together which one we should collabarate on. This also mirrored the sort of environment that we should expect in similar jobs as collaboration is the expectation.

The second project was similarly enlightening as we dove into the depths of documentation and thoroughly outlined the features and slivers of functionality that would provide us with direction in our actual implementation. Again we worked in more of a buisness mindset as we worked in areas outside of computer science creating personas and scenarios to guide our actual code. One of the things that this portion taught us was that we should always focus on the audience of the code, which is to say that we should keep in mind that a program that others are supposed to use should be catered to their use, not that of the programmer. While certain solutions might seem obvious to a programmer, anyone who does not have an understanding of how exactly the code works might be confused and stuck in the midst of well-intentioned design. This also was a good experience in that it allowed us to glimpse what working with clients might be like as we attemtpted to talior our features to the wants and needs of the users that we identified though the personas.

The design of the architecture went similarly as we focused on the planning aspect, which is a necessary part of any programming, but a much larger component when working with a project as large as this one. This portion of the software development process also incentivized us to do research into different components that could feasably be a portion of a larger, completed VentureForge. As such, we did research into cloud-based servers, such as Microsoft Azure, and services like SQLite that could keep track of user information and creations in a database. Finally, when we arrived at the actual implementation of the product, we had the experience of piecing these components together and realizing the fruits of our previous efforts. In some cases, these prior activities led us to focus on customer needs and were generally useful. Occationally, we noted that our previous expectations did not quite match up with the actual implementation of the product. This was an insigtful glimpse into the constant refinement that a product undergoes over the process of its development and put into practice the cycle of development and redevelopment that occurs in order to meet specifications. Overall, this exercise of attempting the software development process was a useful galnce into the practical application of constructive software development practices.
