using System;
using System.Collections.Generic;

#nullable disable

namespace Omdb.Entities.Entities
{
    public partial class User : IEntity
    {
        public User()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] Email { get; set; }
        public string Password { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
