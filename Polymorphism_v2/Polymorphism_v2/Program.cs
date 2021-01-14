using System;

namespace Polymorphism_v2
{
    class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен на склад!");
        }
    }
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        // Цена товара со скидкой
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
                return Price;

            if (user.Spent < 1000)
                return Price * 0.9;

            return Price * 0.8;
        }
    }

    class Dolls : Product
    {
        // Уникальное свойство
        public string Material { get; private set; }
        // Конструктор
        public Dolls(string name, int price, string manufacturer, string material)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Material = material;
        }
    }

    class Aphrodisiacs : Product
    {

        // Уникальное свойство
        public string Composition { get; set; }
        // Конструктор
        public Aphrodisiacs(string name, int price, string manufacturer, string composition)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Composition = composition;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }
    }

    class Condoms : Product
    {
        // Уникальное свойство
        public int Size { get; set; }
        // Конструктор
        public Condoms(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
    }
    class User
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public User(string name, string address, int balance, int spent)
        {
            Name = name;
            Address = address;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)
        {
            // Уменьшение баланса
            Balance -= price;
            // Увеличивание потраченных средств
            Spent += price;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                   "Artem",
                   "ул. Большая красная 18",
                   10000,
                   550
            );

            Console.WriteLine("Список товаров");

            Dolls gusDolls = new Dolls(
                "Гусь",
                200,
                "Гусыня",
                "Резина"
                );
            Console.WriteLine("Кукла:");
            Console.WriteLine("Название: " + gusDolls.Name);
            Console.WriteLine("Цена: " + gusDolls.Price);
            Console.WriteLine("Производитель:" + gusDolls.Manufacturer);
            Console.WriteLine("Материал:" + gusDolls.Material);
            Console.WriteLine(new String('-', 25));


            Condoms DirtyJoes = new Condoms(
                "Грязный Джо",
                400,
                "Хэнд мейд",
                25
                );
            Console.WriteLine("Контрацептив:");
            Console.WriteLine("Название: " + DirtyJoes.Name);
            Console.WriteLine("Цена: " + DirtyJoes.Price);
            Console.WriteLine("Производитель:" + DirtyJoes.Manufacturer);
            Console.WriteLine("Размер:" + DirtyJoes.Size);
            Console.WriteLine(new String('-', 25));



            Aphrodisiacs HorseAphro = new Aphrodisiacs(
                "Конский возбужд",
                500,
                "Дядя Вася",
                "Любовь + жидкость"
                );
            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + HorseAphro.Name);
            Console.WriteLine("Цена: " + HorseAphro.Price);
            Console.WriteLine("Производитель:" + HorseAphro.Manufacturer);
            Console.WriteLine("Состав:" + HorseAphro.Composition);
            Console.WriteLine(new String('-', 25));


            Aphrodisiacs WomanAphro = new Aphrodisiacs(
                "Женский возбужд",
                1500,
                "Тетя Катя",
                "Жесткость + жидкость"
                );
            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + WomanAphro.Name);
            Console.WriteLine("Цена: " + WomanAphro.Price);
            Console.WriteLine("Производитель:" + WomanAphro.Manufacturer);
            Console.WriteLine("Состав:" + WomanAphro.Composition);
            Console.WriteLine(new String('-', 25));



            // Upcast, создаем массив типо продукт и вносим во внутрь дочерние элементы
            Product[] products = new Product[]
            {
                gusDolls,
                DirtyJoes,
                HorseAphro,
                WomanAphro
            };


            Informer info = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"\n\n{user.Name} ваш баланс {user.Balance}");

                // Вывод товаров из массива
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }


                Console.WriteLine("\n\nВыберите номер товара и нажмите Enter");
                int productNumber = Convert.ToInt32(Console.ReadLine());


                if (productNumber >= 0 && productNumber < products.Length)
                {
                    // Проверка доступности баланса
                    if (products[productNumber].Price < user.Balance)
                        info.Buy(user, products[productNumber]);
                    
                    else
                        Console.WriteLine("\n\nУ вас недостаточно средств");
                }
                else
                    Console.WriteLine("\n\nТаких товаров нету");

            }
        }
    }
}
