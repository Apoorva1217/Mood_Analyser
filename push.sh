read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Use Reflection to create Mood Analyser with Parameter Constructor"
git push origin $a
git checkout master
git merge $a
git push origin master --force
