   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Vistas.PaginasVistas.Paginas  5   	   E AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK4clr-namespace:ClasesBase.Enlaces;assembly=ClasesBaseClasesBase.Enlaces 5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5	   	   "    Vistas.Paginas.FiltroUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Vistas.Paginas     5   	   QcoleccionUsuario4clr-namespace:ClasesBase.Enlaces;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5	   	     � Title$  FiltroUsuario��5   	    � WindowStyle$
 None=�6    $	��530��5   	   $	��760��6    � 
ResizeMode$ NoResize=�5       � 	Resources 5       S� 
ObjectType#  ClasesBase.Enlaces.ABMUsuario S� 
MethodName   list_Usuario  
vista_user �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName	   	Direction��%�   &	        &	 >     7   S� 5   
   "  6   $ traer_usuario��5      5      �� 5   
   -   5        8    5        5      $ Usu_NombreUsuario��61   $	 	Ascending=�6R   5       5!      .��5%      � ���#b64d49$	��760��6    $	��530��6,   
 � ColumnDefinitions
 5&   
   �� 5'       � RowDefinitions 5)   
   �� 5*      $	��100 �6   �� 5+      $
��300* �6   �� 5,      $	��130 �6   .+�5.   
   �� $4��./Vistas;component/Resources/Imagenes/vback.jpg��6   $��3��6H   $
��Fill=�6Y    J� Opacity$	 0.8Q�6h   6x   �� 5/   
   $��Center=�6    
 txtabm#��[ 61   $��0��50      $��Center=�6   Listado de Usuarios6P   � 51   
   $	��Top=�6   $��Right=�6'   $��50��6C   
������ $��50��52      .+�53      �� -   5        $��close��55      $��45��53      $��45��6!   $��Center=�6,   $��Center=�6G   
������ $��1��54   .   $��0q�6>   .��56      �� $4��./Vistas;component/Resources/Imagenes/close.png��6   $
��Fill=�6P   6a   57      58      � 59   
   $��Center=�6   $	��600��6,   $��1��68    5:      �� 5;      $��60 �6    �� 5<      .+�5>      � $��0��6   $	��600��6    
 5?      �� 5@      $	��350 �6'   �� 5A      $	��250 �6'    5C      �� 5D      .+�5F      �� $��Center=�6   #��[ 69   $��0��5G      $��Center=�6"   Buscar por Username6S   �� 5H      -   5        $��	txtBuscar��5H      $��Center=�6,   $��Center=�5I      $	��245��68   $��40��6D     style_texbox#��[ 5J      $��1��5K      .��6O   5L      5O      � 5P      $��1��6   .+�5Q      �� -   5        $��Lista_Usuario��5Q      ��60   ��  �� Source# [  �� View 5R      �� 5S      .P�5T      �� $��ID��6-    �� Width$ 30��69    �� DisplayMemberBinding 6D   �� *Usu_ID+�� 5U      $��Nombre Usuario��6-   $	 150��6E    6Q   �� *Usu_NombreUsuario+�� 5V      $��Contraseña��6-   $	 100��6A    6M   �� *Usu_Contraseña+�� 5W      $��Apellido y Nombre��6-   $	 200��6H    6T   �� *Usu_ApellidoNombre+�� 5X      $	��Rol��6-   $	 100��6:    6F   �� *
Rol_Codigo+5Y      5\      5]      5^      � 5_   
   $��2��6   $��Center=�6   $��Center=�69   .+�5`      �� -   5        $��btnImprimir��5a        menu#��[ 5`      .��5a   C   
Imprimir6M   5b      5c      5d      