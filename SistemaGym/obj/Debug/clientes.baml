   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	       SistemaGym.clientes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;controls,http://metro.mahapps.com/winfx/xaml/controls  5	   	     � Title$   Administracion de Clientes��5
   	   $	��680��6,   $	��820��69    � WindowStartupLocation$ CenterScreen=�6E    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType   MaterialDesignComboBox �� BasedOn �� Property �� Value�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Card.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Popupbox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   '��       7   �� 5      " ��6   8   .�5      ��  � ��$ Stretch=�68   �� 5       � ��$ 0 8 0 8q�6+   5      5      .��5      � .+�5    
   #  MaterialDesignThemes.Wpf.Card  $y�Hidden=�6   $	��Top=�62   $	��735��6J   $	��250��6W   $��	0,43,10,0q�6c   $��10q�6v   $��Right=�6�   .��5!      �� .+�5"      ��    MaterialDesignTitleTextBlock#���  6   �� 6T   $�Nuevo Cliente��6X   6p   �� 5#      -   5        	 ��Name$	 
txt_nombre��5#      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 NOMBRE��6.   $��Center=�6V   $��30��6s   $��0q�6    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��205��6�   $	��Top=�6�   �� 5$      -   5        $	 txt_telefono��5$      $
 TELEFONO��60   $��Center=�6Z   $��30��6w   $��0,20,0,0q�6�   $	��205��6�   $	��Top=�6�   �� 5%      -   5        $	 
txt_correo��5%      $
 CORREO��6.   $��Center=�6V   $��30��6s   $��0,20,0,0q�6   $	��205��6�   $	��Top=�6�   �� 5&      -   5        $	 
txt_ciudad��5&      $
 CIUDAD��6.   $��Center=�6V   $��30��6s   $��0,20,0,0q�6   $	��205��6�   $	��Top=�6�   �� 5'      -   5        $	 txt_direccion��5'      $
 	DIRECCION��61   $��Center=�6\   $��30��6y   $��0,20,0,0q�6�   $	��205��6�   $	��Top=�6�   �� 5(      -   5         ��Name$ cmb_sexo��5(      
������� � Cursor$
 Hand��6@   $

 SEXO��6O   $��30��6u   $��0,20,0,0q�6�   $	��Top=�6�   $	��205��6�   .@�5)      �� $��Femenino��6#   
 � Tag$ Femenino��66   �� 5*      $��	Masculino��6#   $ 	Masculino��67   5+      �� 5-      -   5         ��Name$ btn_guardar��5-      $��	Registrar��6.   $	��205��6B   $��0,35,0,0q�6O   
��� � �$	��Top=�6t   ��6�   Z� 6�   �� 5.      -   5        $ btn_cancelar��5.      $��Cancelar��6/   $	��205��6B   $	��Top=�6N   $��0,10,0,0q�6g   
��� �����6�   Z� 6�   �� 5/      -	   5        $ btn_actualizar��5/      $��
Actualizar��61   $y�Hidden=�6F   $	��205��6Z   $��7.5,35,7.5,0q�6g   
��� � �$	��Top=�6�   ��6�   Z� 6�   50      52      (  "MaterialDesignThemes.Wpf.ColorZone  54   
      Mode$ 
PrimaryMid=�6#   $��16q�65   .��56      ]� .+�57      '  !MaterialDesignThemes.Wpf.PackIcon  $
��Left=�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Face=�6@   $��30��6L   $��30��6X   $��Center=�6c   �� 59       �� Orientation$ 
Horizontal=�6   +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5?        $ Standard=�6/   $��8 4 8 4q�6?      CornerRadius$ 2��6Q    K� ZIndex$ 1��6b   $��16 0 0 0q�5A   $   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5C   $   .��5E      �  � ColumnDefinitions 5G      �� 5I   "   $
��Auto �63   �� 5K   "   $��* �63   �� 5M   "   $
��Auto �63   .+�5Q      ��   MaterialDesignToolButton#���  6%   .��5S   "     $ Magnify=�6:    J� Opacity$	 .56Q�6I   5U      �� 5W      -
   5        $	 
txt_buscar��5W   &   $��1��6:   $��8 0 0 0q�6J   $
 Buscar��6[   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5Y   &   $��0q�6c   $	��200��5[   &   $��Center=�65   6Q   �� 5]      #���  6%   $��2��6X   5a      5c      5e      �� 5g       & "MaterialDesignToolForegroundButton#���  6   $��8 0 0 0q�6Z   $ 0��6k   5k      5n      5p      5r        5u   
   $	��Top=�6   $	��586��66   $	��800��6C   $��5,43,0,0q�6O   $��10q�6a   $
��Left=�6n   .��5v      � $��0,0,-0.2,82q�6   .+�5w      �� #���  6   $
��Left=�6S   $	��Top=�6n   �� 6�   $�Clientes Registrados��6�   6�   �� 5x      -   5         ��Name$ dg_clientes��5x       � IsSharedSizeScope . $��10,32,-9.8,-32q�6R   ��5z      �� 5|      .R�5~      ��  ��Name$ Border��6%   $
 Hand��65    �� Padding$ 10q�6C   $��0 0 0 1q�6P     MaterialDesignDivider#���  6j   ._�5�   "   �  5�   &   .+�5�   &   �� $��8 0 0 0q�61   $��1��6B   .+�5�   *   �� $
��Bold"�64   ��6F   �� *NOMBRE+�� 5�   *   ��64   �� *
TELEFONO+�� 5�   *   ��64   �� *CORREO+'	  !MaterialDesignThemes.Wpf.PopupBox	  5�   *    	  PlacementMode$ BottomAndAlignRightEdges=�6B    	  	StaysOpen .  $��Right=�6}   $	��Top=�6�   $��	0 -40 0 0q�6�     	  PopupContent.  5�   .   �� .+�5�   2   �� $ 
btn_perfil��6P   -   5        $��
Ver Perfil��5�   �   ��69   Z� ��6d   �� *COD+6�   �� 5�   2   $ btn_eliminar��6c   -   5        
���  ��$��Eliminar��5�   �   ��6L   Z� ��6y   �� *COD+6�   5�   /   5�   +   5�   '   5�   #   5�      ! �� Triggers! 5�      �� 5�   "   " �� Value$
" True��6M   # �� Binding# 6.   �� *
IsSelected+5�   #   5�      5�      &
   System.Windows.Controls.DataGrid
  5�      -   5        $ 
 Name$$ dg_clientes1��5�   /   $y�Hidden=�6   % 
  
IsReadOnly% . $��10,212,0.2,-227q�6W   & 
  AutoGenerateColumns& .  ' 
  CanUserSortColumns' .  $��Arial)�6�   $��13(�6�   ( 
  EnableRowVirtualization( .  ���	#89C1C1C1$��Stretch=�6   $��Stretch=�6%  $	��456��6H  $	��Top=�6U  ) � ContextMenu) 5�      �� 5�      .@�5�      m� $��Editar��6'   
��� � �* m� Icon* 5�   "     5�   &   $ Pencil=�6>   $��16��6L   $��16��6X   
��� � �6c   5�      �� 5�      m� 5�      $��Eliminar��6(   
���  ��* 5�   "     5�   &   $ Delete=�6>   $��16��6L   $��16��6X   
���  ��6c   5�      m� 5�      $��Huella��6(   
���  ��* 5�   "     5�   &   $ Fingerprint=�6>   $��16��6Q   $��16��6]   
�������6h   5�      5�      + 
  Columns+ 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn,   Header$	, COD��6-   -   
IsReadOnly- . 1  +System.Windows.Controls.DataGridBoundColumn.   Binding. 6:   �� *COD+6R     5�      $, NOMBRE��6-   - . . 6=   �� *NOMBRE+6X     5�      $, TELEFONO��6-   - . . 6?   �� *
TELEFONO+6\     5�      $, CORREO��6-   - . . 6=   �� *CORREO+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $, Acciones��61   /   Width5  /System.Windows.Controls.DataGridLengthConverter$	/ 150 6C   0   CellTemplate0 5�      �� 5�   "   .R�5�   &   � .+�5�   *   �� $ btn_membresia��6�   -   5         & "MaterialDesignFloatingActionButton#��[ 5�   1   $��20��6m   $��20��6y   
���� ��$��	10 0 10 0q�6�   ��6�   Z� ��6�   �� *COD+.��5�   .     $ Ticket=�6F   $��16��6T   $��16��6`   5�   +   �� 5�   *   $ 
btn_huella��6�   -   5        #��[ 5�   1   $��20��6m   $��20��6y   
���������6�   Z� ��6�   �� *COD+.��5�   .     $ Fingerprint=�6F   $��16��6Y   $��16��6e   5�   +   �� 5�   *   $ btn_eliminar��6�   -   5        #��[ 5�   1   $��20��6m   $��20��6y   
���  ��$��10 0 0 0q�6�   ��6�   Z� ��6�   �� *COD+.��5�   .     $ Delete=�6F   $��16��6T   $��16��6`   5�   +   �� 5�   *   $ btn_actualizar��6�   -   5        #��[ 5�   1   $��20��6m   $��20��6y   
����  �$��10 0 0 0q�6�   ��6�   Z� ��6�   �� *COD+.��5�   .     $ Pencil=�6F   $��16��6T   $��16��6`   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�   
   -   5        $ btn_imprimir��5�      #��[ 6'   $��0,5,23,0q�5�      $��Right=�6   $	��Top=�6;   1 � ToolTip$1 Imprimir��5�      $��48��6    $��48��6,   
���������6k   Z� .��5�        $ Printer=�6&   $��24��65   $��24��6A   
����� ���6_   Z� 5�      �� 5�   
   -   5        $ 	btn_nuevo��5�      #��[ 6$   $��0,5,85,0q�5�      $��Right=�6   $	��Top=�6;   $1 Nuevo��5�      $��48��6   $��48��6)   
���������6M   Z� .��5�        $
 Plus=�6&   $��24��62   $��24��6>   
����� ���6\   Z� 5�      5�      5�      