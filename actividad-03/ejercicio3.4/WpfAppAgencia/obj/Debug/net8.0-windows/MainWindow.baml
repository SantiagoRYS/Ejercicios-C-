   M S B A M L   `   `   `  ����H  DWpfAppAgencia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAppAgenciaWpfAppAgencia  5   	       WpfAppAgencia.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAppAgencia     5   	     � Title$  
MainWindow��5   	   $	��477��6   $	��351��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��118��6.   $��Tipo de vehiculo��6;   $��	10,10,0,0q�6U   $	��Top=�6h   $	��176��6�   .��5      �� 5      	� 5   
   -   5         	�Name$ RbtAutoCompacto��5      $��Auto compacto��6/   $
��Left=�6G   $��	20,32,0,0q�6b   $	��Top=�6u   6�   	� 5   
   -   5        $ RbtCamioneta��5      $��	Camioneta��6,   $
��Left=�6@   $��
20,102,0,0q�6[   $	��Top=�6o   6�   	� 5   
   -   5        $ RbtVagoneta��5      $��Vagoneta��6+   $
��Left=�6>   $��	20,80,0,0q�6Y   $	��Top=�6l   6�   	� 5   
   -   5        $ RbtAutoDeLujo��5      $��Auto de lujo��6-   $
��Left=�6D   $��	20,57,0,0q�6_   $	��Top=�6r   6�   �� 5   
   $
��Left=�6   $	��283��6.   $��Datos del vehiculo��6;   $��
12,141,0,0q�6W   $	��Top=�6k   $	��306��6�   .��5      �� .+�5      �� $"��Numero de 
serie del motor:��6    �� Left$ 10��6G   
 �� Top$ 4��6X   $��Center=�6g   $	��Top=�6�   �� 5      -   5         ��Name$ LblPasajeros��5      $��Capacidad de
pasajeros:��6.   $ 10��6Y   $	 171��6j   $��Center=�6{   $	��Top=�6�   �� 5      $��Precio:��6   $ 10��6*   $	 140��6;   $��Center=�6L   $	��Top=�6i   �� 5      $��Año (superior a 1885):��6   $ 10��69   $	 101��6J   $��Center=�6[   $	��Top=�6x   �� 5      $��Marca:��6   $ 10��6)   $ 58��6:   $��Center=�6J   $	��Top=�6g   �� 5      -   5        $ LblCarga��5      $��Capacidad de 
carga:��6*   $ 10��6R   $	 218��6c   $��Center=�6t   $	��Top=�6�   5      5      �� 5   
   -   5         ��Name$ 	TxbNumero��5      $
��Left=�6%   $��127,182,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��59��6�   �� 5   
   -   5        $ TxbMarca��5      $
��Left=�6$   $��
81,220,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��134��6   �� 5   
   -	   5        $ TxbAño��5      $
��Left=�6"   $��155,265,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $��46��6~   �� 5   
   -
   5        $ 	TxbPrecio��5      $
��Left=�6%   $��
81,302,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $��75��6�   �� 5   
   -   5        $ TxbPajaseros��5      $
��Left=�6(   $��112,349,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5    
   -   5        $ TxbCarga��5       $
��Left=�6$   $��113,396,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $��59��6�   �� 5!   
   -   5         ��Name$ BtnCapturar��5!      $��Capturar
vehiculo��6&   $
��Left=�6K   $��
235,20,0,0q�6f   $	��Top=�6z   $��36��6�   $��83��6�   6�   �� 5"   
   -   5        $ 
BtnMostrar��5"      $��Mostrar
vehiculos��6%   $
��Left=�6J   $��
235,71,0,0q�6e   $	��Top=�6y   $��36��6�   $��83��6�   6�   �� 5#   
   -   5        $ BtnSalir��5#      $��Salir��6#   $
��Left=�63   $��251,121,0,0q�6N   $	��Top=�6c   $��20��6{   $��51��6�   6�   5%      5&      