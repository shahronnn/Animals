public class Snake: Animal
{
    string color;
    string species;
    public Snake()
    {
        
    }
    public Snake(string species)
    {
        this.species=species;
    }
    public Snake(string name,string color,string species):base(name,0)
    {
        this.color=color;
        this.species=species;
    }
    public string GetColor()=> color;
    public void SetColor(string color)=> this.color=color;
    public override string GetSound()=> "fas fas";
    public override bool IsScary()=> true;
    public override string ToString()=> $"name: {GetName()} / color: {color} / species: {species} / legs: {base.legs}";
}