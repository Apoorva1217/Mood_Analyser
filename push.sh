read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Given a message, Ability to analyse and respond Happy or Sad Mood"
git push origin $a
git checkout master
git merge $a
git push origin master --force
