using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class bookingclass
    {

        string name;
        DateTime whenBook;
        int room;
        string staffmember;

        bookingclass book = new bookingclass { 
        //customer name? 
        Console.WriteLine("What is your name?");


        //when do you want to book?
        Console.WriteLine("When do you wish to book?");


        //what room do you want to book?
        Console.WriteLine("What room do you wish to book?");

        //staff member taking booking? 
        Console.WriteLine("Staff Member helping you?");
        }
    }
}
