   M S B A M L   `   `   `  ����D  @HostelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HostelApp	HostelApp  5          HostelApp.DormitoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:HostelApp     5        N� Title$  DormitoryPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $;��5Введите название для поиска: ��6   $	��175��6A    �� TextAlignment$ Right=�6M   6e   �� 5      -   5        $��
TBoxSearch��5   &   $	��225��6   6a   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Выберите тип: ��6   $	��175��62   $ Right=�6>   6V   �� 5      -   5        $��	ComboType��5   '   $	��225��6    �� DisplayMemberPath$ Название��6f   6�   5      �� 5      -   5         ��Name$ CheckActual��5      $M��GПоказывать только доступные общежития��6j   $��Center=�6�   6�   5      �� 5   
   -   5        $��LViewDormitory��5       $��1��6   $��Disabled=�66   $��Center=�6l   ��5      �� 5       .R�5!      � $ 
Horizontal=�6    $��Center=�69   6Y   5"      ��5$      �� 5%      .R�5&      � $��20q�6   $	��400��6'    5'      �� 5(      $��70 �6,   6:   �� 5)      $	��310 �6,   6;   �� 5*      $
��auto �6,   6<   �� 5+      $
��auto �6,   6<   .+�5-      �� $	��400��6    $��1��6,   $��UniformToFill=�69   $��Center=�6Q   $��5q�6n   ��5.      �� 5/   "    �� Path$ ImagePrewiew�6*    �� TargetNullValue 50   &   ��51   *   Resources/images.png��6L   53   #   55      �� 56      $��Center=�6>   $ Center=�6Y   $	��390��6p   $
��Wrap=�57   $   $��Center=�68   $	��5 5q�6U   $��26(�6b   $��0��6p   ��56   $   �� *Название+57      �� 58      $��2��6U   $��5 5 5 15q�6b   $��Center=�6t   $��26(�6�   $
��Bold"�6�   ��6$   �� *
Цена+	 �� StringFormat$	 {0:N2} РУБ��6�   �� 59      $��3��6g   $��14(�6t   $��Right=�6�   ��6$   �� *КоличествоМест+$$	 Мест осталось: {0}��6�   �� 5:      $��3��6@   $��14(�6M   $
��Left=�6[   ��6$   �� *
ActualText+6x   5;      5<      5?      5@      5A      