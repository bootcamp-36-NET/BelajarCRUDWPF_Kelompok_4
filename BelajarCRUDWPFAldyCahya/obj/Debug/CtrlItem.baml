   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5      &     BelajarCRUDWPFAldyCahya.CtrlItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BelajarCRUDWPFAldyCahya     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6   .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$   TrainsitioningContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6R   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�5      �� .+�5      �� $��10q�6!   .+�5      � $��1��6   $��1��6/   
�������$	��578��6S   .+�5      � .+�5   "   �� -   5         ��Name$ txtSearchItem��5   *   $
��Left=�6A   $��24��6\   $��427,270,0,0q�6h    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��204��6�   
���   �6�   �� 5   "   -   5         ��Name$ btnSearchItem��5   )   $	��Top=�6@   $
��Left=�6X    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6s   
���   �$��643,270,0,0q�6�   $��24��6  $��31��66  ��6�   Z� ��6�   Z� .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6>   $��20��6L   $��20��6X   $��0q�6c   5   #   �� 5   "   $��Name:��6(   $
��Left=�68   $	��Top=�6S    J� RenderTransformOrigin$ 3.079,3.622&�6k   $��
174,69,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��22��6�   $��55��6�   �� 5   "   -   5        $ txtItemName��5   *   $
��Left=�6?   $��32��6Z   $
 Wrap=�6f   $	��Top=�6z   $	��409��6�   $��
265,59,0,0q�6�   6�   �� 5   "   $+��%Learn Windows Presentation Foundation��6(   $��220,21,142,0q�6X   $	��454��6n   $��33��6z   $��Arial Black)�6�   $��20(�6�   $��Center=�6�   $	��Top=�6�   �� 5   "   -   5        $ 	txtItemId��5   *   	 �� 
IsReadOnly	 . $
��Left=�6O   $��31��6j   $
 Wrap=�6v   $	��Top=�6�   $	��121��6�   $��265,109,0,0q�6�   
 �� 	IsEnabled
 . 6�   �� 5   "   $	��Id:��6(   $
��Left=�66   $	��Top=�6Q   $ 3.079,3.622&�6i   $��174,119,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��21��6�   $��25��6�   �� 5   "   -   5        $ 
btnRefresh��5   )   $��Refresh��6=   $
��Left=�6O   $	��Top=�6j   $��65��6�   $��337,244,0,0q�6�   $ 0.242,-0.114&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5   "   -   5        $ btnSave��5   )   $
��Save��6:   $
��Left=�6I   $	��Top=�6d   $��60��6|   $��427,244,0,0q�6�   $ 0.242,-0.114&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5    "   -   5        $ 	btnUpdate��5    )   $
��Edit��6<   $
��Left=�6K   $	��Top=�6f   $��59��6~   $��516,244,0,0q�6�   $ 0.107,0.438&�6�   
���   �
����� �$��22��6  $��12(�6  �� 5!   "   -	   5        $ 	btnDelete��5!   )   $��Delete��6<   $
��Left=�6M   $	��Top=�6h   $��78��6�   $��596,244,0,0q�6�   $ -0.091,0.75&�6�   
���   �
����� �$��22��6	  $��12(�6  &   System.Windows.Controls.DataGrid  5"   "   -
   5          Name$ dataGridItem��5"   +   $
��Left=�6A   $	��192��6\   $��
102,0,0,87q�6j   $��Bottom=�6~   $	��632��6�   ���	#FFE1F3F9���	#8900BFFF"   VerticalScrollBarVisibility$ Visible=�6     AutoGenerateColumns .     
IsReadOnly .    Columns 5#   &   0  *System.Windows.Controls.DataGridTextColumn  5$   *   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5%   =   �� *Id+  5&   *   $
 Name��6=    5'   =   �� *Name+  5(   *   $ Price��6=    5)   =   �� *Price+  5*   *   $ Stock��6=    5+   =   �� *Stock+  5.   *   $ Supplier Name��6=    5/   =   �� *Supplier.Name+4	  .System.Windows.Controls.DataGridTemplateColumn	  50   *   $ Action��6A    	  CellTemplate 51   .   �� 52   2   .R�53   6   �� $ btnDeletedgItem��6=   -   5        #��[  53   V   
����� �$��20��6�   $��20��6�   ��6�   Z� .��54   :     $ Trash=�6R   $��15��6`   $��15��6l   $��0q�6w   55   7   56   3   58   +   5:   #   �� 5;   "   -   5        $ txtPrice��5;   *   $
��Left=�6<   $��32��6W   $
 Wrap=�6c   $	��Top=�6w   $	��409��6�   $��265,160,0,0q�6�   
 . 6�   �� 5<   "   $��Supplier Id:��6(   $
��Left=�6?   $	��Top=�6Z   $ 3.079,3.622&�6r   $��423,119,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��21��6�   $	��123��6�   �� 5=   "   -   5        $ txtStock��5=   *   $
��Left=�6<   $��32��6W   $
 Wrap=�6c   $	��Top=�6w   $	��409��6�   $��265,209,0,0q�6�   
 . 6�   �� 5>   "   $��Price
��6(   $
��Left=�6B   $	��Top=�6]   $ 3.079,3.622&�6u   $��174,160,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��25��6�   $��45��6�   �� 5?   "   $��Stock
��6(   $
��Left=�6=   $	��Top=�6X   $ 3.079,3.622&�6p   $��174,215,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��26��6�   $��49��6�   �� 5@   "   -   5         ��Name$ 	comboBox1��5@   +   $
��Left=�6>   $	��Top=�6Y   $	��126��6q   $��536,119,0,0q�6}   $��21��6�    �� 
IsEditable .  �� SelectedValue 5A   +   ��  �� Path$ Supplier.Id���5B   +   �� $ Supplier� �� SelectedValuePath 5C   +   �� $ Supplier.Id�5E      5F      5G      �� 5H      $��Champagne & Limousines)�6   $��
Aldy Cahya��6E   $��18(�6Z   $��25q�6h   
����� �6t   5I      5J      5K      5L      5M      