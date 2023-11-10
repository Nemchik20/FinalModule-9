namespace Program
{
    class Program
    { 
        public static void Main(string[] args)
        {
            string[] LastNames = new string[]
            {
                "а - Сидоренко", // используем для нагрлядности алфавит, не мог придумать фамилии )
                "б - Сидорчук",
                "в - Иванов",
                "г - Человеков",
                "д - Тут должна быть файша фамилия))"
            };
            Sort st = new Sort();
            st.SortEvent += PrintsNames;
            while (true) // главный метод)
            {
                try
                {
                    st.Read(LastNames); 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не корректные данные");
                }
            }
        }

        public static void PrintsNames (string[] names) // Вывод имен в консоль
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    class Sort
    {
        public delegate void SortDelegate(string[] names);
        public event SortDelegate SortEvent;

        public void Read(string[] names) // чтение с консоли
        {
            Console.WriteLine("Введите число 1 или 2 для выбора сортировки");
            byte i = byte.Parse(Console.ReadLine());
            if (i != 1 && i != 2) throw new FormatException(); // Выброс исключене 
            SortLastNames(names, i); // вызов сортировки
        }
        public void SortLastNames(string[] lastNames, byte i) // тут сортировка и сообщение что произощло событие
        {
            switch(i)
            {
                case 1:
                    Array.Sort(lastNames);
                    SortEvent.Invoke(lastNames);
                    break;
                case 2:
                    Array.Sort(lastNames, (x, y) => string.Compare(y, x));
                    SortEvent.Invoke(lastNames);
                    break;
            }
        }
    }
}