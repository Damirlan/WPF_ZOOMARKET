   M S B A M L   `   `   `  ����D  @SimpleApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SimpleApp	SimpleApp  5   	       SimpleApp.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SimpleApp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
addProduct��5	   	   $	��450��6   $	��800��6)   .��5
      � ���#599f6a.+�5   
   �� $	��400��6   $��
15,10,15,0q�6    
�������$	��Top=�6G    �� Padding$ 30q�6_   $	��550��6l    �� CornerRadius$ 20��6{   $	��104��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $!��Добавить товар��6   $��30(�62   $
��Bold"�6@   $��0 0 0 20q�6R   5      5      �� 5   
   $	��400��6   $��15,144,15,0q�6    
�������$	��Top=�6H   $ 30q�6`   $	��550��6m   $ 20��6|   $	��250��6�    J� RenderTransformOrigin$ 0.497,0.762&�6�   ._�5      � $��Center=�6    � ColumnDefinitions 5      �� 5      $
��163* �6'   �� 5      $
��327* �6'   .+�5      �� -   5        	 ��Name$	 nameProduct��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$6
 0Введите название продукта��6/    %  !MaterialDesignFloatingHintTextBox#��[  6j   $��0,-18,0,145q�6�   $��2��6�   �� 5      -   5         ��Name$ 
nameAnimal��5      $4
 .Введите породу животного��6/    & "MaterialDesignFloatingHintComboBox#��[ 6i   $
��Left=�6�   $��0,27,0,0q�6�   $��2��6�   $	��Top=�6�   $	��120��6�   .@�5       �� CentralAsian6.   �� 5!      Red6%   �� 5"      
American6*   �� 5#      	African6)   �� 5$      French6(   �� 5%      
Portuguese6,   �� 5&      
Scottish6*   �� 5'      	English6)   5(      �� 5)      -   5        $ nameTop��5)      $4
 .Введите породу животного��6,   #��[ 6f   $
��Left=�6�   $��0,72,0,0q�6�   $��2��6�   $	��Top=�6�   $	��120��6�   .@�5*      �� food6&   �� 5+      	clothes6)   �� 5,      	medicines6+   �� 5-      accessories6-   5.      �� 5/      -   5        $ 	nameBrend��5/      $4
 .Введите породу животного��6.   #��[ 6h   $
��Left=�6�   $��	0,117,0,0q�6�   $��2��6�   $	��Top=�6�   $	��120��6�   .@�50      �� 
royalcanin6,   �� 51      acana6'   �� 52      	proplan6)   �� 53      purina6(   �� 54      	catchow6)   55      �� 59      -   5        $��Добавить��59      $��1,172,0,-32q�6,   $ 
0.33,1.314&�6A    � Cursor$
 Hand��6d   6r   �� 5:      -   5        $��
Назад��5:      $��165,172,0,-32q�6)   $��1��6@   $
 Hand��6P   6^   5;      5<      5?      5@      