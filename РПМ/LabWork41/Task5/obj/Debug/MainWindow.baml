   M S B A M L   `   `   `  ����@  <Task5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task5Task5  5   	       Task5.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   A� -   5         A�Name$ Ellipse��5
      $	��150��6#   $	��150��6/    �� Left$	 320��6<   
 �� Top$	 150��6N   ��5      
� 5       
� RadiusX$ 1Q�6&    
� RadiusY$ 1Q�62    
� GradientOrigin$ 0.5, 0.3&�6>   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $	 Red��6#   $ 1Q�6/   5      5      �� 5   
   $��Сменить цвет��6   $	 350��6(   	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 Button.Click��6   .[�5      �� .��5      �� .��5      ��  �� TargetProperty$! Fill.GradientStops[1].Color�5       �� 
TargetName$ Ellipse��5       g� Duration$ 0:0:5D�5      g�5   &   ��  �� KeyTime$ 0:0:1��6:    �� Value$ Green��6J   �� 5   &   $ 0:0:2��6:   $
 Blue��6J   �� 5   &   $ 0:0:3��6:   $ 
LightCoral��6J   �� 5   &   $ 0:0:4��6:   $ Orange��6J   �� 5    &   $ 0:0:5��6:   $ 	LightBlue��6J   5"      5#      5$      5%      5'      5(      5)      