   M S B A M L   `   `   `  ����D  @triangles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:triangles	triangles  5   	       triangles.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:triangles     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���#1D8BDF � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   �� $E��?Введите длины сторон треугольника��6   $��1��6<   $��3��6I   $��Center=�5      $��Center=�6-   $��22(�6H   
�������6V   �� 5   
   -   5         ��Name$ sideA��5      $��50��6!   $	��200��6-   $��0��69   $��2��6I   $��20(�5      $��Center=�6    �� 5   
   -   5        $ sideB��5      $��50��6!   $	��200��6-   $��1��69   $��2��6I   $��20(�5      $��Center=�6    �� 5   
   -   5        $ sideC��5      $��50��6!   $	��200��6-   $��2��69   $��2��6I   $��20(�5      $��Center=�6    �� 5   
   -   5        $��Проверить��5      $��50��6%   $	��200��61   $��1��6=   $��3��6M   ���#FF9A12
�������$��20(�5    9   6G   �� 5!   
   -   5         ��Name$ result��5!      $��4��6$   $��3��61   
�������$��Center=�5"      $��Center=�6/   $��16(�6L   5#      5$      