Project has built with two presentation formats one with console application and another with web application
Solution has majorly four projects 

ConsoleApp3(Presentation Layer)
ConwaysGameOfLife(Presentation Layer)
Conways.Domain(Domain Layer)
Conways.Domain.Tests(Test Layer)
Conways.Utilities(Helper Layer)

Conways.Domain(Domain Layer) will be having the Service which gives the number of live cells around current cell
Domain layer can be accessed into presentation layer through repository pattern which will be easy to test

Conways.Domain.Tests(Test Layer) has a test cases for testing Conways.Domain layer which has mock testing also
Helper layer will have helper methods used by the project


