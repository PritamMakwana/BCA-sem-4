echo "enter file "
read FILE

if [ -f "$FILE" ]; then
    echo "File $FILE exist."
else
    echo "File $FILE does not exist" >&2
fi
#enter file 
#26_checkfile_Exist.sh 
#File 26_checkfile_Exist.sh exist.