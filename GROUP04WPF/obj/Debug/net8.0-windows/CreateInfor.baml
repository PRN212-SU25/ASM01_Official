   M S B A M L   `   `   `  ����E  AGROUP04WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GROUP04WPF
GROUP04WPF  5   	       GROUP04WPF.CreateInfor   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GROUP04WPF     5   	     � Title$  CreateInfor��5   	   $	��400��6   $	��600��6*    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $	��425��6   $	��Top=�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5      .+�5   
   �� $��Create Room Information��6   $��
Montserrat)�62   $��24(�6J   $
��Bold"�6X   $��Center=�6j   $	��Top=�6�   $��0,20,0,0q�6�   � 5   
   $��50,92,50,49q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5       $	��57* �6#   �� 5!      $
��293* �6#   .+�5$      �� $��Room Number:��6   $��0��6+   $��0��68   $��5,5,5,5q�6H   �� 5%      -   5         ��Name$ txtRoomNumber��5%      $��0��6-   $��1��6:   $��5,5,5,5q�6J   $��2��6[   �� 5'      $��Room Detail Description:��6   $��1��67   $��0��6D   $��5,5,5,5q�6T   �� 5(      -   5        $ txtRoomDetailDescription��5(      $��1��68   $��1��6E   $��5,5,5,5q�6U   $��2��6f   �� 5*      $��Room Max Capacity:��6   $��2��61   $��0��6>   $��5,5,5,5q�6N   �� 5+      -   5        $ txtRoomMaxCapacity��5+      $��2��62   $��1��6?   $��5,5,5,5q�6O   $��2��6`   �� 5-      $��
Room Type:��6   $��3��6)   $��0��66   $��5,5,5,5q�6F   �� 5.      -   5        	 ��Name$	 cbRoomTypeId��5.      $��3��6-   $��1��6:   $��5,5,5,5q�6J   $��2��6[   6o   �� 50      $��Room Price Per Day:��6   $��4��62   $��0��6?   $��5,5,5,5q�6O   �� 51      -   5        $ txtRoomPricePerDay��51      $��4��62   $��1��6?   $��5,5,5,5q�6O   $��2��6`   �� 53      
 �� Orientation$
 
Horizontal=�6   $��5��62   $��1��6?   $
��Left=�6O   $��5,5,0,5q�6j   $��2��6{   .+�54      �� -   5         ��Name$ CreateButton��54      $��Create��6/   $	��100��6@   $��5q�6L   ���	#FF0099FF��55      �� 56       �� 
TargetType" ��6*   .R�57      ��  �� CornerRadius$ 5��58      #��z��59      ._�5:   "   �� $��Center=�63   $��Center=�5;      5<      5=      5?      �� 5@      -   5        $ CancelButton��5@      $��Cancel��6/   $	��100��6@   $��5q�6L   ���	#FFEF8F18��5A      �� 5B      " ��6*   .R�5C      �� $ 5��5D      #��z��5E      ._�5F   "   �� $��Center=�63   $��Center=�5G      5H      5I      5K      5L      5M      5N      5O      