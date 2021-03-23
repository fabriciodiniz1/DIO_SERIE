namespace DIOSerie.Classes
{
    public abstract class EntidadeBase // ela não vai ter os métodos, ela só tenha um ID (todo mundo que herdar vai ter esse ID
    {
        public int Id { get; protected set; } // protected só pode acessado dentro da dll

    }
}