   M S B A M L   `   `   `  ����E  ARaumplaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Raumplaner
Raumplaner  5   	       Raumplaner.WindowMieter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Raumplaner     5   	   -   5          � Title$  
Raumplaner��5   	   $	��400��6   $	��600��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��Freie Räume��6   $��30(�6&   $��2��64   $��2��6H   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgRooms��5      $��1��6"   $��5q�6/      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *RoomId+6@     5      $ Anzahl Plätze��6B    6%   �� *
Capacity+6B     5      $ Beschreibung��6E      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[    6%   �� *Description+6[     5      $ Etage��6?    6%   �� *Floor+6?     5      $ Gebäude��6B    6%   �� *
Building+6B   5      �� 5   
   $��30��6   $
��Von:��6   $��5q�6+   $��2��66   $��40��6C   $
��Left=�6N   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	StartDate��5      $��2��6&   $	��100��63   $��30��6?   $��50,4.6,0,5.4q�6K   $
��Left=�6a      Text$ Start Datum��6|   �� 5   
   $��30��6   $
��Bis:��6   $��150,3.6,0,6.4q�6+   $��2��6B   $��40��6O   $
��Left=�6Z     5   
   -   5        $��EndDate��5      $��2��6$   $	��100��61   $��30��6=   $��195,4.6,0,5.4q�6I   $
��Left=�6`   $ Start Datum��6{   �� 5   
   -   5        $��	btnFilter��5      $��2��6"   $��Right=�6/   $��70��6K   $��Filter��6V   $��5q�6g   6r   5       5!      