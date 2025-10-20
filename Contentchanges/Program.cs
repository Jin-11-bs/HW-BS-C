namespace Contentchanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //可被 3 整除者替換為 Build，可被 5 整除者替換為 School，可被 15 整除者替換為 Dann
            Console.Write("請輸入一個整數max (至少大於 90): ");
            var input = Console.ReadLine();
            var max = int.Parse(input);
            if (max <= 90)
            {
                Console.WriteLine("請輸入大於90的數字!");
                return;
            }
            var result = 
                Enumerable.Range(1, max)
                .Select(n =>
                (n % 15 == 0) ? "Dann" :
                (n % 3 == 0) ? "Build" :
                (n % 5 == 0) ? "School" :
                n.ToString());
            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(
            //    string.Join(Environment.NewLine,
            //                Enumerable.Range(1, max)
            //                .Select(n =>
            //                (n % 15 == 0) ? "Dann" :
            //                (n % 3 == 0) ? "Build" :
            //                (n % 5 == 0) ? "School" :
            //                n.ToString()
            //                ))
            //);
            //Enumerable.Range(1, max) ➜ 產生 1 到 max 的整數序列 
            //三元運算子: 條件 ? 當條件成立時要回傳的值 : 當條件不成立時要回傳的值
        }
    }
}
