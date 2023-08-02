public class Dog: Canis
{
    public Dog(){}
    public Dog(string name)=> SetName(name);
    public override string GetSound()=> "gaf gaf";
    public override bool IsScary()=> true;
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}