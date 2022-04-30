echo Enter the filename
read file
c=$(cat $file | wc -c)
w=$(cat $file | wc -w)
l=$(grep -c "." $file)
echo Number of characters in $file is $c
echo Number of words in $file is $w
echo Number of lines in $file is $l

#Enter the filename
#28_check_word_line.sh
#Number of characters in 28_check_word_line.sh is 215
#Number of words in 28_check_word_line.sh is 44
#Number of lines in 28_check_word_line.sh is 8