   M S B A M L   `   `   `  ����T  PLibraryDemo.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LibraryDemo.DesktopClient.ViewsLibraryDemo.DesktopClient.Views  5      4    .LibraryDemo.DesktopClient.Views.SecondMenuView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:LibraryDemo.DesktopClient.Views     5      .��5	      � 
���z���  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6     5      �� 5      $��4* �6    �� 5      $��* �6    .+�5      �� $$��\Resources\images\allBooks.png��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5      $��1��6   
���   �
���z���$��Center=�5       $��40(�5!       � Cursor$
 Hand��5"      ��5   "   �� *ShowAllButtonContent+��5      ��  �� Path$ ShowAllCommand�5"      5#      � 5%   
   $��0��6   $��1��6    5&      �� 5'      $��4* �6    �� 5(      $��* �6    .+�5*      �� $#��\Resources\images\addBook.jpg��6   $��0��6;   $
��Fill=�6H   $	��Top=�6W   �� 5,      $��1��6   $��Center=�5.      
���   �
���z���$��40(�51      $
 Hand��52      ��5,   "   �� *AddButtonContent+��5-      �� $ 
AddCommand�52      53      � 55   
   $��1��6   $��1��6    56      �� 57      $��4* �6    �� 58      $��* �6    .+�5;      �� $#��\Resources\images\delete.jfif��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5=      $��1��6   $��Center=�5?      
���   �
���z���$��40(�5B      $
 Hand��5C      ��5=   "   �� *DeleteButtonContent+��5>      �� $ DeleteCommand�5C      5D      � 5F   
   $��1��6   $��0��6    5G      �� 5H      $��4* �6    �� 5I      $��* �6    .+�5L      �� $"��\Resources\images\search.jpg��6   $��0��6;   $
��Fill=�6H   $	��Top=�6X   �� 5N      $��1��6   
���   �
���z���$��Center=�5R      $��40(�5S      $
 Hand��5T      ��5N   "   �� *SearchButtonContent+��5O      �� $ SearchCommand�5T      5U      �� 5V   
   $��2��68   $��2��6L   ��6   �� *
CurentView+6L   5W      5X      