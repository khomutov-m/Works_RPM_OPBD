   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.CancelDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  CancelDialog��5   	   $	��200��6   $	��370��6+    � WindowStartupLocation$ CenterOwner=�67   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Question.png��6   $��2��6&   �� 5   
   $<��6Вы хотите закрыть приложение?��6   $��1��68   $��2��6H   $��15(�6\   $��Bottom=�6j   �� 5   
   -   5         ��Name$ 	YesButton��5      $
��Да��6$   $��1��61   $��2��6A   $��30��5   	   $��70��6   
������ �� 	IsDefault$
 True��68   6I   �� 5   
   -   5        $ NoButton��5      $��Нет��6#   $��2��61   $��2��6A   $��30��5   	   $��70��6   
������� �� IsCancel$
 True��62   6B   5      5      