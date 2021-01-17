using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название игры")]
        [Display(Name = "Название игры")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание игры")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание игры")]
        public override string Text { get; set; }

    }
}
