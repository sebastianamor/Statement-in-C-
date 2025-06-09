
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) {}

for (int i = 0; i < 10; i++)
{
    if (i == 7) break;
}


for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine( $"{i} {names[i]}");
}