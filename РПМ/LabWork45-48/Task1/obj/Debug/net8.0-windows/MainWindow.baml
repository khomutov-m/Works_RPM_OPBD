   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� $��Bottom=�6   .@�5      �� -   5        $��CountChangedRows��5      $1��+Число измененный строк:��64   5      �� 5      .+�5   
   � .+�5      �� -   5        $��	TextBlock��5      $%��Введите sql-запрос��6*   �� 5      -   5        $��QueryTextBox��5      $
��Auto��6*   
������ 6^   5      � 5   
   .+�5      	� -   5        $��Task1RadioButton��5      $��Task1��62    	� 	GroupName$ Tasks��6B   	� 5      -   5        $��Task2RadioButton��5      $��Task2��62   $ Tasks��6B   	� 5      -   5        $��Task3RadioButton��5      $��Task3��62   $ Tasks��6B   	� 5      -   5        $��Task4RadioButton��5      $��Task4��62   $ Tasks��6B   	� 5      -   5        $��Task5RadioButton��5      $��Task5��62   $ Tasks��6B   �� 5      $	��ID:��6   �� 5      -	   5        $��	IdTextBox��5      $��30��6'   �� 5      $��Новая цена:��6   �� 5      -
   5        $��NewPriceTextBox��5      $��40��6-   �� 5      -   5        $��
SaveButton��5      $��Сохранить��6'   6;   �� 5      $��Имя таблицы:��6   �� 5      -   5        $��NameTableTextBox��5      $��50��6.   5      �� 5    
   -   5        $��ExecuteButton��5       $��Выполнить��6&   6:   �� 5!   
   -   5        $��ResultTextBlock��5!      �� 5"   
   $
��True��6   $
��Auto=�6/   .��5#      &   System.Windows.Controls.DataGrid  -   5        $��ResultDataGrid��5#      5$      5%      5&      5'      