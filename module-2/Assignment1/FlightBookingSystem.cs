using System;
using System.Collections.Generic;

// Base class representing an Airport
class Airport
{
    public string Code { get; set; }
    public string Name { get; set; }

    public Airport(string code, string name)
    {
        Code = code;
        Name = name;
    }
}

// Base class representing an Airline
class Airline
{
    public string Name { get; set; }

    public Airline(string name)
    {
        Name = name;
    }
}

// Base class representing a Flight
class Flight
{
    public string FlightNumber { get; set; }
    public Airport DepartureAirport { get; set; }
    public Airport DestinationAirport { get; set; }
    public DateTime DepartureTime { get; set; }
    public Airline Airline { get; set; }

    public Flight(string flightNumber, Airport departureAirport, Airport destinationAirport, DateTime departureTime, Airline airline)
    {
        FlightNumber = flightNumber;
        DepartureAirport = departureAirport;
        DestinationAirport = destinationAirport;
        DepartureTime = departureTime;
        Airline = airline;
    }
}

// Passenger class
class Passenger
{
    public string Name { get; set; }

    public Passenger(string name)
    {
        Name = name;
    }
}

// Booking class
class Booking
{
    public int BookingId { get; set; }
    public Flight Flight { get; set; }
    public List<Ticket> Tickets { get; set; }

    public Booking(int bookingId, Flight flight)
    {
        BookingId = bookingId;
        Flight = flight;
        Tickets = new List<Ticket>();
    }

    public void AddTicket(Ticket ticket)
    {
        Tickets.Add(ticket);
    }
}

// Seat class
class Seat
{
    public string SeatNumber { get; set; }
    public bool IsOccupied { get; set; }

    public Seat(string seatNumber)
    {
        SeatNumber = seatNumber;
        IsOccupied = false;
    }
}

// Ticket class
class Ticket
{
    public int TicketNumber { get; set; }
    public Seat Seat { get; set; }
    public Passenger Passenger { get; set; }

    public Ticket(int ticketNumber, Seat seat, Passenger passenger)
    {
        TicketNumber = ticketNumber;
        Seat = seat;
        Passenger = passenger;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Airport, Airline, Flight, Passenger, Booking, Seat, and Ticket
        Airport airport1 = new Airport("JFK", "John F. Kennedy International Airport");
        Airport airport2 = new Airport("LAX", "Los Angeles International Airport");
        Airline airline1 = new Airline("Example Airlines");
        Flight flight1 = new Flight("E123", airport1, airport2, DateTime.Now.AddHours(2), airline1);
        Passenger passenger1 = new Passenger("Alice Passenger");
        Booking booking1 = new Booking(1, flight1);
        Seat seat1 = new Seat("A1");
        Ticket ticket1 = new Ticket(101, seat1, passenger1);

        // Book the flight and add a ticket
        booking1.AddTicket(ticket1);
        seat1.IsOccupied = true;

        // Display booking details
        Console.WriteLine($"Booking ID: {booking1.BookingId}");
        Console.WriteLine($"Flight: {booking1.Flight.FlightNumber} from {booking1.Flight.DepartureAirport.Name} to {booking1.Flight.DestinationAirport.Name}");
        Console.WriteLine("Passengers:");
        foreach (var ticket in booking1.Tickets)
        {
            Console.WriteLine($"  - {ticket.Passenger.Name}, Seat: {ticket.Seat.SeatNumber}");
        }
    }
}



// Output:

// Booking ID: 1

// Flight: E123 from John F. Kennedy International Airport to Los Angeles International Airport

// Passengers:

//   - Alice Passenger, Seat: A1

