   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	   )    #SistemaGym.AdministracionMembresias   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � Title$"  Administracion de Membresias��5   	   $��667.2��6.   $��899.345��6=    � WindowStyle$
 None=�6M    � WindowStartupLocation$ CenterScreen=�6`    � 	Resources 5	       �� MergedDictionaries �� Source �� 
TargetType   MaterialDesignComboBox �� BasedOn �� Property	 �� Value�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Card.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Popupbox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   '��       7   �� 5      " ��6   8   .�5      ��  � ��$	 Stretch=�68   �� 5       � ��$	 0 8 0 8q�6+   5      5      .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��20q�6#   +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth1=�60      Mode$
 Dark=�5   -   $	��Top=�69   .��5      ]� .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  $
��Left=�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Ticket=�6@   $��24��6N   $��24��6Z   �� 5!      $��Center=�6   $��Center=�69   $��18(�6T   Administración de Membresias6�   5"      5#      �� 5%   
   -   5         ��Name$ 
txt_buscar��5%      $
��Left=�6&   $��30��6A    �� TextWrapping$
 Wrap=�6M   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Buscar��6a   
�������$	��Top=�6�   $	��160��6�   $��	80,18,0,0q�6�   $��16(�6�   
�������6�   �� 5&   
   -   5         ��Name$ 	btn_salir��5&       & "MaterialDesignFloatingActionButton#��[ 6$   $��0,5,10,0q�5'      $��Right=�6+   $	��Top=�6G    � ToolTip$ Salir��5(      $��48��6)   $��48��65   .��5)        $ 	ExitToApp=�6&   $��24��67   $��24��6C   
���������6a   Z� 5+      �� 5,   
   -   5        $ 	btn_nueva��5,      #��[ 6$   $��0,5,80,0q�5-      $��Right=�6+   $	��Top=�6G   $ Nueva Membresia��5.      $��48��63   $��48��6?   
��� � ���6u   Z� .��5/        $
 Plus=�6&   $��24��62   $��24��6>   
���������6\   Z� 51      #  MaterialDesignThemes.Wpf.Card  55   
   $	��Top=�6   $	��586��66   $	��873��6C   $��5,43,0,0q�6O   $��10q�6a   $
��Left=�6n   .��56      � $��0,0,-0.2,82q�6   .+�57      ��    MaterialDesignTitleTextBlock#���  6   $
��Left=�6S   $	��Top=�6n   Membresias Registradas6�   &   System.Windows.Controls.DataGrid  59      -   5          Name$ dg_membresias��59         
IsReadOnly . $��0,45,43,-48.6q�6D      AutoGenerateColumns .     CanUserSortColumns .  $��Arial)�6�   $��13(�6�      EnableRowVirtualization .  ���	#89C1C1C1$��Stretch=�6�   $��Stretch=�6  $	��444��63  $	��Top=�6@   � ContextMenu 5;      �� 5<      .@�5=      m� $��Eliminar��6(   
���  �� m� Icon 5>   "     5?   &   $ Delete=�6>   $��16��6L   $��16��6X   
���  ��6c   5A      m� 5B      $��Huella��6(   
���  �� 5C   "     5D   &   $ Fingerprint=�6>   $��16��6Q   $��16��6]   
�������6h   5F      5G         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ ID��6-    	  
IsReadOnly . 1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 69   �� *id_membresia+6Z     5M      $ CLIENTE��6-    .  6>   �� *nombre+6Y     5N      $
 TIPO��6-    .  6;   �� *tipo_membresia+6^     5O      $ INICIO��6-    .  6=   �� *fecha_inicial+6_     5P      $	 FIN��6-    .  6:   �� *fecha_final+6Z     5Q      $ COSTO��6-    .  6<   �� *costo+6V     5R      $ 	DESCUENTO��6-    .  6@   �� *	descuento+6^   4  .System.Windows.Controls.DataGridTemplateColumn  5S      $ Acciones��61    	  Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6C      CellTemplate 5T      �� 5U   "   .R�5V   &   � .+�5Y   *   �� $ btn_eliminar��6�   -   5        #��[ 5Y   1   $��20��6m   $��20��6y   
���  ��$��10 0 0 0q�6�   ��6�   Z� ��6�   ��  �� Path$ id_membresia�.��5Z   .     $ Delete=�6F   $��16��6T   $��16��6`   5[   +   5]   '   5^   #   5`      5b      5c      5e      �� 5f   
   -   5        $ btn_actualizar��5f      #��[ 6)   $��	0,5,150,0q�5g      $��Right=�6    $	��Top=�6<   $ 
Actualizar��5h      $��48��6"   $��48��6.   
���������6h   Z� .��5i        $
 Sync=�6&   $��24��62   $��24��6>   
���������6\   Z� 5k      �� 5l   
   -   5        $ btn_imprimir��5l      #��[ 6'   $��	0,5,217,0q�5m      $��Right=�6    $	��Top=�6<   $ Imprimir��5n      $��48��6    $��48��6,   
��� �����6g   Z� .��5o        $ Printer=�6&   $��24��65   $��24��6A   
���������6`   Z� 5q      5t      5u      