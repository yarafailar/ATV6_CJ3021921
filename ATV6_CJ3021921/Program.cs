namespace ATV6_CJ3021921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========MENU DO MARQUESITO========");

            Console.WriteLine("Digite 1 para o exercício 1");

            Console.WriteLine("Digite 2 para o exercício 2");

            Console.WriteLine("Digite 3 para o exercício 3");

            Console.WriteLine("Digite 4 para o exercício 4");

            Console.WriteLine("Digite 5 para o exercício 5");

            Console.WriteLine("Digite 6 para o exercício 6");

            Console.WriteLine("Digite 7 para o exercício 7");

            Console.WriteLine("Digite 0 para sair");

            Console.WriteLine("=====================================");


            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:

                    Console.WriteLine("obrigado por utilizar o programa");
                    break;

                case 1:

                    //1
                    int i, n;
                    i = 0;

                    Console.WriteLine("Digite um número:");
                    int i = int.Parse(Console.ReadLine());


                    while (n <= i)
                    {
                        Console.WriteLine(n);

                        n++;

                    }


                    break;


                case 2:

                    int r = 1;

                    Console.WriteLine("Digite um número:");
                    int j = int.Parse(Console.ReadLine());


                    while (r <= j)
                    {
                        if (r % 2 == 0)
                        {
                            Console.WriteLine(r);
                            r++;


                        }
                    }

                    break;

                case 3:

                    int p3 = 1;

                    Console.WriteLine("Digite um número até 1000:");
                    int l2 = int.Parse(Console.ReadLine());

                    while (p3 < 1000)
                    {
                        if (p3 % 2 == 0)
                        {
                            Console.WriteLine(p3);
                            p3++;
                        }
                    }

                    break;

                case 4:

                    int x1;

                    int soma = 200;

                    Console.WriteLine("Digite um número");
                    x1 = int.Parse(Console.ReadLine());
                    soma = 200;

                    while (x1 <= soma)
                    {
                        if (x1 < 0)
                        {
                            Console.WriteLine("número inválido");
                        }

                        else

                            Console.WriteLine(x1);
                    }

                    break;

                case 5:

                    int vale1, n1;

                    Console.WriteLine("Digite um número:");
                    n1 = int.Parse(Console.ReadLine());
                    vale1 = 1;

                    while (vale1 <= n1)
                    {
                        if (n1 % vale1 == 0)
                        {
                            Console.WriteLine(n1);
                        }
                        vale1 = (vale1 + 1);
                    }
                    break;


                case 6:

                    int n12 = 100, n22 = 99;

                    while (n12 <= n22)
                    {
                        Console.WriteLine("Digite 10 valores");
                        n22 = int.Parse(Console.ReadLine());

                        if (n22 < n12)
                        {
                            Console.WriteLine("o número maior é = {0}", n22);

                        }


                        if (n12 > n22)
                        {
                            Console.WriteLine("o número menor é = {0}", n22);
                        }


                    }

                    break;

                case 7:

                    int n7 = 1, h3 = 1;
                    int p1 = 0, g3 = 0;

                    while (p1 < g3) 
                    {
                        Console.WriteLine("Digite um valor");
                        h3 = int.Parse(Console.ReadLine());

                        if (h3 <= 0)

                            break;

                        if (n7 % 2 != 0)
                        {
                            n7 = n7 + n7;
                        }

                        if (n7 % 2 == 0)
                        {
                            n7 = n7 + p1;
                        }
                        Console.WriteLine("soma dos números ímpares = {0}", g3, p1, "soma dos números pares {1}", p1);
                    }


                    break;

            }
        }
    }
}
