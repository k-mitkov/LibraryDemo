   M S B A M L   `   `   `  ����  LibraryDemo.DesktopClient.    (LibraryDemo.DesktopClient.Views.BookView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � 
���z���  � ColumnDefinitions  5	   
   �� 5
   
   $��* �6   �� 5   
   $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6     5      �� 5      $��3* �6$   �� 5      $��* �6$   .+�5      �� $$��\Resources\images\allBooks.png��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5      -   5         ��Name$ AllBooks��5      $��1��6,   
���   �
���z���$��Center=�5       $��40(�5!       � Cursor$
 Hand��5"      ��5   9   �� *ShowAllButtonContent+��5      ��  �� Path$ ShowAllCommand�5"      5#      � 5%   
   $��0��6   $��1��6    5&      �� 5'      $��3* �6    �� 5(      $��* �6    .+�5*      �� $"��\Resources\images\Author.jpg��6   $��0��6:   $
��Fill=�6G   $	��Top=�6V   �� 5,      -   5        $ BooksByAuthor��5,      $��1��6-   $��Center=�5.      
���   �
���z���$��40(�51      $
 Hand��52      ��5,   :   �� *BooksByAuthorButtonContent+��5-      �� $ BooksByAuthorCommand�52      53      � 55   
   $��0��6   $��2��6    56      �� 57      $��3* �6    �� 58      $��* �6    .+�5;      �� $#��\Resources\images\Library.png��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5=      -   5        $ BooksByLibrary��5=      $��1��6.   $��Center=�5?      
���   �
���z���$��40(�5B      $
 Hand��5C      ��5=   ;   �� *BooksByLibraryButtonContent+��5>      �� $ BooksByLibraryCommand�5C      5D      � 5G   
   $��1��6   $��1��6    5H      �� 5I      $��3* �6    �� 5J      $��* �6    .+�5M      �� $#��\Resources\images\addBook.jpg��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5O      -   5        $ AddBook��5O      $��1��6'   $��Center=�5Q      
���   �
���z���$��40(�5T      $
 Hand��5U      ��5O   4   �� *AddButtonContent+��5P      �� $ 
AddCommand�5U      5V      � 5X   
   $��1��6   $��0��6    5Y      �� 5Z      $��3* �6    �� 5[      $��* �6    .+�5^      �� $"��\Resources\images\search.jpg��6   $��0��6;   $
��Fill=�6H   $	��Top=�6X   �� 5`      -   5        $ 
SearchBook��5`      $��1��6*   
���   �
���z���$��Center=�5d      $��40(�5e      $
 Hand��5f      ��5`   7   �� *SearchButtonContent+��5a      �� $ SearchCommand�5f      5g      � 5i   
   $��1��6   $��2��6    5j      �� 5k      $��3* �6    �� 5l      $��* �6    .+�5o      �� $#��\Resources\images\delete.jfif��6   $��0��6<   $
��Fill=�6I   $	��Top=�6X   �� 5q      -   5        $ 
DeleteBook��5q      $��1��6*   $��Center=�5s      
���   �
���z���$��40(�5v      $
 Hand��5w      ��5q   7   �� *DeleteButtonContent+��5r      �� $ DeleteCommand�5w      5x      �� 5z   
   $��2��68   $��3��6L   ��6   �� *
CurentView+6L   5{      5|      