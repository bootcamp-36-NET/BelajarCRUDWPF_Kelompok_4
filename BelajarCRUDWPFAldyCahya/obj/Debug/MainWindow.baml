   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5   	   (    "BelajarCRUDWPFAldyCahya.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BelajarCRUDWPFAldyCahya     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1024��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[    � WindowStyle$
 None=�6q   .��5      � -   5        ���	#FFEEEEEE.+�5   
   �� .+�5      � 
���   �$��10��6&   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $!��Belajar CRUD WPF ALDI CAHYA��6    $��Center=�6C   $��20(�6^   $
��20 0q�6l   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5         ��Name$ btnExit��5      $��30��6.   $��30��69   $��0q�6r   
���������6E   Z� ��6[   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�62   5      5      5      5"      � 5#   
   $��
250 55 0 0q�6   .+�5$      � -   5        	 �Name$	 GridPrincipal��5$      $��Center=�6*   $��Center=�6G   5&      � 5'   
   $	��250��6   $
��Left=�6   ���	#FF097FA6.+�5(      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        
  Name$
 TransitionName��5(   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6J   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5)      � -   5        $	 
GridCursor��5)      $��	0 100 0 0q�6+   $	��Top=�6>   
����� �$��10��6o   $
��Left=�6z   $��60��6�   5*      �� 5+      -   5         ��Name$ ListViewMenu��5+      $��0 100q�6-   
�������.@�5,      �� $��60��6   .��5-      �� $ 
Horizontal=�6!   .+�5.        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5/      $
��Home��6$   $��26(�60   $��Center=�6>   $
��20 0q�6Y   50      51      �� 52      $��60��6   .��53      �� $ 
Horizontal=�6!   .+�54        $ TruckDelivery=�62   $��30��6G   $��30��6R   $��Center=�6^   $��5q�6y   �� 55      $��Supplier��6$   $��26(�64   $��Center=�6B   $
��20 0q�6]   56      57      �� 58      $��60��6   .��59      �� $ 
Horizontal=�6!   .+�5:        $ AccountBalanceWallet=�62   $��30��6N   $��30��6Y   $��Center=�6e   $��5q�6�   �� 5;      $
��Item��6$   $��26(�60   $��Center=�6>   $
��20 0q�6Y   5<      5=      �� 5>      $��60��6   .��5?      �� $ 
Horizontal=�6!   .+�5@        $ AccountCheck=�62   $��30��6F   $��30��6Q   $��Center=�6]   $��5q�6x   �� 5A      $��Transaction Item��6$   $��20(�6<   $��Center=�6J   $
��20 0q�6e   5B      5C      �� 5D      $��60��6   .��5E      �� $ 
Horizontal=�6!   .+�5F        $ AddShoppingCart=�62   $��30��6I   $��30��6T   $��Center=�6`   $��5q�6{   �� 5G      $��Transaction��6$   $��26(�67   $��Center=�6E   $
��20 0q�6`   5H      5I      5K      5M      �� 5P   
   -   5         ��Name$ WelcomeHeading��5P   O   $��23��6   $
��Left=�6    $��
770,21,0,0q�6;   $��Welcome:��6g   $	��Top=�6w   $��17(�6�   $��ExtraCondensed&�6�   �� 5Q   
   -   5        $ TextBlockName��5Q   O   $��23��6   $
��Left=�6    $��
770,41,0,0q�6;   $	��Top=�6g   $��15(�6   $��ExtraCondensed&�6�   �� 5R   
   -	   5        $ 	btnLogOut��5R      $��Log Out��6S   $
��Left=�6e   $	��Top=�6�   $��98��6�   $��
72,411,0,0q�6�   ���	#FFFBF8F8$��29��6�   $��16(�6�   ��6<   Z� 6�   5S      5T      