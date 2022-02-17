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

/*
  Based on UnityEngine.UI/UI/Core/ColorBlock.cs
*/

using System;

using UnityEngine;

namespace BinaryCharm.UI.TextColorButtons
{
    [Serializable]
    public struct TextColorBlock : IEquatable<TextColorBlock>
    {
        [SerializeField]
        private Color m_TextNormalColor;

        [SerializeField]
        private Color m_TextHighlightedColor;

        [SerializeField]
        private Color m_TextPressedColor;

        [SerializeField]
        private Color m_TextSelectedColor;

        [SerializeField]
        private Color m_TextDisabledColor;

        [Range(1, 5)]
        [SerializeField]
        private float m_TextColorMultiplier;

        [SerializeField]
        private float m_TextFadeDuration;

        public Color textNormalColor { get { return m_TextNormalColor; } set { m_TextNormalColor = value; } }
        public Color textHighlightedColor { get { return m_TextHighlightedColor; } set { m_TextHighlightedColor = value; } }
        public Color textPressedColor { get { return m_TextPressedColor; } set { m_TextPressedColor = value; } }
        public Color textSelectedColor { get { return m_TextSelectedColor; } set { m_TextSelectedColor = value; } }
        public Color textDisabledColor { get { return m_TextDisabledColor; } set { m_TextDisabledColor = value; } }
        public float textColorMultiplier { get { return m_TextColorMultiplier; } set { m_TextColorMultiplier = value; } }
        public float textFadeDuration { get { return m_TextFadeDuration; } set { m_TextFadeDuration = value; } }

        public static TextColorBlock defaultColorBlock {
            get {
                var c = new TextColorBlock {
                    m_TextNormalColor = new Color32(0, 0, 0, 255),
                    m_TextHighlightedColor = new Color32(5, 5, 5, 255),
                    m_TextPressedColor = new Color32(55, 55, 55, 255),
                    m_TextSelectedColor = new Color32(10, 10, 10, 255),
                    m_TextDisabledColor = new Color32(55, 55, 55, 128),
                    m_TextColorMultiplier = 1.0f,
                    m_TextFadeDuration = 0.1f
                };
                return c;
            }
        }

        public override bool Equals(object obj) {
            if (!(obj is TextColorBlock))
                return false;

            return Equals((TextColorBlock)obj);
        }

        public bool Equals(TextColorBlock other) {
            return textNormalColor == other.textNormalColor &&
                textHighlightedColor == other.textHighlightedColor &&
                textPressedColor == other.textPressedColor &&
                textSelectedColor == other.textSelectedColor &&
                textDisabledColor == other.textDisabledColor &&
                textColorMultiplier == other.textColorMultiplier &&
                textFadeDuration == other.textFadeDuration;
        }

        public static bool operator ==(TextColorBlock b1, TextColorBlock b2) {
            return b1.Equals(b2);
        }

        public static bool operator !=(TextColorBlock b1, TextColorBlock b2) {
            return !b1.Equals(b2);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}