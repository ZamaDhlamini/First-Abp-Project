using System.ComponentModel.DataAnnotations;

namespace NewAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}