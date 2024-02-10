using Lab7;

Generator gen1 = new Generator(672347, 675586, 65534, 846765);
Generator gen2 = new Generator(5, 3, 11, 1);

GeneratorFib genf1 = new GeneratorFib(45, 65);
GeneratorFib genf2 = new GeneratorFib(55, 24);

int[] arr_gen1 = gen1.GenerateArray(10000);
int[] arr_gen2 = gen2.GenerateArray(10000);

double[] arr_genf1 = genf1.GenerateArray(10000);
double[] arr_genf2 = genf1.GenerateArray(10000);

var standart_generator = new Random();
int[] arr_standart = new int[10000];
for (int i = 0; i < arr_standart.Length; i++)
{
    arr_standart[i] = standart_generator.Next();
}

FileWorker f1 = new FileWorker("f1.txt");
FileWorker f2 = new FileWorker("f2.txt");
FileWorker f3 = new FileWorker("f3.txt");
FileWorker f4 = new FileWorker("f4.txt");
FileWorker f5 = new FileWorker("f5.txt");

f1.SaveArrayToFile(arr_gen1);
f2.SaveArrayToFile(arr_gen2);
f3.SaveArrayToFile(arr_genf1);
f4.SaveArrayToFile(arr_genf2);
f5.SaveArrayToFile(arr_standart);