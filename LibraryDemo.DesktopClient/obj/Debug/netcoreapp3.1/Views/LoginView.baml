   M S B A M L   `   `   `  ����T  PLibraryDemo.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:LibraryDemo.DesktopClient.UtilLibraryDemo.DesktopClient.Util  5      /    )LibraryDemo.DesktopClient.Views.LoginView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      =util,clr-namespace:LibraryDemo.DesktopClient.Util     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��1��6    5      �� 5      $��2* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��2* �6    .+�5      ��  �� CornerRadius$ 30��6   
�������$��5��6=   � 5       $��0��6   .+�5!      �� $��50(�6@   $��Center=�6N   $��Center=�6i   ��6   :   4LibraryDemo.DesktopClient.Util.LocalizationExtension  *
strLogin+6i   5"      � 5$      $��1��6   $
��20,0q�6     5%      �� 5&      $��* �6$   �� 5'      $��* �6$   �� 5(      $
��0.2* �6$   .+�5*      �� $��0��6   $��20(�6%   ��63     *	strName+6[   �� 5+      $��1��6   $��20(�6=   $��Center=�6K    �� 	MaxLength$ 32��6f   ��6'   �� *Name+6w   5,      � 5.      $��2��6   $
��20,0q�6!    5/      �� 50      $��* �6$   �� 51      $��* �6$   �� 52      $
��0.2* �6$   .+�54      �� $��0��6   $��20(�6%   ��63     *strPassword+6_   G� 55      -   5         G�Name$ passwordText��55   9   $��1��6   $��20(�6+   $��Center=�6O    G� 	MaxLength$ 32��6j   56      � 58      $��3��6   $
��20,0q�6!    59      �� 5:      $��* �6$   �� 5;      $��* �6$   �� 5<      $
��0.2* �6$   .+�5>      �� $��0��6   $��20(�6)      
LogInFaild#���   67   �� 5?      $��1��6   $��20(�6N   
���z�����6&     *	strSingIn+��6\   ��  �� ElementName$ passwordText����6�   ��  �� Path$ LoginCommand�6�   5@      � 5B      $��4��6    5C      �� 5D      $��* �6$   �� 5E      $��* �6$   �� 5F      $��3* �6$     5H      �� 5I      $��* �6'   �� 5J      $��* �6'   .+�5L      �� $��1��6   $��0��6&   $
��20,0q�66   $��20(�6r   
���z�����6D     *strRegistration+��6�   �� $ RegisterFormCommand�6�   �� 5M      $��1��6   $��1��6&   $
��20,0q�66   $��20(�6w   
���z�����6D     *strForgottenPassword+��6�   �� $ ForgottenPasswordCommand�6�   5N      5O      �� 5P   
   $��3��6   $��3��6*   ��6>   �� *
CurentView+5Q      5R      