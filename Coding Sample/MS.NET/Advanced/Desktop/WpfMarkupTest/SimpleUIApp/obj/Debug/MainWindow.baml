   M S B A M L   `   `   `  ����F  BSimpleUIApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SimpleUIAppSimpleUIApp  5   	       SimpleUIApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SimpleUIApp     5   	     � Title$  SimpleUIApp��5   	   $��340.79��6   $��381.579��6-    � 
ResizeMode$ CanMinimize=�6=    � WindowStartupLocation$ CenterScreen=�6V   .��5	      �� -   5        .+�5
   
   �� -   5         ��Name$ outputTextBlock��5
       �� Left$ 22��6-   $
��Wrap=�6>   $��Welcome User��6R   
 �� Top$ 24��6f    J� RenderTransformOrigin$ -0.56,-2.967&�6v   $��14(�6�   �� 5   
   $ 22��6   $
��Wrap=�6%   $��Person:��69   $ 92��6H   �� 5   
   -   5         ��Name$ personTextBox��5      $��23��6)   $	 162��65    �� TextWrapping$
 Wrap=�6G   $ 91��6[   $	��175��6k   �� 5   
   $ 22��6   $
��Wrap=�6%   $��Period:��69   $	 143��6H   $ -0.448,0.082&�6Y   �� 5   
   -   5        	 ��Name$	 periodComboBox��5      $	 162��6+   $	 140��6=   $	��175��6N   
 �� SelectedIndex$
 0��6Z   .@�5      �� $��Night��6   �� 5      $��Morning��6   �� 5      $��	Afternoon��6   �� 5      $��Evening��6   5      �� 5   
   -   5         ��Name$ greetButton��5      $��Greet��6&   $	 146��66   $	 235��6H   $��75��6Y   $��25��6d   {�6p   �� *Text.Length+ �� ElementName$ personTextBox�� �� Mode$ OneWay=�6�   5      5      