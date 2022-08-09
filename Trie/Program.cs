using System;

namespace Trie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("привет", 50);
            trie.Add("мир", 100);
            trie.Add("приз", 200);
            trie.Add("мирний", 100);
            trie.Add("подарок", 50);
            trie.Add("проект", 200);
            trie.Add("прапорщик", 50);
            trie.Add("правий", 100);
            trie.Add("год", 150);
            trie.Add("герой", 100);
            trie.Add("голуб", 200);

            trie.Remove("правий");
            trie.Remove("мир");

            Search(trie, "привет");
            Search(trie, "мир");
            Search(trie, "облоко");
            Search(trie, "мирний");
            Search(trie, "проект");
            Search(trie, "год");
        }
        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine(word + " " + value);
            }
            else
                Console.WriteLine("Не знайдено " + word);
        }
    }
}
