using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticleCase.Core
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Article> Articles { get; set; }
        public DateTime BirthDate { get; set; }
        [NotMapped] public string FullName => FirstName + ' ' + LastName;
    }
}