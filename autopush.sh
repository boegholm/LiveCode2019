#!/usr/bin/bash

if ! ps -p $SSH_AGENT_PID > /dev/null
then
  eval `ssh-agent -s`
fi

if ! ssh-add -l | grep -q "$(ssh-keygen -lf ~/.ssh/id_rsa | awk '{print $2}')"; 
    then ssh-add 
fi

while true; do 
git add .
git commit -m auto_`date +%F_%R`
git push
echo Waiting 5 minutes...
sleep 300
done




