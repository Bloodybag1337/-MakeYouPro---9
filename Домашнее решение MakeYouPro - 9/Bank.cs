using System;

/*
Задание:
Вы участвуете в разработке банковской системы.
Создайте библиотеку, содержащую в себе следующие методы:

1 - Метод проверки клиента для спецпредложений:
Банк хронит о клиентах следующую информацию:
- Имя;
- Возраст; 
- Количество банковских продуктов;
- Сумма средств.
Банк предоставляет акционные предложения клиентам старше 60 лет,
клиентам с суммой средств более миллиона и клиентам с суммой средств более 400тыс.,
использующим минимум 3 банковских продукта.
Метод получает на вход необходимую информацию о клиенте и возвращает информацию о том,
доступны ли ему акционные предложения.

2 - Метод, рассчитывающий размер банковского вклада по истечении его срока:
Метод получает на вход 3 числа (изначальная сумма, продолжительность в годах, %, начисляемый за год)
и возвращает размер накоплений по истечении срока вклада.
Обратите внимание, проценты по вкладу начисляются раз в год на всю сумму.
Например, при вкладе 1000 под 10% по итогам первого года итоговый размер будет составлять 1100,
а по итогам второго - уже 1210.

3 - Метод подсчёта купюр банкоматом:
Банкомат содержит в себе купюры номиналом в 1000, 500 и 100 рублей.
Метож получает на вход число - запрашиваемую у банкомата сумму и возвращает число
- оптимальное количество банкнот.
Оптимальным является вариант с наименьшим числом банкнот. 
Например, при запросе в 2800 рублей оптимальным будет выдать 2 купюры по 1000,
1 по 500 и 3 по 100, соответственно, метод вернёт число 6.
*/

namespace HomeWork
{
	public static class Bank
	{
		public static void PromotionalsAvailability()
		{
			Console.WriteLine("Введите Ваше имя:");
			string name = Console.ReadLine();

            Console.WriteLine("Напишите Ваш возраст:");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Укажите количество используемых банковских продуктов:");
			int productsUsed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите сумму Ваших средств:");
			int moneySum = Convert.ToInt32(Console.ReadLine());

			if (age > 60 || moneySum > 1000000 || moneySum > 400000 && productsUsed >= 3)
				Console.WriteLine($"{name}, Вам доступны акционные предложенмя!\n");
			else
				Console.WriteLine($"{name}, Вам не доступны акционные предложенмя\n");
        }

        public static void FindOutDepositAmount()
		{
            Console.WriteLine("Введите изначальную сумму для вклада:");
            double moneyAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажите продолжительность в годах:");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите процент, начисляемый за год:");
            double percent = Convert.ToDouble(Console.ReadLine()) / 100;

            for (int i = 1; i <= years; i++)
            {
                double newValue = moneyAmount + years * percent;
                Console.WriteLine($"{newValue}");
                moneyAmount = newValue;
            }
            Console.WriteLine("\n");
        }

        public static void CashOut()
        {
            Console.WriteLine("Какую сумму денег Вы хотите снять?");
            int cashOutMoney = Convert.ToInt32(Console.ReadLine());
            int billsNumber;
            while (cashOutMoney >= 100)
            {
                if (cashOutMoney >= 1000)
                {
                    billsNumber = cashOutMoney / 1000;
                    cashOutMoney -= billsNumber * 1000;
                    Console.WriteLine($"Выдать {billsNumber} по 1000");
                }
                else if (cashOutMoney >= 500)
                {
                    billsNumber = cashOutMoney / 500;
                    cashOutMoney -= billsNumber * 500;
                    Console.WriteLine($"Выдать {billsNumber} по 500");
                }
                else
                {
                    billsNumber = cashOutMoney / 100;
                    cashOutMoney -= billsNumber * 100;
                    Console.WriteLine($"Выдать {billsNumber} по 100");
                }
            }
            Console.ReadKey();
        }
    }
}