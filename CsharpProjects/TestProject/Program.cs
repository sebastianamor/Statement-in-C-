
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine( "{names[i]}");
}
