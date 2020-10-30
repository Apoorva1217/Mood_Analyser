read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Inform user if enetred Invalid Mood, in case of NULL or Empty throw Exception"
git push origin $a
git checkout master
git merge $a
git push origin master --force
