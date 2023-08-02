public abstract class Canis: Animal
{
    protected string species;

    public Canis(){}
    public Canis(string species)
    {
        this.species=species;
    }
    public Canis(string name, string species)
    {
        this.species=species;
        base.SetName(name);
        base.SetLegs(4);
    }
    public string GetSpecies()=> species;
    public void SetSpecies(string species)=> this.species=species;
    public override string GetSound()=> "gaf gaf";
    public override bool IsScary()=> true;
}