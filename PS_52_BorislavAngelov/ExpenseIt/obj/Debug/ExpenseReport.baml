   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � ��5
   
   �� 5       �� ImageSource$ watermark.jpeg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��24(�6   $��0��6"   
����  �$
��Bold"�6E   .��6W   Expense Report For6k   �� 5      $��1��6   $
��Bold"�6!   .��63   Name:6:   �� 5      $��1��6   $
��Bold"�6!   $��40, 0, 0, 0q�63   ��6H   ��  �� Path$
 Name�6h   �� 5      $��2��6   $
��Bold"�6!   .��63   Department:6@   �� 5      $��2��6   $
��Bold"�6!   $��75, 0, 0, 0q�63   ��6H   �� $ 
Department�6n   � 5      $��3��6    5       �� 5!      $
��auto �6$   �� 5"      $��* �6$    5$      �� 5%      $
��auto �6'   .+�5'      &   System.Windows.Controls.DataGrid  $��1��6   $��0��6+      AutoGenerateColumns .     RowHeaderWidth$ 0Q�5(         CanUserAddRows .  ��5'   8   �� $ Expenses�   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ExpenseType��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� $ ExpenseType�  5+      $	 Amount��6)   
 69   �� $ ExpenseAmount�5-      5/      50      51      52      