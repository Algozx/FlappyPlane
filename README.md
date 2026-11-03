# Flappy Plane

A Flappy Bird style game with a plane, made in Unity. Fly through the gaps, don't hit anything and try to get the highest score.

Play it in the browser: https://algozx.github.io/FlappyPlane/

## Controls

- Jump: Space, left mouse button, or tap the screen on a phone
- Restart: click or tap the button on the game over screen

## About

This is an old project. I made it a few years ago while following a Unity course, and I'm keeping it as part of my portfolio. I didn't rewrite the gameplay code on purpose, so the names and comments are still in Portuguese.

I came back to it to make it run on current Unity:

- Updated to Unity 6
- Removed the Android and in-app purchase leftovers, the target is now WebGL
- Added keyboard, mouse and touch input, so it also works in a phone browser
- Replaced the jump sound with a new one
- Added a WebGL build, hosted with GitHub Pages
- Fixed a few bugs (the restart button loaded a scene that no longer existed, and clicking it also made the plane jump)

## Running the project

Open it with Unity 6000.6 or newer, open `Assets/Scenes/FlappyPlane.unity` and press Play.

The WebGL build used by GitHub Pages is in the `docs` folder.

## Credits

- Font: Kenney Future Square by Kenney (CC0)
- Jump sound: generated for this project
