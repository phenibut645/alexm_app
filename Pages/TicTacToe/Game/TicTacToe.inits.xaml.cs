﻿using alexm_app.Controls;
using alexm_app.Models.TicTacToe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cell = alexm_app.Models.TicTacToe.Cell;

namespace alexm_app
{
    public partial class TicTacToe
    {
        private void InitGameArea()
        {
            for(int i = 0; i < 3; i++)
            {
                GameArea.RowDefinitions.Add(new RowDefinition() { Height = (int)Math.Round(50 * AppContext.TicTacToeSizeOfMapMultiply) });
                GameArea.ColumnDefinitions.Add(new ColumnDefinition() {Width = (int)Math.Round(50 * AppContext.TicTacToeSizeOfMapMultiply) } );
            }
            for(int row = 0; row < 3; row++)
            {
                CellList.Add(new List<CellButton>());
                for(int col = 0; col < 3; col++)
                {
                    CellButton button = new CellButton();
                    button.CellInGameArea = new Cell() { Y = row, X = col };
                    button.Clicked += CellButton_Clicked;
                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, col);
                    GameArea.Children.Add(button);
                    CellList[row].Add(button);
                }
            }
        }


    }
}
