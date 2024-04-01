using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApp
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Weapon weapon = new Weapon(10, 5, false);
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------Welcome my App-----------");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("0.Informasiya almaq ucun!");
                Console.WriteLine("1.Shoot metodu ucun!");
                Console.WriteLine("2.fire metodu ucun!");
                Console.WriteLine("3.GetRemainBulletCount metodu ucun!");
                Console.WriteLine("4.Reload metodu ucun!");
                Console.WriteLine("5.ChangeFire metodu ucun!");
                Console.WriteLine("6.Exit App....");
                Console.WriteLine("7.Edit!");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Gulle tutumu: "+ weapon.BulletCapacity) ;
                        Console.WriteLine("Gulle sayi:"+weapon.BulletCount);
                        Console.Write("Gulle modu: ");
                        if (!weapon.ShootingMode)
                        {
                            Console.WriteLine("Avtomatik");
                        }
                        else
                        {
                            Console.WriteLine("Tekli");
                        }
                        break;
                    case "1":
                       if(weapon.BulletCount >0) {
                            weapon.Shoot();
                        }
                        else
                        {
                            Console.WriteLine("Silahda gulle yoxdur");
                        }
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program...");
                        flag = true;
                        break;
                    case "7":
                        Console.WriteLine("8.Tutumu deyissin!");
                        Console.WriteLine("9.Gulle sayi deyissin") ;
                        Console.WriteLine() ;
                        Console.WriteLine("Seciminizi edin: ");
                        string s=Console.ReadLine();
                        switch (s)
                        {
                            case "8":
                                int capacity;
                                do
                                {
                                    Console.Write("New capacity: ");
                                }
                                while (!int.TryParse(Console.ReadLine(), out capacity) ) ;
                                weapon.BulletCapacity= capacity ;
                                Console.WriteLine("tutum deyisdirildi!");
                                break;
                            case "9":
                                int count;
                                do
                                {
                                    Console.Write("New bullet count: ");
                                }
                                while (!int.TryParse(Console.ReadLine(), out count) || weapon.BulletCapacity<count);
                                weapon.BulletCapacity = count;
                                Console.WriteLine("Gulle sayi deyisdirildi!");
                                break;
                            default:
                                Console.WriteLine("Duzgun secim etmediniz!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("This is not correct! Please, enter correct choice!");
                        break;
                }
            }
            while (!flag);

            
    }
    }
}

