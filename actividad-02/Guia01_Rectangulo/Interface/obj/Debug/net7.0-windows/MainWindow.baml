   M S B A M L   `   `   `  ����D  @Interface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Interface	Interface  5   	       Interface.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Interface     5   	     � Title$  Rectangulos��5   	   $	��450��6   $	��800��6*    � ShowActivated$ False��66   .��5	      � .+�5
   
   �� -   5         ��Name$ LbLargo��5
      $��Largo��6!   $
��Left=�61   $��	53,31,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ TxbLargo��5      $
��Left=�6$   $��
165,35,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $��0��6g   $	��Top=�6p   $	��120��6�   6�   �� 5   
   -   5         ��Name$ BtnCapturarLargoAncho��5      $��Capturar Largo y Ancho��60   $
��Left=�6Q   $��
622,75,0,0q�6l   $	��Top=�6�   $	��138��6�   $��25��6�   
���   �6�   �� 5   
   -   5        $ BtnCalcularArea��5      $��Calcular Area��6*   $
��Left=�6B   $��622,120,0,0q�6]   $	��Top=�6r   $	��138��6�   $��25��6�   
���   �${�False��6�   �� 5   
   -   5        $ BtnCalcularDiferencia��5      $��Calcular Diferencia��60   $
��Left=�6N   $��622,166,0,0q�6i   $	��Top=�6~   $	��138��6�   $��25��6�   
���   �${�False��6�   �� 5   
   -   5        $ BtnSalir��5      $��Salir��6#   $
��Left=�63   $��666,254,0,0q�6N   $	��Top=�6c   $��24��6{   $��50��6�   
���   �6�   �� 5   
   $��Objetos��6   $��48,123,518,111q�6$   .��5      �� $��	21,0,26,0q�6   $	��128��6(   .+�5      	� -   5         	�Name$ RbtPared��5      $��Pared��60    �� Left$ 62��6@   
 �� Top$ 28��6Q   $��Center=�6a   $	��Top=�6~   	� 5      -   5        $ 
RbtVentana��5      $��Ventana��62   $ 62��6D   $ 64��6U   $��Center=�6e   $	��Top=�6�   5      5      �� 5   
   -	   5        $ LblResultado��5      $�� ��6&   $��Center=�61   $��	0,347,0,0q�6N   $	��Top=�6a   $	��720��6y   �� 5   
   -
   5        $ LbAncho��5      $��Ancho��6!   $
��Left=�61   $��	53,74,0,0q�6L   $	��Top=�6_   �� 5   
   -   5        $ TxbAncho��5      $
��Left=�6$   $��
165,78,0,0q�6?   $
 Wrap=�6S   $��0��6g   $	��Top=�6p   $	��120��6�   6�   �� 5   
   -   5        $ LblAreaPared��5      $��0��6&   $
��Left=�62   $��430,132,0,0q�6M   $	��Top=�6b   $	��140��6z   �� 5   
   -   5        $ LblAreaVentana��5      $��0��6(   $
��Left=�64   $��430,210,0,0q�6O   $	��Top=�6d   $	��136��6|   �� 5   
   -   5        $ LblAreaTotal��5      $��0��6&   $
��Left=�62   $��430,297,0,0q�6M   $	��Top=�6b   $	��140��6z   �� 5   
   -   5        $ BtnCalcularTiempo��5      $��Calcular Tiempo��6,   $
��Left=�6F   $��622,211,0,0q�6a   $	��Top=�6v   $	��138��6�   $��25��6�   
���   �${�False��6�   �� 5   
   $��Area de la Pared m2:��6   $
��Left=�6/   $��287,132,0,0q�6J   $	��Top=�6_   $	��138��6w   	 J� RenderTransformOrigin$	 0.491,0.541&�6�   �� 5   
   $��Area de la Ventana m2:��6   $
��Left=�61   $��287,210,0,0q�6L   $	��Top=�6a   $	��138��6y   �� 5   
   $��Area Total m2: ��6   $
��Left=�6*   $��303,297,0,0q�6E   $	��Top=�6Z   $	��112��6r   5!      5"      