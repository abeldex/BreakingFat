   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaGym.ventasSistemaGym.ventas  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5	   	   G1clr-namespace:Dragablz.Dockablz;assembly=DragablzDragablz.Dockablz 5
   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs 5   	   H DShowMeTheXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAMLShowMeTheXAML 5   	   !    SistemaGym.ventas.Productos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaGym.ventas     5   	   ;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   V	 RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX
 TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	   9dragablz(clr-namespace:Dragablz;assembly=Dragablz 	 
 5	   	   Bdockablz1clr-namespace:Dragablz.Dockablz;assembly=Dragablz 	 
 5
   	   SdialogsCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro 	 
 5   	   ?smtx2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML 	 
 5   	   =wpf1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	   $	��600��5      $
��1240��6   .��5      � .+�5   
     Dragablz.Dockablz.Layout  $��0��6   $��0,0,0,1.667q�6'   $��3��6<   .��5        Dragablz.TabablzControl  $��0q�6&   $��0 0 0 0q�6:       InterTabController  5      !  Dragablz.InterTabController  5      -   5          Name$
 tabs��5   3   .@�5      �� -   5         ��Name$ tab_prod��5   ,   $��PRODUCTO��6   .��5      �  � ColumnDefinitions 5      �� 5      $��80 �6/   �� 5      $	��200 �6/   �� 5      $	��350 �6/    � RowDefinitions 5      �� 5      $��55 �6,   �� 5       $��55 �6,   �� 5!      $��55 �6,   �� 5"      $��55 �6,   �� 5#      $��55 �6,   �� 5$      $��55 �6,   �� 5%      $��55 �6,   �� 5&      $��55 �6,   �� 5'      $��55 �6,   �� 5(      $��55 �6,   �� 5)      $��55 �6,   �� 5*      $��55 �6,   �� 5+      $��55 �6,   �� 5,      $��55 �6,   .+�5.      ' 	 !MaterialDesignThemes.Wpf.PackIcon  � 	 �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ BarcodeScan=�62   $��0��6E   $��1��6U   $��Center=�6b   $��Center=�6   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 5/      $��0��6$   $��2��64   $��0��6H   $��Center=�6U   $��Center=�6p   $��20(�6�   $
��Bold"�6�   DATOS DEL PRODUCTO6�   �� 50      $��1��6"   $��1��62    %  !MaterialDesignFloatingHintTextBox#��[  6?   $�� ��6z   $
��Left=�6�   $	��Top=�6�   $	��500��6�   .��6�   ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint 51      �� 52   "    �� Orientation$ 
Horizontal=�6-   $��0 0 0 0q�6F   .+�53   &   �� Código de Barras6B   54   #   .��55   >   56        57      $ NoteText=�62   $��0��6B   $��2��6R   $��Center=�6_   $��Center=�6|   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 58      $��1��6"   $��2��62   #��[  6?   $�� ��6z   $
��Left=�6�   $	��Top=�6�   $	��400��6�   .��6�    59      �� 5:   "   $ 
Horizontal=�6-   $��0 0 0 0q�6F   .+�5;   &   �� Descripción6=   5<   #   .��5=   >   5>        5?      $ FormatListBulletedType=�62   $��0��6P   $��3��6`   $��Center=�6m   $��Center=�6�   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 5@      $��1��6#   $��3��63    & "MaterialDesignFloatingHintComboBox#��[ 6@   $
��Left=�6}   $��Center=�6�   $	��500��6�    5A      �� 5B   "   $ 
Horizontal=�6-   .+�5C   &   �� Se vende Por6>   5D   #   .@�5F      �� 
 � Tag$ unidad��6+   .��68   
Unidad/Pza6D   �� 5G      $ granel��6+   .��68   A granel (Usa Decimales)6R   �� 5H      $
 pack��6+   .��66   Como paquete (kit)6J   5I        5J      $
 Cash=�62   $��0��6>   $��4��6N   $��Center=�6[   $��Center=�6x   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 5K      -   5        $��1��5K   P   $��4��6`   #��[  6m   $�� ��6�   $
��Left=�6�   $	��Top=�6�   $	��500��6�   .��6�    5L      �� 5M   "   $ 
Horizontal=�6-   $��0 0 0 0q�6F   .+�5N   &   �� Precio Costo6>   5O   #   .��5P   >   5Q        5R      $
 Coin=�62   $��0��6>   $��5��6N   $��Center=�6[   $��Center=�6x   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 5S      $��1��6"   $��5��62   #��[  6?   $�� ��6z   $
��Left=�6�   $	��Top=�6�   $	��500��6�   .��6�    5T      �� 5U   "   $ 
Horizontal=�6-   $��0 0 0 0q�6F   .+�5V   &   �� Precio Venta6>   5W   #   .��5X   >   5Y        5Z      $ WeightKilogram=�62   $��0��6H   $��6��6X   $��Center=�6e   $��Center=�6�   $��15��6�   $��15��6�   $��0 8 0 0q�6�   �� 5[      $��1��6#   $��6��63   #��[ 6@   $
��Left=�6}   $��Center=�6�   $	��500��6�    5\      �� 5]   "   $ 
Horizontal=�6-   .+�5^   &   �� Unidad de Medida6B   5_   #   .@�5a      �� $	 PZA��6+   .��65   Pieza6<   �� 5b      $ KG��6+   .��64   
Kilogramos6@   �� 5c      $ GR��6+   .��64   Gramos6<   �� 5d      $ LT��6+   .��64   Litros6<   5e      �� 5f      $��3��6$   $��0��64   $��Center=�6A   $��Center=�6\   $��20(�6y   $
��Bold"�6�   
INVENTARIO6�   �� 5g      $��3��6#   $��1��63   	 d� 	IsChecked$
	 TrueY�6@   $)��#Este Producto SI utiliza inventario��6Q   $��Center=�6   �� 5h      -   5        #��[  5h   "   $��3��6^   $��2��6n   $��Center=�6{   $��Center=�6�   $	��200��6�   .��6�    5i      �� 5j   "   $ 
Horizontal=�6-   .+�5k   &   ��  ¿Cuantos hay en este momento?6O   5l   #   .��5m   >   5n      �� 5o      -   5        #��[  5o   #   $��3��6^   $��3��6n   $��Center=�6{   $��Center=�6�   $	��200��6�   .��6�    5p      �� 5q   "   $ 
Horizontal=�6-   .+�5r   &   ��  Cantidad mínima en inventario6O   5s   #   .��5t   >   5u      �� 5v      $��2��6!   $��5��61   $��Center=�6>   $	��200��6Y   .��5x      �� $ 
Horizontal=�6)   .+�5y   "     $ Check=�6:   $��0 0 8 0q�6G   6Z   �� 5z   "   Guardar Producto6>   5{      5|      �� 5}      $��2��6!   $��6��61   $��Center=�6>   $	��200��6Y   
�������
���  ��.��5~      �� $ 
Horizontal=�6)   .+�5   "     $ Close=�6:   $��0 0 8 0q�6G   6Z   �� 5�   "   
Cancelar66   5�      5�      5�      5�      �� 5�      $��Precios��6   6-   5�      5�      5�      5�      