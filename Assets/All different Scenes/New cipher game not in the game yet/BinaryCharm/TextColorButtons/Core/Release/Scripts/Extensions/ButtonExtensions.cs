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
using UnityEngine.UI;

namespace BinaryCharm.UI.TextColorButtons.Extensions
{
    public static class ButtonExtensions
    {
        public static void setGfxColorFadeDuration(this Button rB, float fFadeDuration) {
            ColorBlock cb = rB.colors;
            cb.fadeDuration = fFadeDuration;
            rB.colors = cb;
        }

        public static void setGfxColorMultiplier(this Button rB, float fColorMultiplier) {
            ColorBlock cb = rB.colors;
            cb.colorMultiplier = fColorMultiplier;
            rB.colors = cb;
        }

        public static void setNormalGfxColor(this Button rB, Color c) {
            ColorBlock cb = rB.colors;
            cb.normalColor = c;
            rB.colors = cb;
        }

        public static void setHighlightedGfxColor(this Button rB, Color c) {
            ColorBlock cb = rB.colors;
            cb.highlightedColor = c;
            rB.colors = cb;
        }

        public static void setPressedGfxColor(this Button rB, Color c) {
            ColorBlock cb = rB.colors;
            cb.pressedColor = c;
            rB.colors = cb;
        }
        public static void setDisabledGfxColor(this Button rB, Color c) {
            ColorBlock cb = rB.colors;
            cb.disabledColor = c;
            rB.colors = cb;
        }

#if UNITY_2019_1_OR_NEWER
        public static void setSelectedGfxColor(this Button rB, Color c) {
            ColorBlock cb = rB.colors;
            cb.selectedColor = c;
            rB.colors = cb;
        }
#endif
    }
}