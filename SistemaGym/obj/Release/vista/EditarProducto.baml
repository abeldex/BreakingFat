   M S B A M L   `   `   `  ����   
SistemaGym(    "ControlVentas.vista.EditarProducto   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  EditarProducto��$��491.305��$��585.837�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � 	Resources    FontAwesome��%>   &	        *�.*/fonts/fontawesome-webfont.ttf#FontAwesome)�.���  � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $	��74* ��� $	��85* ��� $	��85* ��� $
��170* ��� $	��90* �.+��� $��0��$��Editar producto��$��20(�$
��Left=�$��	43,28,0,0q�$	��Top=�$��39��$	��247��$��Center=��� $��0��$	����$��30(�#��[  $
��Left=�$��
211,28,0,0q�$	��Top=�$��39��$��37�� J� RenderTransformOrigin$ 1.622,0.465&�$��1���� -   $��textBoxNombre��$��1�� �� 	MaxLength$ 50��$��15(�$
��Left=�$��35��$��	43,36,0,0q�$��2�� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��214���� -   $��7��	 � Cursor$
	 Hand��$��17(�
�������$��Guardar��$
��Left=�$��
105,10,0,0q�$��4��$	��Top=�$	��143��$ 0.022,0.139&�$��54��$��1���� $��Nombre de producto��$
��Left=�$��	43,10,0,0q�$��2��$	��Top=�$��26��$	��123���� $��Stock��$
��Left=�$��	34,10,0,0q�$��2��$	��Top=�$��26��$	��123��$��1���� -   
 ��Name$
 textBoxStock��$ 9��$��4��$��15(�$
��Left=�$��35��$��	34,36,0,0q�$��2��$
 Wrap=�$�� ��$	��Top=�$	��214��$��1���� $��
Categoría��$
��Left=�$��	34,11,0,0q�$��1��$	��Top=�$��26��$	��123��$��1���� -    ��Name$ comboBoxIdCategoria��$��3�� �� DisplayMemberPath$ Nombre�� �� SelectedValuePath$ Nombre��$
��Left=�$��	37,37,0,0q�$��1��$	��Top=�$	��211��$��35��$��1������ *	Categoria+�� -   $
 textBoxDescripcion��$	 100��$��2��$��15(�$
��Left=�$	��110��$��	43,36,0,0q�$��3��$
 Wrap=�$�� ��$	��Top=�$	��214���� $��Descripción��$
��Left=�$��	43,10,0,0q�$��3��$	��Top=�$��26��$	��123���� -   $
 textBoxPrecioCompra��$ 9��$��5��$��15(�$
��Left=�$��35��$��	34,41,0,0q�$��3��$
 Wrap=�$�� ��$	��Top=�$	��214��$��1���� $��Precio de compra��$
��Left=�$��	34,15,0,0q�$��3��$	��Top=�$��26��$	��123��$��1���� -   $
 textBoxPrecioVenta��$ 9��$��6��$��15(�$
��Left=�$��35��$��
34,111,0,0q�$��3��$
 Wrap=�$�� ��$	��Top=�$	��214��$��1���� $��Precio de venta��$
��Left=�$��	34,85,0,0q�$��3��$	��Top=�$��26��$	��123��$��1���� -   $
 textBoxIdProducto��{�.  $��15(�$
��Left=�$��35��$��	43,37,0,0q�$��1��$
 Wrap=�$�� ��$	��Top=�$	��214���� $��Código de producto��$
��Left=�$��	43,11,0,0q�$��1��$	��Top=�$��26��$	��123��