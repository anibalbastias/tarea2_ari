   M S B A M L   `   `   `  ����   Tarea2-ARI (Bastias - Rojas);    5Tarea2_ARI__Bastias___Rojas_.ListarFuncionariosWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$3  -Kiosko System - Tarea 2 ARI (Bastias - Rojas)��5   	   $	��400��6?   $	��700��6L   $��Center=�6X   $��Center=�6u   $��Center=�6�   $��Center=�6�   $	��700��6�   $	��400��6�   $	��700��6�   $	��400��6   � 
ResizeMode$ NoResize=�6   � WindowStyle$ 
ToolWindow=�6*  .��5      � .+�5   
   � $
��Left=�6   $	��270��6*   $��	36,10,0,0q�67   $	��Top=�6J   $	��623��6b   .+�5      �� -   5         ��Name$ 	btnVolver��5      $��Volver��6(   $
��Left=�69   $��422,304,0,-64q�6T   $	��Top=�6k   $	��177��6�   $��30��6�    J� RenderTransformOrigin$ 1.862,-0.636&�6�   6�   �� 5      -   5         ��Name$ txtPrincipal��5      $
��Left=�6.   $��	22,28,0,0q�6I   $
��Wrap=�6\   $	��Top=�6p   $��60��6�   $	��577��6�   $��30(�6�    �� TextAlignment$ Center=�6�   �� 6�    � Language$ es-cl�6�   $)�#KIOSKO SYSTEM - LISTAR FUNCIONARIOS��6�   6	  �� 5	      -   5         ��Name$ listViewUsuarios��5	   -   $��35,84,24,-11q�6   	 �� View	 5
      �� 5      .P�5      �� $	��Nº��6)   
 �� Width$
 25��65    �� DisplayMemberBinding 6@   �� *Num+�� 5      $	��RUT��6)   $
 80��66    6A   �� *Rut+�� 5      $��Nombre Completo��6)   $	
 150��6B    6N   �� *Nombre+�� 5      $��Carrera��6)   $	
 160��6:    6F   �� *	Carrera+�� 5      $�� ��6)   $
 60��63    �� CellTemplate 5      �� 5   "   .R�5   &   �� -   5        $	��Ver��5   -   $��40��6;   $��30��6F   ��6i   �� 5   #   5      �� 5      $�� ��6)   $
 60��63    5      �� 5   "   .R�5   &   �� -   5        $��Editar��5   -   $��40��6>   $��30��6I   ��6o   �� 5   #   5      5      5       5!      5"      5#      