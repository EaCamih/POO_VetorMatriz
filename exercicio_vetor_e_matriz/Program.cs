using System;

namespace exercicio_vetor_e_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random objeto = new Random();

            Console.Write("Exercicio 1");
            Console.Write("\n");


            // Matriz
            int[,] notas = new int[2, 4];
            int linha, coluna = 0;
            for (linha = 0; linha < 2; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    notas[linha, coluna] = objeto.Next(10, 15);
                }
            }
            for (linha = 0; linha < 2; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(notas[linha, coluna] + "\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            Console.Write("Exercicio 2");
            Console.Write("\n");


            // Matriz
            int[,] valor2 = new int[10, 10];
            int somalinha24 = 0;
            int somacoluna26 = 0;
            int linha2, coluna2 = 0;
            for (linha2 = 0; linha2 < 10; linha2++)
            {
                for (coluna2 = 0; coluna2 < 10; coluna2++)
                {
                    valor2[linha2, coluna2] = objeto.Next(1, 100);
                }
            }
            for (linha2 = 0; linha2 < 10; linha2++)
            {
                for (coluna2 = 0; coluna2 < 10; coluna2++)
                {
                    if (linha2 == 4)
                    {
                        somalinha24 += valor2[linha2, coluna2];
                    }
                    if (coluna2 == 6)
                    {
                        somacoluna26 += valor2[linha2, coluna2];
                    }
                    Console.Write(valor2[linha2, coluna2] + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.WriteLine("a) A soma dos valores da linha 4: " + somalinha24);
            Console.Write("\n");
            Console.WriteLine("a) A soma dos valores da linha 4: " + somacoluna26);
            Console.Write("\n");


            Console.Write("\n");
            Console.Write("Exercicio 3");
            Console.Write("\n");

            int[,] valor3 = new int[3, 2];
            int linha3, coluna3 = 0;
            int contpar3 = 0, contimpar3 = 0;
            int ipar3 = 0, iimpar3 = 0;
            for (linha3 = 0; linha3 < 3; linha3++)
            {

                for (coluna3 = 0; coluna3 < 2; coluna3++)
                {
                    valor3[linha3, coluna3] = objeto.Next(0, 100);
                }
            }
            for (linha3 = 0; linha3 < 3; linha3++)
            {

                for (coluna3 = 0; coluna3 < 2; coluna3++)
                {
                    if (valor3[linha3, coluna3] % 2 == 0)
                    {
                        contpar3++;
                    }
                    else
                    {
                        contimpar3++;
                    }
                    Console.Write(valor3[linha3, coluna3] + "\t");
                }

                Console.Write("\n");
            }


            int[] vetor_impar3 = new int[contimpar3];
            int[] vetor_par3 = new int[contpar3];
            for (linha3 = 0; linha3 < 3; linha3++)
            {

                for (coluna3 = 0; coluna3 < 2; coluna3++)
                {
                    if (valor3[linha3, coluna3] % 2 == 0)
                    {
                        vetor_par3[ipar3] = valor3[linha3, coluna3];
                        ipar3++;
                    }
                    else
                    {
                        vetor_impar3[iimpar3] = valor3[linha3, coluna3];
                        iimpar3++;
                    }
                }

                Console.Write("\n");
            }
            for (int i = 0; i < contpar3; i++)
            {
                Console.WriteLine(vetor_par3[i] + "Par\t");
            }
            for (int i = 0; i < contimpar3; i++)
            {
                Console.WriteLine(vetor_impar3[i] + "Impar\t");
            }


            Console.Write("\n");
            Console.Write("Exercicio 4");
            Console.Write("\n");

            int[,] valor4 = new int[6, 6];
            int[] maior4 = new int[6];
            int linha4, coluna4 = 0;
            int maiornum2 = 0, maiornum4 = 0, maiornum6 = 0;

            for (linha4 = 0; linha4 < 6; linha4++)
            {
                for (coluna4 = 0; coluna4 < 6; coluna4++)
                {
                    valor4[linha4, coluna4] = objeto.Next(1, 50);
                    Console.Write(valor4[linha4, coluna4] + "\t");

                    if (linha4 == 1)
                    {
                        if (valor4[linha4, coluna4] > maiornum2)
                        {
                            maiornum2 = valor4[linha4, coluna4];

                        }
                    }
                    if (linha4 == 3)
                    {
                        if (valor4[linha, coluna] > maiornum4)
                        {
                            maiornum4 = valor4[linha4, coluna4];

                        }
                    }
                    if (linha4 == 5)
                    {
                        if (valor4[linha, coluna] > maiornum6)
                        {
                            maiornum6 = valor4[linha4, coluna4];

                        }
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("Maior valor da linha 2: " + maiornum2);
            Console.Write("\n");
            Console.Write("Maior valor da linha 4: " + maiornum4);
            Console.Write("\n");
            Console.Write("Maior valor da linha 6: " + maiornum6);

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Exercicio 5");
            Console.Write("\n");

            int[,] valor5 = new int[4, 4];
            int[] maior5 = new int[6];
            int[] maiores5 = new int[16];
            int linha5, coluna5 = 0;
            int i5 = 0;


            for (linha5 = 0; linha5 < 4; linha5++)
            {
                for (coluna5 = 0; coluna5 < 4; coluna5++)
                {
                    valor5[linha5, coluna5] = objeto.Next(1, 9);
                    maiores5[i5] = valor5[linha5, coluna5];
                    i5++;

                    Console.Write(valor5[linha5, coluna5] + "\t");

                }
                Console.Write("\n");
            }
            Array.Sort(maiores5);
            Array.Reverse(maiores5);

            Console.Write("\n");
            Console.Write("RESULTADO:  ");
            Console.Write("\n");

            for (int t = 1; t < 6; t++)
            {
                Console.Write(maiores5[t] + "\t");
            }

            Console.ReadKey();
        }
    }
}
