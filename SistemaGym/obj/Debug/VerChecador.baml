   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	       SistemaGym.VerChecador   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  AsignarHuella��5	   	   $	��667��6   $	��900��6,    � WindowStyle$
 None=�69    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5
       �� MergedDictionaries �� Source �� 
TargetType   MaterialDesignComboBox �� BasedOn �� Property	 �� Value�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Card.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Popupbox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   '��       7   �� 5      " ��6   8   .�5      ��  � ��$	 Stretch=�68   �� 5       � ��$	 0 8 0 8q�6+   5      5      .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��20q�6#   +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth1=�60      Mode$
 Dark=�5    -   $	��Top=�69   .��5!      ]� .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon  $
��Left=�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Fingerprint=�6@   $��24��6S   $��24��6_   �� 5#      $��Center=�6   $��Center=�69   $��18(�6T   �� 6c   $�CHECADOR��6g   6z   5$      5%      �� 5(   
   -   5         ��Name$ 
txt_buscar��5(      $
��Left=�6&   $��30��6A    �� TextWrapping$
 Wrap=�6M   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Buscar��6a   
�������$	��Top=�6�   $	��238��6�   $��	80,18,0,0q�6�   $��16(�6�   
�������6�   �� 5)   
   -   5         ��Name$ 	btn_salir��5)       & "MaterialDesignFloatingActionButton#��[ 6$   $��0,5,10,0q�5*      $��Right=�6+   $	��Top=�6G    � ToolTip$ Salir��5+      $��48��6)   $��48��65   .��5,        $ 	ExitToApp=�6&   $��24��67   $��24��6C   
���������6a   Z� 5.      �� 5/   
   -   5        $ btn_checador��5/      #��[ 6'   $��0,5,80,0q�50      $��Right=�6+   $	��Top=�6G   $ Abrir Checador��51      $��48��62   $��48��6>   
��� � ���6\   Z� .��52        $
 Plus=�6&   $��24��62   $��24��6>   
���������6\   Z� 54      #  MaterialDesignThemes.Wpf.Card  58   
   $	��Top=�6   $	��586��66   $	��873��6C   $��5,43,0,0q�6O   $��10q�6a   $
��Left=�6n   .��59      � $��0,0,-0.2,82q�6   .+�5:      ��    MaterialDesignTitleTextBlock#���  6   $
��Left=�6S   $	��Top=�6n   Registros del Checador6�   &   System.Windows.Controls.DataGrid  5<      -   5          Name$ dg_checadas��5<         
IsReadOnly . $��0,45,43,-48.6q�6B      AutoGenerateColumns .     CanUserSortColumns .  $��Arial)�6�   $��13(�6�      EnableRowVirtualization .  ���	#89C1C1C1$��Stretch=�6�   $��Stretch=�6  $	��444��61  $	��Top=�6>     Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ CLIENTE��6-    	  
IsReadOnly . 1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6>   �� *nombre+6Y     5B      $ FECHA��6-    .  6<   �� *fecha+6V     5C      $ HORA CHECADA��6-    .  6C   �� *HoraEntrada+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5D      $ Acciones��61    	  Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6C      CellTemplate 5E      �� 5F   "   .R�5G   &   � .+�5J   *   �� $ btn_eliminar��6�   #��[ 61   $��20��6m   $��20��6y   
���  ��$��10 0 0 0q�6�   ��6�   Z� ��6�   ��  �� Path$ id_membresia�.��5K   .     $ Delete=�6F   $��16��6T   $��16��6`   5L   +   5N   '   5O   #   5Q      5S      5T      5V      �� 5W   
   -   5        $ btn_actualizar��5W      #��[ 6)   $��	0,5,150,0q�5X      $��Right=�6    $	��Top=�6<   $ 
Actualizar��5Y      $��48��6"   $��48��6.   
���������6h   Z� .��5Z        $
 Sync=�6&   $��24��62   $��24��6>   
���������6\   Z� 5\      5_      5`      