   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5      1    +BelajarCRUDWPFAldyCahya.CtrlTransactionItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BelajarCRUDWPFAldyCahya     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6   .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$   TrainsitioningContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6R   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�5      �� .+�5      �� $��10q�6!   .+�5      � $��1��6   $��1��6/   
�������$	��578��6S   .+�5      � .+�5   "   �� -   5         ��Name$ txtSearchItem��5   *   $
��Left=�6A   $��24��6\   $��427,264,0,0q�6h    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��204��6�   
���   �6�   �� 5   "   -   5         ��Name$ btnSearchItem��5   )   $	��Top=�6@   $
��Left=�6X    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6s   
���   �$��643,264,0,0q�6�   $��24��6  $��31��66  ��6�   Z� ��6�   Z� .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6>   $��20��6L   $��20��6X   $��0q�6c   5   #   �� 5   "   $+��%Learn Windows Presentation Foundation��6(   $��220,21,142,0q�6X   $	��454��6n   $��33��6z   $��Arial Black)�6�   $��20(�6�   $��Center=�6�   $	��Top=�6�   �� 5   "   -   5        $ txtId��5   *    �� 
IsReadOnly .  $
��Left=�6L   $��31��6g   $
 Wrap=�6s   $	��Top=�6�   $	��121��6�   $��
265,77,0,0q�6�   	 �� 	IsEnabled	 . 6�   �� 5   "   $	��Id:��6(   $
��Left=�66   $	��Top=�6Q   
 J� RenderTransformOrigin$
 3.079,3.622&�6i   $��
174,87,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��21��6�   $��25��6�   �� 5   "   -   5        $ 
btnRefresh��5   )   $��Refresh��6=   $
��Left=�6O   $	��Top=�6j   $��65��6�   $��337,228,0,0q�6�   $
 0.242,-0.114&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5   "   -   5        $ btnSave��5   )   $
��Save��6:   $
��Left=�6I   $	��Top=�6d   $��60��6|   $��427,228,0,0q�6�   $
 0.242,-0.114&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5   "   -   5        $ 	btnUpdate��5   )   $
��Edit��6<   $
��Left=�6K   $	��Top=�6f   $��59��6~   $��516,228,0,0q�6�   $
 0.107,0.438&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5   "   -   5        $ 	btnDelete��5   )   $��Delete��6<   $
��Left=�6M   $	��Top=�6h   $��78��6�   $��596,228,0,0q�6�   $
 -0.091,0.75&�6�   
���   �
����� �$��22��6	  $��12(�6  &   System.Windows.Controls.DataGrid  5   "   -	   5          Name$ dataGridTransactionItem��5   +   $
��Left=�6L   $	��192��6g   $��
102,0,0,87q�6u   $��Bottom=�6�   $	��632��6�   ���	#FFE1F3F9���	#8900BFFF"   VerticalScrollBarVisibility$ Visible=�6#     AutoGenerateColumns .     
IsReadOnly .    Columns 5    &   0  *System.Windows.Controls.DataGridTextColumn  5!   *   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5"   =   �� *Id+  5#   *   $ Quantity��6=    5$   =   �� *
Quantity+  5%   *   $ Item Id��6=    5&   =   �� *	Item_Id+  5'   *   $ Transaction Id��6=    5(   =   �� *Transaction_Id+4	  .System.Windows.Controls.DataGridTemplateColumn	  5)   *   $ Action��6A    	  CellTemplate 5*   .   �� 5+   2   .R�5,   6   �� $ btnDeletedgItem��6=   -
   5        #��[  5,   V   
����� �$��20��6�   $��20��6�   ��6�   Z� .��5-   :     $ Trash=�6R   $��15��6`   $��15��6l   $��0q�6w   5.   7   5/   3   51   +   53   #   �� 54   "   -   5        $ txtQuantity��54   *   $
��Left=�6?   $��32��6Z   $
 Wrap=�6f   $	��Top=�6z   $	��409��6�   $��265,128,0,0q�6�   	 . 6�   �� 55   "   $��Item Id:��6(   $
��Left=�6;   $	��Top=�6V   $
 3.079,3.622&�6n   $��
423,87,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��21��6�   $	��123��6�   �� 56   "   $��Quantity��6(   $
��Left=�6;   $	��Top=�6V   $
 3.079,3.622&�6n   $��174,128,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��25��6�   $��59��6�   �� 57   "   -   5         ��Name$ comboBoxItem��57   +   $
��Left=�6A   $	��Top=�6\   $	��126��6t   $��
536,87,0,0q�6�   $��21��6�    �� 
IsEditable .  �� SelectedValue 58   +   ��  �� Path$ Item.Id���59   +   �� $
 Item� �� SelectedValuePath 5:   +   �� $ Item.Id�5<      5=      5>      �� 5?      $��Champagne & Limousines)�6   $��
Aldy Cahya��6E   $��18(�6Z   $��25q�6h   
����� �6t   5@      5A      5B      �� 5C   
   $��Transaction Id:��6   $
��Left=�6+   $	��Top=�6F   $
 3.079,3.622&�6^   $��184,188,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��21��6�   $	��123��6�   �� 5D   
   -   5        $ comboBoxTransaction��5D      $
��Left=�60   $	��Top=�6K   $	��126��6c   $��281,188,0,0q�6o   $��21��6�    .  5E      �� $ Transaction.Id���5F      �� $ Transaction� 5G      �� $ Transaction.Id�5H      5I      