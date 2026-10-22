// Starting balance
decimal balance = 1000m;
bool running = true;

// Main menu
while (running)
{
    Console.WriteLine("\n=== BANK ACCOUNT ===");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
    Console.Write("Choose: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Display balance
            Console.WriteLine($"Balance: ${balance}");
            break;

        case "2":
            // Deposit money
            Console.Write("Amount: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal deposit) && deposit > 0)
            {
                balance += deposit;
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Invalid amount."); 
            }
            break;
        
        case "3":
            // Withdraw Money
            Console.Write("Amount: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal withdraw) && withdraw > 0 && withdraw <= balance)
            {
                balance -= withdraw;
                Console.WriteLine("Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient funds.");
            }
            break;

        case "4":
            // Exit program
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option. ");
            break;



    }
}