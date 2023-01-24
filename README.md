# CS352-PA1
Jackson Horton
1/23/2023


The goal of this programming assignment is to explore how class inheritance, abstract classes, and the overall C# language works.


# Design Decisions
- Comment wise, I'm trying to be more minimalist when it comes to comments. I'm tring to avoid explaining every line of super simple code because then I just have more stuff to update if I change the code.
- In the main class, I just made a list of Animals and added each instance of one of its subclasses one-by-one. I thought that was the easiest way to do it so that's how I did. The main driver just runs through the list and runs the printInfo() method for each Animal in the list.
- For the animal class, I might use some getters for the subclasses to use, but I won't use any setters. The only way to set an animal's member variables is when it is instantiated (*the age can be incremented with ageUp()*).
- Animal is an abstract class that is inheritted by all of the subclasses because, a Cat for example, **is an Animal**, so it inherits the Animal class.
