using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    //DTO stand for Data Transfer Object. It exists so it's easier to discard all unwanted changes in the data that was sent back by the API user
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfAMember] //It has to be commented out because otherwise it is going to throw InvalidCastException when checking
        //the customer membership type because it is going to be casted as a Customer, and not as a CustomerDto
        //From what I know the workaround is to:
        //- create another constraint but this time for CustomerDto
        //- modify existing function so it can be applied to CustomerDto
        //- create another type from which but CustomerDto and Customer would inherit (which is probably the best even though it will slow
        //down the code a bit due to boxing happening)
        //- use only one data type
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}