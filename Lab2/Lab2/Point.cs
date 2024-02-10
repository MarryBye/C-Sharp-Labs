namespace Lab2;

public class Point
{
    private (int x, int y) Coordinates;
    
    // Перегружаю оператора
    public override string ToString()
    {
        return $"Координаты | x = {this.Coordinates.x}, y = {this.Coordinates.y}";
    }
    
    // Подсмотрел как делать стандартное значение кортежа
    public Point((int x, int y)? Coordinates = null)
    {
        this.Coordinates = Coordinates ?? (0, 0);
    }

    public (int, int) GetCoordinates()
    {
        return this.Coordinates;
    }

    public void SetCoordinates((int, int) Coordinates)
    {
        this.Coordinates = Coordinates;
    }

    public float GetDistance()
    {
        return Single.Sqrt(Single.Pow(this.Coordinates.x, 2) + Single.Pow(this.Coordinates.y, 2));
    }
}