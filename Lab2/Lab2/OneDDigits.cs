namespace Lab2;

public class OneDDigits
{
    private int[] Arr;
    private int n;

    public OneDDigits(int n = 10)
    {
        this.Arr = new int[n];
        this.n = n;
    }

    public override string ToString()
    {
        string str_output = "";
        
        for (int i = 0; i < this.n; i++)
        {
            str_output = str_output + $"{i + 1}: {this.Arr[i]}\n";
        }

        return str_output;
    }

    public void sort()
    {
        Array.Sort(this.Arr);
    }

    public void input_elements()
    {
        for (int i = 0; i < this.n; i++)
        {
            Console.WriteLine($"Введите число №{i + 1}: ");
            this.Arr[i] = int.Parse(Console.ReadLine());
        }
    } 
}