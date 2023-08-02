public class Cat: Pet
{
    public Cat(){}
    public Cat(string name)
    {
        base.name=name;
    }
    public override string GetName()=> base.name;
    public override void SetName(string name)=> base.name=name;
    public override string Play()=> "with ball";
}