namespace PrgPattern.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(20, 70)]
        public int Age { get; set; }
    }
}