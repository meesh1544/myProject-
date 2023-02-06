using System;
using System.Security.Cryptography;
using System.Transactions;

namespace myProject
{
    class Food
    {
        private int _Id;
        private string _Hot;
        private string _Cold;

        private static int _transactions = 0;

        public void SetTrans()
        {
            _transactions++;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public Food()
        {
            _Id = 0;
            _Hot = "";
            _Cold = "";
        }
        public Food(int i, string Hot, string Cold)
        {
            _Id = i;
            _Hot = Hot;
            _Cold = Cold;
        }
        public int GetfoodId()
        {
            return _Id;
        }
        public string GetHot()
        {
            return _Hot;
        }
        public string GetCold()
        {
            return _Cold;
        }

        public void SetfoodId(int identification)
        {
            _Id = identification;
        }
        public void SetHot(string hot)
        {
            _Hot = hot;
        }
        public void SetCold(string cold)
        {
            _Cold = cold;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Food member10 = new Food();
            member10.SetTrans();
            member10.SetfoodId(10);
            member10.SetHot("Chicken Fajita");
            member10.SetCold("Bento Box");

            Food member20 = new Food();
            Console.WriteLine("Please enter the student Id:");
            member20.SetfoodId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please choose hot lunch");
            member20.SetHot(Console.ReadLine());
            Console.WriteLine("Please choose cold lunch");
            member20.SetCold(Console.ReadLine());

            Food member30 = new Food(30, "Salad Bar", "Cold");
            member30.SetTrans();

            Console.WriteLine("Please enter the student Id:");
            int temp_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the type of hot lunch");
            string temp_Hot = Console.ReadLine();
            Console.WriteLine("Please enter the type of cold lunch");
            string temp_Cold = Console.ReadLine();
            Food member40 = new Food(temp_Id, temp_Hot, temp_Cold);

            Console.WriteLine($"The student has {member10.GetTrans()} new entries");
            displayFoods(member10);
            displayFoods(member20);
            displayFoods(member30);
            displayFoods(member40);
        }
        static void displayFoods(Food member)
        {
            Console.WriteLine("Here's your student information");
            Console.WriteLine($"Student Id: {member.GetfoodId()}");
            Console.WriteLine($"Hot: {member.GetHot()}");
            Console.WriteLine($"Cold: {member.GetCold()}");
            Console.WriteLine($"New Entries: {member.GetTrans()}");
        }

    }
}
