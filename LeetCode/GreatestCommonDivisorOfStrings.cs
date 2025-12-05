namespace LeetCode
{
    public static class GreatestCommonDivisorOfStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if ((str1 + str2) != (str2 + str1))
                return "";

            int gcdLength = GCD(str1.Length, str2.Length);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ms");
            return str1.Substring(0, gcdLength);
        }

        /// <summary>
        /// Metodo para calcular o MDC (Máximo Divisor Comum) usando o Algoritmo de Euclides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>O maior número inteiro que divide ambos sem deixar resto.</returns>
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

}

//🧮 O que é o GCD?
//O Máximo Divisor Comum entre dois números a e b é o maior número inteiro que divide ambos sem deixar resto.
//Exemplo:
//-GCD(8, 12) = 4
//- GCD(15, 25) = 5

//🔧 Método Usado: Algoritmo de Euclides
//O seu código usa o algoritmo de Euclides, que é super eficiente e elegante. Aqui está o trecho:
//private int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}



//🧠 Explicação Passo a Passo
//1. Ideia central
//O algoritmo se baseia na propriedade:
//GCD(a, b) = GCD(b, a % b)

//Ou seja, o GCD de dois números é o mesmo que o GCD do menor número e o resto da divisão do maior por ele.
//2. Loop até o resto ser zero
//- Enquanto b ≠ 0, você continua trocando os valores:
//-a recebe o valor de b
//- b recebe o valor de a % b
//3. Quando b == 0
//- O valor de a nesse momento é o GCD.

//🔄 Exemplo: GCD(48, 18) a%b = 48/18 = 2 resto 12
//Inicial
//|  a  |  b  | a % b |
//| 48  | 18  | 12    |
//Iteração 1
//|  a  |  b  | a % b |
//| 18  | 12  | 6     |
//Iteração 2
//|  a  |  b  | a % b |
//| 12  | 6   | 0     |
//Iteração 3(Final)
//|  a  |  b  | a % b |
//| 6 | 0 |  |

//GCD(8, 12)
//|  a  |  b  | a % b |
//| 8   | 12  | 8     |
//| 12  | 8   | 4     |
//| 8   | 4   | 0     |

//GCD(15, 25)
//|  a  |  b  | a % b |
//| 15  | 25  | 15    |
//| 25  | 15  | 10    |
//| 15  | 10  | 5     |
//| 10  | 5   | 0     |

//Resultado: GCD = 6

//⚡ Performance
//- Complexidade de tempo: O(log min(a, b)) — extremamente rápido, mesmo para números grandes.
//- Complexidade de espaço: O(1)
