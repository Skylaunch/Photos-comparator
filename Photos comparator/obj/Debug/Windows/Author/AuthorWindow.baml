   M S B A M L   `   `   `  ����L  HPhotos comparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Photos_comparator.WindowsPhotos_comparator.Windows  5   	   ,    &Photos_comparator.Windows.AuthorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Photos_comparator.Windows     5   	     � Title$W  QДобавление нового изображения в базу данных��5   
   $	��400��6>   $	��500��6K    � WindowStartupLocation$ CenterScreen=�6W    � 
ResizeMode$ NoResize=�6|   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #353835��6    � Offset$ 0Q�6/   � 5      $ #0DAFB5��6   $	 0.5Q�6/   � 5      $ #5A5E64��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��GoBackButton��5      $��1��6%   $��На главную��65   $��50��6J   $	��150��6V   $��Right=�6b   $	��Top=�6~   $��4,9,9,16q�6�   6�   �� 5   
   $��1��6   $��0��6   $5��/Введите навание картинки:��6-   $��15(�6Q   $��Center=�6_   $��Right=�6z   �� 5    
   -   5        $��TitleTextBox��5    /   $��1��6   $��1��6   $
��Left=�6C   $��Center=�6^   $	��150��6y   $��30��6�   �� 5"   
   $��2��6   $��0��6   $@��:Выберите картинку для загрузки:��6-   $��15(�6W   $��Center=�6e   �� 5#   
   -   5        $��SelectPhotoButton��5#      $��1��6*   $��2��6:   $��Обзор...��6G   $��Center=�6Z   $��4q�6u   $
��Left=�6�   $	��100��6�   $��30��6�   6�   �� 5$   
   -   5        $��ImageCheckBox��5$      {�.  $��2��6:   $��1��6G   $��25��6W   $��25��6c   $��	0,15,10,0q�6n   	 d� 	IsChecked$	 FalseY�6�   �� 5&   
   $*��$Выберите категорию:��6   $��3��6.   $��15(�6;   $��Center=�6I   $��Right=�6d   �� 5'   
   -   5        $��CategoryComboBox��5'   +   
 �� MaxDropDownHeight$	
 150��6   $
��Auto��6C   $��1��6P   $��3��6`   $��30��6m   $	��200��6y    �� SelectedIndex$ 0��6�   $
��Left=�6�   �� 5)   
   -   5        $��AddPhotoButton��5)      $��4��6'   $��2��64   $��Добавить��6H   $��Center=�6[   $��Center=�6v   $	��200��6�   $��60��6�   $��0,0,10,0q�6�   6�   5*      5+      