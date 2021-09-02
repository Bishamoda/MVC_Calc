
![калкМВС](https://user-images.githubusercontent.com/63037087/131790711-1e229289-e076-494b-bff1-412036494175.PNG)

# MVC_Calc


#How to install this App

Clone this app on your computer (select the folder yourself) with comand:
git clone https://github.com/Bishamoda/MVC_Calc.git

Open "CMD" in folder (which were chosen earlier). Write commands:  
cd MVC_Calc\WebAppCore  
dotnet build  
dotnet run  

After that, open the browser and enter: http://localhost: 5000/. 

#How it works

1) The programm will show available operations and ask you to enter a numbers (FirstNumber and SecondNumber).  
2) Available operations buttons: addition (+), multiplication (*), subtraction(-), division(/), and resets the result - C.  
3) Next you press the button with the desired operation. Automatically, FirstNumber will seem as a result and further operations will be used this number.  
For example: Enter the number 4, operation "-", and SecondNumber 6. The result will be: -2. Now your FirstNumber is equal -2.
4) After that, if you enter the letter "с" in the operation, then the result will be reset and will be 0, First and Second numbers also take a value 0.  
6) If the user writes instead of a letter, the program will display 0 in all boxes. Division on 0 will also lead to this case.  
7) The program takes the numbers integer and floating point. Positive and negative.  