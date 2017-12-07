using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class RegExTestData {
        // Portuguese Postal Code
        [RegularExpression(@"\d{4}(-\d{3})?", ErrorMessage = "Invalid Postal Code")]
        public string PostalCode { get; set; }

        // Portuguese License Plate
        [RegularExpression("[A-Z0-9]{2}-[A-Z0-9]{2}-[A-Z0-9]{2}", ErrorMessage ="Invalid License Plate")]
        public string LicensePlate { get; set; }

        // Portuguese Phone Number
        [RegularExpression(@"(2\d{8})|(9[1236]\d{7})", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
    }
}
