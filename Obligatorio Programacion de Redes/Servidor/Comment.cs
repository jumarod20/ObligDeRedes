﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servidor
{
    public class Comment
    {
        public User Author { get; set; }
        
        public string Text { get; set; }

        public Comment(User author, string text)
        {
            Author = author;
            Text = text;
        }

    }

}
