﻿using System;

namespace Sum100NumbersWith50DigitsEach
{
    //============================================
    // Without Using System.Numerics
    //============================================

    class Program
    {
        static void Main(string[] args)
        {
            int[] Number0 = new int[50] { 7, 6, 1, 6, 2, 3, 1, 0, 4, 5, 8, 5, 7, 4, 7, 2, 6, 0, 2, 7, 3, 1, 6, 6, 2, 3, 8, 5, 8, 4, 1, 8, 1, 6, 0, 5, 8, 7, 3, 7, 5, 5, 5, 0, 5, 7, 7, 1, 0, 7 };
            int[] Number1 = new int[50] { 8, 4, 7, 3, 8, 5, 0, 4, 4, 7, 4, 5, 0, 0, 4, 0, 3, 0, 3, 2, 2, 7, 6, 3, 1, 6, 5, 5, 0, 4, 5, 7, 4, 1, 4, 5, 0, 6, 6, 3, 4, 3, 3, 4, 3, 0, 4, 5, 5, 5 };
            int[] Number2 = new int[50] { 3, 6, 6, 7, 4, 0, 7, 3, 2, 1, 0, 3, 4, 8, 2, 5, 0, 8, 5, 7, 0, 6, 3, 0, 6, 8, 4, 1, 8, 0, 2, 0, 0, 4, 1, 8, 1, 6, 6, 3, 7, 5, 4, 5, 3, 1, 8, 3, 2, 7 };
            int[] Number3 = new int[50] { 0, 5, 0, 6, 5, 5, 2, 6, 0, 5, 5, 5, 3, 1, 8, 0, 2, 0, 7, 2, 4, 3, 2, 1, 0, 3, 2, 7, 5, 5, 8, 0, 8, 1, 0, 6, 0, 2, 7, 4, 5, 3, 5, 0, 6, 1, 1, 2, 5, 3 };
            int[] Number4 = new int[50] { 7, 7, 5, 8, 2, 6, 2, 7, 5, 1, 3, 4, 0, 4, 5, 5, 6, 2, 1, 1, 0, 8, 1, 2, 5, 0, 6, 1, 4, 8, 1, 8, 1, 2, 6, 1, 4, 8, 8, 2, 3, 2, 5, 6, 1, 1, 3, 1, 3, 1 };
            int[] Number5 = new int[50] { 3, 8, 1, 3, 2, 7, 6, 2, 3, 2, 8, 1, 2, 6, 8, 3, 3, 7, 6, 4, 0, 6, 2, 7, 7, 7, 3, 4, 1, 4, 6, 4, 6, 2, 4, 1, 6, 6, 8, 8, 4, 1, 5, 6, 2, 2, 8, 8, 6, 6 };
            int[] Number6 = new int[50] { 6, 4, 4, 8, 0, 6, 6, 3, 5, 4, 4, 1, 1, 8, 4, 4, 3, 8, 1, 7, 5, 6, 7, 7, 8, 8, 1, 5, 4, 4, 7, 3, 6, 3, 7, 1, 0, 7, 2, 7, 4, 3, 0, 4, 3, 2, 0, 5, 1, 7 };
            int[] Number7 = new int[50] { 8, 8, 6, 8, 1, 0, 6, 5, 8, 1, 4, 0, 7, 0, 5, 0, 3, 7, 1, 2, 3, 5, 6, 3, 2, 2, 5, 3, 3, 6, 8, 4, 3, 5, 5, 8, 5, 7, 2, 6, 4, 4, 7, 1, 3, 4, 5, 8, 7, 2 };
            int[] Number8 = new int[50] { 7, 1, 4, 7, 4, 3, 2, 3, 6, 8, 3, 3, 2, 2, 1, 8, 5, 1, 4, 6, 4, 5, 5, 3, 7, 8, 6, 5, 0, 6, 5, 5, 5, 0, 8, 6, 8, 4, 1, 2, 5, 2, 1, 3, 3, 0, 1, 5, 8, 3 };
            int[] Number9 = new int[50] { 7, 3, 4, 0, 7, 2, 5, 1, 0, 5, 5, 5, 3, 8, 2, 6, 7, 1, 3, 4, 8, 0, 0, 1, 0, 2, 3, 1, 8, 6, 6, 1, 6, 5, 8, 2, 1, 4, 2, 5, 0, 7, 4, 4, 6, 0, 7, 2, 0, 6 };
            int[] Number10 = new int[50] { 2, 0, 1, 4, 3, 7, 2, 3, 8, 5, 7, 3, 2, 2, 8, 3, 8, 6, 0, 8, 5, 2, 8, 6, 3, 1, 4, 4, 4, 0, 3, 1, 1, 2, 3, 5, 8, 1, 1, 1, 8, 6, 4, 5, 7, 5, 5, 2, 5, 3 };
            int[] Number11 = new int[50] { 0, 0, 1, 1, 0, 0, 0, 4, 0, 2, 2, 7, 7, 7, 2, 5, 2, 8, 7, 2, 3, 7, 4, 8, 0, 7, 6, 2, 7, 6, 5, 2, 8, 1, 0, 2, 8, 8, 1, 3, 5, 4, 1, 8, 7, 1, 8, 6, 3, 1 };
            int[] Number12 = new int[50] { 3, 5, 4, 3, 8, 2, 4, 2, 0, 2, 2, 7, 5, 3, 5, 0, 8, 6, 7, 8, 6, 2, 6, 3, 6, 7, 5, 5, 0, 8, 8, 0, 8, 6, 3, 8, 6, 5, 1, 7, 6, 5, 8, 8, 0, 6, 7, 6, 2, 7 };
            int[] Number13 = new int[50] { 2, 1, 7, 3, 4, 0, 7, 0, 5, 1, 5, 8, 2, 1, 2, 2, 7, 8, 8, 5, 2, 2, 5, 8, 2, 0, 3, 7, 2, 8, 8, 7, 2, 1, 6, 7, 1, 4, 2, 3, 1, 5, 8, 0, 2, 7, 3, 6, 5, 7 };
            int[] Number14 = new int[50] { 8, 8, 7, 5, 4, 8, 4, 8, 1, 3, 5, 0, 6, 6, 1, 6, 5, 0, 4, 4, 0, 3, 6, 5, 4, 5, 3, 5, 6, 3, 6, 6, 1, 3, 0, 0, 0, 5, 6, 6, 2, 2, 2, 7, 7, 1, 7, 1, 8, 4 };
            int[] Number15 = new int[50] { 1, 3, 1, 1, 7, 4, 2, 2, 1, 7, 4, 7, 1, 6, 6, 7, 7, 3, 6, 0, 5, 8, 3, 6, 1, 6, 0, 7, 6, 3, 6, 1, 6, 1, 2, 2, 5, 0, 5, 4, 6, 7, 4, 7, 2, 4, 0, 5, 0, 8 };
            int[] Number16 = new int[50] { 2, 4, 4, 7, 8, 1, 8, 3, 8, 0, 4, 3, 4, 7, 1, 2, 0, 0, 3, 3, 2, 7, 6, 1, 3, 7, 4, 5, 4, 6, 6, 4, 7, 6, 0, 1, 6, 8, 2, 1, 3, 1, 0, 4, 0, 2, 3, 6, 6, 8 };
            int[] Number17 = new int[50] { 3, 8, 1, 5, 6, 4, 7, 2, 3, 0, 5, 3, 8, 2, 2, 0, 5, 6, 6, 8, 5, 1, 7, 2, 0, 0, 6, 1, 1, 0, 4, 6, 7, 4, 2, 6, 2, 1, 0, 4, 3, 3, 4, 1, 4, 8, 1, 7, 1, 8 };
            int[] Number18 = new int[50] { 5, 5, 8, 6, 3, 2, 1, 7, 4, 5, 7, 5, 1, 3, 5, 7, 4, 3, 8, 5, 6, 4, 6, 1, 4, 1, 5, 5, 7, 1, 8, 7, 0, 2, 3, 7, 7, 0, 1, 0, 4, 3, 6, 3, 6, 7, 2, 1, 4, 5 };
            int[] Number19 = new int[50] { 3, 7, 8, 5, 1, 1, 7, 7, 2, 1, 5, 4, 0, 2, 6, 8, 5, 7, 8, 6, 0, 4, 2, 8, 0, 2, 6, 3, 4, 5, 8, 4, 1, 1, 7, 1, 8, 3, 0, 2, 0, 0, 7, 8, 4, 0, 3, 3, 5, 6 };
            int[] Number20 = new int[50] { 2, 3, 2, 6, 4, 8, 4, 0, 5, 7, 3, 4, 2, 5, 1, 1, 3, 7, 4, 5, 0, 1, 7, 5, 6, 0, 5, 2, 3, 0, 8, 3, 6, 6, 3, 4, 1, 3, 5, 8, 5, 8, 7, 1, 7, 5, 6, 1, 7, 2 };
            int[] Number21 = new int[50] { 5, 4, 8, 8, 6, 1, 5, 5, 0, 3, 2, 1, 5, 5, 8, 0, 6, 5, 2, 6, 8, 0, 1, 4, 0, 1, 3, 5, 7, 1, 3, 4, 4, 1, 3, 4, 4, 7, 0, 2, 8, 5, 2, 1, 6, 3, 3, 2, 2, 7 };
            int[] Number22 = new int[50] { 7, 0, 7, 0, 3, 5, 2, 3, 8, 4, 6, 8, 6, 8, 0, 6, 6, 3, 1, 4, 4, 8, 4, 0, 6, 3, 6, 8, 7, 5, 6, 0, 3, 0, 2, 2, 6, 3, 7, 7, 1, 1, 7, 4, 4, 8, 7, 3, 1, 8 };
            int[] Number23 = new int[50] { 6, 8, 0, 7, 2, 8, 5, 6, 3, 8, 7, 2, 5, 2, 6, 6, 5, 6, 5, 6, 0, 2, 5, 3, 2, 3, 0, 8, 5, 7, 5, 3, 7, 7, 8, 7, 0, 4, 6, 3, 6, 8, 0, 7, 8, 8, 4, 4, 6, 6 };
            int[] Number24 = new int[50] { 2, 0, 7, 4, 8, 3, 2, 6, 4, 8, 8, 5, 1, 4, 3, 4, 4, 7, 3, 8, 5, 1, 8, 2, 0, 0, 2, 7, 3, 3, 7, 4, 2, 7, 4, 4, 4, 3, 8, 4, 5, 2, 8, 7, 3, 1, 7, 4, 3, 4 };
            int[] Number25 = new int[50] { 3, 6, 1, 7, 0, 1, 1, 4, 4, 7, 1, 3, 3, 1, 0, 3, 3, 2, 0, 8, 8, 0, 8, 8, 2, 3, 1, 1, 7, 8, 2, 6, 4, 7, 8, 0, 3, 3, 6, 3, 3, 8, 8, 0, 3, 1, 8, 7, 6, 0 };
            int[] Number26 = new int[50] { 6, 5, 4, 4, 4, 2, 7, 1, 4, 6, 0, 8, 6, 4, 4, 3, 8, 5, 1, 8, 8, 8, 4, 6, 5, 8, 1, 7, 5, 0, 4, 2, 3, 7, 1, 6, 2, 8, 2, 5, 2, 1, 8, 0, 2, 3, 2, 3, 4, 8 };
            int[] Number27 = new int[50] { 2, 2, 5, 6, 0, 7, 0, 7, 8, 5, 1, 0, 5, 4, 2, 6, 5, 8, 3, 7, 1, 8, 2, 5, 6, 7, 0, 4, 3, 1, 6, 7, 2, 6, 7, 1, 6, 5, 7, 2, 6, 4, 0, 6, 4, 2, 5, 4, 7, 5 };
            int[] Number28 = new int[50] { 6, 3, 8, 6, 6, 3, 0, 0, 0, 1, 7, 4, 3, 6, 7, 2, 6, 8, 5, 0, 0, 8, 0, 1, 1, 6, 7, 4, 0, 4, 2, 5, 6, 7, 4, 2, 8, 5, 8, 3, 0, 6, 5, 5, 4, 1, 0, 3, 7, 1 };
            int[] Number29 = new int[50] { 4, 5, 7, 6, 4, 6, 2, 6, 4, 0, 4, 4, 8, 4, 8, 1, 6, 5, 1, 4, 3, 0, 0, 2, 8, 3, 3, 4, 6, 8, 6, 3, 6, 7, 8, 5, 7, 0, 2, 6, 0, 1, 0, 8, 8, 5, 6, 0, 5, 2 };
            int[] Number30 = new int[50] { 3, 3, 1, 3, 7, 4, 5, 4, 6, 1, 3, 6, 0, 4, 3, 0, 7, 0, 4, 2, 3, 6, 3, 4, 4, 1, 8, 0, 2, 3, 5, 2, 8, 4, 5, 2, 2, 2, 0, 4, 0, 2, 2, 0, 2, 2, 1, 4, 5, 7 };
            int[] Number31 = new int[50] { 6, 6, 4, 2, 7, 5, 0, 5, 7, 6, 4, 4, 2, 3, 5, 0, 7, 5, 8, 0, 7, 4, 0, 8, 2, 1, 4, 2, 2, 1, 0, 3, 4, 4, 6, 7, 6, 5, 5, 8, 2, 5, 4, 2, 0, 5, 0, 8, 4, 1 };
            int[] Number32 = new int[50] { 4, 4, 5, 4, 0, 1, 6, 5, 0, 6, 1, 6, 3, 6, 6, 0, 0, 7, 5, 6, 3, 1, 8, 0, 7, 1, 0, 6, 8, 6, 1, 4, 7, 0, 6, 4, 7, 8, 3, 4, 0, 1, 5, 8, 6, 4, 1, 6, 5, 8 };
            int[] Number33 = new int[50] { 4, 2, 2, 6, 7, 2, 5, 4, 5, 7, 0, 0, 5, 2, 4, 5, 8, 3, 0, 1, 1, 0, 3, 0, 5, 1, 4, 0, 3, 3, 0, 3, 1, 8, 1, 8, 1, 0, 1, 3, 8, 3, 2, 5, 4, 0, 4, 3, 3, 0 };
            int[] Number34 = new int[50] { 4, 7, 6, 3, 6, 4, 7, 2, 1, 6, 6, 4, 1, 2, 7, 6, 7, 6, 1, 5, 4, 8, 1, 5, 2, 7, 6, 7, 5, 4, 5, 1, 5, 2, 8, 2, 5, 6, 1, 5, 0, 8, 8, 4, 6, 3, 2, 0, 7, 6 };
            int[] Number35 = new int[50] { 1, 7, 1, 6, 5, 4, 5, 1, 1, 8, 7, 0, 5, 5, 0, 4, 8, 7, 3, 4, 0, 1, 4, 4, 5, 4, 0, 6, 8, 7, 5, 5, 0, 7, 3, 7, 8, 7, 6, 3, 6, 4, 5, 2, 6, 8, 3, 2, 4, 1 };
            int[] Number36 = new int[50] { 4, 3, 6, 2, 6, 0, 2, 6, 1, 1, 4, 7, 1, 2, 2, 2, 0, 6, 2, 2, 4, 0, 1, 0, 7, 5, 4, 2, 6, 5, 1, 6, 2, 7, 3, 1, 8, 6, 1, 2, 4, 2, 6, 5, 7, 7, 2, 3, 8, 4 };
            int[] Number37 = new int[50] { 8, 5, 0, 2, 5, 4, 2, 5, 3, 0, 5, 8, 8, 5, 0, 6, 5, 3, 7, 1, 2, 2, 5, 8, 6, 2, 2, 5, 1, 0, 3, 1, 3, 1, 5, 4, 6, 8, 2, 8, 8, 2, 3, 0, 6, 4, 3, 1, 4, 1 };
            int[] Number38 = new int[50] { 1, 7, 4, 7, 2, 5, 8, 0, 4, 3, 1, 6, 4, 2, 6, 4, 5, 6, 8, 4, 0, 5, 1, 8, 1, 0, 8, 4, 2, 1, 7, 1, 0, 0, 8, 4, 5, 5, 8, 0, 4, 5, 4, 8, 6, 1, 7, 0, 3, 2 };
            int[] Number39 = new int[50] { 8, 6, 1, 0, 0, 4, 5, 5, 5, 2, 6, 4, 7, 3, 4, 8, 6, 3, 3, 2, 7, 8, 6, 8, 8, 3, 1, 2, 1, 0, 2, 7, 1, 0, 2, 1, 0, 8, 8, 3, 7, 8, 0, 6, 2, 0, 7, 1, 3, 7 };
            int[] Number40 = new int[50] { 4, 3, 6, 1, 3, 8, 8, 2, 0, 5, 2, 3, 3, 5, 0, 8, 3, 6, 0, 3, 8, 6, 3, 8, 3, 8, 8, 0, 5, 8, 5, 0, 7, 3, 4, 7, 0, 0, 6, 2, 1, 6, 8, 3, 0, 4, 4, 4, 6, 3 };
            int[] Number41 = new int[50] { 5, 0, 0, 0, 7, 7, 8, 7, 6, 3, 8, 7, 6, 0, 0, 2, 4, 8, 0, 1, 7, 3, 0, 6, 1, 2, 6, 0, 7, 8, 3, 4, 3, 2, 2, 4, 0, 7, 5, 5, 8, 2, 2, 2, 2, 3, 0, 7, 2, 7 };
            int[] Number42 = new int[50] { 8, 5, 3, 4, 4, 2, 0, 2, 8, 5, 1, 7, 8, 6, 0, 4, 4, 4, 6, 4, 1, 5, 3, 4, 2, 5, 0, 7, 3, 7, 2, 7, 6, 0, 8, 7, 0, 7, 6, 0, 4, 6, 8, 0, 4, 0, 3, 4, 1, 6 };
            int[] Number43 = new int[50] { 7, 4, 0, 6, 5, 3, 1, 8, 2, 8, 1, 2, 7, 0, 3, 2, 0, 8, 6, 2, 4, 6, 6, 6, 0, 3, 6, 3, 0, 1, 2, 4, 5, 5, 0, 6, 7, 8, 3, 5, 5, 1, 4, 7, 7, 2, 8, 7, 5, 2 };
            int[] Number44 = new int[50] { 8, 4, 6, 8, 2, 0, 7, 3, 6, 2, 5, 6, 8, 0, 5, 6, 5, 1, 0, 6, 3, 0, 5, 1, 5, 3, 1, 7, 8, 7, 4, 7, 6, 6, 2, 7, 6, 6, 3, 8, 7, 3, 2, 0, 8, 8, 2, 4, 1, 1 };
            int[] Number45 = new int[50] { 5, 6, 7, 8, 7, 8, 8, 5, 3, 8, 8, 8, 4, 7, 6, 7, 0, 1, 7, 7, 8, 8, 7, 1, 7, 8, 7, 4, 1, 6, 1, 6, 5, 6, 1, 7, 0, 7, 8, 2, 7, 1, 3, 4, 8, 8, 8, 3, 3, 1 };
            int[] Number46 = new int[50] { 7, 0, 5, 2, 2, 6, 7, 5, 1, 7, 0, 3, 4, 5, 6, 1, 2, 6, 6, 8, 7, 2, 1, 4, 8, 6, 4, 3, 1, 8, 0, 3, 0, 8, 7, 0, 0, 2, 4, 4, 8, 3, 5, 1, 1, 4, 5, 6, 6, 6 };
            int[] Number47 = new int[50] { 5, 2, 6, 4, 2, 5, 8, 0, 3, 4, 2, 4, 4, 2, 7, 6, 3, 4, 7, 6, 1, 8, 2, 1, 8, 4, 5, 0, 2, 4, 1, 7, 5, 3, 2, 7, 5, 5, 6, 1, 0, 8, 8, 8, 2, 3, 8, 3, 3, 4 };
            int[] Number48 = new int[50] { 0, 1, 8, 8, 5, 5, 8, 4, 4, 7, 0, 7, 7, 7, 3, 3, 8, 0, 8, 8, 1, 6, 7, 5, 5, 1, 8, 2, 8, 5, 4, 2, 6, 7, 4, 8, 7, 6, 6, 6, 7, 0, 0, 7, 1, 2, 1, 1, 5, 7 };
            int[] Number49 = new int[50] { 4, 7, 4, 3, 2, 2, 2, 2, 2, 4, 5, 6, 4, 8, 2, 7, 1, 8, 3, 3, 5, 2, 2, 1, 1, 0, 6, 8, 4, 3, 8, 7, 5, 1, 0, 6, 7, 2, 4, 1, 6, 4, 3, 2, 0, 0, 4, 1, 5, 3 };
            int[] Number50 = new int[50] { 0, 1, 7, 2, 1, 2, 4, 2, 2, 2, 5, 3, 7, 8, 4, 7, 0, 3, 7, 5, 8, 8, 4, 2, 6, 0, 7, 0, 1, 0, 5, 4, 2, 0, 3, 6, 8, 3, 0, 7, 1, 5, 0, 2, 4, 2, 5, 3, 6, 2 };
            int[] Number51 = new int[50] { 8, 1, 2, 0, 3, 1, 6, 5, 4, 0, 3, 4, 1, 1, 6, 1, 0, 6, 4, 6, 7, 6, 2, 0, 3, 3, 7, 2, 7, 3, 3, 3, 2, 7, 0, 3, 1, 2, 6, 2, 0, 3, 7, 8, 3, 5, 3, 8, 4, 2 };
            int[] Number52 = new int[50] { 2, 8, 8, 8, 3, 2, 7, 2, 5, 8, 2, 4, 7, 1, 5, 8, 2, 2, 0, 2, 8, 6, 0, 2, 6, 4, 8, 3, 5, 7, 8, 8, 6, 4, 1, 4, 4, 2, 4, 7, 4, 8, 6, 6, 8, 4, 5, 6, 2, 4 };
            int[] Number53 = new int[50] { 3, 1, 7, 2, 3, 4, 7, 6, 2, 8, 2, 4, 6, 7, 8, 3, 7, 3, 8, 0, 4, 8, 7, 2, 6, 0, 0, 2, 2, 1, 8, 2, 0, 1, 3, 7, 0, 4, 0, 6, 5, 7, 0, 5, 4, 0, 1, 7, 6, 5 };
            int[] Number54 = new int[50] { 6, 1, 6, 1, 8, 3, 3, 4, 4, 2, 3, 5, 3, 0, 8, 0, 3, 4, 3, 1, 2, 2, 2, 1, 4, 5, 8, 2, 7, 6, 7, 2, 4, 6, 3, 6, 4, 7, 1, 8, 4, 5, 0, 7, 3, 0, 4, 8, 5, 3 };
            int[] Number55 = new int[50] { 5, 6, 4, 5, 2, 4, 8, 4, 6, 3, 4, 1, 5, 6, 4, 1, 1, 6, 6, 2, 5, 4, 3, 3, 6, 6, 2, 4, 7, 4, 1, 0, 5, 4, 0, 1, 6, 8, 3, 8, 6, 0, 1, 7, 4, 2, 8, 2, 2, 2 };
            int[] Number56 = new int[50] { 8, 6, 2, 3, 7, 0, 2, 0, 7, 5, 1, 4, 6, 2, 1, 4, 4, 1, 5, 3, 3, 1, 2, 6, 4, 5, 3, 4, 8, 3, 6, 8, 1, 5, 4, 3, 7, 1, 5, 0, 7, 6, 0, 7, 7, 1, 3, 7, 5, 0 };
            int[] Number57 = new int[50] { 7, 6, 5, 8, 8, 6, 4, 4, 8, 2, 5, 7, 1, 4, 8, 1, 3, 0, 6, 6, 5, 2, 4, 5, 4, 6, 1, 4, 8, 2, 2, 5, 7, 8, 5, 8, 2, 1, 6, 7, 8, 2, 2, 3, 3, 0, 4, 5, 7, 5 };
            int[] Number58 = new int[50] { 7, 2, 1, 8, 3, 4, 2, 0, 3, 1, 4, 8, 5, 5, 0, 0, 8, 2, 7, 8, 7, 1, 3, 7, 7, 3, 0, 1, 2, 4, 1, 5, 5, 2, 4, 8, 3, 8, 5, 0, 6, 2, 6, 4, 3, 8, 5, 6, 3, 2 };
            int[] Number59 = new int[50] { 1, 2, 6, 7, 7, 5, 7, 2, 0, 8, 4, 0, 7, 8, 0, 8, 3, 3, 1, 0, 5, 8, 6, 7, 2, 5, 3, 8, 4, 7, 6, 2, 6, 8, 3, 7, 8, 6, 4, 7, 1, 1, 8, 5, 5, 5, 4, 7, 3, 3 };
            int[] Number60 = new int[50] { 5, 2, 4, 3, 5, 1, 5, 8, 5, 2, 1, 8, 6, 1, 2, 1, 3, 7, 4, 1, 0, 5, 8, 2, 8, 4, 0, 0, 1, 5, 0, 5, 4, 0, 2, 3, 6, 2, 3, 1, 2, 8, 1, 2, 5, 1, 3, 6, 3, 3 };
            int[] Number61 = new int[50] { 2, 5, 2, 2, 3, 8, 3, 2, 4, 1, 1, 4, 6, 8, 1, 5, 4, 5, 8, 7, 3, 0, 3, 3, 7, 0, 4, 5, 6, 6, 0, 2, 6, 6, 3, 3, 2, 2, 5, 2, 8, 4, 7, 2, 0, 7, 2, 1, 0, 8 };
            int[] Number62 = new int[50] { 6, 7, 7, 4, 0, 1, 1, 8, 3, 3, 4, 6, 5, 6, 0, 8, 6, 8, 5, 6, 2, 1, 0, 5, 7, 7, 1, 1, 3, 0, 6, 2, 4, 6, 0, 2, 4, 2, 6, 1, 1, 3, 7, 2, 7, 2, 8, 0, 1, 1 };
            int[] Number63 = new int[50] { 1, 2, 5, 3, 5, 4, 6, 2, 5, 1, 8, 0, 5, 3, 6, 1, 1, 8, 6, 7, 3, 3, 2, 3, 4, 8, 3, 6, 6, 5, 8, 1, 0, 1, 8, 4, 6, 1, 0, 4, 4, 1, 5, 4, 1, 1, 6, 4, 5, 5 };
            int[] Number64 = new int[50] { 0, 0, 3, 2, 6, 6, 8, 1, 7, 6, 1, 0, 4, 0, 2, 7, 8, 3, 3, 1, 4, 0, 8, 1, 3, 1, 7, 6, 1, 2, 2, 7, 1, 1, 5, 7, 7, 6, 4, 2, 4, 5, 2, 2, 3, 4, 6, 5, 2, 3 };
            int[] Number65 = new int[50] { 2, 3, 0, 3, 1, 8, 1, 1, 8, 4, 7, 2, 8, 5, 4, 2, 7, 3, 3, 3, 0, 1, 7, 1, 6, 8, 7, 5, 6, 7, 4, 1, 4, 7, 0, 7, 7, 7, 0, 6, 6, 5, 7, 0, 3, 2, 5, 6, 7, 1 };
            int[] Number66 = new int[50] { 6, 2, 1, 8, 2, 0, 4, 7, 5, 1, 1, 5, 3, 0, 8, 5, 6, 0, 4, 5, 3, 8, 3, 6, 5, 4, 3, 7, 7, 4, 2, 0, 6, 5, 1, 2, 8, 4, 5, 0, 3, 8, 2, 7, 4, 1, 1, 6, 0, 6 };
            int[] Number67 = new int[50] { 4, 5, 2, 2, 6, 6, 8, 4, 2, 7, 5, 5, 0, 0, 8, 0, 7, 7, 7, 6, 6, 2, 4, 3, 1, 4, 5, 4, 1, 4, 2, 6, 6, 0, 0, 6, 7, 3, 7, 3, 2, 4, 2, 7, 4, 6, 8, 1, 7, 4 };
            int[] Number68 = new int[50] { 2, 3, 7, 3, 0, 2, 1, 8, 1, 2, 1, 3, 2, 7, 4, 7, 7, 8, 0, 2, 2, 4, 8, 3, 3, 1, 8, 5, 7, 3, 4, 3, 5, 6, 1, 7, 7, 3, 0, 7, 5, 8, 2, 4, 2, 7, 1, 3, 2, 5 };
            int[] Number69 = new int[50] { 7, 8, 1, 5, 2, 7, 3, 3, 8, 7, 2, 4, 0, 6, 6, 6, 6, 5, 6, 6, 8, 4, 8, 1, 5, 2, 1, 3, 1, 4, 8, 5, 3, 1, 4, 5, 1, 0, 3, 2, 4, 4, 3, 1, 5, 0, 8, 5, 7, 5 };
            int[] Number70 = new int[50] { 0, 5, 5, 5, 5, 3, 0, 0, 8, 8, 6, 8, 2, 4, 7, 5, 0, 7, 1, 1, 4, 6, 1, 4, 2, 4, 1, 6, 4, 5, 3, 5, 5, 4, 3, 3, 8, 7, 4, 1, 4, 1, 0, 4, 5, 4, 1, 8, 2, 0 };
            int[] Number71 = new int[50] { 0, 0, 3, 5, 1, 3, 3, 1, 2, 1, 1, 2, 4, 3, 4, 1, 3, 6, 0, 4, 5, 2, 2, 0, 6, 2, 6, 6, 8, 7, 2, 2, 4, 4, 5, 3, 1, 0, 3, 0, 0, 7, 4, 3, 0, 2, 6, 5, 8, 4 };
            int[] Number72 = new int[50] { 0, 4, 8, 7, 3, 6, 6, 3, 8, 7, 5, 6, 2, 4, 7, 8, 7, 8, 7, 1, 8, 2, 2, 8, 3, 7, 6, 8, 8, 3, 5, 0, 6, 3, 6, 7, 3, 5, 1, 7, 5, 7, 1, 5, 4, 2, 4, 0, 5, 1 };
            int[] Number73 = new int[50] { 3, 6, 6, 6, 4, 7, 1, 8, 3, 4, 0, 7, 3, 4, 1, 4, 8, 7, 7, 8, 4, 1, 6, 0, 5, 0, 1, 6, 4, 1, 3, 6, 2, 7, 8, 7, 3, 0, 8, 7, 6, 3, 2, 5, 6, 6, 4, 6, 4, 8 };
            int[] Number74 = new int[50] { 2, 5, 1, 5, 5, 2, 8, 6, 0, 4, 6, 3, 4, 2, 1, 2, 5, 4, 4, 2, 1, 8, 8, 8, 1, 1, 7, 1, 2, 8, 5, 3, 2, 4, 7, 6, 4, 5, 2, 6, 8, 5, 8, 4, 1, 3, 8, 0, 3, 4 };
            int[] Number75 = new int[50] { 1, 8, 2, 1, 6, 3, 6, 2, 4, 4, 4, 7, 4, 1, 7, 2, 1, 8, 3, 4, 7, 8, 2, 6, 3, 5, 0, 4, 6, 7, 1, 6, 6, 7, 7, 5, 1, 0, 7, 4, 8, 2, 1, 7, 1, 0, 1, 6, 5, 8 };
            int[] Number76 = new int[50] { 1, 8, 6, 8, 6, 1, 6, 4, 6, 1, 2, 2, 4, 5, 2, 6, 0, 5, 3, 1, 0, 0, 1, 8, 4, 4, 6, 3, 5, 3, 3, 2, 7, 7, 5, 2, 0, 7, 1, 5, 8, 6, 3, 6, 1, 6, 7, 5, 4, 4 };
            int[] Number77 = new int[50] { 8, 4, 3, 4, 7, 1, 7, 6, 3, 1, 4, 2, 8, 3, 6, 8, 3, 5, 8, 0, 5, 2, 4, 7, 2, 2, 6, 3, 6, 6, 5, 1, 8, 0, 3, 8, 8, 3, 8, 4, 3, 2, 4, 8, 1, 5, 7, 8, 8, 2 };
            int[] Number78 = new int[50] { 3, 2, 5, 4, 8, 6, 8, 4, 1, 4, 4, 3, 0, 5, 5, 2, 3, 7, 0, 6, 8, 8, 5, 3, 5, 2, 6, 5, 5, 5, 4, 6, 4, 4, 3, 3, 5, 4, 1, 6, 8, 3, 1, 3, 0, 8, 2, 7, 2, 7 };
            int[] Number79 = new int[50] { 2, 8, 8, 1, 2, 3, 5, 1, 7, 5, 8, 3, 8, 5, 0, 6, 8, 5, 2, 1, 6, 7, 6, 2, 6, 4, 7, 2, 3, 6, 0, 7, 2, 7, 3, 4, 6, 2, 2, 8, 7, 3, 6, 5, 6, 5, 4, 5, 3, 3 };
            int[] Number80 = new int[50] { 0, 6, 5, 1, 0, 3, 2, 5, 4, 6, 5, 3, 7, 1, 5, 0, 0, 0, 2, 4, 8, 6, 3, 2, 3, 3, 1, 1, 5, 1, 8, 2, 7, 8, 5, 2, 2, 1, 6, 8, 1, 1, 7, 4, 3, 4, 4, 5, 8, 5 };
            int[] Number81 = new int[50] { 5, 4, 3, 7, 3, 3, 3, 3, 6, 6, 2, 1, 0, 2, 6, 3, 4, 7, 4, 2, 7, 8, 3, 2, 2, 7, 7, 7, 7, 8, 7, 5, 1, 8, 4, 4, 7, 0, 5, 2, 8, 7, 3, 8, 6, 0, 0, 4, 6, 0 };
            int[] Number82 = new int[50] { 8, 6, 0, 6, 7, 6, 0, 0, 4, 5, 4, 4, 4, 7, 8, 5, 0, 1, 7, 2, 4, 4, 2, 2, 2, 8, 4, 3, 5, 2, 7, 3, 0, 7, 8, 0, 4, 4, 1, 7, 3, 7, 4, 0, 6, 4, 2, 5, 8, 0 };
            int[] Number83 = new int[50] { 8, 8, 6, 4, 5, 4, 4, 7, 3, 7, 1, 6, 3, 1, 6, 0, 3, 6, 7, 8, 0, 5, 8, 8, 7, 5, 8, 1, 4, 7, 6, 7, 4, 5, 3, 7, 6, 5, 1, 3, 5, 6, 0, 2, 5, 6, 4, 3, 2, 6 };
            int[] Number84 = new int[50] { 0, 5, 7, 0, 8, 3, 8, 6, 5, 8, 5, 2, 2, 5, 1, 3, 2, 6, 7, 8, 3, 7, 4, 3, 2, 3, 4, 6, 2, 1, 1, 5, 8, 7, 6, 1, 0, 3, 6, 0, 8, 0, 8, 1, 7, 3, 3, 4, 1, 2 };
            int[] Number85 = new int[50] { 4, 6, 4, 2, 3, 2, 0, 3, 7, 4, 7, 2, 3, 4, 7, 0, 2, 4, 7, 0, 2, 7, 0, 7, 0, 3, 7, 3, 5, 8, 8, 0, 4, 0, 6, 4, 0, 5, 4, 4, 0, 6, 5, 1, 1, 5, 5, 3, 3, 7 };
            int[] Number86 = new int[50] { 0, 7, 5, 1, 0, 5, 5, 6, 2, 8, 3, 6, 6, 8, 5, 6, 6, 3, 7, 2, 8, 5, 0, 3, 8, 5, 2, 8, 5, 3, 6, 3, 8, 7, 7, 0, 3, 2, 0, 0, 8, 3, 3, 4, 0, 3, 8, 6, 4, 4 };
            int[] Number87 = new int[50] { 7, 2, 5, 0, 8, 4, 6, 2, 2, 4, 2, 6, 1, 7, 2, 8, 6, 8, 0, 4, 2, 3, 3, 7, 3, 5, 2, 5, 2, 4, 5, 5, 3, 1, 4, 4, 7, 8, 8, 2, 2, 1, 0, 4, 6, 1, 2, 4, 1, 0 };
            int[] Number88 = new int[50] { 6, 8, 5, 0, 1, 3, 7, 6, 5, 2, 2, 1, 8, 6, 7, 6, 2, 8, 3, 6, 0, 7, 0, 7, 1, 1, 3, 7, 0, 1, 3, 6, 4, 2, 6, 5, 0, 3, 0, 0, 5, 1, 2, 5, 0, 1, 1, 2, 6, 0 };
            int[] Number89 = new int[50] { 8, 2, 1, 3, 8, 8, 8, 7, 7, 8, 0, 0, 6, 3, 8, 4, 6, 6, 8, 2, 6, 8, 8, 2, 1, 8, 4, 4, 6, 8, 0, 0, 0, 0, 2, 0, 5, 0, 2, 7, 6, 1, 4, 0, 0, 4, 3, 7, 5, 5 };
            int[] Number90 = new int[50] { 4, 3, 2, 4, 3, 8, 2, 8, 2, 8, 3, 4, 0, 7, 7, 0, 8, 6, 1, 8, 8, 5, 3, 1, 5, 4, 4, 7, 2, 5, 5, 6, 7, 1, 3, 5, 6, 5, 6, 3, 6, 5, 6, 3, 4, 1, 0, 5, 1, 8 };
            int[] Number91 = new int[50] { 5, 6, 6, 6, 5, 7, 0, 1, 8, 7, 3, 3, 6, 5, 3, 5, 5, 8, 3, 2, 2, 2, 0, 6, 1, 2, 8, 8, 5, 3, 3, 8, 6, 2, 0, 8, 0, 1, 4, 5, 5, 4, 6, 7, 8, 3, 8, 0, 0, 7 };
            int[] Number92 = new int[50] { 5, 1, 1, 8, 5, 2, 5, 8, 5, 2, 8, 0, 4, 4, 4, 4, 6, 3, 5, 4, 5, 4, 4, 7, 6, 6, 5, 2, 7, 7, 3, 7, 8, 7, 7, 2, 6, 6, 5, 6, 2, 1, 4, 1, 5, 4, 8, 2, 2, 3 };
            int[] Number93 = new int[50] { 5, 4, 4, 5, 2, 0, 5, 2, 2, 8, 6, 3, 0, 7, 8, 1, 0, 6, 6, 2, 7, 8, 7, 7, 2, 3, 8, 2, 2, 1, 7, 3, 8, 3, 1, 7, 2, 3, 4, 6, 5, 4, 4, 6, 0, 7, 0, 6, 2, 3 };
            int[] Number94 = new int[50] { 3, 2, 4, 0, 5, 5, 6, 5, 3, 7, 1, 3, 8, 0, 0, 3, 4, 5, 5, 0, 7, 6, 2, 0, 6, 3, 3, 0, 7, 3, 2, 1, 0, 7, 7, 4, 7, 7, 7, 4, 1, 6, 0, 5, 4, 1, 4, 4, 5, 6 };
            int[] Number95 = new int[50] { 2, 4, 1, 1, 5, 6, 8, 4, 3, 2, 2, 5, 7, 8, 5, 8, 2, 0, 2, 5, 4, 5, 6, 0, 8, 1, 6, 5, 4, 4, 7, 8, 4, 0, 1, 7, 0, 8, 2, 0, 4, 3, 4, 5, 2, 4, 7, 1, 0, 4 };
            int[] Number96 = new int[50] { 8, 3, 2, 0, 1, 5, 6, 0, 1, 4, 0, 3, 8, 7, 3, 3, 1, 7, 7, 6, 8, 3, 7, 1, 0, 0, 1, 1, 7, 4, 2, 4, 5, 8, 5, 4, 5, 3, 7, 4, 1, 0, 6, 7, 0, 1, 4, 5, 2, 8 };
            int[] Number97 = new int[50] { 2, 0, 3, 2, 5, 4, 4, 0, 0, 0, 4, 5, 2, 6, 1, 4, 6, 8, 2, 7, 6, 6, 8, 2, 5, 8, 6, 0, 1, 7, 5, 4, 7, 8, 1, 2, 1, 2, 3, 0, 8, 4, 3, 7, 0, 4, 7, 0, 6, 5 };
            int[] Number98 = new int[50] { 3, 4, 2, 3, 1, 5, 1, 0, 6, 6, 7, 4, 8, 1, 4, 8, 6, 2, 4, 7, 2, 4, 5, 2, 8, 1, 3, 1, 2, 0, 1, 5, 2, 4, 3, 0, 1, 4, 6, 5, 1, 1, 5, 5, 1, 3, 5, 1, 2, 0 };
            int[] Number99 = new int[50] { 7, 4, 5, 7, 2, 8, 8, 0, 4, 0, 2, 0, 7, 5, 5, 2, 1, 3, 6, 3, 6, 2, 5, 7, 6, 1, 8, 8, 0, 4, 5, 1, 7, 2, 2, 5, 0, 4, 2, 4, 1, 1, 8, 6, 3, 1, 3, 8, 0, 8 };

            int[] resultNumber = new int[50];
            int temp = 0;

            for (int i = Number0.Length - 1; i >= 0; i--)
            {
                resultNumber[i] = Number0[i] + Number1[i] + Number2[i] + Number3[i] + Number4[i] + Number5[i] + Number6[i] + Number7[i] + Number8[i] + Number9[i] +
                    Number10[i] + Number11[i] + Number12[i] + Number13[i] + Number14[i] + Number15[i] + Number16[i] + Number17[i] + Number18[i] + Number19[i] +
                    Number20[i] + Number21[i] + Number22[i] + Number23[i] + Number24[i] + Number25[i] + Number26[i] + Number27[i] + Number28[i] + Number29[i] +
                    Number30[i] + Number31[i] + Number32[i] + Number33[i] + Number34[i] + Number35[i] + Number36[i] + Number37[i] + Number38[i] + Number39[i] +
                    Number40[i] + Number41[i] + Number42[i] + Number43[i] + Number44[i] + Number45[i] + Number46[i] + Number47[i] + Number48[i] + Number49[i] +
                    Number50[i] + Number51[i] + Number52[i] + Number53[i] + Number54[i] + Number55[i] + Number56[i] + Number57[i] + Number58[i] + Number59[i] +
                    Number60[i] + Number61[i] + Number62[i] + Number63[i] + Number64[i] + Number65[i] + Number66[i] + Number67[i] + Number68[i] + Number69[i] +
                    Number70[i] + Number71[i] + Number72[i] + Number73[i] + Number74[i] + Number75[i] + Number76[i] + Number77[i] + Number78[i] + Number79[i] +
                    Number80[i] + Number81[i] + Number82[i] + Number83[i] + Number84[i] + Number85[i] + Number86[i] + Number87[i] + Number88[i] + Number89[i] +
                    Number90[i] + Number91[i] + Number92[i] + Number93[i] + Number94[i] + Number95[i] + Number96[i] + Number97[i] + Number98[i] + Number99[i] + temp;

                if (resultNumber[i] > 9 && i != 0)
                {
                    temp = Convert.ToInt32(resultNumber[i].ToString().Substring(0, resultNumber[i].ToString().Length - 1));
                    resultNumber[i] = Convert.ToInt32(resultNumber[i].ToString().Remove(0, resultNumber[i].ToString().Length - 1));
                }
                else
                    temp = 0;
            }

            Console.WriteLine("\n========================================================");
            Console.WriteLine("Resultant number after addition without using Numerics:   ");
            Console.WriteLine("========================================================\n");
            foreach (int i in resultNumber)
                Console.Write(i);

            Console.ReadKey();
        }
    }
}

