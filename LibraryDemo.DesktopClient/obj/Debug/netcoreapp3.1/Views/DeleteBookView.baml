   M S B A M L   `   `   `  ����T  PLibraryDemo.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LibraryDemo.DesktopClient.ViewsLibraryDemo.DesktopClient.Views  5      4    .LibraryDemo.DesktopClient.Views.DeleteBookView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:LibraryDemo.DesktopClient.Views     5      .��5	      � 
���z���  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   �� $��1��6   $��1��6!   $��30(�6X   ��61   �� *SelectToDeleteContent+6X   �� 5   
   $��2��6   $��1��6    ��60   ��  �� Path$ ListOfBooks� �� SelectedItem 6Z   �� $ SBook���5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��30(�6;   ��6$   �� *Title+6;   5       5!      5#      �� 5%   
   $��4��6   $��1��6   
���  ��$��20(�6�   ��6.   �� *DeleteButtonContent+��6g   �� $ DeleteCommand�6�   �� 5'   
   $��5��6   $��3��6!   $
��auto��6P   $��20(�6]   $��Center=�6k   ��65   �� *	ErrMasage+6k   �� 5)   
   $��7��6   $��3��6*   ��6>   �� *
CurentView+5*      5+      