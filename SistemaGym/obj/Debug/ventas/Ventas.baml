   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5	   	   G1clr-namespace:Dragablz.Dockablz;assembly=DragablzDragablz.Dockablz 5
   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs 5   	   H DShowMeTheXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAMLShowMeTheXAML 5   	       SistemaGym.ventas.Ventas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   ;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   V	 RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX
 TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	   9dragablz(clr-namespace:Dragablz;assembly=Dragablz 	 
 5	   	   Bdockablz1clr-namespace:Dragablz.Dockablz;assembly=Dragablz 	 
 5
   	   SdialogsCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro 	 
 5   	   ?smtx2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML 	 
 5   	   =wpf1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	     � Title$  Ventas��5      $	��768��6   $
��1360��6    � WindowState$ 	Maximized=�6+    � WindowStyle$
 None=�6C    � ShowInTaskbar .  � WindowStartupLocation$ CenterOwner=�6k   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��110* �6   �� 5      $
��123* �6   �� 5      $
��123* �6   �� 5      $
��488* �6   �� 5      $
��244* �6   �� 5      $
��264* �6    � RowDefinitions 5   
   �� 5      $	��73* �6   �� 5      $	��478 �6   �� 5      $��0* �6   �� 5      $
��143* �6   �� 5      $	��66* �6   .+�5"   
   ( 	 "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��16q�65   $��72��6B   $��6��6N   .��5$      ]� .+�5%      ' 	 !MaterialDesignThemes.Wpf.PackIcon  $
��Left=�6*   � 	 �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Shopping=�6@   $��30��6P   $��30��6\   $��Center=�6g   �� 5'      	 �� Orientation$	 
Horizontal=�6   + 	 %MaterialDesignThemes.Wpf.RippleAssist
   
IsCentered
 . .+�5-        $ Light=�6/   $��8 4 8 4q�6<      CornerRadius$ 2��6N    K� ZIndex$ 1��6_   $��16 0 0 0q�5/   $   + 	 %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�51   $   .��53      �  55      �� 57   "   $
��Auto �63   �� 59   "   $��* �63   �� 5;   "   $
��Auto �63   .+�5?      ��    MaterialDesignToolButton#���   6%   .��5A   "     $ BarcodeScan=�6:    J� Opacity$	 .56Q�6M   5C      �� 5E      -   5         ��Name$ 
txt_buscar��5E   &   $��1��6:   $��8 0 0 0q�6J   ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint$ Código del Producto��6[   . 	 (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5G   &   $��0q�6c   $	��200��5I   &   $��Center=�65   5M      5O      �� 5P       & "MaterialDesignToolForegroundButton#���  6   $��8 0 0 0q�6Z   $ 0��6k   .��5Q      �� $	 
Horizontal=�6%   .+�5R        $ Check=�66   �� 5S      $��8 0 0 0q�6(   $��Center=�69   [Enter] Agregar Producto6n   5T      5U      �� 5W      -   5        $��btn_buscar_prod��5W      #���  6R   $��8 0 0 0q�6�   $ 0��6�   .��5X      �� $	 
Horizontal=�6%   .+�5Y        $ Magnify=�66   �� 5Z      $��8 0 0 0q�6(   $��Center=�69   [F10] Buscar6b   5[      5\      �� 5^      #���  6   $��8 0 0 0q�6Z   $ 0��6k   .��5_      �� $	 
Horizontal=�6%   .+�5`        $ CashMultiple=�66   �� 5a      $��8 0 0 0q�6(   $��Center=�69   [F7] Entradas6c   5b      5c      �� 5e      #���  6   $��8 0 0 0q�6Z   $ 0��6k   .��5f      �� $	 
Horizontal=�6%   .+�5g        $ CardsOutline=�66   �� 5h      $��8 0 0 0q�6(   $��Center=�69   [F8] Salidas6b   5i      5j      �� 5k      #���  6   $��8 0 0 0q�6Z   $ 0��6k   .��5l      �� $	 
Horizontal=�6%   .+�5m        $ DeleteForever=�66   �� 5n      $��8 0 0 0q�6(   $��Center=�69   [DEL] Borrar Articulo6k   5o      5p      5q      5s      5u      &   System.Windows.Controls.DataGrid  5v   
   -   5          Name$ gridCarroDeCompras��5v       � Cursor$ Arrow��6      
IsReadOnly .    RowHeaderWidth$ 0Q�65      GridLinesVisibility$
 None=�6H      AutoGenerateColumns .  ���#62666A$��0,0,0,0q�6�   
������ 
������ $��1��6�   $��3��6  $��6��6  $��Stretch=�6&  $��Stretch=�6B   � 	Resources 5w      =	  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '	        �� 5x      " 	 6   .�5y      ��  � ��
 �����63   �� 5z       � ��$ 0,0,2,5q�68   �� 5{       � �� �#E0E0E064   �� 5|       � ��$ 10,5,0,5q�60   �� 5}       � ��$ 0,0,0,15q�6/   5~      5         	CellStyle 5�      �� 5�      *
  $System.Windows.Controls.DataGridCell" 
 6   .�5�      ��  � ��$ 18(�61   �� 5�       � ��$ Normal"�63   �� 5�       � ��$ 0,0,0,0q�60   �� 5�       � �� 5�      �� 5�       �� 
TargetType" 
 6.   .R�5�   "   ��  �� Padding# z��6)   #��z��6M   #��z��6y   #��z��6�    J� SnapsToDevicePixels . ._�5�   &   �� # z 67   5�   #   5�      5�        �� Triggers  5�      P� 5�      ! P� Property! �@
 
IsSelected" P� Value" . . �5�      ��  � �� �#6AC4EA6;   �� 5�       � �� �#6AC4EA6<   5�      5�      #   Columns# 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn$   Header$$ Código de Barras��6@   %   Width5  /System.Windows.Controls.DataGridLengthConverter$	% 140 6Z   &   
IsReadOnly& . 1  +System.Windows.Controls.DataGridBoundColumn'   Binding' 6%   �� *Codigo+6f     5�      $$ Descripción del Producto��6@   $	% 400 6b   & . ' 6%   �� *Nombre+(   	CellStyle( 5�      �� 5�      " 
 6    .�5�      ��  � �� �#E1F3FB6;   �� 5�       � ��$ 18(�69   �� 5�       � ��$ Normal"�6;   �� 5�       � ��$ 
10,10,0,10q�68   �� 5�       � �� 5�   "   �� 5�   &   " 
 66   .R�5�   *   �� # z��61   #��z��6U   #��z��6�   #��z��6�    . ._�5�   .   �� # z 6?   5�   +   5�   '   5�        5�      P� 5�   "   ! �@
 
IsSelected" . . �5�   &   ��  � �� �#3AA0CC6C   �� 5�   &    � �� �#3AA0CC6D   5�   #   5�      5�        5�      $$ Cantidad��6B   $	% 140 6T   & . ' 6%   �� *
Cantidad+6`     5�      $$ Importe��6@   $	% 140 6Q   & . ' 6%   �� *Precio+6]     5�      $$ 
Existencia��6B   $	% 140 6V   & . ' 6%   �� *
SubTotal+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 5�      �� 5�      $��Eliminar��6$   ) �� Padding$) 0,0,20,0q�64   *   CellTemplate* 5�      �� 5�      .R�5�      �� ���#62666A$	����6:   
������ 
������ ��5�   "   �� 5�   &   " ��6,   .�5�   *   ��  � �� 5�   .   �� 5�   2   " ��6B   .R�5�   6   �� #��z��6=   ._�5�   :   �� $��Center=�6K   $��Center=�6h   5�   7   5�   3   5�   +   5�   '   5�      5�      5�      5�      �� 5�   
   $��Bottom=�6   $��Center=�6+   $��0��6H   $��3��6X   $��Total:��6e   
���   �
������ $
��Bold"�6�   $��16(�6�   $��31��6�   $
��30,0q�6�   $��50��6�   �� 5�   
   $	��Top=�6   $��Center=�6(   $��0��6E   $��4��6U   $��$0.00��6b   
����� �$��20(�6�   $��37��6�   $
��26,0q�6�   $��58��6�   �� 5�   
   $��Bottom=�6   $��Center=�6+   $��1��6H   $��3��6X   $��	Pago con:��6e   
���   �
������ $
��Bold"�6�   $��16(�6�   $��31��6�   $��	20,0,19,0q�6�   $��84��6�   �� 5�   
   $	��Top=�6   $��Center=�6(   $��1��6E   $��4��6U   $��$0.00��6b   
����� �$��20(�6�   $��37��6�   $
��33,0q�6�   $��57��6�   �� 5�   
   $��Bottom=�6   $��Center=�6+   $��2��6H   $��3��6X   $��Cambio:��6e   
���   �
������ $
��Bold"�6�   $��16(�6�   $��31��6�   $��	25,0,26,0q�6�   $��72��6�   �� 5�   
   $	��Top=�6   $��Center=�6(   $��2��6E   $��4��6U   $��$0.00��6b   
����� �$��20(�6�   $��37��6�   $
��33,0q�6�   $��57��6�   �� 5�   
   $��40��6   $��4��6   $��4��6-   $��Stretch=�6:   $	��Top=�6X   $
��14,0q�6p   .��5�      �� $	 
Horizontal=�6   .+�5�        $ Printer=�6*   �� 5�      $��8 0 0 0q�6   $��Center=�6-   Reimprimir Ultimo Ticket6b   5�      5�      �� 5�   
   $��40��6   $	��245��6   $��0,0,10,0q�6)   $��5��6;   $��4��6K   $��Right=�6X   $	��Top=�6t   .��5�      �� $	 
Horizontal=�6   .+�5�        $ Cash100=�6*   �� 5�      $��8 0 0 0q�6   $��Center=�6-   Ventas del día6X   5�      5�        5�   
   $ 
PrimaryMid=�6#   $��16q�65   $��72��6B   $��5��6N   $��3��6b   .��5�      ]� .+�5�        $
��Left=�6*   $ Shopping=�6@   $��30��6P   $��30��6\   $��Center=�6g   �� 5�      $	 
Horizontal=�6   
 . .+�5�      �� $��0��6    $ 0��6)   $��30(�6:   $��8 0 0 0q�6H   6[   �� 5�      $"��Productos en la venta actual��6    $��25(�6D   $��12 0 0 0q�6R   $��Center=�6d   6�   5�      5�      5�      �� 5   
   -   5        $��
btn_cobrar��5      
�������
����� �$��72��6H   $��8 0 0 0q�6T   $��4��6e   $��1��6u   $��3��6�   $��Stretch=�6�   $	��Top=�6�   .��5     �� $	 
Horizontal=�6   .+�5       $
 Coin=�6*   $��Center=�66   $��30��6Q   $��30��6]   �� 5     $��5 0 0 0q�6   $��Center=�6-   $��18(�6H   [F12] Cobrar6d   5     5     �� 5  
   $	��Top=�6   $��Center=�6,   $��5��6J   $��3��6Z   $��55(�6g   $��73��6u   $
��66,0q�6�   $	��132��6�   $0.006�   5     5	     