   M S B A M L   `   `   `  ????Z  VSagittal_from_byMThread_1108022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Sagittal_from_byMThread_1108022Sagittal_from_byMThread_1108022  5   	   0    *Sagittal_from_byMThread_1108022.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Sagittal_from_byMThread_1108022     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??0??6#    ?? Orientation$ 
Horizontal=?5      .+?5      ?? $??Input-image??6   ?? 5      $??X??6   ?? 5      -   5         ??Name$ x1??5      ?? 5      $??Y??6   ?? 5      -   5        $ y1??5      5      ?? 5   
   $??0??6   $??1??6   $??Output-image??5      ? 5!   
   -   5        $??1??5!      $??0??6   
????ح?.+?5$      ?? -   5         ??Name$ axial??5$      .??5%      ?? -   5         ??Name$ inputImage2??5%      5&      5'      ?? 5(   
   -   5        $??
Load-image??5(      $??2??6&   $??0??63    ? ToolTip$% provide Axial.bmp images folder??5)   &   ?? 5-   
   -   5        $ segittal??5-   4   $??1??6   $??1??6$   .??5.      ?? -   5        $ segittalImage??5.      5/      ?? 50   
   $??1??6   $??2??6&   $ 
Horizontal=?51      .+?52      ?? -	   5         ??Name$ Sagittal??52      $??Sagittal-View??6'   $c ]this will generate Sagittal.bmp Images from Axials.bmp at Desktop/SegittalImagesLockBitUnsafe??53   (   $	??100??54      ?? 55      -
   5        $ del_sagittal_balank??55      $??	Del_Blank??62   $??90??56   7   57      5:      5;      