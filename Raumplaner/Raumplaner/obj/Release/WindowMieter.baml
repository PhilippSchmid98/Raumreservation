   M S B A M L   `   `   `  ���� E  ARaumplaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Raumplaner
Raumplaner      Raumplaner.WindowMieter   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Raumplaner     -     � Title$  
Raumplaner��$	��400��$	��600��.���  � RowDefinitions �� $��50 ��� $��* ��� $��40 �.+��� $��Freie Räume��$��30(�$��2��$��2��&   System.Windows.Controls.DataGrid  -   $��dgRooms��$��1��$��5q�   
IsReadOnly .    AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *RoomId+  $ Anzahl Plätze�� �� *
Capacity+  $ Beschreibung��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *  �� *Description+  $ Etage�� �� *Floor+  $ Gebäude�� �� *
Building+�� $��30��$
��Von:��$��5q�$��2��$��40��$
��Left=�(  "System.Windows.Controls.DatePicker  -   $��	StartDate��$��2��$	��100��$��30��$��50,4.6,0,5.4q�$
��Left=�   Text$ Start Datum���� $��30��$
��Bis:��$��150,3.6,0,6.4q�$��2��$��40��$
��Left=�  -   $��EndDate��$��2��$	��100��$��30��$��195,4.6,0,5.4q�$
��Left=�$ Start Datum���� -   $��	btnFilter��$��2��$��Right=�$��70��$��Filter��$��5q�