using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class JsonModel
    {
      
           public String name_ru { get; set; } //- заголовок новости на русском языке
            public String name_be { get; set; } //- заголовок новости на белорусском языке
            public String html_ru { get; set; } //- текст новости на русском языке
            public String html_be { get; set; } //- текст новости на белорусском языке
            public String img { get; set; }//- картинка к новости
            public String start_date { get; set; }//- дата размещения новости
        
    }
}

