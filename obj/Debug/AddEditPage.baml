   M S B A M L   `   `   `  ����D  @HostelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HostelApp	HostelApp  5          HostelApp.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:HostelApp     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
Номер��6   6#   �� 5   
   $#��Свободные места��6   $��1��6+   6:   �� 5   
   $��Жильцы��6   $��2��6"   61   �� 5   
   $��1��6)   $	��175��69   $
��Left=�6E   ��6   �� *
Номер+6c   �� 5   
   $��1��62   $��1��6B   $	��175��6O   $
��Left=�6[   ��6   �� *СвободныеМеста+6x   �� 5   
   -   5         ��Name$ 
ComboNames��5   Q   $��2��64   $��1��6A    �� DisplayMemberPath$ Фио��6e    �� SelectedItem 6   �� *Жильцы+6   �� 5   
   -   5        $��BtnSave��5   F   $��Сохранить��6   $��2��6%   $��3��69   6m   5      5      