   M S B A M L   `   `   `  ????L  HFinalFirstProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalFirstProjectFinalFirstProject  5   	   U QSystem.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aO8clr-namespace:System.Collections;assembly=System.RuntimeSystem.Collections 5   	   '    !FinalFirstProject.MainWindowStock   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   1localclr-namespace:FinalFirstProject     5   	   Pcollections8clr-namespace:System.Collections;assembly=System.Runtime     5   	     ? Title$  Stock??5	   	   $	??450??6   $	??800??6$   $	??800??60   $	??450??6?   ???#991426.??5
      ?  ? ShowGridLines$ False??6    ? RowDefinitions 5   
   ?? 5      6   ?? 5      $??2* ?6   6*   ?? 5      $
??0.5* ?6   6,   ?? 5      $??* ?6   6)    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $??0??6   $??0??6!   $??Center=?61   $??Center=?6L   $??50??6i   $??15(?6u   $??Verdana)?6?   
???????$??5??6?   ECДобро пожаловать в приложение Склад!?? 6?   KIПожалуйста выберите доступное действие6  ?? 5   
   $??1??6   $??1??6$   $??2??64   $??Right=?6H   .??5      &   System.Windows.Controls.DataGrid  -   5          Name$ ProductsGrid??5         AutoGenerateColumns$
 True??6-      Products#???   6H   $??Center=?6}    ? 	Resources 5      "  System.Collections.ArrayList   FinalFirstProject.Product   ProductName   Price	   Quantity??%Y   &	          5        5      $
 Name??6(   $ 0??6;   $	 0??6E   5      5      5       5!      ?? 5"   
   -   5        $??3??5"      $??1??6   
 ? ToolTip$<
 6Показать все продукты из базы??6.   $	??180??6X   $	??120??6g   $??40??6v   $??30??6?   $&?? Прочитать из базы??6?   ???#059923
???????$??Verdana)?6?    5#       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5$      " ??6   .?5%      ??  ?@??CornerRadius$ 20??65   5&      5'      5(      ?? 5)   
   -   5        $??3??5)      $??3??6   $:
 4Добавить в базу новую запись??6.   $	??180??6W   $	??120??6f   $??40??6u   $??30??6?   $"??Записать в базу??6?   ???#059923
???????$??Verdana)?6?    5*      ??%_   '??       ?? 5+      " ??6   .?5,      ??  ?@??CornerRadius$ 20??65   5-      5.      5/      50      51      