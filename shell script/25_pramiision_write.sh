echo "enter file "
read FILE
 
if [ -w "$FILE" ] 
then
   echo "Write permission is granted on $FILE"
else
   echo "Write permission is NOT granted on $FILE"
fi

#enter file 
#25_pramiision_write.sh\
#Write permission is granted on 25_pramiision_write.sh