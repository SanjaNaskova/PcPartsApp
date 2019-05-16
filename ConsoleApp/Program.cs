using Entities.Classes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        #region parts, modules, configs
        public static void PopulateDb()
        {
            Db.Parts = new List<Part>()
            {
                new Part(1, 380, 1, 0.10, "AMD Ryzen 5 2600", PartType.Cpu, "AMD", true),
                new Part(2, 660, 1, 0.10, "AMD Ryzen 7 2700X", PartType.Cpu, "AMD", true),
                new Part(3, 720, 1, 0, "Intel Core i7-8700K", PartType.Cpu, "Intel", true),
                new Part(4, 420, 1, 0, "Intel Core i5-9400F", PartType.Cpu, "Intel", true),
                new Part(5, 20, 1, 0, "Corsair H60", PartType.CpuCooler, "Corsair", false),
                new Part(6, 30, 1, 0, "Noctua NH-D15", PartType.CpuCooler, "Noctua", false),
                new Part(7, 40, 1, 0.15, "NZXT Kraken X72", PartType.CpuCooler, "NZXT", true),
                new Part(8, 35, 1, 0, "CRYORIG H7", PartType.CpuCooler, "CRYORIG", false),
                new Part(9, 600, 1, 0, "MSI RX 580 ARMOR", PartType.Gpu, "MSI", false),
                new Part(10, 720, 1, 0, "Asus ROG-STRIX", PartType.Gpu, "Asus", true),
                new Part(45, 1500, 2, 0, "Asus ROG-STRIX(dual chanel)", PartType.Gpu, "Asus", true),
                new Part(11, 370, 1, 0.20, "Zotac ZT", PartType.Gpu, "Zotac", false),
                new Part(12, 440, 1, 0, "Gigabyte GV", PartType.Gpu, "Gigabyte", true),
                new Part(13, 55, 1, 0, "ARCTIC Accelero", PartType.GpuCooler, "ARCTIC", false),
                new Part(14, 80, 1, 0, "Kraken G12", PartType.GpuCooler, "NZXT", true),
                new Part(15, 40, 1, 0, "Deepcool TESSERACT", PartType.Case, "Deepcool", false),
                new Part(16, 90, 1, 0, "Cooler Master MasterBox", PartType.Case, "Cooler Master", false),
                new Part(18, 75, 1, 0, "Corsair 200R", PartType.Case, "Corsair", false),
                new Part(19, 110, 1, 0.10, "EVGA SuperNOVA", PartType.PowerSuply, "EVGA", false),
                new Part(20, 140, 1, 0, "Corsair CX450", PartType.PowerSuply, "Corsair", false),
                new Part(21, 160, 1, 0, "SeaSonic FOCUS", PartType.PowerSuply, "SeaSonic", true),
                new Part(22, 200, 1, 0, "MSI B450 TOMAHAWK", PartType.MotherBoard, "MSI", true),
                new Part(23, 230, 1, 0.25, "ASRock B450 Pro4", PartType.MotherBoard, "ASRock", true),
                new Part(24, 340, 1, 0, "Asus Prime X470-Pro", PartType.MotherBoard, "Asus", true),
                new Part(25, 10, 1, 0, "Standard Power Cable", PartType.PowerCable, "MSI", false),
                new Part(26, 60, 1, 0, "Samsung MZ", PartType.SSD, "Samsung", true),
                new Part(27, 70, 1, 0.40, "Seagate MZ", PartType.SSD, "Seagate", false),
                new Part(28, 65, 1, 0, "Western Digital MZ", PartType.SSD, "Western Digital", true),
                new Part(29, 65, 1, 0, "Seagate ST", PartType.HDD, "Seagate", false),
                new Part(30, 80, 1, 0, "Samsung ST", PartType.HDD, "Samsung", true),
                new Part(31, 60, 1, 0, "Corsair Vengeance", PartType.RAM, "AMD", true),
                new Part(32, 70, 1, 0, "Kingston FURY", PartType.RAM, "Kingston", true),
                new Part(33, 140, 2, 0, "Kingston FURY(dual chanel)", PartType.RAM, "Kingston", true),
                new Part(34, 330, 1, 0.10, "HP OMEN X", PartType.Monitor, "HP", true),
                new Part(35, 200, 1, 0, "MSI Optix", PartType.Monitor, "MSI", true),
                new Part(37, 380, 2, 0, "MSI Optix(double)", PartType.Monitor, "MSI", true),
                new Part(39, 8, 1, 0, "Logitech M510", PartType.Mouse, "Logitech", false),
                new Part(42, 20, 1, 0, "VicTsing MM057", PartType.Mouse, "VicTsing", false),
                new Part(43, 10, 1, 0, "Logitech G213", PartType.Keyboard, "Logitech", false),
                new Part(44, 30, 1, 0.29, "Redragon K502", PartType.Keyboard, "Redragon", false)
            };

            Db.Modules = new List<Module>()
            {
                new Module(50, 700, 0.10, ModuleType.Graphics, new List<Part>()
                {
                    Db.Parts[8], // index number vo listata/ demek modul type graphic, i sea ima lista od parts so imaat graphic
                    Db.Parts[13]
                }),
                new Module(51, 820, 0, ModuleType.Graphics, new List<Part>()
                {
                    Db.Parts[9],
                    Db.Parts[14]
                }),
                new Module(52, 100, 0.20, ModuleType.Casing, new List<Part>()
                {
                    Db.Parts[15],
                    Db.Parts[20]
                }),
                new Module(53, 140, 0.15, ModuleType.Casing, new List<Part>()
                {
                    Db.Parts[16],
                    Db.Parts[19]
                }),
                new Module(54, 750, 0.10, ModuleType.Processing, new List<Part>()
                {
                    Db.Parts[1],
                    Db.Parts[5]
                }),
                new Module(55, 840, 0, ModuleType.Processing, new List<Part>()
                {
                    Db.Parts[2],
                    Db.Parts[4]
                   
                }),
                new Module(56, 340, 280, ModuleType.Memory, new List<Part>()
                {
                    Db.Parts[25],
                    Db.Parts[28],
                    Db.Parts[30]
                }),
                new Module(57, 250, 320, ModuleType.Memory, new List<Part>()
                {
                    Db.Parts[27],
                    Db.Parts[32]
                }),
                new Module(58, 260, 0, ModuleType.MainBoard, new List<Part>()
                {
                    Db.Parts[22],
                    Db.Parts[24],
                    Db.Parts[24],
                    Db.Parts[24]
                }),
                new Module(59, 350, 0, ModuleType.MainBoard, new List<Part>()
                {
                    Db.Parts[23],
                    Db.Parts[24],
                    Db.Parts[24]
                }),
                new Module(60, 300, 0, ModuleType.Other, new List<Part>()
                {
                    Db.Parts[34],
                    Db.Parts[36],
                    Db.Parts[38]
                }),
                new Module(61, 460, 0, ModuleType.Other, new List<Part>()
                {
                    Db.Parts[37],
                    Db.Parts[39]
                })
            };


            Db.Configurations = new List<Configuration>()
            {
                new Configuration(80, 1000, 0.10, "Office Deluxe", ConfigurationType.Office, new List<Module>()
                {
                    Db.Modules[1],
                    Db.Modules[3],
                    Db.Modules[5],
                    Db.Modules[7],
                    Db.Modules[9],
                    Db.Modules[11]
                }),
                new Configuration(81, 800, 0.10, "Office Basic", ConfigurationType.Office, new List<Module>()
                {
                    Db.Modules[1],
                    Db.Modules[2],
                    Db.Modules[3],
                    Db.Modules[4],
                    Db.Modules[5],
                    Db.Modules[6]
                }),
                new Configuration(82, 1300, 0.10, "Personal 2000", ConfigurationType.Standard, new List<Module>()
                {
                    Db.Modules[4],
                    Db.Modules[2],
                    Db.Modules[1],
                    Db.Modules[8],
                    Db.Modules[11],
                    Db.Modules[7]
                }),
                new Configuration(83, 1800, 0.10, "Gamer Extreme", ConfigurationType.Gaming, new List<Module>()
                {
                    Db.Modules[2],
                    Db.Modules[4],
                    Db.Modules[6],
                    Db.Modules[8],
                    Db.Modules[10],
                    Db.Modules[11]
                })
            };
        }
        #endregion
        // EXCEPTIONS
        public class InvalidNumberException : Exception
        {
            public int NumInput { get; set; }
            
            // konstruktor mi treba samo ako sakam da go vidam inputot {} vo greskata so ke ja frli
            public InvalidNumberException(int numInput)
            {
                NumInput = numInput;
            }

            public void PrintError()
            {
                Console.WriteLine($"Your input {NumInput} is not a valid choice.");
                Console.WriteLine("Please choose one of the numbers given for option.");
                Console.WriteLine("Extra information: ");
                Console.WriteLine($"Source: {base.Source}");
                Console.WriteLine($"Target: {base.TargetSite}");
                Console.WriteLine($"Trace: {base.StackTrace}");              
            }

        }

    static void Main(string[] args)
        {
            PopulateDb();

            //SENDING RECEIPT VIA..
           
            void SendReceiptViaSMS()
            {
                Console.WriteLine("Your receipt was sent via SMS.");
            }

            void SendReceiptViaMail()
            {
                Console.WriteLine("Your receipt was sent via email.");
            }

            void SendReceiptViaPost()
            {
                Console.WriteLine("Your receipt will be sent via post");
            }

            var receiptVia = new Reciept();
            //ovie se kako counter, za da se zacuvaat poslednite filtriranja
            int partsCounter = 0; 
            int modulesCounter = 0;
            int configurationsCounter = 0;

            double totalPriceToPay = 0;
            int choice = 0;

            List<Part> outputParts = new List<Part>(); // prazna lista za da se zacuvaat filtriranite podatoci
            List<Module> outputModules = new List<Module>();
            List<Configuration> outputConfiguration = new List<Configuration>();

            List<Item> shoppingCart = new List<Item>();

            
            //1
          void welcomeFunction()
            {
                Console.WriteLine("Welcome to our store. Please enter the number of the product you want to see: ");
                Console.WriteLine("1) for PARTS");
                Console.WriteLine("2) for MODULES");
                Console.WriteLine("3) for CONFIGURATIONS");

                if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= 3)
                {
                    printOptions();

                }
                else
                {     //bez ovoj error nema da funkcionira try/catch
                    throw new InvalidNumberException(choice);
                }
            }

            void continueShopping()
            {
                Console.WriteLine("Please choose: ");
                Console.WriteLine("1) Continue shopping from the same list");
                Console.WriteLine("2) Choose soomething else");
                Console.WriteLine("3) See cart");
                Console.WriteLine("4) Continue to check out");

                int.TryParse(Console.ReadLine(), out int choiceInput);
                if (choiceInput == 1) // continue shopping
                {
                    if (choice == 1)
                    {
                        printParts(outputParts);

                    }
                    else if (choice == 2)
                    {
                        printModules(outputModules);
                    }
                    else if (choice == 3)
                    {
                        printConfigurations(outputConfiguration);
                    }
                }
                else if (choiceInput == 2) //choose something else
                {
                    welcomeFunction();
                }
                else if (choiceInput == 3) //see cart
                {
                    seeItemsInShoppingCart();

                    Console.WriteLine("Do you want to continue shopping? Y/N");
                    char answer = Console.ReadKey().KeyChar;


                    if (answer == 'y' || answer == 'Y')
                    {
                        Console.ReadLine();
                        continueShopping();
                    }
                    else if (answer == 'n' || answer == 'N')
                    {
                        Console.ReadLine();
                        printReceipt();

                    }
                    else
                    {
                        throw new InvalidNumberException(answer);
                    }
                                       
                }
                else if (choiceInput == 4) //check out
                {
                    printReceipt();

                    for (int i = 0; i < shoppingCart.Count; i++)
                    {
                        
                    }
                }
            }

            //

            while (true)
            {           
            try
            {    //povikuvam kod kade sto moze da pukne greska
                welcomeFunction();
                    
            }
            catch (InvalidNumberException ex)
            { //a tuka ja hendlam
                ex.PrintError();
                Console.ReadKey();
                Console.Clear();
                    // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;


                    if (answer == 'y' || answer == 'Y')
                    {
                        welcomeFunction();
                    }
                    else
                    {
                        break;
                    }

                }
                catch(NumberExeption2 ex)
                {
                    // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    ex.PrintError2();
                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;

                    if (answer == 'y' || answer == 'Y')
                    {
                        printReceipt();
                    }
                    else
                    {
                        break;
                    }

                }
                catch (PriceExeption ex)
                { // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    ex.PrintPriceExeption();
                   
                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;

                    if (answer == 'y' || answer == 'Y')
                    {
                        printOptions();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (IdExeption ex)
                { // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    ex.PrintIdExeption();

                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;

                    if (answer == 'y' || answer == 'Y')
                    {
                        printOptions();
                    }
                    else
                    {
                        break;
                    }

                }
                catch (StringException ex)
                {
                    // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    ex.PrintStringException();
                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;

                    if (answer == 'y' || answer == 'Y')
                    {
                        printOptions();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                { // AKO PO VTOR PAT UTNE NE JA HENDLA GRESKATA??
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Do you want to try again? y/n");
                    char answer = Console.ReadKey().KeyChar;

                    if (answer == 'y' || answer == 'Y')
                    {

                    }
                    else
                    {
                        break;
                    }
                }              
            }
         
            //2

            void printOptions() //ova mi e za prethodno so ke odbere od welcome f-ja =>  numInput = choice
            {
                Console.WriteLine("Please enter the number for filtering the products: ");
                Console.WriteLine("1) for ALL PRODUCTS");
                Console.WriteLine("2) for BY PRICE ");
                Console.WriteLine("3) for TYPE");

                if (int.TryParse(Console.ReadLine(), out int numInput) && numInput > 0 && numInput < 4)
                {
                    switch (numInput)
                    {
                        //case 1 deka odbral 1 all pruducts
                        case 1: //1) for ALL PRODUCTS"
                            if (choice == 1)// // i ova za prethodno sto odbral prviot choice (dali saka da gleda parts, modules ili conf)
                            {
                                printParts(Db.Parts); //ako prethodno odbral parts tuka gi printa parts
                            }
                            else if (choice == 2)
                            {
                                printModules(Db.Modules); //ako prethodno odbral modules tuka gi printa modules
                            }
                            else if (choice == 3)
                            {
                                printConfigurations(Db.Configurations);
                            }
                            break;

                        case 2: //ByPrice - ( requires min and max price and returns product between those numbers )

                            Console.WriteLine("Please enter the minimum price");
                            if (double.TryParse(Console.ReadLine(), out double minPrice)) ;
                            else throw new Exception();

                            if (choice == 1)
                            {
                                if (minPrice < 8) throw new PriceExeption(minPrice);
                            }
                            else if (choice == 2)
                            {
                                if (minPrice < 100) throw new PriceExeption(minPrice);
                            }
                            else if (choice == 3)
                            {
                                if (minPrice < 800) throw new PriceExeption(minPrice);

                            }

                            Console.WriteLine("Please enter the maximum price");
                            double.TryParse(Console.ReadLine(), out double maxPrice);

                            if (choice == 1)
                            {
                                printParts(Db.Parts.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList());
                            }
                            else if (choice == 2)
                            {
                                printModules(Db.Modules.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList());
                            }
                            else if (choice == 3)
                            {
                                printConfigurations(Db.Configurations.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList());
                            }
                            break;

                        case 3:
                            if (choice == 1)
                            {
                                Console.WriteLine("Please choose/write the type: ");
                                Console.WriteLine("Proccessing, Graphics, Casing, MainBoard, Memory, Other");
                               
                                string answerInput = Console.ReadLine();

                                if (answerInput.ToLower() == "proccessing")
                                {
                                    printParts(Db.Parts.Where(x => x.Type == PartType.Cpu || x.Type == PartType.CpuCooler).ToList());
                                }
                                else if (answerInput.ToLower() == "graphics")
                                {
                                    printParts(Db.Parts.Where(x => x.Type == PartType.Gpu || x.Type == PartType.GpuCooler).ToList());
                                }
                                else if (answerInput.ToLower() == "casing")
                                {
                                    printParts(Db.Parts.Where(x => x.Type == PartType.Case || x.Type == PartType.PowerSuply).ToList());
                                }
                                else if (answerInput.ToLower() == "mainboard")
                                {
                                    printParts(Db.Parts.Where(x => x.Type == PartType.MotherBoard || x.Type == PartType.ConnectionCable || x.Type == PartType.PowerCable).ToList());
                                }
                                else if (answerInput.ToLower() == "memory")
                                {
                                    printParts(Db.Parts.Where(x => x.Type == PartType.SSD || x.Type == PartType.HDD || x.Type == PartType.RAM).ToList());
                                }
                                else if (answerInput.ToLower() == "other")
                                {

                                    printParts(Db.Parts.Where(x => x.Type == PartType.Monitor || x.Type == PartType.Mouse || x.Type == PartType.Keyboard).ToList());
                                }
                                else
                                {
                                    throw new StringException(answerInput);
                                }
                            }
                            else if (choice == 2)
                            {
                                Console.WriteLine("Please choose/write the type: ");
                                Console.WriteLine("Proccessing, Graphics, Casing, MainBoard, Memory, Other");

                                string answerInput = Console.ReadLine();

                                if (answerInput.ToLower() == "proccessing")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.Processing).ToList());
                                }
                                else if (answerInput.ToLower() == "graphics")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.Graphics).ToList());
                                }
                                else if (answerInput.ToLower() == "casing")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.Casing).ToList());
                                }
                                else if (answerInput.ToLower() == "mainboard")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.MainBoard).ToList());
                                }
                                else if (answerInput.ToLower() == "memory")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.Memory).ToList());
                                }
                                else if (answerInput.ToLower() == "other")
                                {
                                    printModules(Db.Modules.Where(x => x.Type == ModuleType.Other).ToList());
                                }
                                else
                                {
                                    throw new StringException(answerInput);
                                }
                            }

                            else if (choice == 3)
                            {
                                Console.WriteLine("Please choose/write the type: ");
                                Console.WriteLine("Standard, Office, Gaming");

                                string answerInput = Console.ReadLine();

                                if (answerInput.ToLower() == "standard")
                                {
                                    printConfigurations(Db.Configurations.Where(x => x.Type == ConfigurationType.Standard).ToList());
                                }
                                else if (answerInput.ToLower() == "office")
                                {
                                    printConfigurations(Db.Configurations.Where(x => x.Type == ConfigurationType.Office).ToList());
                                }
                                else if (answerInput.ToLower() == "gaming")
                                {
                                    printConfigurations(Db.Configurations.Where(x => x.Type == ConfigurationType.Gaming).ToList());
                                }
                                else
                                {
                                    throw new StringException(answerInput);
                                }
                            }
                            break;
                    }
                }
                else
                {
                    throw new InvalidNumberException(choice);
                }

            }           
            
            //ako sakam da rabotam linq f-cii sekogas vrakja IEnumerable, a toa se pretvara vo lista
            //.ToList();
            //ako sakam da printam ne mozam so IEnumerable, moram da pretvoram vo lista
            //linq funkciite rabotat/primaat lista a vrakja ienumerable
             void printParts(List<Part> parts) {

                outputParts = parts; //praznata lista ja polnam so filtriranite podatoci .where()
                for (int i = 0; i < parts.Count; i++)
                {
                    Console.WriteLine($" Parts** ID: {parts[i].Id} NAME: {parts[i].Name} TYPE: {parts[i].Type}  COMPANY: {parts[i].Company} QUANTITY: {parts[i].Quantity} PRICE: {parts[i].Price} $");
                }

                Console.WriteLine("Enter the ID of the item to put it in your shopping cart: ");
                
              if(int.TryParse(Console.ReadLine(), out int cartInput));
                else
                {
                    throw new Exception();
                }
              if(cartInput < 0 || cartInput > 44)
                {
                    throw new IdExeption(cartInput);
                }

                for (int i = 0; i < parts.Count; i++)
                {
                    if (parts[i].Id == cartInput)
                    {
                        if(partsCounter < 10)
                        {
                            shoppingCart.Add(parts[i]);
                          
                            Console.WriteLine($"Item: {parts[i].Id} {parts[i].Name} {parts[i].Type} was added to your cart.");
                            partsCounter++;                          
                        }
                       else
                        {
                           Console.WriteLine("You already have 10 parts.");
                        }
                    }
                }                                
                continueShopping();              
            }

                
                // Console.WriteLine("========");
                void printModules(List<Module> modules)
            {
                outputModules = modules;

                for (int i = 0; i < modules.Count; i++)
                {
                    Console.WriteLine($" Modules** ID: {modules[i].Id} TYPE: {modules[i].Type} PRICE: {modules[i].Price} $");
                }
                Console.WriteLine("Enter the ID of the item to put it in your shopping cart: ");
                               
                if (int.TryParse(Console.ReadLine(), out int cartInput));
                else
                {
                    throw new Exception();
                }
                if (cartInput < 50 || cartInput > 61)
                {
                    throw new IdExeption(cartInput);
                }


                for (int i = 0; i < modules.Count; i++)
                {
                    if(modules[i].Id == cartInput)
                    {                      
                        if(modulesCounter < 5)
                        {
                            shoppingCart.Add(modules[i]);
                            modulesCounter++;

                            Console.WriteLine($"Your shopping cart contains: ID: {modules[i].Id} TYPE: {modules[i].Type} PRICE: {modules[i].Price} $");
                        }
                        else
                        {
                            Console.WriteLine("You already have 5 modules. ");
                        }
                    }                    
                }
                continueShopping();
                
            }
            
            //Console.WriteLine("========");

            void printConfigurations(List<Configuration> configurations)
            {
                outputConfiguration = configurations;

                for (int i = 0; i < configurations.Count; i++)
                {
                    Console.WriteLine($" Configurations** ID: {configurations[i].Id} TITLE: {configurations[i].Title} TYPE: {configurations[i].Type} PRICE: {configurations[i].Price} $");
                }

                Console.WriteLine("Enter the ID of the item to put it in your shopping cart: ");
                
                if (int.TryParse(Console.ReadLine(), out int cartInput)) ;
                else
                {
                    throw new Exception();
                }
                if (cartInput < 80 || cartInput > 83)
                {
                    throw new IdExeption(cartInput);
                }

                for (int i = 0; i < configurations.Count; i++)
                {
                    if (configurations[i].Id == cartInput)
                    {
                        if(configurationsCounter < 1)
                        {
                            shoppingCart.Add(configurations[i]);
                            configurationsCounter++;
                            Console.WriteLine($"Your shopping cart contains: ID: {configurations[i].Id} TITLE: {configurations[i].Title} TYPE: {configurations[i].Type} PRICE: {configurations[i].Price} $");
                        }
                        else
                        {
                            Console.WriteLine("You have already 1 configuration");
                        }
                    }
                }
                continueShopping();                                                   
            }

            //
            void seeItemsInShoppingCart()
            {
                foreach (Item product in shoppingCart)
                {
                    // za da ima title!!!!
                    if (product.Id > 0 && product.Id < 45)
                    {
                        foreach (Part item in Db.Parts)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($" YOUR CART CONTAINS: PARTS** id: {item.Id} name: {item.Name} type: {item.Type}  company: {item.Company} quantity: {item.Quantity} price: {item.Price} $");
                            }
                        }
                    }
                    else if (product.Id > 49 && product.Id < 61)
                    {
                        foreach (var item in Db.Modules)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($" YOUR CART CONTAINS: MODULES** ID: {item.Id} TYPE: {item.Type} PRICE: {item.Price} $");
                            }
                        }
                    }
                    else if (product.Id > 79 && product.Id < 84)
                    {
                        foreach (var item in Db.Configurations)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($"YOUR CART CONTAINS: CONFIGURATIONS** ID: {item.Id}  TITLE {item.Title} TYPE: {item.Type} PRICE: {item.Price} $");
                            }
                        }
                    }
                  //  totalPriceToPay += product.Price;
                }
                Console.WriteLine($"Number of Items: {shoppingCart.Count}");
            }

            //RECEIPT
            void printReceipt()
            {
                Console.WriteLine("Your receipt: ");

                foreach (Item product in shoppingCart)
                {
                    if (product.Id > 0 && product.Id < 45)
                    {
                        foreach (Part item in Db.Parts)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($"PARTS** ID: {item.Id} NAME: {item.Name} FULL PRICE: {item.Price}$, PRICE WITH 10% DISCOUNT: {item.Price -item.Price/10} $");

                            }
                        }
                    }
                    else if (product.Id > 49 && product.Id < 61)
                    {
                        foreach (var item in Db.Modules)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($" MODULES** ID: {item.Id} TYPE: {item.Type} FULL PRICE: {item.Price}$, PRICE WITH 10% DISCOUNT: {item.Price - item.Price / 10} $");
                            }
                        }
                    }
                    else if (product.Id > 79 && product.Id < 84)
                    {
                        foreach (var item in Db.Configurations)
                        {
                            if (product.Id == item.Id)
                            {
                                Console.WriteLine($" CONFIGURATIONS** ID: {item.Id}  TITLE {item.Type} FULL PRICE: {item.Price}$, PRICE WITH 10% DISCOUNT: {item.Price - item.Price / 10} $");
                            }
                        }
                    }
                    totalPriceToPay += product.Price;
                }
                Console.Clear();
                Console.WriteLine($"Number of Items: {shoppingCart.Count}, Total Price: {totalPriceToPay}$, Total price with discount: {totalPriceToPay - totalPriceToPay / 10}$, Money saved with discount: {totalPriceToPay / 10}$");
                Console.WriteLine("Please choose the method of sending your receipt: ");
                Console.WriteLine("1) via SMS");
                Console.WriteLine("2) via E-MAIL");
                Console.WriteLine("3) via MAIL(POST)");
                Console.WriteLine("4) via all above mentioned methods");


                int.TryParse(Console.ReadLine(), out int chooseVia);
                if (chooseVia == 1)
                {
                    receiptVia.SendReceipt += SendReceiptViaSMS;
                }
                else if (chooseVia == 2)
                {
                    receiptVia.SendReceipt += SendReceiptViaMail;
                }
                else if (chooseVia == 3)
                {
                    receiptVia.SendReceipt += SendReceiptViaPost;
                }
                else if (chooseVia == 4)
                {
                    receiptVia.SendReceipt += SendReceiptViaSMS;
                    receiptVia.SendReceipt += SendReceiptViaMail;
                    receiptVia.SendReceipt += SendReceiptViaPost;
                }
                else
                {
                    throw new NumberExeption2(chooseVia);
                }

                receiptVia.SendReceiptFinaly();
            }

            Console.ReadLine();

        }
    }
}
