   M S B A M L   `   `   `  ����A  =GymAAY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GymAAY.PagesGymAAY.Pages  5      $    GymAAY.Pages.gymMemberRegister   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:GymAAY.Pages     5        N� Title$  gymMemberRegister��5	       � 	Resources 5
         OpS �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%  &	        �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $ image��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1��6'   $ 1Q�67   5      U� 5      $ (UIElement.Opacity)�6,   $ image1��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1��6'   $ 1Q�67   5      U� 5      $ (UIElement.Opacity)�6,   $ 	textBlock��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1��6'   $ 1Q�67   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5       � ��5!   
   �� 5"       �� ImageSource$ ../Images/gymLRBg.jpg��6   .+�5$   
   �� -   5        	 ��Name$	 button��5$   `   
 � ToolTip$I
 CΠατήστε για να κλείσετε την εφαρμογή��6   $��0q�6@   $��40��6T   $
��Left=�6p   $	��Top=�6�   $��41��6�   $��
698,14,0,0q�6�     MyButton#��[ 6�   ��5%      �� 5&      $ ../Images/closeButton.png��6   5(      �� 5)   
   -   5        $	 button1��5)   e   $j
 dΜάθετε πληροφορίες για τους δημιουργούς της εφαρμογής��6   $��0q�6Q   $
��Left=�6v   $��40��6�   $��
609,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��5*      �� 5+      $ ../Images/infoButton.png��6   5-      �� 5.   
   -   5        $	 button2��5.   S   $G
 AΠατήστε για να ανοίξετε την βοήθεια��6   $��0q�6?   $
��Left=�6d   $��40��6   $��
565,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��5/      �� 50      $ ../Images/helpButton.png��6   52      �� 53   
   -   5        $	 button3��53   H   $5
 /Ελαχιστοποίηση εφαρμογής��6   $��0q�64   $
��Left=�6Y   $��40��6t   $��
654,14,0,0q�6�   $	��Top=�6�   $��40��6�   #��[ 6�   ��54      �� 55      $" ../Images/minimizeButton.png��6   57      �� 58   
   -   5         ��Name$ image��58      $"��../Images/trainerMnSmall.png��6   $
��Left=�6E   $	��179��6`   $��124,173,0,0q�6m   $	��Top=�6�   $	��165��6�   �� 59   
   -   5        $ image1��59      $��../Images/dialogBg.png��6    $
��Left=�6@   $��84��6[   $��
56,107,0,0q�6g   $	��Top=�6{   $	��222��6�   �� 5:   
   -   5         ��Name$ 	textBlock��5:      $
��Left=�6'   $��
95,127,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   /-Παρακαλώ πληκτρολογήστε�� 6�   *(σωστά τα στοιχεία σας.6�   �� 5;   
   -   5        $ image2��5;      $��../Images/monitor.png��6    $
��Left=�6?   $	��239��6Z   $��278,117,0,0q�6g   $	��Top=�6|   $	��299��6�   �� 5<   
   ���	#FFF4F4F5$
��Left=�6%   $	��161��6@   $��292,131,0,0q�6M   
���   �$	��Top=�6q   $	��258��6�   5=      �� 5>   
   -	   5         ��Name$ textBox��5>      $
��Left=�6#   $��25��6>   $��409,149,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��123��6�   �� 5?   
   -
   5         ��Name$ label��5?      $��Username : ��6   $
��Left=�65   $��300,146,0,0q�6P   $	��Top=�6e   $��28��6}   $	��100��6�   �� 5@   
   -   5        $ label1��5@      $��Κωδικός : ��6    $
��Left=�65   $��299,179,0,0q�6P   $	��Top=�6e   $��41��6}   $	��110��6�   �� 5A   
   -   5        $ textBox1��5A      $
��Left=�6$   $��25��6?   $��409,181,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��123��6�   �� 5B   
   -   5        $ label2��5B      $��Βάρος : ��6    $
��Left=�63   $��299,213,0,0q�6N   $	��Top=�6c   $��41��6{   $	��110��6�   �� 5C   
   -   5        $ textBox2��5C      $
��Left=�6$   $��25��6?   $��409,212,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��123��6�   �� 5D   
   -   5        $	 button4��5D   3   $2
 ,Επιβεβαίωση και εγγραφή��6   $��Επιβεβαίωση��6D   $
��Left=�6Z   $��438,249,0,0q�6u   $	��Top=�6�   $��93��6�   $��32��6�   6�   5E      5F      