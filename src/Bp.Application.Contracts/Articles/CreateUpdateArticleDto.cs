using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bp.Dtos
{
    public class CreateUpdateArticleDto
    {
        [Required]
        [StringLength(1024)]
        public string Title { get; set; }
        [Required]
        [StringLength(1024)]
        public string Author { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreationTime{ get; set; }
    }
}
