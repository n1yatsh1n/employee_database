using System;

namespace Workers
{
   

    public class Workers
    {
        public string Name;
        public int Birthday;
        public string[][] WorkRecs;



        public Workers(string a, int b, string[][] k)
        {
            Name = a;
            Birthday = b;
            WorkRecs = k;
        }
    }

    public class Managers : Workers
    {
        public string[][] orders;

        public Managers(string a, int b, string[][] k, string[][] d) : base(a, b, k)
        {
            Name = a;
            Birthday = b;
            WorkRecs = k;
            orders = d;
        }
    }

    public class Basic : Workers
    {
        public int Counter;

        public Basic(string a, int b, string[][] k, int n) : base(a, b, k)
        {
            Name = a;
            Birthday = b;
            WorkRecs = k;
            Counter = n;
        }
    }

    public class Support : Workers
    {
        public string[][] documents;

        public Support(string a, int b, string[][] k, string[][] d) : base(a, b, k)
        {
            Name = a;
            Birthday = b;
            WorkRecs = k;
            documents = d;
        }
    }



    public class Class1
    {
        private static Managers[] managers;
        private static Basic[] basics;
        private static Support[] supports;

        public static void Main()
        {
            bool menu_checker = true;
            while (menu_checker)
            {
                menu_checker = Menu();
            }
        }

        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("--ГЛАВНОЕ МЕНЮ--");
            Console.WriteLine("1) Заполнить базу данных");
            Console.WriteLine("2) Просмотреть выборки");
            Console.WriteLine("3) Выход");
            Console.Write("\r\nВыберите действие: ");
            String str = Console.ReadLine();
            string checker;
            switch (str)
            {
                case "1":
                    checker = Category();
                    if (checker == "1")
                    {
                        managers = MCompletion();
                    }
                    else if (checker == "2")
                    {
                        basics = BCompletion();
                    }
                    else if (checker == "3")
                    {
                        supports = SCompletion();
                    }
                    else
                    {
                        Console.Write("Выбрана неверная категoрия");
                    }

                    return true;
                case "2":
                    Output(managers, basics, supports);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        static string Category()
        {
            Console.Clear();
            Console.WriteLine("--ВЫБЕРИТЕ КАТЕГОРИЮ--");
            Console.WriteLine("1) Управленцы");
            Console.WriteLine("2) Основные");
            Console.WriteLine("3) Вспомогательные");
            Console.Write("\r\nВыбор: ");
            string checker = Console.ReadLine();
            return checker;
        }

        static Support[] SCompletion()
        {
            Console.Clear();
            Console.Write("Введите количество работников ");
            int n = Convert.ToInt32(Console.ReadLine());
            Support[] supports = new Support[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите имя ");
                string a = Console.ReadLine();
                Console.Write("Введите год рождения ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write(
                    "Заполнение трудовой книжки:\nВведите количество организаций, в которых работал сотрудник ");
                int q = Convert.ToInt32(Console.ReadLine());
                string[][] works = new string[q][];
                for (int j = 0; j < q; j++)
                {
                    string[] work = new string[4];
                    Console.Write("Введите год поступления в организацию ");
                    int date_receipt = Convert.ToInt32(Console.ReadLine());
                    work[0] = Convert.ToString(date_receipt);
                    Console.Write("Введите наименанование организации ");
                    string organization = Console.ReadLine();
                    work[1] = organization;
                    Console.Write("Введите дату увольнения из огранизации ");
                    int date_dismissal = Convert.ToInt32(Console.ReadLine());
                    work[2] = Convert.ToString(date_dismissal);
                    int experience = date_dismissal - date_receipt;
                    work[3] = Convert.ToString(experience);
                    works[j] = work;
                }

                Console.Write("Введите количество работ выполненных сотрудником: ");
                int x = Convert.ToInt32(Console.ReadLine());
                string[][] docs = new string[x][];
                for (int r = 0; r < x; r++)
                {
                    string[] doc = new string [2];
                    Console.Write("Введите наименование выполненной рыботы");
                    string l = Console.ReadLine();
                    doc[0] = l;
                    Console.Write("Введите дату выполнения работы");
                    string g = Console.ReadLine();
                    doc[1] = g;
                }

                Support support = new Support(a, b, works, docs);
                supports[i] = support;
                Console.Clear();
            }

            return supports;
        }

        static Basic[] BCompletion()
        {
            Console.Clear();
            Console.Write("Введите количество работников ");
            int n = Convert.ToInt32(Console.ReadLine());
            Basic[] basics = new Basic[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите имя ");
                string a = Console.ReadLine();
                Console.Write("Введите год рождения ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write(
                    "Заполнение трудовой книжки:\nВведите количество организаций, в которых работал сотрудник ");
                int q = Convert.ToInt32(Console.ReadLine());
                string[][] works = new string[q][];
                for (int j = 0; j < q; j++)
                {
                    string[] work = new string[4];
                    Console.Write("Введите год поступления в организацию ");
                    int date_receipt = Convert.ToInt32(Console.ReadLine());
                    work[0] = Convert.ToString(date_receipt);
                    Console.Write("Введите наименанование организации ");
                    string organization = Console.ReadLine();
                    work[1] = organization;
                    Console.Write("Введите дату увольнения из огранизации ");
                    int date_dismissal = Convert.ToInt32(Console.ReadLine());
                    work[2] = Convert.ToString(date_dismissal);
                    int experience = date_dismissal - date_receipt;
                    work[3] = Convert.ToString(experience);
                    works[j] = work;
                }


                Console.Write("Введите экземпляров, отпечатанных в день:");
                int g = Convert.ToInt32(Console.ReadLine());
                Basic basic = new Basic(a, b, works, g);
                basics[i] = basic;
                Console.Clear();
            }

            return basics;
        }

        static Managers[] MCompletion()
        {
            Console.Clear();
            Console.Write("Введите количество работников ");
            int n = Convert.ToInt32(Console.ReadLine());
            Managers[] managers = new Managers[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите имя ");
                string a = Console.ReadLine();
                Console.Write("Введите год рождения ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write(
                    "Заполнение трудовой книжки:\nВведите количество организаций, в которых работал сотрудник ");
                int q = Convert.ToInt32(Console.ReadLine());
                string[][] works = new string[q][];
                for (int j = 0; j < q; j++)
                {
                    string[] work = new string[4];
                    Console.Write("Введите год поступления в организацию ");
                    int date_receipt = Convert.ToInt32(Console.ReadLine());
                    work[0] = Convert.ToString(date_receipt);
                    Console.Write("Введите наименанование организации ");
                    string organization = Console.ReadLine();
                    work[1] = organization;
                    Console.Write("Введите дату увольнения из огранизации ");
                    int date_dismissal = Convert.ToInt32(Console.ReadLine());
                    work[2] = Convert.ToString(date_dismissal);
                    int experience = date_dismissal - date_receipt;
                    work[3] = Convert.ToString(experience);
                    works[j] = work;
                }


                Console.Write("Введите количество приказов, изданных сотрудником:");
                int g = Convert.ToInt32(Console.ReadLine());
                string[][] orders = new string[g][];
                for (int f = 0; f < g; f++)
                {
                    string[] order = new string[2];
                    order[0] = Convert.ToString(f + 1);
                    Console.Write("Введите приказ №" + Convert.ToString(f + 1) + ":");
                    string prikaz = Console.ReadLine();
                    order[1] = prikaz;
                    orders[f] = order;
                }

                Managers manager = new Managers(a, b, works, orders);
                managers[i] = manager;
                Console.Clear();
            }

            return managers;
        }

        static void Output(Managers[] m, Basic[] b, Support[] s)
        {

            if (m != null || b != null || s != null)
            {
                Console.Clear();
                Console.WriteLine("--ВЫБОРКА--");
                Console.WriteLine("1) По общему стажу работы ");
                Console.WriteLine("2) По стажу работы на последнем месте ");
                Console.WriteLine("3) По количеству экземпляров, отпечатанных за диапазон дат ");
                Console.WriteLine("4) Приказы составленные определенным лицом ");
                Console.Write("\rВыберите действие: ");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Clear();
                        int g = 0;
                        Console.Write("Введите требуемый общий стаж раюоты: ");
                        int general_experience = Convert.ToInt32(Console.ReadLine());
                        if (m != null)
                        {
                            foreach (var man in m)
                            {
                                int sum = 0;
                                foreach (var w in man.WorkRecs)
                                {
                                    sum += Convert.ToInt32(w[3]);
                                }

                                if (general_experience == sum)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Управляющий ");
                                }
                                else g += 1;

                            }
                        }

                        if (b != null)
                        {
                            foreach (var man in b)
                            {
                                int sum = 0;
                                foreach (var w in man.WorkRecs)
                                {
                                    sum += Convert.ToInt32(w[3]);
                                }

                                if (general_experience == sum)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Основной ");
                                }
                                else g += 1;
                            }
                        }

                        if (s != null)
                        {
                            foreach (var man in s)
                            {
                                int sum = 0;
                                foreach (var w in man.WorkRecs)
                                {
                                    sum += Convert.ToInt32(w[3]);
                                }

                                if (general_experience == sum)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Основной ");
                                }
                                else g += 1;
                            }
                        }

                        if (g == 3)
                        {
                            Console.WriteLine("Совпадений не найдено");
                        }
                        Console.ReadLine();
                        Menu();
                        break;
                    
                    case "2":
                        int c = 0;
                        Console.Clear();
                        Console.Write("Введите требуемый стаж раюоты на последнем рабочем месте: ");
                        int count_experience = Convert.ToInt32(Console.ReadLine());
                        if (m != null)
                        {
                            foreach (var man in m)
                            {
                                if (Convert.ToInt32(man.WorkRecs[man.WorkRecs.Length - 1][3]) == count_experience)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Основной ");
                                }
                                else c += 1;
                            }
                        }

                        if (b != null)
                        {
                            foreach (var man in b)
                            {
                                if (Convert.ToInt32(man.WorkRecs[man.WorkRecs.Length - 1][3]) == count_experience)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Основной ");
                                }
                                else c += 1;
                            }
                        }

                        if (s != null)
                        {
                            foreach (var man in s)
                            {
                                if (Convert.ToInt32(man.WorkRecs[man.WorkRecs.Length - 1][3]) == count_experience)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Помошь ");
                                }
                                else c += 1;
                            }
                        }

                        if (c == 3)
                        {
                            Console.WriteLine("Совпадений не найдено");
                        }
                        Console.ReadLine();
                        Menu();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Введите требуемое количество экземпляров: ");
                        int e = Convert.ToInt32(Console.ReadLine());
                        if (b != null)
                        {
                            foreach (var man in b)
                            {
                                if (e == man.Counter)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Основной ");
                                }
                                else
                                {
                                    Console.WriteLine("Совпадений не найдено");
                                }
                            }
                        }

                        Console.ReadLine();
                        Menu();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        if (m != null)
                        {
                            foreach (var man in m)
                            {


                                if (name == man.Name)
                                {
                                    Console.Clear();
                                    Console.Write(
                                        $"ФИО: {man.Name} \nДата рождения: {man.Birthday} \nКласс работника: Управляющий\nПриказы: ");
                                    for (int k = 0; k < man.orders.Length; k++)
                                    {
                                        Console.WriteLine("№" + Convert.ToString(k + 1) + " " + man.orders[k][1]);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Совпадений не найдено");
                                }

                            }
                        }

                        Console.ReadLine();
                        Menu();
                        break;
                    default:
                        Menu();
                        break;
                        
                }
            }
            else
            {
                Console.Write("База данных пуста");
                Console.ReadLine();
            }
        }
    }
}