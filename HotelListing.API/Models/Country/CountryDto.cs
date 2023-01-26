using HotelListing.API.Models.Hotel;
using Microsoft.Build.Framework;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        [Required]
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
}

