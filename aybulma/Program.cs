// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
         string tarih;

            Console.Write("bir tarih giriniz ");
            tarih= Console.ReadLine();
               string[] tarih_deger = tarih.Split('.');
       switch (tarih_deger[1])
            {
                case "01": Console.Write("OCAK"); break;
                case "02": Console.Write("ŞUBAT"); break;
                case "03": Console.Write("MART"); break;
                case "04": Console.Write("NİSAN"); break;
                case "5": Console.Write("MAYIS"); break;
                case "06": Console.Write("HAZİRAN"); break;
                case "07": Console.Write("TEMMUZ"); break;
                case "08": Console.Write("AĞUSTOS"); break;
                case "09": Console.Write("EYLÜL"); break;
                case "10": Console.Write("EKİM"); break;
                case "11": Console.Write("KASIM"); break;
                case "12": Console.Write("ARALIK"); break;
                default: Console.Write("Lütfen ay bilgisini dogru giriniz"); break;
            }
            Console.ReadKey();

