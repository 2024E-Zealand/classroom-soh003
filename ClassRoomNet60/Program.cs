// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

List<Studerende> studerende = new List<Studerende>();

Studerende studerende1 = new Studerende("Søren", 8, 28);
Studerende studerende2 = new Studerende("Thomas", 3, 15);
Studerende studerende3 = new Studerende("Christian", 9, 17);

studerende.Add(studerende1);
studerende.Add(studerende2);
studerende.Add(studerende3);

DateTime semesterStartDato = new DateTime(2022, 09, 01);


Klasserum klasserum3B = new Klasserum("3B", studerende, semesterStartDato);


klasserum3B.UdskrivKlasseLokale();



