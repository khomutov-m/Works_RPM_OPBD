   M S B A M L   `   `   `  ����@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��
Логин��6   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��1��6(   �� 5   
   $��Пароль��6   $��1��6!   �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $��1��68   �� 5   
   $��2��6   $��1��6"   $��Center=�62   .+�5      �� -   5         ��Name$ OkButton��5      $��OK��6'   �� 5      -   5        $ CancelButton��5      $��Отмена��6+      RedColor#��[  6<   	� 5      -   5         	�Name$ DarkThemeRadioButton��5      $��Тёмная тема��68   6N   	� 5      -   5        $ WhiteThemeRadioButton��5      $��Светлая тема��69   6P   5      �� 5   
   $��/Images/galaxy.jpg��6   $��2��6,   $��0��69   $
��Left=�6I   $��Center=�6d   $��70��6   5      5      