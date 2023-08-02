public class Fish: Pet
{
    public Fish(){}
    public override string GetName()=> base.name;
    public override void SetName(string name)=> base.name=name;
    public override string Play()=> "ob";
    public override string Valk()=> "obbozi";
    public override string Eat()=> "kirm";
}