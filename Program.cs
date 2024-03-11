namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, int> visited = new Dictionary<int, int>();
            List<int> items = [2, 3, 7, 11, 15];
            int target = 9;

            for (int i = 0; i < items.Count; i++)
            {
                var atual = items[i];
                var result = target - atual;

                // Implementação 1 - Verifica se o complemento está na lista.
                if (visited.ContainsKey(result))
                    Console.WriteLine($"Soma encontrada !! [{visited[result]}, {i}]");
                visited[atual] = i;

                //Implementação 2 - Verifica se o atual é complemento de target.
                if (visited.ContainsKey(atual))
                    Console.WriteLine($"Soma encontrada !! [{visited[atual]}, {i}]");
                visited[result] = i;
            }
        }
    }
}
