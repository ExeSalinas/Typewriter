   M S B A M L   `   `   `  ����E  ATypewriter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Typewriter
Typewriter  5   	       Typewriter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Typewriter     5   	     � Title$  
Typewriter��5   	    � SizeToContent$ WidthAndHeight=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ textBoxPrincipal��5      $��Stretch=�6,   $��25q�6H    �� TextWrapping$
 Wrap=�6T   $	��408��6h    �� 	IsEnabled .  � Cursor$
 Hand��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Ingrese Texto Aqui��6�   	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 . 6�   � 5   
   $��1��6   $��20,20,20,400q�6$   .+�5      �� -   5         ��Name$ txtVelocidad��5      $��18(�6.   $	��120��6=   $��Velocidad: ��6I   $��Stretch=�6\   �� 5      -   5         ��Name$ SliderVelocidad��5      $��30��6.   $	��150��6:    � Maximum$	 100Q�6r    � Minimum$ 10Q�6�   5      �� 5   
   -   5        $��1��5      $��10,20,10,300q�6"   $
 Hand��68   $��36��6[   $��Bottom=�6g   ��5      � 5      .+�5       �� -   5         ��Name$ lblPlay��5       $
��Play��6-   $��26��6=   $��32��6I   �� 5!      -   5         ��Name$ imgPlay��5!      $'��!Recursos/reproductor-de-video.png��6.   $��32��6Y   $��42��6e    J� RenderTransformOrigin$ 0.786,-0.957&�6q   5"      5$      5)      5*      