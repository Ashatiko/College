   M S B A M L   `   `   `  ����F  BAgencyHouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AgencyHouse.PagesAgencyHouse.Pages  5      $    AgencyHouse.Pages.PageUserEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:AgencyHouse.Pages     5        N� Title$  PageUserEdit��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      �� $"��Редактирование��6   $��Center=�6.   $��30(�6K   $��0 0 0 15q�6Y   �� 5      $ 
Horizontal=�6   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Имя��6      TxtBlock#��[  6'   �� 5      -   5        $
��name��5   <     mainTbox#��[ 6   6<   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Фамилия��6   #��[  6+   �� 5      -   5        $��surname��5   <   #��[ 6   6<   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Логин��6   #��[  6)   �� 5      -   5        $��login��5   <   #��[ 6   6<   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Права��6   #��[  6)   �� 5      -   5        $
��role��5   T    �� DisplayMemberPath$
 Role��6    
 CmbBox#��[ 64   6T   5      �� 5       $ 
Horizontal=�6   $��Center=�62   .+�5!      �� -   5        $��Сохранить��5!        mainBtn#��[ 6-   6N   �� 5"      -   5        $/��)Заблокировать/Удалить��5"      #��[ 69   6Z   5#      5$      5%      5&      