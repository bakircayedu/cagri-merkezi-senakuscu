using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace odevv
{
    class Program
    {
        static void Main(string[] args)
        {
			int l = 0; 
			int n = 0;  
			int t = 0;  
			int m = 0; 
			int callArrival;    
			int serviceTime = 0;    
			int customerID = 0;
			int totalCustomersServed = 0;   
			int longestLine = 0;    
			int longestWaitTime = 0;    
			int totalWaitTime = 0;  
			String fileName = "testcase0.txt";
			int menuSelection;
			bool repAvail = true;    
			int  scan;
            Customer currentCustomer = new Customer();
			
			Random rand = new Random();
			scan = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini seçin:\n"
				+ "1. Dosya giris\n"
				+ "2. Manual giris\n");
			
			menuSelection = scan.nextInt();

			if (menuSelection == 1)
			{
				Console.WriteLine("Lütfen dosya adını yazın: ");
				fileName = scan.next();

				
				Scanner fileScanner = new Scanner(new File(fileName));

				
				l = fileScanner.nextInt();
				n = fileScanner.nextInt(); 
				m = fileScanner.nextInt(); 
				t = fileScanner.nextInt(); 
			}
			else if (menuSelection == 2)
			{
				Console.WriteLine("Lütfen cagri hattı numarasini yaziniz, müsterinin arama varis orani, " + "müsteri hizmetleri zaman orani, ve toplam simülasyon süresi.");
				
				l = scan.nextInt(); 
				n = scan.nextInt(); 
				m = scan.nextInt(); 
				t = scan.nextInt(); 


			}
			
			callArrival = (rand.Next(n) + 1);

			
			LinkedQueue<Customer> callLine = new LinkedQueue();

		

			

			for (int i = 1; i <= t; i++)
			{
				
				Console.WriteLine("Zaman: " + i);

				
				if (i == callArrival)
				{
					
					Customer customer = new Customer(++customerID, callArrival);

					
					callLine.enqueue(customer);

					
					int estimatedWaitTime = callLine.size() * m / 2;

					
					Console.WriteLine("[ --- Müsteri " + customer.getCustomerID() + " aradi! --- ]" + "\nOrtalama bekleme süresi: " + estimatedWaitTime + " dakika");

					
					callArrival += rand.Next(n) + 1;
				}
				

				
				if (serviceTime == 0 && !repAvail)
				{
					Console.WriteLine("Müsteri " + currentCustomer.getCustomerID() + " Tamamlandi***");
					repAvail = true;
				}



				

				if (repAvail && !callLine.isEmpty())
				{
					
					int startTime = callLine.first().getStartTime();
					int waitTime = i - startTime;

					 
					totalWaitTime += waitTime;

					
					if (waitTime > longestWaitTime)
					{
						longestWaitTime = waitTime;
					}

					
					currentCustomer = callLine.dequeue();

					
					totalCustomersServed++;

				
					serviceTime = (rand.Next(m) + 1);

					
					repAvail = false;

				}
				

				
				if (callLine.size() > longestLine)
				{
					longestLine = callLine.size();
				}

				
				if (!repAvail)
				{
					serviceTime--;
				}
			}

			
			float averageWaitTime = (float)totalWaitTime / totalCustomersServed;

			
			Console.WriteLine("---------------------------");
			Console.Write("# hizmet verilen müşteri: " + totalCustomersServed + "\n# kuyrukta kalan müşteri sayısı: " + callLine.size() + "\nHerhangi bir zamanda maksimum müşteri sayısı:  " + longestLine + "\nEn uzun bekleme süresi " + longestWaitTime + "\nOrtalama bekleme süresi: " + averageWaitTime);
		}


	}


}
		

