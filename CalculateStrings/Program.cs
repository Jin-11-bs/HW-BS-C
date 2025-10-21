namespace CalculateStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(不區分大小寫)
            Console.Write("請輸入一個有意義的英文敘述字串: ");
            string input = Console.ReadLine();
            //Split(' ') 以空白分割句子成單字陣列
            var words = input.ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var result = words.GroupBy((w) => w) //單字分組
                //每個群組 g，建立一個新的匿名物件 {Word = 群組名稱, Count = 群組中項目數}
                .Select((g) => new { Word = g.Key, Count = g.Count()});
            foreach (var item in result)
            {
                Console.WriteLine($"單字 {item.Word} 出現了 {item.Count} 次");
            }
        }
    }
}
