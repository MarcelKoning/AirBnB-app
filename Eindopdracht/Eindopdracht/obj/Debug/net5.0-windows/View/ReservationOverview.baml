   M S B A M L   `   `   `  ????G  CEindopdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Eindopdracht.ViewEindopdracht.View  5      +    %Eindopdracht.View.ReservationOverview   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Eindopdracht.View     5        N? Title$  ReservationOverview??5	      .??5      ? ??5   
   ?? 5       ?? ImageSource$ /Background2.png??6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ]? .+?5       ? -   5          ?Name$ _NavigationFrame??5        ? NavigationUIVisibility$ Hidden=?6.   5      ?? 5   
   -   5        $??ReservationGrid??5      $??1??6*   $??
0,215,10,0q?67   ??6L   ?? *AllReservations+ ?? SelectedItem 6t   ?? *SelectedReservation+ ?? View 5      ?? 5      -   5        grdTest??.P?5      ?? $??
Start Date??6%    ?? Width$	 150??6g    ?? DisplayMemberBinding 69   ?? *
Start_date+6g   ?? 5      $??End Date??6%   $	 150??6a    67   ?? *
End_date+6a   ?? 5      $??House??6%   $	 100??6e    64   ?? *House.HouseName+6e   ?? 5      $??Customer??6%   $	 120??67   	 ?? CellTemplate	 5      ?? 5       .R?5!   "   ?? ??5"   &   `? 5#   *   
 ?? StringFormat$
 {0} {1}??67   .1?5$   .   ??  ?? Path$ Customer.FirstName?66   ?? 5%   .   $ Customer.LastName?66   5&   +   5(   #   5)      5+      ?? 5,      $??Total Price??6%   $ 75??6a    6:   ?? *Price+6a   5-      5/      ?? 50   
   -   5        $??	btnUpdate??50   O   $??Update??6   $??1??6"   $??28??6/   $??
176,20,0,0q?6;   $
??Left=?6`   $	??Top=?6{   $	??114??6?    ? 	Resources 51       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 52      " ??6   .?53      ??  ?@??CornerRadius$ 10??65   54      55      56      ?? 57   
   -   5         ??Name$ openAddReservationPage??57      $??Add Reservation??61   $
??Left=?6K   $??	36,20,0,0q?6f   $??1??6y   $	??Top=?6?   $??28??6?   $	??114??6?    58      ??%_   '??       ?? 59      " ??6   .?5:      ??  ?@??CornerRadius$ 10??65   5;      5<      5=      ?? 5>   
   -   5        $ 	btnDelete??5>      $??Delete??6$   $??1??65   $??28??6B   $
??Left=?6N   $??
316,20,0,0q?6i   $	??Top=?6}   $	??114??6?   ??6?   ?? *DeleteReservationClick+ 5?      ??%_   '??       ?? 5@      " ??6   .?5A      ??  ?@??CornerRadius$ 10??65   5B      5C      5D      5E      5F      