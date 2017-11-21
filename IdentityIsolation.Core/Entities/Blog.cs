using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityIsolation.Core.Entities
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
