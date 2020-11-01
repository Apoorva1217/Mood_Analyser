read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Use Reflection to change mood dynamically"
git push origin $a
git checkout master
git merge $a
git push origin master --force
