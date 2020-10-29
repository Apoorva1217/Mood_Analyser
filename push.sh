read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Handle Exception if User Provides Invalid Mood, like NULL"
git push origin $a
git checkout master
git merge $a
git push origin master --force
