   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5   	   #    BelajarCRUDWPFAldyCahya.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BelajarCRUDWPFAldyCahya     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FFFAFAFA  MaterialDesignFont#���  5   	    � Title$ Login��5   	   $	��600��6   $
��1024��6$    � WindowStyle$
 None=�61   .��5      � -   5        .+�5   
   �� $��48��6   $��Bottom=�6     �� RadiusY$ 10��6;    �� RadiusX$ 10��6H   
�������$��576,0,35,78q�6b    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63   	   RenderingBias$	 Quality=�6A   
   ShadowDepth$
 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      �� 5   
   .+�5      � 
���   �$��10��6&   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5         ��Name$ btnExit��5      $��30��6.   $��30��69   $��0q�6r   
���������6E   Z� ��6[   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�62   5      5      5       5!      �� 5#   
   $	��372��6   $��Bottom=�6!   $ 10��6<   $ 10��6I   
�������$��576,0,35,158q�6c    5$        5%      $ 15Q�6#   $ 0Q�63   $	 Quality=�6A   $
 1Q�6Y   $ 	#FFBBBBBB��6i   5'      � 5(   
   $��Bottom=�6   $��576,0,35,301q�6*   $	��170��6@   .+�5)      �� $	��Top=�6   $��
15,20,15,0q�61   .+�5*      �� -   5         ��Name$ txtEmail��5*      $
��0,10q�6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6;    % !MaterialDesignFloatingHintTextBox#��[ 6b   $��Champagne & Limousines)�6�   $��18(�6�   $��58��6�   6�   G� 5+      -   5         G�Name$ pwBox��5+      $
��0,10q�6-   $ Password��6;    ) %MaterialDesignFloatingHintPasswordBox#��[ 6e   $��Champagne & Limousines)�6�   $��18(�6�   $��50��6�   6�   5,      5-      �� 5.   
   -   5        $ 	btnSubmit��5.   )   $	��366��6<   $��Center=�6H   $��Bottom=�6e   $��592,0,58,243q�6�   $��Log In��6�   $��20(�6�   $
��Bold"�6�   �� 5/   
   $��Assets/home.png��6   $��59��6)   $	��Top=�65   $��750,82,199,0q�6M   �� 50   
   $��Assets/instagram.png��6   $	��440��6.   $	��Top=�6;   $��52,62,495,0q�6S   �� 51   
   -   5         ��Name$ checkBoxRememberMe��51      $��Remember Me��6/   $
��Left=�6E   $	��Top=�6`   $��592,386,0,0q�6x   $��41��6�   $	��366��6�   $��20(�6�   6�   �� 52   
   -   5        $ 	btnSignUp��52      $��Sign Up��6$   $
��Left=�66   $	��Top=�6Q   $��96��6i   $��815,470,0,0q�6t   
����� �$
��Bold"�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 53   
   $��Don't have an account?��6   $
��Left=�61   $	��Top=�6L   $��592,470,0,0q�6d   $��29��6y   $	��227��6�   $��20(�6�   �� 54   
   -   5        $��Forgot password?��54   1   $
��Left=�6L   $	��Top=�6g   $	��147��6   ���	#FFF95F5F$��712,355,0,0q�6�    J� RenderTransformOrigin$ 
1.67,0.688&�6�   ��6�   Z� ��6�   Z� �� 55   
   -	   5         ��Name$ lblNameStatus��55   !   
���  ��$�� ��68   $
��Left=�6C   $	��Top=�6^   $��592,282,0,0q�6v   $	��366��6�   $��12(�6�   56      57      