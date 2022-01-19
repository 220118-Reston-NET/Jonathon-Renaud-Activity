
clear # This will clear our terminal
repeat="true"

while [ "$repeat" == true ]
do
echo "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
echo "~~~~~~~~~~~~~ Basic Calculator ~~~~~~~~~~~~"
echo "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
echo "1. Add two numbers!"
echo "2. Subtract two numbers!"
echo "3. Multiply two numbers!"
echo "4. Divide two numbers! --"
echo "5. Exit Calculator"
read ans

if [ "$ans" == "1" ]
then
echo "Input two numbers you wish to add together"
read num1
read num2
echo "$num1 + $num2 = $(($num1+$num2))"
echo "Press Enter to continue"
read 
elif [ "$ans" == "2" ]
then
echo "Input first number"
read num1
echo "Input number you wish to subtract from the first number"
read num2
echo "$num1 - $num2 = $(($num1-$num2))"
echo "Press Enter to continue"
read 
elif [ "$ans" == "3" ]
then
echo "Input two numbers you wish to multiply together"
read num1
read num2
echo "$num1 * $num2 = $(($num1*$num2))"
echo "Press Enter to continue"
read 
elif [ "$ans" == "4" ]
then
echo "Input first number"
read num1
echo "Input number you wish to divide by"
read num2
while [ "$num2" == "0" ]
do 
echo "Number cannot be zero, please enter a new number..."
read num2
done
echo "$num1 / $num2 = $(($num1/$num2))" 
echo "Press Enter to continue"
read 
elif [ "$ans" == "5" ]
then
echo "Goodbye!"
repeat="false"
else
echo "Command not found"
fi

clear
done
