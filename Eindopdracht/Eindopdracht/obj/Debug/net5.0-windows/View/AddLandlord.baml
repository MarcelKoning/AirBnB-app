   M S B A M L   `   `   `  ????G  CEindopdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Eindopdracht.ViewEindopdracht.View  5      #    Eindopdracht.View.AddLandlord   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Eindopdracht.View     5        N? Title$  AddLandlord??5	      .??5      ? ??5   
   ?? 5       ?? ImageSource$ /Background2.png??6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? -   5        $??UserGrid??5      $??1??6#   $??4,178,12,13q?60   ??6F   ?? *AllLandlords+ ?? View 5      ?? 5      -   5        grdTest??.P?5      ?? $??
First Name??6%    ?? Width$	 120??6e    ?? DisplayMemberBinding 69   ?? *	FirstName+6e   ?? 5      $??	Last Name??6%   $	 120??6b    68   ?? *
LastName+6b   5      5      ?? 5   
   -   5        $??txtFirstName??5   Y   $??1??6   $??23??6   $
??Left=?6+   $??	80,35,0,0q?6F   $	??Top=?6m   $	??178??6?   ??6?   ?? *
_FirstName+?? 5   
   -   5        $??txtLastName??5   Y   $??1??6   $??23??6   $
??Left=?6+   $??	80,62,0,0q?6F   $	??Top=?6l   $	??178??6?   ??6?   ?? *	_LastName+?? 5   
   -   5        $??label2??5   k   $??	Last Name??6   $??1??6$   $??28??61   $
??Left=?6=   $??	12,60,0,0q?6X   $	??Top=?6y   ?? 5   
   -   5        $??label3??5   l   $??
First Name??6   $??1??6%   $??28??62   $
??Left=?6>   $??	12,35,0,0q?6Y   $	??Top=?6z   ?? 5    
   $??Create??61   $
??Left=?6B   $??
80,102,0,0q?6]   $??1??6q   $	??Top=?6~   $??28??6?   $	??114??6?   ??6   ?? *AddNewClick+ ? 	Resources 5!       ?? 
TargetType ?? Property	 ?? Value??%_   '??       ?? 5"      " ??6   .?5#      ??  ?@??CornerRadius$	 10??65   5$      5%      5&      5'      5(      