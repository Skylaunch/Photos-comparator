   M S B A M L   `   `   `  ����L  HPhotos comparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Photos_comparator.Windows.UserPhotos_comparator.Windows.User  5   	   9    3Photos_comparator.Windows.User.SearchInFolderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Photos_comparator.Windows.User     5   	     � Title$  Поиск в папке��5   	   $	��400��6   $	��500��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #353835��6    � Offset$ 0Q�6/   � 5      $ #0DAFB5��6   $	 0.5Q�6/   � 5      $ #5A5E64��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��GoBackButton��5      $��1��6%   $��На главную��65   $��50��6J   $	��150��6V   $��Right=�6c   $	��Top=�6   $��4,9,9,15q�6�   6�   �� 5   
   $��1��6   $7��1Выберите искомую картинку:��6   $��15(�6B   $��Center=�6P   $��Center=�6k   �� 5   
   -   5        $��SelectPhotoButton��5   )   $��1��6   $��4q�6   $��1��6B   $��Обзор...��6R   $��Center=�6e   $
��Left=�6�   $	��100��6�   $��30��6�   6�   �� 5    
   -   5        $��ImageTextBox��5        $��1��6   {�.  $��1��6F   $��25��6V   $��25��6b   $��	0,15,10,0q�6m   	 d� 	IsChecked$	 FalseY�6�   �� 5"   
   $9��3Введите полный путь к папке:��6   $��2��67   $��15(�6D   $��Center=�6R   $��Right=�6m   �� 5#   
   -   5        $��FolderTextBox��5#      $��2��6'   $��2��64   $	��200��6D   $��30��6P   $
��Left=�6\   �� 5%   
   -   5        $��SearchPhotoButton��5%      $��3��6*   $��2��67   $��
Поиск��6K   $	��Top=�6[   $��4q�6s   $��Center=�6~   $	��180��6�   $��50��6�   6�   5'      5(      