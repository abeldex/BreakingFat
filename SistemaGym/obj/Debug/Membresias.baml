   M S B A M L   `   `   `  ����E  ASistemaGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SistemaGym
SistemaGym  5   	       SistemaGym.Membresias   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SistemaGym     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  Registrar Membresias��5	   	   $	��500��6&   $	��750��63    � WindowStartupLocation$ CenterScreen=�6?    � WindowStyle$
 None=�6d    � 
ResizeMode$ NoResize=�6w    � 	Resources 5
       �� MergedDictionaries �� Source �� 
TargetType   MaterialDesignComboBox �� BasedOn	 �� Property
 �� Value�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Card.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Popupbox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   '��       7   �� 5      " ��6   8   .�5      �� 	 � ��$
 Stretch=�68   �� 5      	 � ��$
 0 8 0 8q�6+   5      5      .��5      � .+�5   
   �� $��0��6   $��Resumen de la Membresia��6      MaterialDesignGroupBox#���  6A   $��10,289,403,0q�6r   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6�   $��0q�6�   (  "MaterialDesignThemes.Wpf.ColorZone  5    
   $��20q�6#   $ Depth1=�60      Mode$
 Dark=�5!   -   $	��Top=�69   .��5"      ]� .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon  $
��Left=�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Ticket=�6@   $��24��6N   $��24��6Z   �� 5$      $��Center=�6   $��Center=�69   $��18(�6T   �� 6c   $�Registro de Membresias��6g   6�   5%      5&      �� 5'   
   -   5         ��Name$ 	btn_salir��5'       & "MaterialDesignFloatingActionButton#��[ 6$   $��	0,16,10,0q�5(      $��Right=�6,   $	��Top=�6H    � ToolTip$ 
Actualizar��5)      $��30��6.   $��30��6:   .��5*        $ 	ExitToApp=�6&   $��20��67   $��20��6C   
���������6a   Z� 5+      �� 5,   
   -   5        $ btn_guardar��5,      #��[ 6&   $��	0,16,50,0q�5-      $��Right=�6,   $	��Top=�6H   $ Guardar��5.      $��30��6+   $��30��67   
��� � ���6U   Z� .��5/        $ ContentSaveOutline=�6&   $��20��6@   $��20��6L   
���������6j   Z� 50      �� 51   
   -   5         ��Name$ PanelServicios��51       �� Orientation$ 
Horizontal=�6-   $��center=�6F   $	��120��6c   $	��750��6p   $	��Top=�6|   $��0 65 0 0q�6�   .+�53      	� $��Gimnasio��6   $��
180 80 0 0q�6-   $��Center=�6A   
 � Tag$	 Gym��6^   	� 54      $��Zumba��6   $��
100 80 0 0q�6*   $��Center=�6?   $ Zumba��6\   	� 55      $��Crossfit��6   $��
100 80 0 0q�6-   $ Crossfit��6A   56      �� 57   
   $��img/gym.png��6   $��166,0,0,279q�6%   $	��100��6:   $
��Left=�6F   �� 58   
   $��img/cross.png��6   $��515,0,0,279q�6'   $��60��6<   $
��Left=�6G   �� 59   
   $��img/zumba.png��6   $��350,0,0,279q�6'   $��60��6=   $
��Left=�6H   �� 5:   
   $ 
Horizontal=�6   $��center=�6.   $	��120��6K   $	��750��6X   $	��Top=�6d   $��
-4,65,-4,0q�6|   .+�5;      	� -   5         	�Name$ rb_gym��5;       	� 	GroupName$ servicio��6*   $��Gimnasio��6?   $��
180 80 0 0q�6R   $��Center=�6f    d� 	IsChecked$
 TrueY�6�    � Cursor$
 Hand��6�   	� 5<      -   5        $ rb_zumba��5<      $ servicio��6,   $��Zumba��6A   $��
100 80 0 0q�6Q   $��Center=�6f   $
 Hand��6�   	� 5=      -   5        $ rb_cross��5=      $ servicio��6,   $��Crossfit��6A   $��
100 80 0 0q�6T   $
 Hand��6h   5>      �� 5?   
   $ 
Horizontal=�6   $��center=�6.   $��85��6K   $	��750��6W   $	��Top=�6c   $��	0,185,0,0q�6{   .+�5A      	� -   5        $ 	rb_diario��5A      $ tiempo��6-   $��Diario��6@   $��
180 60 0 0q�6Q   $��Center=�6e   $
 TrueY�6�   $
 Hand��6�   6�   	� 5B      -   5        $ 	rb_semana��5B      $ tiempo��6-   $��Semanal��6@   $��
100 60 0 0q�6R   $��Center=�6g   $
 Hand��6�   	� 5C      -	   5        $ rb_mes��5C      $ tiempo��6*   $��Mensual��6=   $��
100 60 0 0q�6O   $
 Hand��6c   6q   5D        5E   
   $ CalendarClock=�6"   $��50��67   
��� E��$��166,190,0,0q�6q   $	��100��6�   $
��Left=�6�   ��6Z   Z� 6�     5F   
   $ CalendarRange=�6"   $��50��67   
��� E��$��325,190,0,0q�6q   $	��100��6�   $
��Left=�6�   ��6Z   Z� 6�     5G   
   $ CalendarMultiple=�6"   $��50��6:   
��� E��$��493,190,0,0q�6t   $	��100��6�   $
��Left=�6�   ��6]   Z� 6�   �� 5H   
   $
��Left=�6   $��86��6/   $��	0,135,0,0q�6;   $	��Top=�6N   $	��750��6f   �� 5I   
   $
��Left=�6   $��81��6/   $��	0,245,0,0q�6;   $	��Top=�6N   $	��750��6f   �� 5J   
   $��Fecha Inicial:��6   $
��Left=�6)   $��
13,340,0,0q�6D   $	��Top=�6X   �� 5K   
   $��Fecha Final:��6   $
��Left=�6'   $��
13,382,0,0q�6B   $	��Top=�6V   (  "System.Windows.Controls.DatePicker  5L   
   -
   5          Name$ date_inicio��5L      $
��Left=�6*   $��106,340,0,0q�6E   $	��Top=�6Z   $	��160��6r   6~     5M   
   -   5        $ date_fin��5M      $
��Left=�6'   $��106,382,0,0q�6B   $	��Top=�6W   $	��160��6o   �� 5N   
   $��0��6   $��Resumen de la Membresia��6    #���  6A   $��403,289,10,0q�6r   $ Depth2=�6�   $��0q�6�   �� 5O   
   $��Subtotal:     $��6   $
��Left=�6*   $��412,339,0,0q�6E   $	��Top=�6Z   $
��Bold"�6s   $��16(�6�   �� 5P   
   $��Descuento: $��6   $
��Left=�6'   $��412,381,0,0q�6B   $	��Top=�6W   $
��Bold"�6p   $��16(�6�   �� 5Q   
   $��Total:          $��6   $
��Left=�6,   $��412,423,0,0q�6G   $	��Top=�6\   $
��Bold"�6u   $��16(�6�   �� 5R   
   -   5         ��Name$ txt_subtotal��5R      $
��Left=�6(   $��31��6C   $��528,335,0,0q�6O    �� TextWrapping$
 Wrap=�6d    �� TextAlignment$ Center=�6x   $�� ��6�   $	��Top=�6�   $	��159��6�    J� RenderTransformOrigin$ 1.375,-6&�6�   {�.  $
��Bold"�6�   $��16(�6   6  �� 5S   
   -   5        $ txt_descuento��5S      $
��Left=�6)   $��39��6D   $��527,367,0,0q�6P   $
 Wrap=�6e   $ Center=�6y   $�� ��6�   $	��Top=�6�   $	��160��6�   $ 1.375,-6&�6�   $
��Bold"�6  $��16(�6  �� 5T   
   -   5        $ 	txt_total��5T      $
��Left=�6%   $��38��6@   $��526,411,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $ Center=�6}   $	��Top=�6�   $	��161��6�   $ 1.375,-6&�6�   {�.  $
��Bold"�6�   $��16(�6�   6  5V      5W      