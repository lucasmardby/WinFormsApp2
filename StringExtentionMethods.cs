﻿namespace WinFormsApp2
{
    public static class StringExtentionMethods
    {
        public static bool IsNotNullOrEmpty(this string text)
        { 
            return !string.IsNullOrEmpty(text);
        }
    }
}
