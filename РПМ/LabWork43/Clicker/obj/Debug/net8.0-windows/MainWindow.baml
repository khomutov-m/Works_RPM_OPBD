   M S B A M L   `   `   `  ����B  >Clicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ClickerClicker  5   	       Clicker.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Clicker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      A� -   5         A�Name$ Cookie��5      $	��160��6&   $	��160��62    � Cursor$
 Hand��6?   $��50q�6M   ��5      �� 5       �� ImageSource$ 1.png��6!    j� Stretch$
 None=�65   5      �� 5      -   5         ��Name$ CountClickLabel��5      $��Center=�6-   �� 5      -   5        $ 	TimeLabel��5      $��Bottom=�6'   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ Grandmother��5      $	��300��6-   $	��100��6:   $
 Hand��6F   ��5      �� 5      $ 2.jpg��6!   $
 None=�65   5      �� 5      -   5        $ CountGrandmotherLabel��5      $��Center=�63   5      5      5       