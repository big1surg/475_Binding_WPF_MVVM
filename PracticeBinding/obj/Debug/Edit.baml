   M S B A M L   `   `   `  ����J  FPracticeBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PracticeBindingPracticeBinding  5   	       PracticeBinding.Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PracticeBinding     5   	     � Title$
  Edit��5   	   $	��170��6   $	��350��6#   .��5	      � $��0 10 0 0q�6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��Center=�6   
���   �$��0��6>   $��0��6N   .��6[   Name:6b   �� 5   
   $��Center=�6   
���   �$��0��6>   $��1��6N   .��6[   Last:6b   �� 5   
   $��Center=�6   
���   �$��0��6>   $��2��6N   .��6[   Email:6c   �� 5    
   -   5        $
��user��5       $	��250��6   $��0��6*   $��1��67   $��20��6G   .��6S   ��5!      �� 5"       �� Path$
 Name�6    �� UpdateSourceTrigger$ Explicit=�6&    �� ValidationRules 5#      $   PracticeBinding.TextLengthRule  5$      
   Max$ 25��6/      
EmailCheck$ 0��68   5&      .��5'      5(      �� 5)   
   -   5        $��userlast��5)      $	��250��6"   $��1��6.   $��1��6;   $��20��6K   .��6W   ��5*      �� 5+      $ LastName�6   $ Explicit=�6*    5,        5-      $ 25��6/   $ 0��68   5/      .��50      51      �� 52   
   -   5        $��	useremail��52      $	��250��6#   $��2��6/   $��1��6<   $��20��6L   .��6X   ��53      �� 54      $ Email�6   $ Explicit=�6'    55        56      $ 25��6/   $ 1��68   58      .��59      5:      � 5<   
   $��1��6   $��3��6$    � Orientation$ 
Horizontal=�61   $��Right=�6J   $	��250��6f   .+�5=      �� -   5        $��3q�5=      $��70��6    .��6G   Update��5>      �� 5?      	 �� 
TargetType"	 ��6   .�5@      �� 
 �� Property
 � {� �� Value . 66    �� Triggers 5A      ^� 5B       ^� 
Conditions 5C   "   �� 5D   &    �� Binding 60   �� $ (Validation.HasError)� �� ElementName$
 user�� �� Value	 False6q   �� 5E   &    60   �� $ (Validation.HasError)�$ userlast��	 False6u   �� 5F   &    60   �� $ (Validation.HasError)�$ 	useremail��	 False6v   .0�5H   "   �� 
 � {� . 6>   5I      5K      5M      �� 5N      -   5        $��3q�5N      $��70��6    .��6G   Cancel/Exit6T   �� 5O      -   5        $��3q�5O      $��70��6    .��6G   Delete6O   5P      5R      5S      