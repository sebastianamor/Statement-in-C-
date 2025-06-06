string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }

// desde aqui 
foreach (var name in names)
{
    Console.WriteLine(name);
}

for (int x = 0; x < 20; x++)
{
    Console.WriteLine(x);
}


}

