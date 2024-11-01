using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Models
{
    public class Member: User
    {
        [Key]

        public int MemberId { get; set; }
        [Required]
        [StringLength(100)]

        public string Name { get; set; }
       
        public  Boolean MembershipStatus { get; set; }
        public string Joindate { get; set; }
        public int MembershipTypeID { get; set; }
        public MembershipType MembershipType { get; set; } 
         public ICollection<Booking> bookings { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public List<string> Tags { get; set; } = new List<string>(); 



        Member()

        {
            booking = new list<booking>();
        }
        public void BookEvent(Event eventItem)
        {
            var booking = new Booking { MemberId = this.MemberId, EventId = eventItem.EventId };
            Bookings.Add(booking); // Records the member's booking for the event
        }
        public void AddInterest(string interest)
        {
            if (!Interests.Contains(interest))
                Interests.Add(interest);
        }
    }

}
