   M S B A M L   `   `   `  ���� E  ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  G1clr-namespace:Dragablz.Dockablz;assembly=DragablzDragablz.Dockablz   
SistemaGym   SistemaGym.nuevo_cliente   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;controls,http://metro.mahapps.com/winfx/xaml/controls  V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  7dragablz(clr-namespace:Dragablz;assembly=Dragablz  @dockablz1clr-namespace:Dragablz.Dockablz;assembly=Dragablz    � Title$  Registro de Clientes��$��511.783��$	��790�� � WindowStyle$
 None=� � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=� � 	Resources  �� MergedDictionaries��  %    .��   Dragablz.Dockablz.Layout  .��   Dragablz.TabablzControl  $��0q�$��0,-1,0,1q�   InterTabController !   Dragablz.InterTabController  -     Name$
 tabs��.@��� -    ��Name$ tab_info��$��Información Personal��.��� .+��� $��Datos Personales��$
��Left=�$	��376��$��	10,10,0,0q�$	��Top=�$	��378���� $��Información Importante��$
��Left=�$	��376��$��
400,10,0,0q�$	��Top=�$	��378���� -   	 ��Name$	 txt_nom_new�� %  !MaterialDesignFloatingHintTextBox#��[  $�� ��$
��Left=�$	��Top=�$��
20 50 20 0q�$	��350��.��)  #MaterialDesignThemes.Wpf.HintAssist
   Hint
 ��  �� Orientation$ 
Horizontal=�$��-2 0 0 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=��� Nombre Completo.���� -   $	 txt_tel_new��#��[  $�� ��$
��Left=�$	��Top=�$��
20 95 20 0q�$	��350��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Phone=��� 
Telefono.���� -   $	 txt_dir_new��#��[  $�� ��$
��Left=�$	��Top=�$��20 120 20 0q�$	��350�� �� TextWrapping$
 Wrap=� �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=� �� 	IsEnabled . $��60��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	MapMarker=��� 
Dirección.���� -   $	 txt_correo_new��#��[  $�� ��$
��Left=�$	��Top=�$��20 190 20 0q�$	��350��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Email=��� Correo Electrónico.���� -    ��Name$ txt_sex_new�� & "MaterialDesignFloatingHintComboBox#��[ $
��Left=�$	��Top=�$��20 235 20 0q�$	��350��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ GenderMaleFemale=��� Sexo.@��� 
 � Tag$ 	Masculino��.��	Masculino�� $ Femenino��.��
Femenino(  "System.Windows.Controls.DatePicker  -     Name$ txt_nac_new��$	��350�� ( $MaterialDesignFloatingHintDatePicker#��[ $
��Left=�$	��Top=�$��20 300 20 0q�
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $
 Cake=��� Fecha de Nacimiento�� -	    ��Name$ btn_aceptar��$��	Siguiente��$��Right=�$��36��$��Bottom=�$	��140��$��	0 0 10 10q��� -
   $	 txt_altura_new��#��[  $�� ��$
��Left=�$	��Top=�$��420 50 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ ArrowUpBold=��� Altura.���� -   $	 txt_peso_new��#��[  $�� ��$
��Left=�$	��Top=�$��590 50 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Weight=��� Peso.���� -   $	 txt_cuello_new��#��[  $�� ��$
��Left=�$	��Top=�$��420 95 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Cuello.���� -   $	 txt_torax_new��#��[  $�� ��$
��Left=�$	��Top=�$��420 140 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Torax.���� -   $	 txt_brazo_new��#��[  $�� ��$
��Left=�$	��Top=�$��590 95 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Brazo.���� -   $	 txt_cintura_new��#��[  $�� ��$
��Left=�$	��Top=�$��590 140 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� 	Cintura.���� -   $	 txt_cadera_new��#��[  $�� ��$
��Left=�$	��Top=�$��420 190 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Cadera.���� -   $	 txt_pierna_new��#��[  $�� ��$
��Left=�$	��Top=�$��590 190 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Pierna.���� -   $	 txt_pantorrilla_new��#��[  $�� ��$
��Left=�$	��Top=�$��420 240 20 0q�$	��140��.��
 �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HumanHandsdown=��� Pantorrilla.���� -   $ 
tab_huella��$��Huella��.���� -   $ btn_asignar_huella��  MaterialDesignFlatButton#���  $��Center=�$	��500��$	��200��.���� $ 
Horizontal=�.+�  $ Fingerprint=�$��50��$��50���� $��8 0 0 0q�$��Center=�$��30(�Registrar Huella�� -   $ tab_membresia��$��
 Membresia��.��� $��16q�$	��Top=�