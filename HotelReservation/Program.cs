using System;
using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;

namespace HotelReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ROOM NUMBER: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("\nCHECK-IN DATE (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CHECK-OUT DATE (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("\n\nRESERVATION: " + reservation);

                Console.WriteLine("\n\nENTER DATA BELLOW TO UPDATE THE RESERVATION:");
                Console.Write("\nCHECK-IN DATE (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CHECK-OUT DATE (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("\n\nRESERVATION: " + reservation);
            }
            catch (DomainException exception)
            {
                Console.WriteLine("\n\nERROR IN RESERVATION: " + exception.Message);
            }
            catch (FormatException exeption)
            {
                Console.WriteLine("\n\nFORMAT ERROR: " + exeption.Message);
            }
            catch(Exception exeption)
            {
                Console.WriteLine("\n\nUNEXPECTED ERROR: " + exeption.Message);
            }
            Console.ReadKey();
        }
    }
}