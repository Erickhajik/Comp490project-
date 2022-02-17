/*
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             Copyright (C) 2021 Binary Charm - All Rights Reserved
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             @@@@@                  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             @@@@@@                        @@@@@@@@@@@@@@@@@@@@@@@
             @@@@@@@@                           @@@@@@@@@@@@@@@@@@
             @@@@@@@@@   @@@@@@@@@@@  @@@@@        @@@@@@@@@@@@@@@
             @@@@@@@@@@@  @@@@@@@@@  @@@@@@@@@@       (@@@@@@@@@@@
             @@@@@@@@@@@@  @@@@@@@@& @@@@@@@@@@ @@@@     @@@@@@@@@
             @@@@@@@@@@@@@ @@@@@@@@@@ *@@@@@@@ @@@@@@@@@*   @@@@@@
             @@@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@@@@@@@@@@@@@@@@@
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*/

using UnityEngine;

namespace BinaryCharm.UI.TextColorButtons.Extensions
{
    public static class TextColorButtonExtensions
    {
        public static void setTextColorFadeDuration(this ITextColorButton rB, float fFadeDuration) {
            TextColorBlock cb = rB.textColors;
            cb.textFadeDuration = fFadeDuration;
            rB.textColors = cb;
        }

        public static void setTextColorMultiplier(this ITextColorButton rB, float fColorMultiplier) {
            TextColorBlock cb = rB.textColors;
            cb.textColorMultiplier = fColorMultiplier;
            rB.textColors = cb;
        }

        public static void setNormalTextColor(this ITextColorButton rB, Color c) {
            TextColorBlock cb = rB.textColors;
            cb.textNormalColor = c;
            rB.textColors = cb;
        }

        public static void setHighlightedTextColor(this ITextColorButton rB, Color c) {
            TextColorBlock cb = rB.textColors;
            cb.textHighlightedColor = c;
            rB.textColors = cb;
        }

        public static void setPressedTextColor(this ITextColorButton rB, Color c) {
            TextColorBlock cb = rB.textColors;
            cb.textPressedColor = c;
            rB.textColors = cb;
        }

#if UNITY_2019_1_OR_NEWER
        public static void setSelectedTextColor(this ITextColorButton rB, Color c) {
            TextColorBlock cb = rB.textColors;
            cb.textSelectedColor = c;
            rB.textColors = cb;
        }
#endif
    }
}