   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	       SistemaGym.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;controls,http://metro.mahapps.com/winfx/xaml/controls  5
   	     � Title$  SysGym��5   	   $	��720��6   $
��1280��6%      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�69    � WindowState$ 	Maximized=�6^    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Shadows.xaml?�6%   �� 5      $l fpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ToggleButton.xaml?�6%   %    5      .��5      )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��6    	   SnackbarMessageQueue	 68   �� 
 �� ElementName$
 MainSnackbar�� �� Path$ MessageQueue�.��5   
   )  #MaterialDesignThemes.Wpf.DrawerHost     IsLeftDrawerOpen 6$   �� $
 MenuToggleButton��$ 	IsChecked�   LeftDrawerContent 5       ]� 5!      $	��212��6   .+�5"      �� -   5         ��Name$
 logo��5"      $	��200��6*   $��Uniform=�67   $��0 10 0 0q�6I   $	��Top=�6[   $��Center=�6p   �� 5(      -   5         ��Name$ MenuListBox��5(      $��	0 16 0 16q�63    �� SelectedIndex$ 0��6F   .@�5)      �� -   5        .��5*      ��  �� Orientation$ 
Horizontal=�6)   .+�5+   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Face=�6:   $��32��6F   $��32��6Q     AccentColorBrush#���  6]   $��	18 15 0 0q�6�   �� 5,   "   $��	20 15 0 0q�6,   $
��Bold"�6?   #���  6Q   $��CharacterEllipsis=�6�   $��18(�6�   
Clientes6�   5-      5.      �� 5/      -   5        .��50      �� $ 
Horizontal=�6)   .+�51   "     $ Ticket=�6:   $��32��6H   $��32��6S   $��Center=�6_   $��Center=�6z   $��	18 15 0 0q�6�   #���  6�   �� 52   "   $��	20 15 0 0q�6,   $
��Bold"�6?   $��Center=�6Q   $��Center=�6l   #���  6�   $��CharacterEllipsis=�6�   $��18(�6�   
Membresias6�   53      54      �� 55      -   5        .��56      �� $ 
Horizontal=�6)   .+�57   "     $ Fingerprint=�6:   $��32��6M   $��32��6X   $��Center=�6d   $��Center=�6   #���  6�   $��	18 15 0 0q�6�   �� 58   "   $��	20 15 0 0q�6,   $
��Bold"�6?   $��Center=�6Q   $��Center=�6l   #���  6�   $��CharacterEllipsis=�6�   $��18(�6�   
Checador6�   59      5:      �� 5;      -   5        .��5<      �� $ 
Horizontal=�6)   .+�5=   "     $
 Coin=�6:   $��32��6F   $��32��6Q   $��Center=�6]   $��Center=�6x   #���  6�   $��	18 15 0 0q�6�   �� 5>   "   $��	20 15 0 0q�6,   $
��Bold"�6?   $��Center=�6Q   $��Center=�6l   #���  6�   $��CharacterEllipsis=�6�   $��18(�6�   Ventas6�   5?      5@      �� 5A      -   5        .��5B      �� $ 
Horizontal=�6)   .+�5C   "     $ Adjust=�6:   $��32��6H   $��32��6S   $��Center=�6_   $��Center=�6z   #���  6�   $��	18 15 0 0q�6�   �� 5D   "   $��	20 15 0 0q�6,   $
��Bold"�6?   $��Center=�6Q   $��Center=�6l   #���  6�   $��CharacterEllipsis=�6�   $��18(�6�   Configuracion6�   5E      5F      �� 5G      5I      5J      .��5L      ]� .+�5M      (  "MaterialDesignThemes.Wpf.ColorZone  $��16q�6+   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�68      Mode$ 
PrimaryMid=�5N   -   $	��Top=�6?      CornerRadius$ 3��6T   .��5O      ]� .+�5P      d� -   5         d�Name$ MenuToggleButton��5Q   )    ' #MaterialDesignHamburgerToggleButton#��[ 5P   '    d� 	IsChecked$ FalseY�6d   5Q   )   '  !MaterialDesignThemes.Wpf.PopupBox  5R      $��Right=�62      PlacementMode$ BottomAndAlignRightEdges=�6I      	StaysOpen .     PopupContent. 5S      �� .+�5U   "   �� -	   5        $��Salir del Sistema��5U   )   6E   5V      5W      �� 5X      -
   5         ��Name$ 
txt_titulo��5X   $   $��Center=�68   $��Center=�6U   $��22(�6p   $��Titulo��6~   6�   5Y      5Z      � 5[      ��5\      �� 5]      -   5        	wallpaper�� j� TileMode$
 Tile=�5]   9    j� Stretch$ UniformToFill=�6I    � RowDefinitions 5_      �� 5`      $
��Auto �6(   �� 5a      $��* �6(   .+�5c       � -   5          �Name$
 Main��5c         � NavigationUIVisibility$  Hidden=�6*   '	  !MaterialDesignThemes.Wpf.Snackbar	  5k      -   5        ! 	 Name$! MainSnackbar��5k   [   $��1��5l   -   " 	  MessageQueue" 5k   .   4
  .MaterialDesignThemes.Wpf.MessageQueueExtension
  5l   -   5m      5n      5o      5p      5q      