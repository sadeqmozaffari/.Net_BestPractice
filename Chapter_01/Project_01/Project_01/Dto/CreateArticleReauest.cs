using System.ComponentModel.DataAnnotations;

namespace Project_01.Dto
{
    public class CreateArticleRequest
    {
        [Required]
        [StringLength(100)]
        public required string Title { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateArticleRequest() : CreateArticleRequest
    {

    }
}
