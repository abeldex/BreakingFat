   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaGym.ventasSistemaGym.ventas  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5	   	   G1clr-namespace:Dragablz.Dockablz;assembly=DragablzDragablz.Dockablz 5
   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs 5   	   H DShowMeTheXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAMLShowMeTheXAML 5   	   !    SistemaGym.ventas.AbrirCaja   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaGym.ventas     5   	   ;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   V	 RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX
 TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	   9dragablz(clr-namespace:Dragablz;assembly=Dragablz 	 
 5	   	   Bdockablz1clr-namespace:Dragablz.Dockablz;assembly=Dragablz 	 
 5
   	   SdialogsCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro 	 
 5   	   ?smtx2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML 	 
 5   	   =wpf1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5   	   $	��192��5      $	��340��6     � WindowStartupLocation$  CenterScreen=�6    � WindowStyle$ 
ToolWindow=�6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $��55 �6   �� 5      $��297.333 �6   �� 5      $��31.333 �6    � RowDefinitions 5   
   �� 5      $��51 �6   �� 5      $��53.333 �6   �� 5      $��69.333 �6   .+�5   
   ' 	 !MaterialDesignThemes.Wpf.PackIcon  � 	 �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ SquareIncCash=�6"   $��0��67   $��0��6G   $��Center=�6T   $��Center=�6q   $��40��6�   $��40��6�   $��7,5,7.667,5.667q�6�   �� 5   
   $��1��6   $��0��6$   $��Center=�61   $��Center=�6L   $��20(�6i   $
��Bold"�6w   $��27��6�   $��7.333,12,74,11.667q�6�   $	��216��6�   Comenzar nuevo turno6�   �� 5   
   $��1��6   $��1��6"    %  !MaterialDesignFloatingHintTextBox#��[  6/   $�� ��6j   $��Center=�6r   $��Center=�6�   $��16(�6�   $	��276��6�   .��6�   ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint 5      �� 5       �� Orientation$ 
Horizontal=�6   $��0 0 0 0q�66   .+�5       �� ¿ Efectivo Inicial en Caja ?6>   5!      .��5"   .   5#      �� 5$   
   $��1��6   $��2��6!   $��Center=�6.   $
��Left=�6I   $��0.333,16,0,21.333q�6d   $	��246��6   .��5%      �� $ 
Horizontal=�6   .+�5&        $ Close=�6*   $��0 0 8 0q�67   6J   �� 5'      " Registrar dinero inicial en caja6>   5(      5)      5*      5+      