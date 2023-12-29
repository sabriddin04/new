class Person
{
    public string Name { get; set; }

     public Person( string name)
     {
        Name=name;
     }
     public override string ToString ()
     {
        return $"Person : {Name}";
     }
}