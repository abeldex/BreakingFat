   M S B A M L   `   `   `  ����  
SistemaGym)    #ControlVentas.vista.VerDetalleVenta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  DetalleVenta��5   	   $��487.633��6   $��1061.463��6/    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize=�6f    � 	Resources 5         FontAwesome��%L   &	        *�5   
   .*/fonts/fontawesome-webfont.ttf#FontAwesome)�6U   5      .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��labelTitulo��5      ���#62666A$��0��68   $��detalle de venta��6E   $��35(�6`   $��0q�6n   $��	50,10,0,0q�6y   $��Light"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridDetalleVenta��5   �   $��15(�6   $��1��6!      
IsReadOnly .    RowHeaderWidth$ 0Q�6@   	   GridLinesVisibility$
	 None=�6S   
   AutoGenerateColumns
 .  ���#62666A$��
40,0,40,40q�6�   
������ 
������� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 �����63   �� 5       � ��$ 0,0,2,5q�68   �� 5       � �� �#E0E0E064   �� 5       � ��$ 10,5,0,5q�60   �� 5       � ��$ 0,0,0,15q�6/   5      5         	CellStyle 5"      �� 5#      *  $System.Windows.Controls.DataGridCell"  6   .�5$      ��  � ��$ 18(�61   �� 5%       � ��$ Normal"�63   �� 5&       � ��$ 
10,10,0,10q�60   �� 5'       � �� 5(      �� 5)       �� 
TargetType"  6.   .R�5*   "   ��  �� Padding# z��6)   #��z��6M   #��z��6y   #��z��6�    J� SnapsToDevicePixels . ._�5+   &   �� # z 67   5,   #   5-      5/       �� Triggers 50      P� 51       P� Property �@ 
IsSelected P� Value . . �52      ��  � �� �#6AC4EA6;   �� 53       � �� �#6AC4EA6<   54      56         Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ Código venta��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6o      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	IdVenta+ �� StringFormat$ {0:D10}��   	CellStyle 5A      �� 5B      "  6    .�5C      ��  � �� �#E1F3FB6;   �� 5D       � ��$ 18(�69   �� 5E       � ��$ Normal"�6;   �� 5F       � ��$ 
10,10,0,10q�68   �� 5G       � �� 5H   "   �� 5I   &   "  66   .R�5J   *   �� # z��61   #��z��6U   #��z��6�   #��z��6�    . ._�5K   .   �� # z 6?   5L   +   5M   '   5O       5P      P� 5Q   "    �@ 
IsSelected . . �5R   &   ��  � �� �#3AA0CC6C   �� 5S   &    � �� �#3AA0CC6D   5T   #   5V      5X        5Y      $ Código detalle��6H   $ * 6`    .  6%   �� *IdDetalleVenta+6j     5Z      $ Producto��6B   $ * 6T    .  6%   �� *
Producto+6^     5[      $ Precio��6E   $ * 6U    .  6%   �� *PrecioVenta+6_     5\      $ Cantidad��6B   $ * 6T    .  6%   �� *
Cantidad+6^     5]      $ 	Sub total��6B   $ * 6U    .  6%   �� *
SubTotal+6_   5�      5�      5�      