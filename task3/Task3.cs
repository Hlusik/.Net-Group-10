using System;
using System.Collections.Generic;

namespace Task3
{
      public class Task3
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[length];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public List<string> CorrectList(char c, List<string> list)
        {
            var distinctList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!distinctList.Contains(list[i]) && list[i][0] != c)
                {
                    distinctList.Add(list[i]);
                }
            }
            distinctList.Sort();
            distinctList.Reverse();
            return distinctList;
        }
        public void DisplayPage(int pageNumber)
        {
            if (stringList.Count >= (pageSize * pageNumber - pageSize + 1))
            {
                for (int i = (pageSize * pageNumber - pageSize);
                         i < (stringList.Count > pageSize * pageNumber ? pageSize * pageNumber : stringList.Count); i++)
                {
                    Console.WriteLine(stringList[i]);
                }
            }
        }

        const int pageSize = 5;
        List<string> stringList = new List<string>();
        public void Execute()
        {
            //task 1
            var personList = new List<Person>
            {
                new Person{Name = "Jhon", Age = 21, PhoneNumbers = new List<string> { "111-111-111", "222-222-222", "333-333-333" }},
                new Person{Name = "Alex", Age = 51, PhoneNumbers = new List<string> { "111-555-111", "222-555-222" }},
                new Person{Name = "Amanda", Age = 25, PhoneNumbers = new List<string> { "777-111-111", "222-222-777", "333-333-444" }},
                new Person{Name = "Pol", Age = 32, PhoneNumbers = new List<string> { "111-256-111", "222-485-222", "333-333-266" }},
                new Person{Name = "Den", Age = 22, PhoneNumbers = new List<string> { "111-111-789", "222-222-546", "333-564-333" }},
                new Person{Name = "KAte", Age = 81, PhoneNumbers = new List<string> { "897-111-111", "789-222-222", "879-333-333" }}
            };

            Console.WriteLine("Persons: ");
            foreach (var item in personList)
            {
                Console.WriteLine("Name: " + item.Name + " Age: " + item.Age);
            }

            //task 2
            var addList = new List<Person>
            {
                new Person{Name = "David", Age = 51, PhoneNumbers = new List<string> { "111-111-111", "222-222-548", "333-333-333" }},
                new Person{Name = "Fill", Age = 58, PhoneNumbers = new List<string> { "111-555-111", "222-555-222" }}
            };
            personList.AddRange(addList);
            Console.WriteLine("PhoneNumbers: ");
            foreach (var item in personList)
            {
                Console.WriteLine();
                Console.WriteLine(string.Join(Environment.NewLine, item.PhoneNumbers));
            }

            // task 3 

            const int length = 4;
            var random = new Random();

            int pageNumber = 0;

            int count = random.Next(100, 150);
            for (int i = 0; i < count; i++)
            {
                stringList.Add(RandomString(length));
            }
            Console.WriteLine("List count befor transformation: ");
            stringList.ForEach(item => Console.Write("{0}\t", item));
            stringList = CorrectList('Z', stringList);
            Console.WriteLine();
            Console.WriteLine("List count after transformation: ");
            stringList.ForEach(item => Console.Write("{0}\t", item));
            Console.WriteLine();
            Console.WriteLine("List count befor transformation: " + count + "\nList count after transformation: " + stringList.Count);

            Console.WriteLine("Input page nuber: ");
            string pageNumStr = Console.ReadLine();
            if (int.TryParse(pageNumStr, out pageNumber))
                DisplayPage(pageNumber);
            else Environment.Exit(0);
        }
    }
}
