   M S B A M L   `   `   `  ����M  IProyectoFinal-23CV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinal_23CV.VistasProyectoFinal_23CV.Vistas  5   	   (    "ProyectoFinal_23CV.Vistas.Usuarios   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinal_23CV.Vistas     5   	     � Title$  Usuarios��5   	   $	��450��6   $	��800��6'   .��5
      � 
���   � � RowDefinitions 5   
   �� 5      $
��145* �6   �� 5      $	��72* �6   .+�5   
   �� $��50(�6   $��Sistema Users��6   $
��Left=�66   $	��100��6Q   $��
183,36,0,0q�6^   $	��Top=�6r   $	��425��6�   $��Sitka Small Semibold)�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF29ED87��6#   � 5      $ 	#FF2FB36A��6#    � Offset$ 1Q�65   5      5      �� 5   
   $��Nombre��6   $
��Left=�6!   $��34��6<   $��
50,103,0,0q�6H   $	��Top=�6\   $	��176��6t   ���	#FFFEFCFC$��16(�6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��19��6@   $��
50,137,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��102��6�   �� 5   
   $��Usuario��6   $
��Left=�6"   $��27��6=   $��
50,156,0,0q�6I   $	��Top=�6]   $	��102��6u   ���	#FFFEFCFC$��16(�6�   �� 5   
   -   5        $ txtUsername��5      $
��Left=�6'   $��25��6B   $��
50,183,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��102��6�   �� 5   
   $��Password��6   $
��Left=�6#   $��26��6>   $��
50,208,0,0q�6J   $	��Top=�6^   $	��102��6v   ���	#FFFEFCFC$��14(�6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��24��6B   $��
50,234,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��102��6�   �� 5   
   -   5         ��Name$ BtnAdd��5      $��Guardar��6!   $
��Left=�63   $��23��6N   $��	67,49,0,0q�6Z   $	��Top=�6m   $��68��6�   ���	#FF96E486$��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	UserTable��5      
   AutoGenerateColumns$
 False��6'      CanUserAddRows$ False��6C      
IsReadOnly$
 True��6Z      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6l   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6|   $��183,127,0,0q�6�   $��2��6�   ���	#FF3A8705$��15(�6�   $	��Top=�6�   $
��Left=�6  $	��224��6   $	��556��6-  ��5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ 	#FF1CEB82��6#   � 5#      $ 	#FF02D24A��6#   $ 1Q�65   � 5$      $ 	#FF7DF3E2��6#   $ 0.089Q�65   � 5%      $ 1Q�6#   5&         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	PkUsuario+  5*      $ Nombre��6%    65   �� *Nombre+  5+      $ Usuario��6%    66   �� *
UserName+  5,      $ Password��6%    67   �� *
Password+  5-      $	 Rol��6%    62   �� *Roles.Nombre+4  .System.Windows.Controls.DataGridTemplateColumn  5/      $ Editar��6)      CellTemplate 50      �� 51      .R�52      �� -   5        $
��Edit��52   %   
�������6K   53      55        56      $ Delete��6)    57      �� 58      .R�59      �� -   5        ���#FA4D4D$��Delete��59   ;   6L   5:      5<      5?      �� 5@   
   $	��Rol��6   $
��Left=�6   $��26��69   $��
50,263,0,0q�6E   $	��Top=�6Y   $	��108��6q   ���	#FFF4EEEE$��16(�6�   �� 5A   
   -   5         ��Name$ 	SelectRol��5A      $
��Left=�6&   $��
50,289,0,0q�6A   $	��Top=�6U   $	��102��6m   $��2��6y   �� 5B   
   -	   5        $ 	txtPkUser��5B      $
��Left=�6%   $��18��6@   $��	50,85,0,0q�6L   $
 Wrap=�6_   $	��Top=�6s   $	��102��6�   ${�False��6�   
���   ����	#FFEFF1F86�   �� 5C   
   $�� ��6   $
��Left=�6   $	��101��66   $��
575,10,0,0q�6C   $	��Top=�6W   $	��131��6o   ��5D      �� 5E       �� ImageSource$" /Vistas/add-user_5268364.png��6   5G      �� 5H   
   -
   5        $�� ��5H      $
��Left=�6   $��
703,72,0,0q�67   $��1��6K   $	��Top=�6X   $��67��6p   $��87��6|   ��6�   Z� ��5I      �� 5J      $N H/Vistas/icons8-löschen-512-02940def1609cd29709fe2d929ba6cd425d783a6.png��6   5L      5M      5N      