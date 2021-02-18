using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JokesWebApp.Models
{
    public class Joke
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Joke Question")]
        public string JokeQuestion { get; set; }

        [Required]
        [Display(Name = "Joke Answer")]
        public string JokeAnswer { get; set; }

        public Joke()
        {
                
        }
    }
}
