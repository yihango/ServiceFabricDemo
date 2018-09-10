using System.ComponentModel.DataAnnotations;

namespace ABP_CORE_MPA.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}