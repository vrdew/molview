# NTU Molecule Viewer
## Introduction
This is a continuation of the previous decrepicated repository of [MoleculeViewerMRTK2](https://github.com/Dhyt1111/MoleculeViewerMRTK2).

NTU Molecule Viewer is an interactive VR educational application designed to aid students in CM3011 to visualize symmetries of molecules and determine point groups.

## Frameworks
Built on MRTK2 and integrated with Meta Quest 3, using Unity Editor 2022.3.41f1.

Build Platform: Android

GPU: RTX 4060 (Laptop) for Meta Quest Linking

Blender 4.2.1 used for 3D modelling, texturing, and animation. The Atomic Blender addon was used for the 3D modelling and texturing of the molecules.

## Requirements for installation
With Meta Quest 3, the primary debugging and building of the HMD is only possible with using Meta Quest Linking, the proprietary software for Oculus device to PC/Laptop/Desktop connection. 

Refer to these [System Requirements](https://www.meta.com/help/quest/articles/headsets-and-accessories/oculus-link/requirements-quest-link/) to know if your system hardware supports this. 

For reference, GTX 1650 on a Legion 5 laptop does not support Meta Quest Link, as stated on the documentation, however Nvidia Quadro P2000 does, even though it isn't listed.

You also will need to create a Meta account and Unity account. Do setup your Meta Horizon app and link it with your HMD, as well as activate the developer mode.

Lastly, you will need to download the Meta Quest Link desktop app. 

## Installation instructions
1) For purposes of saving space, you need only to download the Assets, Packages, ProjectSettings and UserSettings files.
2) Once in your local folder, locate the file folder via Unity Hub.
3) Open it and let it compile the Library folder and temp files.
4) Open the Assets/Scenes/StartScene.unity file to view the stations.

## Controllers
You can either use Oculus Touch Controllers or use Hand Gestures controls.

## Contributors
- [Daniel Han](https://github.com/Dhyt1111) - Backend Unity Programmer
- [Divyansh Jain](https://github.com/Divyansh0987) - 3D Artist
- (Please add your names and role here)

## License
This project is licensed under the MIT License.
