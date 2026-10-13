
        Random random = new Random();
        string playAgain;

        do
        {
            int secretNumber = random.Next(1, 101);
            int maxAttempts = 7;
            bool guessed = false;

            Console.WriteLine($"Я загадал число от 1 до 100. У вас {maxAttempts} попыток.");

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Попытка №{attempt}. Ваша догадка: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempt} попыток!");
                    guessed = true;
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }

            if (!guessed)
            {
                Console.WriteLine($"Вы проиграли! Было загадано число {secretNumber}.");
            }

            Console.Write("Хотите сыграть еще раз? (да/нет): ");
            playAgain = Console.ReadLine();

        } while (playAgain == "да" || playAgain == "yes");

        Console.WriteLine("Нажмите Enter для завершения...");
        Console.ReadLine();