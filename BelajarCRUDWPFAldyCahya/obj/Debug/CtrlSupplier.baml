   M S B A M L   `   `   `  ����R  NBelajarCRUDWPFAldyCahya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BelajarCRUDWPFAldyCahyaBelajarCRUDWPFAldyCahya  5      *    $BelajarCRUDWPFAldyCahya.CtrlSupplier   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BelajarCRUDWPFAldyCahya     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6   .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�5      �� .+�5      �� $��10q�6!   .+�5      � $��1��6   $��1��6/   
�������$	��600��6S   .+�5      � .+�5   "   �� -   5         ��Name$ 	txtSearch��5   *   $
��Left=�6=   $��36��6X   $��434,306,0,0q�6d    �� TextWrapping$
 Wrap=�6y   $	��Top=�6�   $	��257��6�   
���   �$��13(�6�   6�   �� 5   "   -   5         ��Name$ 	btnSearch��5   )   $	��Top=�6<   $
��Left=�6T    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6o   
���   �$��696,306,0,0q�6�   $��12(�6
  $��36��6  ��6�   Z� ��6�   Z� .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6>   $��20��6L   $��20��6X   $��0q�6c   5   #   �� 5   "   $��Name:��6(   $
��Left=�68   $	��Top=�6S    J� RenderTransformOrigin$ 3.079,3.622&�6k   $��
105,74,0,0q�6�   $��20(�6�   $��Arial)�6�   $
��Bold"�6�   �� 5   "   -   5        $ txtName��5   *   $
��Left=�6;   $��46��6V   $
 Wrap=�6b   $	��Top=�6v   $	��516��6�   $��
220,59,0,0q�6�   $��20(�6�   �� 5   "   $+��%Learn Windows Presentation Foundation��6(   $��220,21,142,0q�6X   $	��454��6n   $��33��6z   $��Arial Black)�6�   $��20(�6�   $��Center=�6�   $	��Top=�6�   �� 5   "   -   5        $ txtId��5   *   $
��Left=�69   $��46��6T   $
 Wrap=�6`   $	��Top=�6t   $	��516��6�   $��220,131,0,0q�6�   	 �� 	IsEnabled	 . $��30(�6�   �� 5   "   $	��Id:��6(   $
��Left=�66   $	��Top=�6Q   $ 3.079,3.622&�6i   $��105,132,0,0q�6�   $��Arial)�6�   $
��Bold"�6�   $��20(�6�   �� 5   "   $��	Join Date��6(   $
��Left=�6<   $	��Top=�6W   $ 3.079,3.622&�6o   $��105,202,0,0q�6�   $��20(�6�   $��Arial)�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5   "   -   5        
  Name$
 dateJoinDate��5   `   $
��Left=�6-   $	��Top=�6H   
���   �$��220,189,0,0q�6�   $��44��6�   $	��516��6�      IsTodayHighlighted . ���	#8900BFFF
������ 6   �� 5   "   -   5        $ 
btnRefresh��5   )   $��Refresh��6=   $
��Left=�6O   $	��Top=�6j   $��81��6�   $��309,256,0,0q�6�   $ 0.242,-0.114&�6�   
���   �
����� �6�   �� 5   "   -   5        $ btnSave��5   )   $
��Save��6:   $
��Left=�6I   $	��Top=�6d   $��75��6|   $��424,256,0,0q�6�   $ 0.242,-0.114&�6�   
���   �
����� �6�   �� 5    "   -	   5        $ 	btnUpdate��5    )   $
��Edit��6<   $
��Left=�6K   $	��Top=�6f   $��75��6~   $��536,256,0,0q�6�   $ 0.107,0.438&�6�   
���   �
����� �6�   �� 5!   "   -
   5        $ 	btnDelete��5!   )   $��Delete��6<   $
��Left=�6M   $	��Top=�6h   $��99��6�   $��637,256,0,0q�6�   $ -0.091,0.75&�6�   
���   �
����� �6�   &   System.Windows.Controls.DataGrid  5"   "   -   5          Name$ dataGridSupplier��5"   +   $
��Left=�6E   $	��210��6`   $��
105,0,0,43q�6n   $��Bottom=�6�   $	��631��6�   ���	#FFE1F3F9���	#8900BFFF"   VerticalScrollBarVisibility$ Visible=�6     AutoGenerateColumns .     
IsReadOnly .    Columns 5#   &   0  *System.Windows.Controls.DataGridTextColumn  5$   *   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6=   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 5%   =   �� *Id+  5&   *   $
 Name��6=    5'   =   �� *Name+  5(   *   $ 	Join Date��6=    5)   =   �� *
JoinDate+ �� StringFormat$ 
dd/MM/yyyy��4
  .System.Windows.Controls.DataGridTemplateColumn
  5*   *   $ Action��6A    
  CellTemplate 5+   .   �� 5,   2   .R�5-   6   �� $ btnDeletedqSupplier��6=   -   5        #��[  5-   Z   
����� �$��20��6�   $��20��6�   ��6�   Z� .��5.   :     $ Trash=�6R   $��15��6`   $��15��6l   $��0q�6w   5/   7   50   3   52   +   54   #   56      57      58      �� 59      $��Champagne & Limousines)�6   $��
Aldy Cahya��6E   $��18(�6Z   $��25q�6h   
����� �6t   5:      5;      5<      5=      5>      