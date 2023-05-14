// See https://aka.ms/new-console-template for more information
using LowLevelDesign.Interfaces;

//Console.WriteLine("Hello, World!");

//StaticMembers m1 = new StaticMembers();

//m1.age = 10;
//m1.name = "abc";

//StaticMembers m2 = new StaticMembers();

//m2.age = 20;
//m2.name = "def";

/*
 	- Static members don't live in object memory. They live in classes & belong to class
		○ C# - Can't be accessed via Instance
		○ JAVA -Can be accessed - but warning
 */
//m1.schoolName = "test";
//StaticMembers.schoolName = "test";


Car kiaCar = new Car();

kiaCar.setMusicSystem(new SonyMusicSystem());

kiaCar.playSong();
