
            int[] numero = new int[10];
            int maior;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Informe o {0}° numero", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            maior = numero[0];

            for (int i = 1; i < numero.Length; i++)
            {
                if (numero[i] > maior)
                    maior = numero[i];


            }

            Console.WriteLine(maior);
            Console.ReadKey()
