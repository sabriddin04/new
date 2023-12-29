var person =new Person("sabr");
var student=new Student("umar");
var teacher=new Teacher("AKAi ALi");
List<Person> Spisok =new List<Person>();
Spisok.Add(person);
Spisok.Add(student);
Spisok.Add(teacher);
foreach (var item in Spisok)
{
    if(item==teacher)System.Console.WriteLine(teacher.Explain());
    else System.Console.WriteLine(student.Study());
    
}



