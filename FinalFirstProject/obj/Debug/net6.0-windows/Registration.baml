   M S B A M L   `   `   `  ????L  HFinalFirstProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalFirstProjectFinalFirstProject  5   	   $    FinalFirstProject.Registration   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   1localclr-namespace:FinalFirstProject     5   	   ???#991426  ? Title$  Registration??5	   	   $	??450??6   $	??800??6+   .??5
      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $??0.75* ?6   6/   ?? 5      $??* ?6   6+   ?? 5      $??0.75* ?6   6/   .+?5   
   ?? $??1??6   $??1??6!    ?? TextAlignment$ Center=?61   $??Center=?6H   $??15(?6c   $??Verdana)?6q   
???????><Приветствуем Вас на регистрации!?? 6?   ><Введите пожалуйста логин/пароль!6?   ?? 5   
   $??2??6   $??1??6"   $??Center=?62   .+?5      ?? $??Login:??6   $??Verdana)?6M   
??????? ?? Target 6%   ??  ?? ElementName$ loginBox??6b   ?? 5      -   5        $??loginBox??5       ?? 	MaxLength$ 55??6&   $??30??65   $??15(?6A   $??Verdana)?6O   5      ?? 5   
   $??3??6   $??1??6"   $??Center=?62   .+?5      ?? $??	Password:??6   $??Verdana)?6S   
??????? 6(   ?? $ passwordBox??6h   G? 5       -   5        $??passwordBox??5    +    G? PasswordChar$ *??6    G? 	MaxLength$ 55??6>   $??30??6M   $??15(?6Y   $??Verdana)?6g   5!      ?? 5"   
   -   5        $??5??5"      $??1??6   $	??180??6.   $	??120??6=   $??40??6L   $??30??6[   $*??$Зарегистрироваться??6j   ???#059923$??Verdana)?6?   
???????	 ? 	Resources	 5#      
 ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5$      "
 ??6   .?5%      ??  ?@??CornerRadius$ 20??65   5&      5'      5(      5)      5*      