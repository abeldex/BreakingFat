   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  5   	   G1clr-namespace:Dragablz.Dockablz;assembly=DragablzDragablz.Dockablz  5	   	    
SistemaGym   SistemaGym.nuevo_cliente   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullX	 TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  	 5   	   9dragablz(clr-namespace:Dragablz;assembly=Dragablz  	 5   	   Bdockablz1clr-namespace:Dragablz.Dockablz;assembly=Dragablz  	 5	   	     � Title$  Registro de Clientes��5   	   $��511.783��6&   $	��790��67    � WindowStyle$
 None=�6D    � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�6m    � 	Resources 5       �� MergedDictionaries�� 5   
    5   
   %    5      .��5         Dragablz.Dockablz.Layout  .��5   
      Dragablz.TabablzControl  $��0q�6"   $��0,-1,0,1q�66      InterTabController 5      !   Dragablz.InterTabController  5      -   5          Name$
 tabs��5   /   .@�5      �� -   5         ��Name$ tab_info��5   4   $��Información Personal��6   .��5      � .+�5      �� $��Datos Personales��6   $
��Left=�69   $	��376��6T   $��	10,10,0,0q�6a   $	��Top=�6t   $	��378��6�   �� 5      $��Información Importante��6   $
��Left=�6?   $	��376��6Z   $��
400,10,0,0q�6g   $	��Top=�6{   $	��378��6�   �� 5      -   5        	 ��Name$	 txt_nom_new��5   �    %  !MaterialDesignFloatingHintTextBox#��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��
20 50 20 0q�6�   $	��350��6�   .��6�   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint
 5       �� 5!       �� Orientation$ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5"   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6:   �� 5#   "   Nombre Completo6=   5$      .��5%   :   5&      �� 5(      -   5        $	 txt_tel_new��5(   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��
20 95 20 0q�6�   $	��350��6�   .��6�   
 5)      �� 5*      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5+   "     $ Phone=�6:   �� 5,   "   
Telefono66   5-      .��5.   :   5/      �� 51      -   5        $	 txt_dir_new��51   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��20 120 20 0q�6�   $	��350��6�    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6�    �� 	IsEnabled . $��60��52   2   .��6>   
 53      �� 54      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�55   "     $ 	MapMarker=�6:   �� 56   "   
Dirección67   57      .��58   :   59      �� 5;      -   5        $	 txt_correo_new��5;   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��20 190 20 0q�6�   $	��350��6�   .��6�   
 5<      �� 5=      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5>   "     $ Email=�6:   �� 5?   "   Correo Electrónico6@   5@      .��5A   :   5B      �� 5D      -   5         ��Name$ txt_sex_new��5D   �    & "MaterialDesignFloatingHintComboBox#��[ 6   $
��Left=�6\   $	��Top=�6w   $��20 235 20 0q�6�   $	��350��6�   
 5E      �� 5F      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5G   "     $ GenderMaleFemale=�6:   �� 5H   "   Sexo62   5I      .@�5K      �� 
 � Tag$ 	Masculino��6'   .��67   	Masculino6B   �� 5L      $ Femenino��6'   .��66   
Femenino6@   5M      (  "System.Windows.Controls.DatePicker  5O      -   5          Name$ txt_nac_new��5O   �   $	��350��6!    ( $MaterialDesignFloatingHintDatePicker#��[ 6-   $
��Left=�6k   $	��Top=�6�   $��20 300 20 0q�6�   
 5P      �� 5Q      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5R   "     $
 Cake=�6:   �� 5S   "   Fecha de Nacimiento6D   5T      5V      �� 5Y      -	   5         ��Name$ btn_aceptar��5Y      $��	Siguiente��62   $��Right=�6F   $��36��6b   $��Bottom=�6n   $	��140��6�   $��	0 0 10 10q�6�   �� 5[      -
   5        $	 txt_altura_new��5[   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��420 50 20 0q�6�   $	��140��6�   .��6�   
 5\      �� 5]      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5^   "     $ ArrowUpBold=�6:   �� 5_   "   Altura64   5`      .��5a   :   5b      �� 5c      -   5        $	 txt_peso_new��5c   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��590 50 20 0q�6�   $	��140��6�   .��6�   
 5d      �� 5e      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5f   "     $ Weight=�6:   �� 5g   "   Peso62   5h      .��5i   :   5j      �� 5k      -   5        $	 txt_cuello_new��5k   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��420 95 20 0q�6�   $	��140��6�   .��6�   
 5l      �� 5m      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5n   "     $ HumanHandsdown=�6:   �� 5o   "   Cuello64   5p      .��5q   :   5r      �� 5s      -   5        $	 txt_torax_new��5s   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��420 140 20 0q�6�   $	��140��6�   .��6�   
 5t      �� 5u      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5v   "     $ HumanHandsdown=�6:   �� 5w   "   Torax63   5x      .��5y   :   5z      �� 5{      -   5        $	 txt_brazo_new��5{   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��590 95 20 0q�6�   $	��140��6�   .��6�   
 5|      �� 5}      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5~   "     $ HumanHandsdown=�6:   �� 5   "   Brazo63   5�      .��5�   :   5�      �� 5�      -   5        $	 txt_cintura_new��5�   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��590 140 20 0q�6�   $	��140��6�   .��6�   
 5�      �� 5�      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5�   "     $ HumanHandsdown=�6:   �� 5�   "   	Cintura65   5�      .��5�   :   5�      �� 5�      -   5        $	 txt_cadera_new��5�   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��420 190 20 0q�6�   $	��140��6�   .��6�   
 5�      �� 5�      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5�   "     $ HumanHandsdown=�6:   �� 5�   "   Cadera64   5�      .��5�   :   5�      �� 5�      -   5        $	 txt_pierna_new��5�   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��590 190 20 0q�6�   $	��140��6�   .��6�   
 5�      �� 5�      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5�   "     $ HumanHandsdown=�6:   �� 5�   "   Pierna64   5�      .��5�   :   5�      �� 5�      -   5        $	 txt_pantorrilla_new��5�   �   #��[  6   $�� ��6Y   $
��Left=�6b   $	��Top=�6}   $��420 240 20 0q�6�   $	��140��6�   .��6�   
 5�      �� 5�      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5�   "     $ HumanHandsdown=�6:   �� 5�   "   Pantorrilla69   5�      .��5�   :   5�      5�      5�      �� 5�      -   5        $ 
tab_huella��5�   &   $��Huella��6   .��5�      �� -   5        $ btn_asignar_huella��5�   -     MaterialDesignFlatButton#���  5�      $��Center=�6L   $	��500��5�   j   $	��200��6v   .��5�      �� $ 
Horizontal=�6!   .+�5�        $ Fingerprint=�62   $��50��6E   $��50��6P   �� 5�      $��8 0 0 0q�6$   $��Center=�65   $��30(�6P   Registrar Huella6p   5�      5�      5�      �� 5�      -   5        $ tab_membresia��5�   *   $��
 Membresia��6   .��5�      � $��16q�6   $	��Top=�6#   5�      5�      5�      5�      5�      