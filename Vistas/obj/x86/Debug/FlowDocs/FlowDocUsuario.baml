   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Vistas.FlowDocsVistas.FlowDocs  5   	   E AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK4clr-namespace:ClasesBase.Enlaces;assembly=ClasesBaseClasesBase.Enlaces 5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   $    Vistas.FlowDocs.FlowDocUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Vistas.FlowDocs     5   	   Edata4clr-namespace:ClasesBase.Enlaces;assembly=ClasesBase     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  FlowDocUsuario��5   	   $	��530��5	   	   $	��760��6    � 
ResizeMode$ NoResize=�5
       � WindowStyle$
 None=�5   	    � 	Resources 5       S� 
ObjectType#  ClasesBase.Enlaces.ABMUsuario S� 
MethodName   	LIST_USER  VIEW_LIST_USER �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName	   	Direction��%�   &	        &	 >     7   S� 5   
   "  6   $ traer_usuario��5      5      �� 5   
   8    5        5      $ Usu_NombreUsuario��6&   $	 	Ascending=�6G   5      5      .��5      � ���#b64d49$	��760��6    $	��530��6,   
 � ColumnDefinitions
 5    
   �� 5!       � RowDefinitions 5#   
   �� 5$      $	��100 �6   �� 5%      $	��300 �6   �� 5&      $	��130 �6   .+�5(   
   �� $4��./Vistas;component/Resources/Imagenes/vback.jpg��6   $��3��6H   $
��Fill=�6Y    J� Opacity$	 0.8Q�6h   6x   �� 5)   
   $��Center=�6    
 txtabm#��[ 61   $��0��5*      $��Center=�6   Vista Previa de Impresion6V   � 5+   
   $	��Top=�6   $��Right=�6'   $��50��6C   
������ $��50��5,      .+�5-      �� -   5        $��close��5/      $��45��5-      $��45��6!   $��Center=�6,   $��Center=�6G   
������ $��1��5.   .   $��0q�6>   .��50      �� $4��./Vistas;component/Resources/Imagenes/close.png��6   $
��Fill=�6P   6a   51      52      �� 53   
   $��1��6   .+�54      -�  �� Left$ 12��6!   
 �� Top$ 28��62   $	��300��6B   $	��700��6O   .��55      /� -   5         �Name$ DocMain��55      .T�56      J� .*�6"   Listado de Usuarios67   �� 57      .r�58      �� $	��600��59   $   ��58   $   ��  �� Source# [  �� View 5:      �� 5;   "   P�5<   &   �� 5=   *   $��ID��69    �� Width$ 30��6E    �� DisplayMemberBinding 6P   �� *Usu_ID+�� 5>   *   $��Nombre Usuario��69   $	 150��6Q    6]   �� *Usu_NombreUsuario+�� 5?   *   $��Contraseña��69   $	 100��6M    6Y   �� *Usu_Contraseña+�� 5@   *   $��Apellido y Nombre��69   $	 200��6T    6`   �� *Usu_ApellidoNombre+�� 5A   *   $	��Rol��69   $	 100��6F    6R   �� *
Rol_Codigo+5C   #   5E      5F      5G      5H      5I      � 5J   
   $��2��6   .+�5K      �� -   5        $��btnImprimir��5L        menu#��[ 5K      $��Center=�64   .��5L   C   
Imprimir6M   5M      5N      5O      