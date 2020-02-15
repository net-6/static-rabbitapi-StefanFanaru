using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitProj.Models
{
    public class Rabbit
    {
        public enum FurColors
        {
            White,
            Brown,
            Black,
            Grey
        }
        public enum EyeColors
        {
            Blue,
            Black,
            Red
        }
        public enum Genders
        {
            Male,
            Female
        }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public FurColors FurColor { get; set; }

        [Required]
        public EyeColors EyeColor { get; set; }

        [Required]
        public Genders Gender { get; set; }


    }
}
