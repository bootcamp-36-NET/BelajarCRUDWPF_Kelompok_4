   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5   	   ,    &BelajarCRUDWPFAldyCahya.ForgotPassword   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BelajarCRUDWPFAldyCahya     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ForgotPassword��5	   	   $	��500��6    $	��350��6-    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ DeepSkyBlue��6#    � Offset$ 0.546Q�67   5      5      �� 5   
   $	��280��6   $	��190��6    $��Bottom=�6-   $��35,0,35,130q�6H    �� RadiusY$ 10��6]   	 �� RadiusX$	 10��6j   
�������
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5      �� $��Forgot Password��6   $��Center=�6.   $	��Top=�6K   $��
70,29,70,0q�6c   
�������$��18(�6�   $��Roboto)�6�   �� 5      $��Center=�6   $��15q�64   .+�5       �� -   5         ��Name$ txtEmail��5       $
��0,10q�6,   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6:    %  !MaterialDesignFloatingHintTextBox#��[  6a   $��Roboto)�6�   $��18(�6�   5!      5"      �� 5#   
   -   5        $��Back to log in��5#   (   $
��Left=�6A   $	��Top=�6\   $	��147��6t   ���	#FF787676 J� RenderTransformOrigin$ 
1.67,0.688&�6�   $��103,408,0,0q�6�   $��Roboto)�6�   ��6�   Z� ��6�   Z� 6�   �� 5$   
   -   5        $	��150��5$   &   $��Center=�62   $��Bottom=�6O   $��103,0,97,115q�6j   $��Reset Password��6�   
����� �
����� �6�   �� 5%   
   $��Assets/home.png��6   $	��100��6)   $	��100��65   $	��Top=�6B   $��30q�6Z   �� 5&   
   -   5         ��Name$ 	lblStatus��5&   !   
���  ��$��
��64   $
��Left=�6I   $	��Top=�6d   $��
54,326,0,0q�6|   $ 1,0.521&�6�   $	��248��6�   $��Roboto)�6�   5'      5(      