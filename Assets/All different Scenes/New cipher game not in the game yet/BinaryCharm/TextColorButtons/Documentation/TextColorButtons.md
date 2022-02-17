```
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
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
```

# Public API Reference #
________________________________________________________________________________

## namespace: `BinaryCharm.TextColorButtons` ##
________________________________________________________________________________

### class: `TextColorButton` ###

* Class extending `Button` to allow changing the label color similarly to the
  target graphics color.
  To work properly, the label should be a `UnityEngine.UI.Text` component.
  Access the `textColors` property to set the colors, similarly to how you 
  access `colors` to set the target graphics colors.

### class: `TMP_TextColorButton` ###

* Class extending `Button` to allow changing the label color similarly to the
  target graphics color.
  To work properly, the label should be a `TMPro.TMP_Text` component.
  Access the `textColors` property to set the colors, similarly to how you 
  access `colors` to set the target graphics colors.

### interface: `ITextColorButton` ###

* Interface useful to handle interchangeably `TextColorButton` and 
 `TMP_TextColorButton` instances.
________________________________________________________________________________

## namespace: `BinaryCharm.TextColorButtons.Extensions` ##
________________________________________________________________________________

### class: `ButtonExtensions` ###

* Static class providing extension methods to easily modify a single value of
  the `colors` property.
  Refer to the Unity documentation about `ColorBlock` and `Button` to 
  understand the details.

* `public static void setGfxColorFadeDuration(this Button rB, float fSecs)`
* `public static void setGfxColorMultiplier(this Button rB, float fMult)`
* `public static void setNormalGfxColor(this Button rB, Color c)`
* `public static void setHighlightedGfxColor(this Button rB, Color c)`
* `public static void setPressedGfxColor(this Button rB, Color c)`
* `public static void setSelectedGfxColor(this Button rB, Color c)`
* `public static void setDisabledGfxColor(this Button rB, Color c)`


### class: `TextColorButtonExtensions` ###

* Static class providing extension methods to easily modify a single value of
  the `textColors` property`, which is a `TextColorBlock`.
  This mirrors the `colors` property of standard buttons, which is a
  `ColorBlock`.
  Refer to the Unity documentation about `ColorBlock` and `Button` to 
  understand the details.

  The methods are defined for `ITextColorButton`, which allows you to call
  them on both `TextColorButton` and `TMP_TextColorButton` instances.

* `public static void setTextColorFadeDuration(this ITextColorButton rB, 
     float fSecs)`
* `public static void setTextColorMultiplier(this ITextColorButton rB,
     float fMult)`
* `public static void setNormalTextColor(this ITextColorButton rB, 
     Color c)`
* `public static void setHighlightedTextColor(this ITextColorButton rB, 
     Color c)`
* `public static void setPressedTextColor(this ITextColorButton rB, 
     Color c)`
* `public static void setSelectedTextColor(this ITextColorButton rB, 
     Color c)`
* `public static void setDisabledGfxColor(this ITextColorButton rB, 
     Color c)`
________________________________________________________________________________