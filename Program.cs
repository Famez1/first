namespace Coffie_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min_int = -2147483647;
            int max_int =  2147483647;
            Console.WriteLine("Максимальное значение int:" + max_int); 
            Console.WriteLine("Минимальное значение int:" + min_int);
            Console.WriteLine("Минимальное значение long:"+long.MinValue);
            Console.WriteLine("Максимальное значение long:"+long.MaxValue);
            Console.WriteLine("Минимальное значение float:"+float.MinValue);
            Console.WriteLine("Максимальное значение float:"+float.MaxValue);
            Console.WriteLine("Минимальное значение double:"+double.MinValue);
            Console.WriteLine("Максимальное значение double:"+double.MaxValue);
            Console.WriteLine("Минимальное значение byte:"+byte.MinValue);
            Console.WriteLine("Максимальное значение byte:"+byte.MaxValue);
            Console.WriteLine("Значение boll: 'True, False'");
            char char_a = '1';
            char char_b = 'z';
            Console.WriteLine("Значение char От"+char_a);
            Console.WriteLine("До"+char_b);
            string string_a = "Это стринговая переменная";
            Console.WriteLine("Значение string"+string_a);


            int[] nums = new int[5] {1,2,3,4,5};
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            object[] nums2 = new object[2] { 1, "тоже обджект" };
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }

            
            
            
            
            
            //ZADANIE 2
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

            Console.WriteLine(result);



            //ZADANIE 3
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            for (int i = num3; i < num4; i++)
            {
                Console.WriteLine(i);
            }



            //ZADANIE 5
            Console.WriteLine("Придумайте пароль");
            var pass = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите пароль");
            var proverka = Convert.ToString(Console.ReadLine());
            if (pass == proverka)
            {
                Console.WriteLine("Пароль верный");
            }
            else
            {
                do
                {
                    Console.WriteLine("Не верный пароль, попробуйте снова");
                    proverka = Console.ReadLine();
                } while (proverka != pass);

                Console.WriteLine("Добро пожаловать");
                Console.ReadKey();

                //ZADANIE 4
                List<string> bascket = new List<string>();
                while (true)
                {
                    Console.WriteLine("1 - добавить продукт, 2 - содержимое, 3 - выйти");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Название продукта");
                            string product = Console.ReadLine();
                            bascket.Add(product);
                            Console.WriteLine("Продукт добавлен");
                            break;
                        case 2:
                            Console.WriteLine("Содержимое корзины:");
                            foreach (var item in bascket)
                            {
                                Console.Write($"{item}");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Спасибо за покупку");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверный вариант, выберите существующий");
                            break;
                    }

                }
                
                //ZADANIE 1
                
               





            }
        }
    }
}

