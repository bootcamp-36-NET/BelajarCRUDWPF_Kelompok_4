   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5   	   *    $BelajarCRUDWPFAldyCahya.Registration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BelajarCRUDWPFAldyCahya     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Registration��5   	   $	��600��6   $
��1024��6+    � WindowStyle$
 None=�68   .��5      � -   5        ���	#FFDADADA.+�5   
   �� $	��600��6   
�������$��Center=�63    �� Padding$ 30q�6N    �� CornerRadius$ 10��6[   $
��1024��6m   $	��592��6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63   	   ShadowDepth$	 0Q�6E   ._�5      �� $��624,50,0,56q�6   .+�5      � $��0 0 0 20q�6   5      �� 5      -   5        
 ��Name$
 txtIdReg��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Id��6,    % !MaterialDesignFloatingHintTextBox#��[ 6P   $��
-52,5,52,5q�6�   6�   �� 5      -   5        $
 txtSNameReg��5      $ Supplier Name��6/   #��[ 6^   $��
-52,5,52,5q�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dateJoinDate��5      $ 	Join Date��64     MaterialDesignDatePicker#��[ 6_   $��
-52,5,52,5q�6�   6�   �� 5      -   5        $
 txtEmailReg��5      $ Email��6/   #��[ 6V   $��
-52,5,52,5q�6�   6�   G� 5      -   5         G�Name$ pwReg��5      $ Password��6-    ) %MaterialDesignFloatingHintPasswordBox#��[ 6W   $��
-52,5,52,5q�6�   6�   G� 5       -   5        $ pwConfirmReg��5       $ Confirm Password��64   #��[ 6f   $��
-52,5,52,5q�6�   6�   �� 5!      -   5         ��Name$ btnRegister��5!      $��Sign Up��6H   $��-52,20,52,20q�6Z   
����� �6p   �� 5"      -	   5        $ btnLogIn��5"      $��Log In��6+   $��
164,0,70,0q�6<   
�������
����� �$��30��6|   ��6�   Z� 5#      5$      �� 5%   
   $��Have an account?��6   $
��Left=�6+   $��682,0,0,105q�6F   $��24��6[   $��Bottom=�6g   $��14(�6�   ���	#DD5753536�   �� 5&   
   $��Assets/welcome.jpg��6   $	��356��6,   $	��Top=�69   $��39,131,450,0q�6Q   �� 5'   
   $$��Sign up to see our application��6   $
��Left=�69   $��
654,53,0,0q�6T   $	��Top=�6h   $	��222��6�   ���	#DD858181$��Arial Black)�6�   �� 5(   
   -
   5         ��Name$ lblNameStatus��5(   !   
���  ��$�� ��68   $
��Left=�6C   $	��Top=�6^   $��602,381,0,0q�6v   $	��334��6�   $��10(�6�   $��20��6�   �� 5)   
   -   5        $ btnExit��5)   D   $
��Left=�6   $	��Top=�6,   $��30��6U   $��30��6`   $��0q�6�   
�������$��	965,4,0,0q�6�   ��6l   Z� ��6�   Z� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6&   5+      5,      5-      