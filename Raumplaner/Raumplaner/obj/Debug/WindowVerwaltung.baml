   M S B A M L   `   `   `  ����E  ARaumplaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Raumplaner
Raumplaner  5   	   !    Raumplaner.WindowVerwaltung   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Raumplaner     5   	   -   5          � Title$  
Raumplaner��5   	   $	��400��6   $	��600��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��Reservationen��6   $��30(�6(   $��2��66   $��2��6J   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgReservations��5      $��1��6)   $��5q�66      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ReservationId+6G     5      $ Raum Id��6@    6%   �� *RoomFK+6@     5      $	 Von��6C    6%   �� *	StartDate+6C     5      $	 Bis��6A    6%   �� *	EndDate+6A     5      $ Mieter Nachname��6B    6%   �� *
LastName+6B     5      $ Mieter Vorname��6C    6%   �� *	FirstName+6C     5      $ Mieter Strasse��6@    6%   �� *Street+6@     5      $ 
Mieter Ort��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U    6%   �� *	Village+6U   5      �� 5   
   -   5        $��	btnDelete��5      $��2��6�   $��Right=�6�   $	��100��6�   $��Löschen��6�   $��0,4.6,214.6,5.4q�6�   {�6"   ��  �� ElementName$ dgReservations��	 �� Path$	 SelectedItem�   ObjectConverter
 �� 	Converter#
 [  6�   �� 5   
   -   5        $��btnEdit��5      $��2��6�   $��Right=�6�   $	��100��6�   $��
Bearbeiten��6�   $��0,4.6,109.6,5.4q�6�   {�6    �� $ dgReservations��$	 SelectedItem�#
 [  6�   �� 5    
   -   5        $��btnNeu��5       $��2��64   $��Right=�6A   $	��100��6]   $	��Neu��6i   $��5q�6w   5!      5"      