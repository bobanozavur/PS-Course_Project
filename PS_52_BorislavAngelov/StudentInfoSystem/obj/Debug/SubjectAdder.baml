   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   5clr-namespace:StudentInfoSystemStudentInfoSystem  5      $    StudentInfoSystem.SubjectAdder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	   5	ViewModelclr-namespace:StudentInfoSystem     5        � Title$  SubjectAdder��5
   	   $	��450��6   $	��800��6+   .��5      � .+�5   
   �� -   5        $��	searchBtn��5      $	��Add��6   $
��Left=�6,   $��
545,10,0,0q�6G   $	��Top=�6[   $��75��6s   ��5      �� *AddSubjectCommand+��5      �� *Text+ �� ElementName$ 	addTxtBox��5   s   �� 5   
   -   5         ��Name$ 	addTxtBox��5      $��0��6c   $��0��6s   $��
379,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . $
��Auto=�6�   $	��144��6   ��6%   �� *	Subject+ �� UpdateSourceTrigger$ PropertyChanged=�6   5      5      