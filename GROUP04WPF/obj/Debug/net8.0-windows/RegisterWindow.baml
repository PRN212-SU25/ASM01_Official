   M S B A M L   `   `   `  ����E  AGROUP04WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GROUP04WPF
GROUP04WPF  5   	       GROUP04WPF.RegisterWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GROUP04WPF     5   	     � Title$  RegisterWindow��5   	   $	��600��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #0099FF��6#   	 � Offset$	 0Q�63   � 5      $ #DA34AE��6#   $
	 0.75Q�63   � 5      $ 	#FF60B1E7��6#   $	 1Q�65   � 5      $ 	#FF596FDD��6#   $	 0.309Q�65   � 5      $ 	#FF8C57CA��6#   $	 0.484Q�65   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $ #060531��6#   $	 0Q�63   � 5      $ 	#FF472FDE��6#   $	 1Q�65   5      ._�5!      � .+�5"      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�5#      $��82��5$      $	��Top=�6   $	��480��61   .+�5%      �� $��REGISTER��6    
�������$��28(�5'      $��Medium"�5(      $��
Montserrat)�5)       � Cursor$
 Hand��5*      $��
180,30,0,0q�5+      $	��377��6$   5,      �� 5-      $
 Vertical=�6   $��82,102,82,68q�5.      .+�5/      �� $��	Full Name��6    
�������$��12(�51      $��Medium"�52      $��
Montserrat)�53      $��0,15,0,0q�54      �� 55      -   5         ��Name$ txtFullName��55      $��13(�56      $��Medium"�57      $��
Montserrat)�58      
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5<      $��28��5=      $��Center=�5>      $��0,5,0,0q�5?      .��6E   ��5@      �� 5A      .��5B   .   5C      �� 5D      $��Phone��6    
�������$��12(�5F      $��Medium"�5G      $��
Montserrat)�5H      $��0,15,0,0q�5I      �� 5J      -   5        $ txtTelephone��5J      $��13(�5K      $��Medium"�5L      $��
Montserrat)�5M      
�������
 �����
�������$��0,0,0,2q�5Q      $��28��5R      $��Center=�5S      $��0,5,0,0q�5T      .��6   ��5U      �� 5V      .��5W   .   5X      �� 5Y      $��Email��6    
�������$��12(�5[      $��Medium"�5\      $��
Montserrat)�5]      $��0,15,0,0q�5^      �� 5_      -   5        $ txtEmail��5_      $��13(�5`      $��Medium"�5a      $��
Montserrat)�5b      
�������
 �����
�������$��0,0,0,2q�5f      $��28��5g      $��Center=�5h      $��0,5,0,0q�5i      .��6   ��5j      �� 5k      .��5l   .   5m      �� 5n      $��Password��6    
�������$��12(�5p      $��Medium"�5q      $��
Montserrat)�5r      $��0,15,0,0q�5s      �� 5t      -   5        $ txtPassword��5t      $��13(�5u      $��Medium"�5v      $��
Montserrat)�5w      
�������
 �����
�������$��0,0,0,2q�5{      $��28��5|      $��Center=�5}      $��0,5,0,0q�5~      .��6#   ��5      �� 5�      .��5�   .   5�      �� 5�      $��BirthDay��6    
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,15,0,0q�5�      (  "System.Windows.Controls.DatePicker  5�      -   5          Name$ txtBirthDay��5�   !   $	��220��66   $
��Left=�6B   5�      �� 5�      .+�5�      �� -   5         ��Name$ btnRegister��5�      $��0q�5�      $��REGISTER��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��20,450,20,0q�5�      ��5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � �� �� Value �#0099FF6?    �� Triggers 5�   "   P� 5�   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5�   *   ��  � ��
 ��  �6G   5�   '   5�      ��5�      �� 5�       �� 
TargetType" ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�      #��z��5�      ._�5�   &   �� $��Center=�67   $��Center=�5�   '   5�   #   5�      5�      5�      �� 5�      .+�5�      �� -   5        $ 	btnCancel��5�      $��0q�5�      $��CANCEL��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��20,500,20,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � ��
 �  ��6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � ��
 � E��6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�      #��z��5�      ._�5�   &   �� $��Center=�67   $��Center=�5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      