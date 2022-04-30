echo "enter five subject marks : -"
read s1
read s2
read s3
read s4
read s5

s=` expr $s1 + $s2 + $s3 + $s4 + $s5 `
a=` expr $s / 5 `

echo " total :  $s " 
echo " pre : $a "

if [ $a -ge 90 ]
then
    echo "Grade: A "
elif [ $a -ge 80 -a $a -lt 90 ]
then
    echo "Grade: B "
elif [ $a -ge 70 -a $a -lt 80 ]
then
    echo "Grade: C "
elif [ $a -ge 60 -a $a -lt 70 ]
then
    echo "Grade: D "
else
    echo "Grade: F "
    fi

#enter five subject marks : -
#78
#78
#65
#54
#34
 #total :  309 
 #pre : 61 
#Grade: D

