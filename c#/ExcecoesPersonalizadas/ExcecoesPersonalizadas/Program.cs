using System;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine("Data check-in: " + checkIn.ToString("dd/MM/yyy HH:mm:ss"));
                Console.WriteLine("Data check-out: " + checkOut.ToString("dd/MM/yyy HH:mm:ss"));


                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data check-in: " + checkIn.ToString("dd/MM/yyy HH:mm:ss"));
                Console.WriteLine("Data check-out: " + checkOut.ToString("dd/MM/yyy HH:mm:ss"));
                Console.WriteLine("Data atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}

