# CS352-PA1
Jackson Horton
1/23/2023


The goal of this programming assignment is to explore how class inheritance, abstract classes, and the overall C# language works. In this introduction to C#, I developed a program using abstract classes and subclasses to learn the syntax and workflow of using them in C#, as well as the overall structure of the language.


# Design Decisions
- Comment wise, I'm trying to be more minimalist when it comes to comments. I'm tring to avoid explaining every line of super simple code because then I just have more stuff to update if I change the code. I did comment each function/file as required.
- In the main class, I just made a list of Animals and added each instance of one of its subclasses one-by-one. I thought that was the easiest way to do it so that's how I did. The main driver just runs through the list and runs the printInfo() method for each Animal in the list.
- For the animal class, I could use some getters for the subclasses to use, but I won't use any setters. The only way to set an animal's member variables is when it is instantiated (*the age can be incremented with ageUp()*). *Note: I decided not to use any getters either as they weren't needed in any of the subclasses/overriden methods.*
- Animal is an abstract class that is inheritted by all of the subclasses because, a Cat for example, **is an Animal**, so it inherits the Animal class.
- Most override functions (overrides of Animal's virtual functions) only call the base class per the assignment details. I couldn't think of anything meaningful to make the override functions do, so I didn't. This is also why I didn't ever need any getters to get the private member variables.

# How it works

In the main driver program, *Program.cs*, There is a list that holds objects of type **Animal**. This means that any subclass of Animal (since Animal is abstract and can't be instantiated itself) can be added to the list.

Then, it runs through the list and prints the info for each Animal via the **printInfo()** function.

There is also a singular object that has all of its functions tested at the end of the driver.

More Animals can be added or removed from the list. My favorite part is coming up with names that make no sense.
