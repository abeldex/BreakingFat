   M S B A M L   `   `   `  ����   
SistemaGym)    #ControlVentas.vista.VerDetalleVenta   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  DetalleVenta��$��487.633��$��1061.463�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=� � 	Resources    FontAwesome��%>   &	        *�.*/fonts/fontawesome-webfont.ttf#FontAwesome)�.���  � ColumnDefinitions �� $��* � � RowDefinitions �� $��60 ��� $��* �.+��� -   $��labelTitulo�����#62666A$��0��$��detalle de venta��$��35(�$��0q�$��	50,10,0,0q�$��Light"�&   System.Windows.Controls.DataGrid  -     Name$ gridDetalleVenta��$��15(�$��1��   
IsReadOnly .    RowHeaderWidth$ 0Q�	   GridLinesVisibility$
	 None=�
   AutoGenerateColumns
 .  ���#62666A$��
40,0,40,40q�
������ 
������� =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� "  .���  � ��
 �������  � ��$ 0,0,2,5q���  � �� �#E0E0E0��  � ��$ 10,5,0,5q���  � ��$ 0,0,0,15q�   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 18(���  � ��$ Normal"���  � ��$ 
10,10,0,10q���  � �� ��  �� 
TargetType"  .R���  �� Padding# z��#��z��#��z��#��z�� J� SnapsToDevicePixels . ._��� # z  �� Triggers P�  P� Property �@ 
IsSelected P� Value . . ���  � �� �#6AC4EA��  � �� �#6AC4EA   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Código venta��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	IdVenta+ �� StringFormat$ {0:D10}��   	CellStyle �� "  .���  � �� �#E1F3FB��  � ��$ 18(���  � ��$ Normal"���  � ��$ 
10,10,0,10q���  � �� �� "  .R��� # z��#��z��#��z��#��z�� . ._��� # z  P�  �@ 
IsSelected . . ���  � �� �#3AA0CC��  � �� �#3AA0CC  $ Código detalle��$ *  .  �� *IdDetalleVenta+  $ Producto��$ *  .  �� *
Producto+  $ Precio��$ *  .  �� *PrecioVenta+  $ Cantidad��$ *  .  �� *
Cantidad+  $ 	Sub total��$ *  .  �� *
SubTotal+