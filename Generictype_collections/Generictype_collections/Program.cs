using Generictype_collections.Interfaces;
using Generictype_collections.Models;

namespace Generictype_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            List<Account> accounts = new List<Account>();
            

            string input;
            do
            {
                Console.WriteLine("=============== Xoş gelmisiniz! =================");
                Console.WriteLine("1.Yeni hesab yarat");
                Console.WriteLine("2.Pul yatır");
                Console.WriteLine("3.Pul çıxart");
                Console.WriteLine("4.Bütün hesabların siyahısı");
                Console.WriteLine("5.Hesablar arası pul köçürmə");
                Console.WriteLine("0.Çıxış");          
                Console.WriteLine("===============================");

                Console.WriteLine("Emeliyyat secin.");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Account newaccount = bank.CreateAccount();
                        Console.WriteLine($"hesab yaradildi.");
                        Console.WriteLine(newaccount.ToString()); 
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("hesabin Id-ni daxil edin: ");
                        if (int.TryParse(Console.ReadLine(),out int depositId))
                        {

                            Console.WriteLine("yatirmaq istediyiniz meblegi daxil edin: ");
                            if (decimal.TryParse(Console.ReadLine(),out decimal depositamount))
                            {
                                try
                                {
                                    bank.DepositMoney(depositId, depositamount);
                                    Console.WriteLine($"pul hesaba yatirildi."); break;

                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("meblegi duzgun daxil eddilmiyib.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Id duzgun daxil edilmiyib.");
                        }
                        break;
                    case "3":
                        Console.Clear();

                        Console.WriteLine("hesabin Id-ni daxil edin: ");
                        if (int.TryParse(Console.ReadLine(), out int drawId))
                        {
                            Console.WriteLine("cixarmaq istediyiniz meblegi daxil edin: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal drawamount))
                            {
                                try
                                {
                                    bank.WithDrawMoney(drawId, drawamount);
                                    Console.WriteLine($"pul hesabdan cixarildi.");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("meblegi duzgun daxil edilmiyib.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id duzgun daxil edilmiyib.");
                        }
                        break;
                    case "4":
                        Console.Clear();

                        List<Account> allAccounts = bank.GetAllAccounts();
                      
                        Console.WriteLine("Bütün hesabların siyahısı:");
                        foreach (var account in allAccounts)
                        {
                            Console.WriteLine($"Hesab nömresi: {account.AccountId}, Balans {account.Balance}");
                        }
                        Console.WriteLine("____________________________");

                        break;
                    case "5":
                        Console.Clear();

                        Console.Write("Gonderen hesab id: " );
                        if (int.TryParse(Console.ReadLine(),out int fromaccountid))
                        {
                            
                            Console.Write("Qebul eden hesab id: ");
                            if (int.TryParse(Console.ReadLine(), out int toaccountid))
                            {
                                Console.Write("Kocurulecek mebleg: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal transferamount))
                                {                    
                                try
                                {
                                    bank.TransferMoney(fromaccountid, toaccountid, transferamount);
                                    Console.WriteLine("Mebleg kocuruldu");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"{e.Message}");
                                }
                                }
                                else
                                {
                                    Console.WriteLine("mebleg duzgun daxil edilmiiyib.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Id duzgun daxil edilmiyib.");
                            }
                           
                           
                        }
                        else
                        {
                            Console.WriteLine("Id duzgun daxil edilmeyib.");
                        }
                       
                        
                        break;
                    case "0":
                        Console.WriteLine("EXIT");
                        break;
                    default: 
                        Console.Clear() ;
                       Console.WriteLine("yanlis deyer");
                        break;
                }

            } while (input != "5");
        }
    }
}