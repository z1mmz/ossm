   M S B A M L   `   `   `  ����   ossm    ossm.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  -     �Name$  Window�� � WindowStyle$
 None=� � 
ResizeMode$ CanMinimize=� � Title$2 ,Open Source Study Manager Project ALPHA 0.01��$	��640��$	��480�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�.��� -    �Name$ 
LayoutRoot��$��-11,0,-12,-17q� � RowDefinitions �� $	��47* ��� $
��404* � � ColumnDefinitions �� $	��61* ��� $
��163* ��� $	��93* �.+�� $	��632��$
��Left=�$	��449��$	��Top=�$��3��$��2��$��11,0,0,0q�.+�� $
��Left=�$	��449��$	��Top=�$	��632��
������� �� $
��107* ��� $
��490* ��� $	��35* ��� $��0* �.+�0  *Microsoft.Expression.Shapes.RegularPolygon  $��1�����	#FFFFCB81$
��Left=�$��102.666��	   InnerRadius$	 1Q�$��374.333,-26.666,-80.333,0q�
   
PointCount$
 3Q� �� Stretch$
 Fill=�$	��Top=�$	��231��$��3��  $��1�����	#FFB61616$
��Left=�$��79.186��$	 1Q�$��283.101,-3.092,0,0q�$
 3Q�$
 Fill=�$	��Top=�$��180.79�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 179.994Q�T� �� -    ��Name$ 
TabControl�� �� TabStripPlacement$
 Left=�$	��373��$	��Top=�$��	0,76,10,0q�$��3����Z� ���� .@��� -    ��Name$ HomeTab��$��0q�$
��Home��$��16(�$#��/ossm;component/Fonts/#Tahoma)�$��27��$��-1,-0.999,-20,0q�$	��Top=���Z� ��Z� .��� $��
21,2,21,27q�
������� �� $
��310* ��� $
��189* � �� .+��� -    ��Name$ ClassComboBox�� �� SelectedItem$ Select Subject��$
��Left=�$��28��$��	10,44,0,0q�$	��Top=�$	��368��$ -1.108,0.913&�$��2��
�����������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FF0F0F0F��$ 1Q��� $��Select Subject��$
��Left=�$��	10,10,0,0q�$	��Top=�$ 0.509,-0.293&��� -    ��Name$ openClassDetails��$
��Open��$
��Left=�$��	95,44,0,0q�$	��Top=�$��75��$��1��$��28���� -   $ SettingsTab��$��Manage
Subjects��$��16(�$#��/ossm;component/Fonts/#Tahoma)�$��1,50,-21,-50q�$��48��$	��Top=���Z� ��Z� .��� 
�������$��	21,0,-3,0q�.+��� $
��Left=�$��51��$��	38,32,0,0q�$
��Wrap=�$	��Top=�$	��195���� $%�Double click to delete subjects���� �� �� -    ��Name$ SubjectListDeleteBox��$
��Left=�$	��238��$��	38,83,0,0q�$	��Top=�$	��239���� -	   $ AddClassTab��$��Add Subject��$��16(�$#��/ossm;component/Fonts/#Tahoma)�$��-1,-49,-19,49q� J� IsHitTestVisible . ��Z� ��Z� .��� 
�������$��
20,0,-13,0q�.+��� $��Subject Code��$
��Left=�$��	10,28,0,0q�$	��Top=�$��26��$	��104���� $��Subject name��$
��Left=�$��	10,59,0,0q�$	��Top=�$��26��$	��117���� $��Description
��$
��Left=�$��	10,90,0,0q�$	��Top=�$��42��$	��104���� -
    ��Name$ subjectCodeText��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$	��Top=�$	��333��$��
151,28,0,0q��� -   $ subjectNameBox��$
��Left=�$��23��$
 Wrap=�$	��Top=�$	��333��$��
151,62,0,0q��� -   $ subjectDescBox��$
��Left=�$	��248��$��151,104,0,0q�$
 Wrap=�$	��Top=�$	��333���� -   $ 
AddSubject��$��Add Subject��$
��Left=�$��
15,197,0,0q�$	��Top=�$	��112��$��30���� -   $ SettingsTab_Copy��$��Settings��$��16(�$#��/ossm;component/Fonts/#Tahoma)�$��0,29,-20,-29q�$��27��$	��Top=���Z� ��Z� .��� 
�������$��	21,0,-3,0q�.+��� $
��Left=�$	��325��$��42,0,0,0q�$
��Wrap=�$	��Top=�$	��394���� $,�&OSSM Open Source Study Manger Apha 0.0���� $�2���� �� $�Code By Wolf Zimmermann���� �� $�Design reference by ���� $�Arapaoa Moffat���� �� $� ���� �� $u�oThis project is in its very early stages so expect data loss and do not trust it fully yet be safe make backups���� �� $!�Contact Wolf about any bugs���� �� �� �� $U�OSettings will be implements soon dont worry ill let you change the colours soon���� �� $�		���� �� $�		Latest Changes���� �� $<�6File & folder Drag and drop working for subjects files���� -   $ Close��$��X��$
��Left=�$��Bottom=�$��35��$��2��$��10,-1,-10,415q����	#FFFF8080$ 1.083,0.551&�
�������$��35��$��2��$
��Bold"�$��14(���Z� �� -   $ Minimise��$��-��$
��Left=�$��Bottom=�$��35��$��1��$��466,-1,0,415q�$ 1.083,0.551&�
�������$��35��$
��Bold"�$��
Wide Latin)�$��16(�$��2����Z� ��Z� �� $
��OSSM��$
��Left=�$
��Left=�$	��480��$��Bottom=�$��77��
�������$��48(�$��
0,-1,0,373q�$ 0.5,0.5&�$��2��$
��Auto=����	#FF0021FF J� Opacity$
 0.36Q�$
��Bold"� � Cursor$ Arrow��      Opacity$	 0.2Q�$ 15Q�   RenderingBias$ Quality=�    ShadowDepth$  2Q�!   Color$! 	#FF626789���� $��2�����	#FFF4F4F5$
��Left=�$	��108��$��
36,-32,0,0q�$��2��$	��Top=�$��9���� $��2�����	#FFF4F4F5$
��Left=�$	��108��$��
22,-32,0,0q�$��2��$	��Top=�$��9���� $��2�����	#FFF4F4F5$
��Left=�$	��108��$��
50,-32,0,0q�$��2��$	��Top=�$��9���� -   $ timeTableButton��$��	TimeTable��$
��Left=�$	��Top=�$	��118��$��	11,77,0,0q�$��1��$��25��
�������
�������$��16(�