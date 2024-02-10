namespace Lab2;

public class Triangle
{
    private (int a, int b, int c) Sides;

    public Triangle((int, int, int)? Sides = null)
    {
        this.Sides = Sides ?? (1, 1, 1);
    }

    public override string ToString()
    {
        return $"Стороны | a = {this.Sides.a}, b = {this.Sides.b}, c = {this.Sides.c}";
    }

    public int Perimeter()
    {
        return this.Sides.a + this.Sides.b + this.Sides.c;
    }

    public float Area()
    {
        float p = Perimeter() / 2;
        return Single.Sqrt(p * (p - this.Sides.a) * (p - this.Sides.b) * (p - this.Sides.c));
    }

    public (int, int, int) GetSides()
    {
        return this.Sides;
    }
}