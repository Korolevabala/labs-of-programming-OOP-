   M S B A M L   `   `   `  ����M  IFazulovRushanLaba8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FazulovRushanLaba8FazulovRushanLaba8  5   	        FazulovRushanLaba8.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FazulovRushanLaba8     5   	     � Title$  Input��5   	   $	��200��6   $	��400��6$   
����ح�.��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ textbox1��5      $��2��6$   $
��Left=�64   $��23��6O   $��
8.6,19,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $��8��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ textbox2��5      $��2��6$   $
��Left=�64   $��23��6O   $��3.6,20.2,0,0q�6[   $��1��6q   $
 Wrap=�6~   $��15��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ textbox3��5      $��2��6$   $
��Left=�64   $��23��6O   $��3.6,21.4,0,0q�6[   $��2��6q   $
 Wrap=�6~   $��25��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   $
��Left=�6   $��7,6,0,0q�6/   $
��Wrap=�6@   $	��Top=�6T   $��93��6l   $��2��6x   $	��121��6�   �� 6�   $���Введите длины сторон треугольника и отметьте флажок там - какой результат ��6�   �� 6�   �� 6�   $$�желали бы видеть��6�   �� 6  $�.��6  6(  �� 5   
   -   5         ��Name$ 
checkBox_P��5   &   $��Периметр��6    d� 	IsChecked$ FalseY�6:   $��20��6L    d� IsThreeState .  $��1��5   *   $��19.8,21,5.4,15.8q�6:    J� RenderTransformOrigin$ 	0.502,0.5&�6T   �� 5   
   -   5        $ 
checkBox_S��5   %   $��Площадь��6   $ FalseY�69   $��20��6K    .  $��1��5!   *   $��19.8,20.2,5.4,16.6q�6:   $��1��6V   5"      5#      