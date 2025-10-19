public readonly struct CardColor
{
    public string Name { get; }

    private CardColor(string name)
    {
        Name = name;
    }

    // --- Définition des couleurs standard ---
    public static readonly CardColor Coeur = new("Coeur");
    public static readonly CardColor Carreau = new("Carreau");
    public static readonly CardColor Trefle = new("Trèfle");
    public static readonly CardColor Pique = new("Pique");

    public override string ToString() => Name;

    // definiton opérateurs
    public override bool Equals(object? obj) =>
        obj is CardColor other && Name == other.Name;

    public override int GetHashCode() => Name.GetHashCode();

    public static bool operator ==(CardColor left, CardColor right) => left.Equals(right);
    public static bool operator !=(CardColor left, CardColor right) => !left.Equals(right);
}
