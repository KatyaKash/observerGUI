   M S B A M L   `   `   `  ????F  BobserverGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:observerGuiobserverGui  5   	   #    observerGui.StatisticsDisplay   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:observerGui     5   	     ? Title$  StatisticsDisplay??5   	   $	??400??6#   $	??300??60    ? Left$
 1100??6<   .??5	      ? .+?5
   
   ?? $??Макс. темп.??6   $
??Left=?6&   $??29??6A   $??	26,75,0,0q?6M   $	??Top=?6`   $	??119??6x   ?? 5   
   $??Мин. темп.??6   $
??Left=?6%   $??30??6@   $??
26,108,0,0q?6L   $	??Top=?6`   $	??119??6x   ?? 5   
   $%??Сумма температур??6   $
??Left=?6+   $??29??6F   $??
26,138,0,0q?6R   $	??Top=?6f   $	??119??6~   ?? 5   
   $&?? Кол-во обновлений??6   $
??Left=?6,   $??30??6G   $??
26,167,0,0q?6S   $	??Top=?6g   $	??119??6   ?? 5   
   -   5         ??Name$ Label_max_temp??5      $?? ??6(   $
??Left=?64   $??28??6O   $??
206,79,0,0q?6[   $	??Top=?6o   $??74??6?   ?? 5   
   -   5        $ Label_min_temp??5      $?? ??6(   $
??Left=?64   $??28??6O   $??206,107,0,0q?6[   $	??Top=?6p   $??74??6?   ?? 5   
   -   5        $ Label_sum_temp??5      $?? ??6(   $
??Left=?64   $??28??6O   $??206,139,0,0q?6[   $	??Top=?6p   $??74??6?   ?? 5   
   -   5        $ Label_readings??5      $?? ??6(   $
??Left=?64   $??29??6O   $??206,165,0,0q?6[   $	??Top=?6p   $??74??6?   ?? 5   
   -   5        $??Подписаться??5      $
??Left=?6)   $??15??6D   $??	23,24,0,0q?6P   $	??Top=?6c   $	??133??6{   6?   ?? 5   
   $+??%Средняя температура??6   $
??Left=?6.   $??30??6I   $??
23,224,0,0q?6U   $	??Top=?6i   $	??157??6?   $
??Bold"?6?   ?? 5   
   $'??!Средняя влажность??6   $
??Left=?6,   $??30??6G   $??
23,255,0,0q?6S   $	??Top=?6g   $	??157??6   $
??Bold"?6?   ?? 5   
   $%??Среднее давление??6   $
??Left=?6+   $??30??6F   $??
23,284,0,0q?6R   $	??Top=?6f   $	??157??6~   $
??Bold"?6?   ?? 5   
   -   5        $ Label_avg_temp??5      $?? ??6(   $
??Left=?64   $??29??6O   $??206,225,0,0q?6[   $	??Top=?6p   $??74??6?   ?? 5   
   -   5        $ Label_avg_hum??5      $?? ??6'   $
??Left=?63   $??29??6N   $??206,255,0,0q?6Z   $	??Top=?6o   $??74??6?   ?? 5   
   -   5        $ Label_avg_press??5      $?? ??6)   $
??Left=?65   $??29??6P   $??206,284,0,0q?6\   $	??Top=?6q   $??74??6?   5      5      