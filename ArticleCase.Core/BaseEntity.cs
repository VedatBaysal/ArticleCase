using System;
using System.ComponentModel.DataAnnotations;

namespace ArticleCase.Core
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}