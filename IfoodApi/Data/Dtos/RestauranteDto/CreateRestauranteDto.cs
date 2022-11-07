using System.ComponentModel.DataAnnotations;
using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.RestauranteDto
{
    public class CreateRestauranteDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int AddressId { get; set; }
    }
}