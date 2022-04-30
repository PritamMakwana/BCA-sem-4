N=10
i=1
sum=0
echo "Enter Numbers 10 :"
while [ $i -le $N ]
do
  read num           #get number
  sum=$((sum + num)) #sum+=num
  i=$((i + 1))
done

echo "sum : " $sum

if [ `expr $sum % 2` == 0 ]
then
	echo "$sum is even"
else
	echo "$sum is Odd"
fi

#Enter Numbers 10 :
#1
#2
#3
#4
#5
#6
#7
#8
#9
#10
#sum :  55
#55 is Odd