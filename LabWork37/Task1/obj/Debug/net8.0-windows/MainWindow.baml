   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ resultDataGrid��5
   ;   $	��300��6      AutoGenerateColumns$
 True��6    6;   ]� 5   
   $��10q�6   .+�5      �� $,��&Укажите путь к папке:��6   �� 5      -   5         ��Name$ directoryTextBox��5      5      ]� 5   
   $��10q�6   .+�5      �� $*��$Укажите имя файла:   ��6   �� 5      -   5        $ fileNameTextBox��5      6/   5      ]� 5   
   .+�5      �� -   5         ��Name$ showDataButton��5      $��Сбросить��6G   $��40��6Z   $��60��6f   $
��Left=�6q   �� 5      -   5         ��Name$ warningLabel��5   `   $;��5Подходящей записи не найдено��6   $y�Hidden=�6;   
���  ��6`   5      5      5      