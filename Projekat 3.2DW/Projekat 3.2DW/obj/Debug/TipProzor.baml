   M S B A M L   `   `   `  ����I  EProjekat 3.2DW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Projekat_3._2DWProjekat_3._2DW  5   	   /clr-namespace:ValidacijaAjdeValidacijaAjde  5   	       Projekat_3._2DW.TipProzor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Projekat_3._2DW     5   	   ,valclr-namespace:ValidacijaAjde     5   	     � Title$  	TipProzor��5	   	   $	��300��6   $	��300��6(   .��5
      �� 
�������.+�5   
   �� $��	10 10 0 0q�6   $��Oznaka: ��6'   �� 5   
   $��
10 0 200 0q�6   .��6&   ��5      �� 5       �� Path$ OznakaResurs�6    �� UpdateSourceTrigger$ PropertyChanged=�6.    �� ValidationRules 5      !   ValidacijaAjde.MinMaxString  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ ConvertedProposedValue=�6+      Mins$ 3Q�6S      Maxs$ 10Q�6\   5      .��5       =� ErrorTemplate 5      �� 5      .R�5      � $��0 0 0 0q�6    � RowDefinitions 5      �� 5      	 � ColumnDefinitions	 5      �� 5      �� 5      $
��Auto �6/   .+�5       �� 
 ��Name$
 textBox��6Q   $��0��64   $��0��6D   6Q   �� 5!      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5"      5#      .��5$   (   5%      �� 5(   
   $��	10 10 0 0q�6   $��Opis: ��6'   �� 5)   
    �� TextWrapping$
 Wrap=�6   $��70��6&   $��	10 0 10 0q�62   �� 5+   
   -   5        $��ikonicaDugme��5+      $��
10 10 10 0q�68   $��Izaberite ikonicu��6L   �� 5,   
   -   5        $��putanja��5,   W   
�������$/��)Ovo je read-only polje za putanju ikonice��6&    �� 
IsReadOnly . $��	10 5 10 0q�6x   � 5.   
   $��0 30 0 0q�6   	 5/      �� 50      $��* �6#   �� 51      $��* �6#   .+�53      �� $��0��6   $��	10 0 10 0q�6%   $��Sacuvaj��68   �� 54      $��1��6   $��	10 0 10 0q�6%   $��Odustani��68   55      57      58      