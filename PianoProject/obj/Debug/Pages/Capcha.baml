   M S B A M L   `   `   `  ����G  CPianoProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PianoProject.PagesPianoProject.Pages  5          PianoProject.Pages.Capcha   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:PianoProject.Pages     5        N� Title$  Capcha��5	       � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	     7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 1q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $	 border��6!   #��z��61   $
 15��6[   #��z��6m   #��z��6�    . ._�5+      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?   8   � ��6S   �� 53   "   $ border��6@   8   � ��6T   54      P� 55       � �� . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8 	  � ��6i   5=      5?      5A      5B      �� 5C   
   $ 	#FFABAdB3��68   �� 5D   
   $ 	#FF7EB4EA��6;   �� 5E   
   $ 	#FF569DE5��67   �� 5F   
   " ��6&   .�5G      ��  � ��# � ��6+   �� 5H       � ��8   6,   �� 5I       � ��# � ��6+   �� 5J       � ��$ 1q�60   �� 5K       �@ TabNavigation$
 None=�6A   �� 5L       � ��$
 Left=�6;   �� 5M       �@�FocusVisualStyle 61   Z� �� 5N       �@J�	AllowDrop . 6*   �� 5O       �@��PanningMode$ VerticalFirst=�69   �� 5P       �@��IsFlicksEnabled .  67   �� 5Q       � �� 5R      �� 5S      " ��6&   .R�5T      �� $	 border��6!   #��z��61   $
 15��6[   #��z��6m   #��z��6�    . ._�5U      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5V       5W      P� 5X       � {� .  . �5Y   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5Z      P� 5[       �@J�IsMouseOver . . �5\   "   �� $ border��6@   8   � ��6T   5]      P� 5^       �@J�IsKeyboardFocused . . �5_   "   �� $ border��6@   8   � ��6T   5`      5b      5d       5e      ]� 5f       5g      �� 5h      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5i       �@��IsSelectionActive .  6A   ./�5k      ��  �@��SelectionBrush# � /�67   5l      5n      5o      .��5q      � ���	#FF373737.+�5r   
   �� $��Center=�6   $��0,64,0,0q�62   $
��Wrap=�6D   $f��`ВЫ МНОГО РАЗ НЕПРАВИЛЬНО ВВЕЛИ ПАРОЛЬ,ВВЕДИТЕ КАПЧУ!��6X   $	��Top=�6�   $��Arial)�6�   $��14(�6�   $
��Bold"�6�   ���	#FF78909C6�   �� 5s   
   -   5         ��Name$ inputCapcha��5s   ,   #���  6A   $��Center=�6i   $��	0,215,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��268��6�   $��57��6�   $��Center=�6�   $��Center=�6�   �� 5t   
   -   5         ��Name$ verifyCapcha��5t      #��� 
 6'   $��ПРОВЕРИТЬ��6N   $��Center=�6b   $��	0,299,0,0q�6   $	��Top=�6�   $��44��6�   $	��128��6�   
����������	#FBFF9C1A6�   �� 5u   
   -   5         ��Name$ 
capchaText��5u   -   $��Center=�6A   $��	0,162,0,0q�6^   $
��Wrap=�6q   $�� ��6�   $	��Top=�6�   $��27��6�   $	��268��6�    �� TextAlignment$ Center=�6�   $��14(�6�   $��Arial)�6�   ���	#FF37474F6�   5v      5w      