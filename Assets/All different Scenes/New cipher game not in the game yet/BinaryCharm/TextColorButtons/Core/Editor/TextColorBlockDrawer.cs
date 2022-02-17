﻿/*
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
  Based on UnityEditor.UI/UI/PropertyDrawers/ColorBlockDrawer.cs
*/

using UnityEngine;
using BinaryCharm.UI.TextColorButtons;

namespace UnityEditor.UI
{
    [CustomPropertyDrawer(typeof(TextColorBlock), true)]
    public class TextColorBlockDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect rect, SerializedProperty prop, GUIContent label) {
            Rect drawRect = rect;
            drawRect.height = EditorGUIUtility.singleLineHeight;

            SerializedProperty normalColor = prop.FindPropertyRelative("m_TextNormalColor");
            SerializedProperty highlighted = prop.FindPropertyRelative("m_TextHighlightedColor");
            SerializedProperty pressedColor = prop.FindPropertyRelative("m_TextPressedColor");
#if UNITY_2019_1_OR_NEWER
            SerializedProperty selectedColor = prop.FindPropertyRelative("m_TextSelectedColor");
#endif
            SerializedProperty disabledColor = prop.FindPropertyRelative("m_TextDisabledColor");
            SerializedProperty colorMultiplier = prop.FindPropertyRelative("m_TextColorMultiplier");
            SerializedProperty fadeDuration = prop.FindPropertyRelative("m_TextFadeDuration");

            EditorGUI.PropertyField(drawRect, normalColor);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(drawRect, highlighted);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(drawRect, pressedColor);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
#if UNITY_2019_1_OR_NEWER
            EditorGUI.PropertyField(drawRect, selectedColor);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
#endif
            EditorGUI.PropertyField(drawRect, disabledColor);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(drawRect, colorMultiplier);
            drawRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            EditorGUI.PropertyField(drawRect, fadeDuration);
        }

        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label) {
            const int iNUM_ITEMS =
#if UNITY_2019_1_OR_NEWER
                6
#else
                7
#endif
                ;

            return iNUM_ITEMS * EditorGUIUtility.singleLineHeight 
                + (iNUM_ITEMS-1) * EditorGUIUtility.standardVerticalSpacing;
        }
    }
}