﻿using alexm_app.Enums.TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alexm_app.Models.TicTacToe
{
    public class Move
    {
        public Player Player { get; set; }
        public Cell Cell { get; set; }
        
    }
}
