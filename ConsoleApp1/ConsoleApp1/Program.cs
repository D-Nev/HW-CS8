namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //1
        static long Range(int start, int end)
        {
            long num = 1;
            for (int i = start; i <= end; i++)
                num *= i;
            return num;
        }


        //2
        static bool Fibonachi(int num)
        {
            int a = 0, b = 1;
            while (b < num)
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b == num;
        }

        //3
        static void Sort(int[] arr, bool b)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((b && arr[i] > arr[j]) || (!b && arr[i] < arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }


        //4
        class City
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Populate { get; set; }
            public string ConePhone { get; set; }
            public string[] Distr { get; set; }

            public City(string name, string country, int population, string codephone, string[] distr)
            {
                Name = name;
                Country = country;
                Populate = population;
                ConePhone = codephone;
                Distr = distr;
            }

            public void VivodCity()
            {
                Console.WriteLine($"Город: {Name}, Страна: {Country}, Население: {Populate}, Код: {ConePhone}, Районы: {string.Join(", ", Distr)}");
            }
        }

        //5
        class Sotrudnik
        {
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Dolshnost { get; set; }
            public string Obazonost { get; set; }

            public Sotrudnik(string name, DateTime birthday, string phone, string email, string dolshnost, string obazonost)
            {
                Name = name;
                Birthday = birthday;
                Phone = phone;
                Email = email;
                this.Dolshnost = dolshnost;
                this.Obazonost = obazonost;
            }

            public void VivodSotrudnik()
            {
                Console.WriteLine($"ФИО: {Name}, Дата рождения: {Birthday.ToShortDateString()}, Телефон: {Phone}, Емейл: {Email}, Должность: {Dolshnost}, Обязанности: {Obazonost}");
            }
        }

        //6
        class Airplane
        {
            public string Name { get; set; }
            public string Proizvoditel { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }

            public Airplane(string name, string proizvoditel, int year, string type)
            {
                Name = name;
                Proizvoditel = proizvoditel;
                Year = year;
                Type = type;
            }

            public void VivodAirplane()
            {
                Console.WriteLine($"Название: {Name}, Производитель: {Proizvoditel}, Год выпуска: {Year}, Тип: {Type}");
            }
        }
    }
}
