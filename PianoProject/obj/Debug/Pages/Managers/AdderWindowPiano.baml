   M S B A M L   `   `   `  ����G  CPianoProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PianoProject.Pages.ManagersPianoProject.Pages.Managers  5   	   2    ,PianoProject.Pages.Managers.AdderWindowPiano   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PianoProject.Pages.Managers     5   	     � Title$  AdderWindowPiano��5   	   $	��450��6"   $	��800��6/    � 	Resources 5	         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1 ��Name��%�  &	        &	 #     &	 F     &	 i     7   7  7  &	 o    &	     &	 <    &	 _    &	 �    &		 �    &	
 �    &	 �    &	     &	 1    &	 T    7  7  7  7  7  7 	 7 
 7  7  7  �� 5
   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6&   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�   	 . ._�5      �� $
 PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       � {� .  . �5    "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5!      P� 5"       �@J�IsMouseOver . . �5#   "   �� $ border��6@   8   � ��6T   5$      P� 5%       �@J�IsKeyboardFocused . . �5&   "   �� $ border��6@   8   � ��6T   5'      5)      5+       5,      ]� 5-       5.      �� 5/      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 50       �@��IsSelectionActive .  6A   ./�52      ��  �@��SelectionBrush# � /�67   53      55      �� 56   
   .�57      ��  � �� 58      �� 59      .R�5:      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   	 . $��1��6�   5;      5=      5>      �� 5?   
   $ 	#FFDDDDDD��6;   �� 5@   
   $ 	#FF707070��67   �� 5A   
   $ 	#FFBEE6FD��6>   �� 5B   
   $ 	#FF3C7FB1��6:   �� 5C   
   $ 	#FFC4E5F6��6<   �� 5D   
   $ 	#FF2C628B��68   �� 5E   
   $ 	#FFF4F4F4��6=   �� 5F   
   $ 	#FFADB2B5��69   �� 5G   
   $ 	#FF838383��6=   �� 5H   
   " ��6%   .�5I      ��  �@�FocusVisualStyle8   61   �� 5J       � ��8  6+   �� 5K       � ��8  6,   �� 5L       � ��# � ��6+   �� 5M       � ��$ 1q�60   �� 5N       � ��$ Center=�6;   �� 5O       � ��$ Center=�69   �� 5P       � ��$ 1q�6(   �� 5Q       � �� 5R      �� 5S      " ��6&   .R�5T      �� $ border��6!   $ 15��61   #��z��6C   #��z��6m   #��z��6�   	 . ._�5U      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  5V       5W      P� 5X       �@��IsDefaulted . . �5Y   "   �� $ border��6@   # � ��6T    � ��5Z      P� 5[       �@J�IsMouseOver . . �5\   "   �� $ border��6?   8   � ��6S   �� 5]   "   $ border��6@   8   � ��6T   5^      P� 5_       � �� . . �5`   "   �� $ border��6?   8   � ��6S   �� 5a   "   $ border��6@   8   � ��6T   5b      P� 5c       � {� .  . �5d   "   �� $ border��6?   8   � ��6S   �� 5e   "   $ border��6@   8   � ��6T   �� 5f   "   $ contentPresenter��6K   8 	  � ��6i   5g      5i      5k      5l      5m      .��5n      � ���	#FF373737.+�5o   
   �� -   5         ��Name$ pricebox��5o      #���  6$   $��Center=�6L   $��0,99,0,0q�6i    �� TextWrapping$
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��280��6�   $��34��6�   �� 5p   
   -   5        $ modelbox��5p      #���  6$   $��Center=�6L   $��	0,169,0,0q�6i   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��280��6�   $��34��6�   �� 5q   
   -   5        $ countbox��5q      #���  6$   $��Center=�6L   $��	0,240,0,0q�6i   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��280��6�   $��34��6�   �� 5r   
   $��Price��6   $��Center=�6    $��0,69,0,0q�6=   $	��Top=�6O   
�������$��25��6z   $��Bahnschrift Condensed)�6�   �� 5s   
   $��Model��6   $��Center=�6    $��	0,139,0,0q�6=   $	��Top=�6P   
�������$��25��6{   $��Bahnschrift Condensed)�6�   �� 5t   
   $��Count��6   $��Center=�6    $��	0,210,0,0q�6=   $	��Top=�6P   
�������$��25��6{   $��Bahnschrift Condensed)�6�   �� 5u   
   -   5        #���  5u      $%��Добавить пианино��68   $��Center=�6S   $��	0,303,0,0q�6p   $	��Top=�6�   ���	#FF6CFF89 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��34��6�   $	��148��6�   
�������z�5v      V� 5w      .~�5x      �� �� 5y      �� 5z       �� Angle$ -0.393Q�6&   T� 5{      5|      5~      5�      5�      