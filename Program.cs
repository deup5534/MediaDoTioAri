double resultado1, resultado2, resultado3, media;

Console.WriteLine("Media Aritmetica de 3\n");

Console.Write("digite seu primeiro numero:");
resultado1 = Convert.ToDouble(Console.ReadLine());     


Console.Write("digite seu segundo numero:");
resultado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite seu terceiro numero:");
resultado3 = Convert.ToDouble(Console.ReadLine());

media = (resultado1 + resultado2 + resultado3) /3;

Console.WriteLine($"\nmedia: {media:N1}");
