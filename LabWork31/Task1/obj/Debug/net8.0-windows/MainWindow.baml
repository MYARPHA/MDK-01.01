   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Login��6   �� 5   
   $��Password��6   $��1��6#   �� 5   
   $��Confirm password��6   $��2��6+   �� 5   
   $��About yourself��6   $��3��6)   �� 5   
   $��Date of birth��6   $��4��6(   �� 5   
   -   5         ��Name$ DateOfBirthLabel��5      $��4��6   $��
15,25,15,5q�67   �� 5   
   -   5         ��Name$ LoginTextBox��5   "   $��1��6    �� 	MaxLength$ 10��68   G� 5   
   -   5         G�Name$ PasswordBox��5   3   $��1��6   $��1��6&    G� 	MaxLength$ 10��6H   G� 5   
   -   5        $ ConfirmPasswordBox��5   3   $��1��6   $��2��6&   $ 10��6O   �� 5    
   -   5        $ AboutTextBox��5    /   $��1��6   $��3��6"    �� AcceptsReturn$
 True��6E   (  "System.Windows.Controls.DatePicker  5!   
   -   5        	  Name$	 
DatePicker��5!   2   $��1��6   $��4��6%   
   DisplayDateStart
 
01.01.19006F   6d   �� 5"   
   -   5         ��Name$ RegistrateButton��5"   3   $��
Registrate��6   $��5��6&   6M   5#      5$      