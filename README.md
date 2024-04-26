# Introduction
This repo contain some assets and scripts to display pacman_game in 3D with unity.

>[!NOTE]
>You can install Unity in their office web : https://unity.com/download

# How to run

## Unity Side

1. Clone this repository with submodules

    $ git clone --recursive git@github.com:wennnny/PacMan-unity.git

2. Open the project "PacMan-unity" in unity.

3. Choose "SimpleScenes" in /Assets/Scenes in Project in the lower left.

4. Set IP in "Update_IP"(you need config your ip in the device where you run pacman.py)

5. Press "run" button on unity then run your python code on another device.

## Pygame Side

Clone this pygame repository at https://github.com/ARG-NCTU/oop-proj-bt-pacman

    $ git clone git@github.com:ARG-NCTU/oop-proj-bt-pacman.git

#### Terminal 0 - Check IP

    $ ifconfig

#### Terminal 1 - Run Rosbridge

    $ source docker_run.sh
    $ source environment.sh
    $ roslaunch rosbridge_server rosbridge_websocket.launch

#### Terminal 2 - Run publisher

    $ source docker_joun.sh
    $ source environment.sh
    $ python3 pacmen_game/AgentsPose_to_unity.py

#### Terminal 3 - Run pygame

    $ source docker_joun.sh
    $ source environment.sh
    $ python3 pacmen_game/pacmen.py

# Demonstration

https://github.com/wennnny/PacMan-unity/assets/133328407/c0939bbc-be7e-400f-aeae-45d2cc8add61
