public abstract class Animal
{
    string name;
     protected int legs;

    public Animal(){}
    public Animal(string name, int legs)
    {
        this.name=name;
        this.legs=legs;
    }
    public string GetName()=> name;
    public void SetName(string name)=> this.name=name;
    public void SetLegs(int age)=> this.legs=age;
    public abstract string GetSound();
    public abstract Boolean IsScary();
    public abstract string ToString(); 
}