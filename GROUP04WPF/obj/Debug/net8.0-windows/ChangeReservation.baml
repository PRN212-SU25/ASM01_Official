   M S B A M L   `   `   `  ����E  AGROUP04WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GROUP04WPF
GROUP04WPF  5   	   "    GROUP04WPF.ChangeReservation   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GROUP04WPF     5   	     � Title$  ChangeReservation��5   	   $	��500��6#   $	��600��60    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,0,-6q�6    � ColumnDefinitions 5   
   �� 5      $
��366* �6   �� 5      $
��235* �6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5      .+�5   
   �� $ ��Create Booking Reservation��6   $��
Montserrat)�65   $��24(�6M   $
��Bold"�6[   $
��Left=�6m   $	��Top=�6�   $��
138,20,0,0q�6�   $��2��6�   � 5   
   $��50,122,50,25q�6   $��2��6%    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6     5%      �� 5&      $	��150 �6#   �� 5'      $��* �6#   .+�5*      �� $��Search:��6   $��0��6&   $��0��63   $��5q�6C   �� 5+      -   5         ��Name$ 	txtSearch��5+      $��0��6)   $��1��66   $��5,5,90,5q�6F   �� 5,      -   5        $��Search��5,      $��0��6&   $��1��63   $��	265,5,5,5q�6C   ��5-      �� 5.      	 �� 
TargetType"	 ��6&   .R�5/      �� 
 �� CornerRadius$
 5��50      #��z��51      ._�52      �� $��Center=�6/   $��Center=�53      54      55      57      �� 59      $��Room Number:��6   $��1��6+   $��0��68   $��5q�6H   �� 5:      -   5         ��Name$ cmbRoomNumber��5:      $��1��6.   $��1��6;   $��5q�6K   6V   �� 5<      $��Customer Name:��6   $��2��6-   $��0��6:   $��5q�6J   �� 5=      -   5        $ txtCustomerId��5=      $��2��6-   $��1��6:   $��5q�6J   ${�False��6U   �� 5?      $��Booking Date:��6   $��3��6,   $��0��69   $��5q�6I   (  "System.Windows.Controls.DatePicker  5@      -   5          Name$ txtBookingDate��5@      $��3��61   $��1��6>   $��	5,5,208,5q�6N   ${�False��6a   �� 5B      $��Start Date:��6   $��4��6*   $��0��67   $��5q�6G     5C      -   5        $ txtStartDate��5C      $��4��6/   $��1��6<   $��	5,5,208,5q�6L   ${�False��6�   �� 5E      $��	End Date:��6   $��5��6(   $��0��65   $��5q�6E     5F      -   5        $ 
txtEndDate��5F      $��5��6-   $��1��6:   $��	5,5,208,5q�6J   ${�False��6�   �� 5H      $��Actual Price:��6   $��6��6,   $��0��69   $��5q�6I   �� 5I      -   5        $ txtActualPrice��5I      $��6��6.   $��1��6;   $��5q�6K   ${�False��6V   �� 5K      $��Total Price:��6   $��7��6+   $��0��68   $��5q�6H   �� 5L      -	   5        $ txtTotalPrice��5L      $��7��6-   $��1��6:   $��5q�6J   ${�False��6U   �� 5N       �� Orientation$ 
Horizontal=�6   $��8��62   $��1��6?   $
��Left=�6O   $��5q�6j   .+�5O      �� -
   5         ��Name$ 	btnUpdate��5O      $��Update��6,   $��75��6=   $��5q�6H   ���	#FF0099FF${�False��6�   �� 5P      -   5        $ btnSave��5P      $
��Save��6*   $��75��69   $��5q�6D   ���	#FF0099FF${�False��6   �� 5Q      -   5        $ 	btnDelete��5Q      $��Delete��6,   $��75��6=   $��5q�6H   ���	#FFEF8F18${�False��6�   �� 5R      -   5        $ 	btnCancel��5R      $��Cancel��6,   $��75��6=   $��5q�6H   ���	#FFEF8F18${�False��6�   5S      5T      5U      5V      