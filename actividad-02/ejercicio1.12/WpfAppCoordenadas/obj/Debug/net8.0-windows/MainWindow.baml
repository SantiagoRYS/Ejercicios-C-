   M S B A M L   `   `   `  ����L  HWpfAppCoordenadas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfAppCoordenadasWpfAppCoordenadas  5   	   "    WpfAppCoordenadas.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfAppCoordenadas     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��119��6.   $��Coordenadas del punto��6;   $��	32,28,0,0q�6Z   $	��Top=�6m   $	��222��6�   .��5      �� .+�5      �� $��Coordenada X��6    �� Left$ 20��6/   
 �� Top$ 22��6@   �� 5      $��Coordenada Y��6   $ 20��6/   $ 60��6@   $��Center=�6P   $	��Top=�6m   5      5      �� 5   
   $
��Left=�6   $��86��6.   $��Seleccione un punto��6:   $��
34,161,0,0q�6W   $	��Top=�6k   $	��188��6�   .��5      �� 5      �� 5   
   -   5         ��Name$ BtnCapturar��5      $��Capturar
coordenadas��6&   $
��Left=�6N   $��
280,59,0,0q�6i   $	��Top=�6}   6�   �� 5   
   -   5        $ BtnCalcular��5      $��Calcular
distancia��6&   $
��Left=�6L   $��280,114,0,0q�6g   $	��Top=�6|   $��72��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��438,206,0,0q�6N   $	��Top=�6c   $��72��6{   $��36��6�   6�   �� 5   
   -   5         ��Name$
 TxbX��5      $
��Left=�6    $��
175,70,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $��47��6{   �� 5   
   -   5        $
 TxbY��5      $
��Left=�6    $��175,110,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $��47��6|   	� 5   
   -   5         	�Name$ 	RbtPunto1��5      $��Punto1��6)   $
��Left=�6:   $��
58,189,0,0q�6U   $	��Top=�6i   	� 5   
   -   5        $ 	RbtPunto2��5      $��Punto 2��6)   $
��Left=�6;   $��
58,217,0,0q�6V   $	��Top=�6j   �� 5   
   $��Coordenadas del punto 1:��6   $
��Left=�63   $��
400,64,0,0q�6N   $	��Top=�6b   �� 5   
   -   5         ��Name$ 	LblPunto1��5      $�� ��6#   $
��Left=�6.   $��
400,90,0,0q�6I   $	��Top=�6]   $	��147��6u   �� 5   
   $��Coordenadas del punto 2:��6   $
��Left=�63   $��400,143,0,0q�6N   $	��Top=�6c   �� 5   
   -	   5        $ 	LblPunto2��5      $�� ��6#   $
��Left=�6.   $��400,169,0,0q�6I   $	��Top=�6^   $	��147��6v   �� 5   
   -
   5        $ LblTotal��5      $�� ��6"   $
��Left=�6-   $��254,190,0,0q�6H   $	��Top=�6]   $��28��6u   $	��141��6�   5       5!      