   M S B A M L   `   `   `  ����G  CInterfaceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InterfaceWPFInterfaceWPF  5   	       InterfaceWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InterfaceWPF     5   	     � Title$  
MainWindow��5   	   $	��496��6   $	��592��6)   .��5	      � $��0,0,10,0q�6   .+�5
   
   �� $��Datos de empleados��6   $��17,16,14,165q�6/   .��5      �� $	��280��6   .+�5      �� $��Numero��6    �� Left$ 34��6)   
 �� Top$ 60��6:   $��Center=�6J   $	��Top=�6g   �� 5      $��Nombre��6   $ 34��6)   $	 132��6:   $��Center=�6K   $	��Top=�6h   �� 5      $��Sueldo��6   $ 34��6)   $	 204��6:   $��Center=�6K   $	��Top=�6h   �� 5      -   5         ��Name$ 	TxbNumero��5      $	 172��6-    �� TextWrapping$
 Wrap=�6?   $ 64��6S   $	��120��6c   �� 5      -   5        $ 	TxbSueldo��5      $	 172��6-   $
 Wrap=�6?   $	 208��6S   $	��120��6d   $��Center=�6p   $	��Top=�6�   �� 5      -   5        $ 	TxbNombre��5      $	 172��6-   $
 Wrap=�6?   $	 136��6S   $	��120��6d   $��Center=�6p   $	��Top=�6�   5      5      �� 5   
   -   5         ��Name$ BtnInsertar��5      $��Insertar��6&   $
��Left=�69   $��
462,79,0,0q�6T   $	��Top=�6h   $��26��6�   $��79��6�   6�   �� 5   
   -   5        $ BtnSalir��5      $��Salir��6#   $
��Left=�63   $��482,240,0,0q�6N   $	��Top=�6c   $��59��6{   $��24��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridEmpleados��5      $
��Left=�6.   $	��107��6I   $��
17,329,0,0q�6V   $	��Top=�6j   $	��551��6�   �� 5   
   $��Total nomina:��6   $
��Left=�6(   $��29��6C   $��
17,441,0,0q�6O   $	��Top=�6c   $��85��6{   �� 5   
   -   5         ��Name$ 	LblNomina��5      $�� ��6#   $
��Left=�6.   $��29��6I   $��107,441,0,0q�6U   $	��Top=�6j   $	��128��6�   5      5      