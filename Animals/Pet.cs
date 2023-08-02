public abstract class Pet: Animal
{
    protected string name;
    public Pet():base(4)
    {
        
    }
    public abstract string GetName();
    public abstract void SetName(string name);
    public abstract string Play();
    public override string Valk()
    {
        throw new NotImplementedException();
    }
    public override string Eat()
    {
        throw new NotImplementedException();
    }
}