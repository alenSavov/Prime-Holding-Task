Start application from Visual Studio.
	
From console you have chance to register new card or make purchase.
The input is array divided by blank space.
 For example:
 RegisterCard Silver 1
 
On first position is main command and you have choise to RegisterCard or MakePurchase 
	
	If you choice RegisterCard command:
		on second position choise from types card - Bronze, Silver, Gold
		on third positin you need to write id for card
		
	If you choice MakePurchase command:
		On second positin write id on the already created card
		On third positin write purchaise sum for example: 500
		
	If you want to close the system write: Shutdown
	
	Example Inputs for creating new card:
	01: RegisterCard Bronze 1
	02: RegisterCard Silver 2
	03: RegisterCard Gold 3
		You cannot make new card with already created card with this id
		
	
	Example Inputs for making purchaise
	01: MakePurchase 1 800
	02: MakePurchase 2 1000
	03: MakePurchase 3 1300
	