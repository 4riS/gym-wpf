   M S B A M L   `   `   `  ����A  =GymAAY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GymAAY.PagesGymAAY.Pages  5          GymAAY.Pages.startPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:GymAAY.Pages     5        N� Title$  	startPage��5	       � 	Resources 5
         neonHighlight g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%  &	        �� 5   
   $ Forever��6+   .��5      U� $ (UIElement.Opacity)�6,   $ 	textBlock��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:2��6'   $ 1Q�67     5      $ 0:0:4��6'   $ 0Q�67   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      � ��5   
   �� 5      	 �� ImageSource$	 ../Images/mainBg.jpg��6   6>   .+�5   
   �� -   5        
 ��Name$
 image��5      $��../Images/mainLogo.png��6   $
��Left=�6?   $	��250��6Z   $��175,140,0,0q�6g   $	��Top=�6|   $	��400��6�   �� 5   
   -   5         ��Name$ button��5   `    � ToolTip$I CΠατήστε για να κλείσετε την εφαρμογή��6   $��0q�6@   $��40��6T   $
��Left=�6p   $	��Top=�6�   $��41��6�   $��
698,14,0,0q�6�     MyButton#��[ 6�   ��5      �� 5       $	 ../Images/closeButton.png��6   5"      �� 5#   
   -   5        $ button1��5#   e   $j dΜάθετε πληροφορίες για τους δημιουργούς της εφαρμογής��6   $��0q�6Q   $
��Left=�6v   $��40��6�   $��
609,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��5$      �� 5%      $	 ../Images/infoButton.png��6   5'      �� 5(   
   -   5        $ button2��5(   S   $G AΠατήστε για να ανοίξετε την βοήθεια��6   $��0q�6?   $
��Left=�6d   $��40��6   $��
565,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��5)      �� 5*      $	 ../Images/helpButton.png��6   5,      �� 5-   
   -   5        $ button3��5-   H   $5 /Ελαχιστοποίηση εφαρμογής��6   $��0q�64   $
��Left=�6Y   $��40��6t   $��
654,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��5.      �� 5/      $"	 ../Images/minimizeButton.png��6   51      �� 52   
   -   5        $ button4��52   3   $1 +Πατήστε για να αρχίσετε��6   $��80��6D   $
��Left=�6P   $��326,411,0,0q�6k   $	��Top=�6�   $��80��6�   #��[ 6�   ��53      �� 54      $	 ../Images/playButton.png��6   56      �� 57   
   -   5         ��Name$ 	textBlock��57      $
��Left=�6'   $��273,501,0,0q�6B   $
��Wrap=�6W   $C��=Πατήστε το κουμπί για να αρχίσετε��6k   $	��Top=�6�   $��Segoe UI Light)�6�   
�������6�   58      59      