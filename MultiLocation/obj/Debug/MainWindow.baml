   M S B A M L   `   `   `  ����H  DMultiLocation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MultiLocationMultiLocation  5   	       MultiLocation.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MultiLocation     5   	   -   5          � Title$  Ajouter Location��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $��
Date Debut��6   $
��Left=�6%   $��112,112,0,0q�6@   $	��Top=�6U   $��75��6m   �� 5   
   $��Montant��6   $
��Left=�6"   $��	112,0,0,0q�6=   $��Center=�6P   $	��128��6k   �� 5   
   $��Premier Pay��6   $
��Left=�6&   $��112,159,0,0q�6A   $	��Top=�6V   $��75��6n   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dateDebut��5      $
��Left=�6(   $��192,112,0,0q�6C   $	��Top=�6X   $	��157��6p     5   
   -   5        $ datePremier��5      $
��Left=�6*   $��192,161,0,0q�6E   $	��Top=�6Z   $	��157��6r   �� 5   
   -   5         ��Name$ txt_montant��5      $
��Left=�6'   $��192,210,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��157��6�   �� 5   
   $��Terme��6   $
��Left=�6    $��456,112,0,0q�6;   $	��Top=�6P   $	��128��6h   �� 5   
   $	��NIV��6   $
��Left=�6   $��456,202,0,0q�69   $	��Top=�6N   $	��128��6f   �� 5   
   $��Client��6   $
��Left=�6!   $��456,159,0,0q�6<   $	��Top=�6Q   $	��128��6i   �� 5   
   $��Nb Paye��6   $
��Left=�6"   $��456,242,0,0q�6=   $	��Top=�6R   $	��128��6j   �� 5   
   -   5         ��Name$ btnAddLocation��5      $��Ajouter Location��6)   $
��Left=�6D   $��349,316,0,0q�6_   $	��Top=�6t   $	��139��6�   6�   �� 5   
   -   5         ��Name$ cmbTerme��5      $
��Left=�6%   $��514,113,0,0q�6@   $	��Top=�6U   $	��194��6m   $ �� IsSynchronizedWithCurrentItem$
 trueY�6y    �� DisplayMemberPath$ IdTerme��6�   ��6�   �� 6�   �� 5   
   -   5        $ cmbPay��5      $
��Left=�6#   $��514,244,0,0q�6>   $	��Top=�6S   $	��194��6k   .@�5      �� $��12��6    �� 
IsSelected . 6(   �� 5      $��24��6   �� 5      $��36��6   �� 5      $��48��6   5      �� 5   
   -   5        $ cmbNIV��5      $
��Left=�6#   $��514,204,0,0q�6>   $	��Top=�6S   $	��194��6k   $
 trueY�6w   $ NIVVehicule��6�   ��6�   �� 6�   �� 5   
   -	   5        $ 	cbmClient��5      $
��Left=�6&   $��514,163,0,0q�6A   $	��Top=�6V   $	��194��6n   $
 trueY�6z   $	 Nom��6�   ��6�   �� 6�   �� 5   
   $��Ajouter Location��6   $
��Left=�6+   $��
302,32,0,0q�6F   $	��Top=�6Z   $	��232��6r   $
��Bold"�6~   $��22(�6�   5       5!      