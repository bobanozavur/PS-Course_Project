   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	       StudentInfoSystem.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  Login��5   	   $	��200��6   $��349.391��6$   .��5	      � $��Center=�6   $��7,0,13.2,61.4q�6(   $	��323��6?    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ LabelUserName��5      $��
User Name:��5      $��0 10 0 0q�5      �� 5   
   -   5        $ LabelAge��5      $��	Password:��5      $��1��5      �� 5   
   -   5         ��Name$ TextBoxUserName��5      $��20��5       $	��150��5!      $��0 10 0 0q�5"      $��1��5#      ��5      �� *
UserName+5#      �� 5$   
   -   5        $ 
TextBoxAge��5$      $��20��5&      $	��150��5'      $��1��5(      $��1��5)      ��5%      �� *
Password+5)      �� 5,   
   -   5         ��Name$ StackPanelButtons��5,       �� Orientation$ 
Horizontal=�5-      $��2��5.      $��3��5/      $��-16,0.2,-0.6,0.4q�6"   $��Right=�6<   $	��339��6X   .+�51      �� -   5         ��Name$ ButtonRegister��51      $��20��52      $��90��53      $��Login��54      $��Center=�55      $��20,0,0,-0.4q�56      $��Bottom=�57   ;   ��6   �� *RegisterButtonClicked+6;   �� 59      -   5        $ ButtonReset��59      $��20��5:      $��90��5;      $��Reset��5<      $��Center=�5=      $��	20 10 0 0q�5>      ��5?      �� *ResetButtonClicked+�� 5@      -   5        $ 
ButtonShow��5@      $��20��5A      $��80                     ��5B      $
��Show��5C      $��Center=�5D      $��	20 10 0 0q�5E      ��5F      �� *ShowInformation+5G      5I      5J      