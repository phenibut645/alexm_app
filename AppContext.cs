﻿using alexm_app.Enums.TicTacToe;
using alexm_app.Models;
using alexm_app.Models.TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alexm_app
{
    public delegate void ThemeChanged(Theme theme);
    public delegate void SideChangedHandler();
    public static class AppContext
    {
        public static event SideChangedHandler OnSideChange;
        public static List<ContentPage> Pages { get; set; } = new List<ContentPage>()
        {
            new ValgusfoorPage(),
            new rgb_page(),
            new lumimamm(),
            new GuestPage()
        };

        // TIC-TAC-TOE ---------------------------------------------------------------------------------------------------
        private static Theme _ticTacToeTheme = new Theme();
        public static event ThemeChanged OnThemeChange;
        public static Theme TicTacToeTheme
        {
            get { return _ticTacToeTheme; }
            set
            {
                _ticTacToeTheme = value;
                OnThemeChange?.Invoke(value);
            }
        }
        private static double _ticTacToeSizeOfMapMultiply = 1;
        public static event Action<double> OnMapMulitplyChange;
        public static double TicTacToeSizeOfMapMultiply
        {
            get { return _ticTacToeSizeOfMapMultiply; }
            set
            {
                _ticTacToeSizeOfMapMultiply = value;
                OnMapMulitplyChange?.Invoke(value);
            }
        }
        private static Sides? _side = Sides.Cross;
        public static Sides? Side
        {
            get { return _side; }
            set
            {
                _side = value;
                OnSideChange?.Invoke();
            }
        }
        public static GameMode? GameMode { get; set; } = null;
        public static string? UniqueIdentity { get; set; } = null;
        public static Game? Game { get; set; } = null;
        public static Player? Player { get; set; } = null;
        public static bool? IsGameRunning { get; set; } = null;
        public static INavigation Navigation { get; set; }
        public static TicTacToe? CurrentGame { get; set; } = null;
        public static Player? EnemyPlayer { get; set; } = null;
        public static GameConnection? GameConnection { get; set; } = null;
        // ----------------------------------------------------------------------------------------------------------------
    }
}
