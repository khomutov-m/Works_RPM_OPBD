   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.AuthorizationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  AuthorizationWindow��5   	   $	��150��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��
Логин��6   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��1��6(   �� 5   
   $��Пароль��6   $��1��6!   G� 5   
   -   5         G�Name$ PasswordBox��5      $��1��6+   $��1��6;   �� 5   
   $��2��6   .+�5      �� -   5         ��Name$ EnterButton��5      $��
Войти��6+   6;   �� 5      -   5        $ CancelButton��5      $��Отмена��6+   6<   5      5      5      