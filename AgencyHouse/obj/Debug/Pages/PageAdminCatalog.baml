   M S B A M L   `   `   `  ����F  BAgencyHouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AgencyHouse.PagesAgencyHouse.Pages  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 65   (    "AgencyHouse.Pages.PageAdminCatalog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:AgencyHouse.Pages     5      6sys&clr-namespace:System;assembly=mscorlib     65     N� Title$  PageAdminCatalog��5	       � 	Resources 5         defaulImage��%N   &	        ��5   
   ,(pack://application:,,,/Pages/default.png��5      5      .��5      � .+�5   
   �� .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� $
��Left=�6   $��30 20 0 -10q�63   $��20(�6H   .��6V   Каталог6_   �� 5      $��Center=�6   $��	0 0 0 -20q�65   .��6H   
Поиск6O   �� 5      -   5         ��Name$ 
NameFilter��5   ;   $	��Top=�6O   $��Center=�6g   $	��620��6�   $��25��6�   $��25q�6�   �� 5      -   5         ��Name$ ProductsAdminView��5   >   $��Center=�6   $	��700��6Y   $
��Auto��6e   
������ 
������ ��5      �� 5      .R�5      �� $��listBB��6]   
���   �
�������$	��650��6Q   .��5   "   �� $��Center=�6-   $ 
Horizontal=�6J   .+�5   &   �� $	��200��6u   $	��200��6�   $��10 -25q�6�   ��6,   �� *Image+ �� TargetNullValue# [  6�   �� 5   &   $ Vertical=�61   $��Bottom=�6H   .+�5   *   �� $ 
Horizontal=�65   $��	20 0 0 10q�6N   .+�5   .   �� $ Vertical=�69   .+�5   2   �� $ 
Horizontal=�6=   .+�5    6   �� $��Название: ��6@   �� 5!   6   ��6@   �� *Name+5"   3   �� 5#   2   $ 
Horizontal=�6=   .+�5$   6   �� $��Описание: ��6@   �� 5%   6   $	��350��6@   $
��Wrap=�6L   ��6`   �� *Description+5&   3   �� 5'   2   $ 
Horizontal=�6=   .+�5(   6   �� $��Город: ��6@   �� 5)   6   ��6@   �� *City+5*   3   �� 5+   2   $ 
Horizontal=�6=   .+�5,   6   �� $��Категория: ��6@   �� 5-   6   ��6@   �� *
Category+5.   3   �� 5/   2   $ 
Horizontal=�6=   .+�50   6   �� $ ��Цена за сутки: ��6@   �� 51   6   ��6@   �� *	CostDay+�� 52   6   $�� руб.��6@   53   3   54   /   55   +   �� 56   *   $ 
Horizontal=�65   .+�57   .   �� -   5        $ ��Забронировать��57   5     mainBtn#��[ 6`   �� 58   .    ��Name$ btnEdit��65   -   5        $ ��Редактировать��58   V   #��[ 6n   59   +   5:   '   5;   #   5<      5=      5?      5@      5A      5B      5C      