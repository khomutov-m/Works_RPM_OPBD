   M S B A M L   `   `   `  ����@  <Task5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task5Task5  5   	       Task5.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         ItemTemplate ��Name ��Name��%�  &	        �� 5
   
   .R�5      ]� .+�5      �� $��/dark souls 2.png��6   $��30��63   �� 5      
�������$��3q�6,   ._�5      �� .+�5      �� $ IndentifierLabel��6    
����� �
����  �6L   �� 5      $ 
LoginLabel��6    
����� �
����  �6F   �� 5      $ PasswordLabel��6    
����� �
����  �6I   �� 5      $ ShowSelectedUsersButton��6!   -   5        5   B   5      5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ UsersComboBox��5       �� DisplayMemberPath$ Login��6+   $	��Top=�6F   �� 5   
   -   5         ��Name$ UsersListBox��5      #��[  6(   $��1��6a    �� SelectionMode$ Multiple=�6q   �� 5    
   -   5        	 ��Name$	 UsersListView��5       $ Multiple=�6*   $��2��6C   $ Login��6S   �� 5!   
   #��[  6   $��1��6A   5"      5$      