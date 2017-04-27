# Change Log
All notable chagnes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/) 
and this project adheres to [Semantic Versioning](http://semver.org/).

---

## [2.3.2] - 2017-04-27
### Added
- New POI objects for the new markers.
- Casino, Tower, Drink, Food, and Hotel markers and POI objects.

### Changed
- New marker visuals.
- Moved the Starting Point POI, it's now used as the Hotel POI.

### Removed
- Arch POI and Marker.
- Entrance POI and Marker.

## [2.3.1] - 2017-04-27
### Added
- Sliced up the UI elements.
- Created the base UI.
- Created the settings menu.

## [2.2.1] - 2017-04-25
### Changed
- Added textures to most of the models.

## [2.1.1] - 2017-04-24
### Added
- Texture folder to hold all the unwrap texture maps.
- Created the materials for the center building.
- Began to apply the materials to the model.

### Changed
- Updated the model.

## [2.0.3] - 2017-04-11
### Changed
- Updated Stars particle system.
- The Day/Night toggle now enables/disables the stars.

## [2.0.2] - 2017-04-11
### Added
- Daylight intensity value to the Manager object.
- Day/Night toggle to the HUD.

## [2.0.1] - 2017-04-10
### Added
- Manager object now gets and stores references to all the POI objects.
- Carousel timer is set to 20s.
- By default the carousel will count down and will move through all the POI objects.
- ResetCarousel is called when the user selects their own POI to move to. We update the currentPOI to reflect their choice.

### Changed
- Changed auto orbit timer from 15s to 5s.
- We now cancle the camera system movement update when the auto orbit begins.
- The MoveCamera function now resets the carousel countdown timer.

## [2.0.0] - 2017-04-03 [RELEASE]

## [1.4.0] - 2017-03-27
### Changed
- Merged feat/UXD into trunk.

## [1.3.4] - 2017-03-27
### Added
- Created a Manager object that stores all the public variable references. Instead of searching through all the objects to adjust settings you can update everything through one object.

## [1.3.3] - 2017-03-27
### Changed
- Adjusted the WebGL settings.
- Reverted the splash screen to 1.3.1.

## [1.3.2] - 2017-03-27
### Added
- Fadeing script that fades the program in from black.

### Changed
- Changed splash screen to have FSU and Pillar Workshop logos.

## [1.3.1] - 2017-03-27
### Changed
- Updated splash screen with a render of the model.

## [1.3.0] - 2017-03-26
### Changed
- Merged feat/auto-Orbit into trunk.

## [1.2.1] - 2017-03-26
### Added
- Created an auto orbit feature.
	- If there is no input for 60 seconds the camera system will start to auto orbit.

## [1.2.0] - 2017-03-26
### Changed
- Merged feat/Markers into trunk.

## [1.1.3] - 2017-03-26
### Added
- Added a shader that ignores Z depth (OverlayMat). 
	- The source code was created by: [DanSuperGP](http://answers.unity3d.com/answers/887523/view.html).

### Changed
- Updated the Camera System (Yaw) prefab to match the current settings.

## [1.1.2] - 2017-03-26
### Added
- Updated the Icon Controller script with the following features:
	- Must be linked to a POI object.
	- Clicking on a marker will update the Camera Systems POI.

## [1.1.1] - 2017-03-26
### Change
- Adjusted the following camera settings:
	- Camera System:
		- Lerp from 5 to 1.
	- Main Camera:
		- Lerp from 5 to 1.
		- Max zoom from 25 to 50.
		- Mouse Sensitivity Scroll from 10 to 7.
- Updated the hierarchy.

### Removed
- Stars.

## [1.0.7] - 2017-03-24
### Change
- Updated Graybox.

## [1.0.6] - 2017-03-13
### Change
- Adjusted mobile orbit sensitivity.
- Updated the graybox model.

## [1.0.5] - 2017-03-13
### Added
- Created a HandleOrbit function that is now called from both the Desktop and Mobile 'mouse' input.
- Created a HandleZoom funciton that handles zooming in and out via scrolling or the new zoom slider UI element.
- Created a MobileZoom function that gets the two touch points on mobile and gets the distance between them. When the amount changes we will zoom in or out.

## [1.0.4] - 2017-03-13
### Added
- MobileInput function that checks to see if we have any touch input. If we do we will calculate the rotations just like we do with the desktop version. We should think about putting some of the functionality into its own function.
- Created a new float value for mobile sensitivity.
- Mobile deltaPosition has to be flipped with *-1.

### Changed
- Created a LimitOrbit function in the CameraController script. We refactored the limiting IF statements into its own function so we can use it for desktop and mobile input.
- When getting the 'axis' for touch input we need to use Input.GetTouch(0).deltaPosition.x and .y if we want it to return a value like the GetAxis input value.

### Removed
- Deleted an extra building on the model.

## [1.0.3] - 2017-02-27 [HOTFIX]
### Changed
- Updated graybox model.

## [1.0.2] - 2017-02-27 [HOTFIX]
### Changed
- Made the stars transparent so they are not as visible.
- Updated the project to work in Unity 5.5.2.

## [1.0.1] - 2017-02-27 [HOTFIX]
### Changed
- Updated graybox model.

## [1.0.0] - 2017-02-26 [RELEASE]

## [0.1.6] - 2017-02-26
### Changed
- Updated all the comments.

### Removed
- Cleaned the IconController script by removing the MoveToPosition function. Icons are now Markers, they have no functionality and are only visuals.
- Removed unused variables in the CameraController script.

## [0.1.5] - 2017-02-26
### Added
- Zooming also stops the Lerps and Slerps.

### Changed
- Updated all the camera positions for the POI objects.

## [0.1.4] - 2017-02-26
### Added
- When adjusting the sliders on a POI object the camera will update to show the new settings using the OnValidate function.
- Created a Point of Interest, Marker, and POI Button tag and applied them to the gameobjects.

## [0.1.3] - 2017-02-26
### Added
- In the POI script we search for the Camera System gameobject by looking for the Camera System tag.
- In the POI script now has a UpdatePOI function, it was taken from ButtonLink.cs.

### Changed
- The HUD buttons now call UpdatePOI from the POI objects instead of their own ButtonLink script.

### Removed
- The HUD buttons no longer have a ButtonLink script attached to them.
- Deleted the ButtonLink.cs file since it is no longer needed.

## [0.1.2] - 2017-02-20
### Changed
- Switched color space back to Gamma so the project works with WebGL.

## [0.1.1] - 2017-02-20 [YANKED]

## [0.1.0] - 2017-02-19
### Added
- Merged the finished camera controls feature into the trunk branch.

## [0.0.12] - 2017-02-19
### Added
- Point of Interest prefab.
- A PoI Controller Script.
- MoveToPosition function that sets the desired yaw, pitch, and zoom in the CameraController class.
- UpdateCamera function that lerps the camera into the correct yaw, pitch, and zoom.
- In CameraMovement we make sure the starting location has a POIController attached to it, then we get the desired info from it.
- Points of Interest around the resort.
- UI buttons for each POI.
- ButtonLink script, it has a UpdatePOI function that gets access to the CameraMovement script and calls the MoveCamera function. It requires a point of interest game object so it can pass it's data along.\
- MoveToPosition function Slerps and Lerps the yaw, pitch, and zoom into the correct positions set by the new point of interest objects settings that were passed in.

### Changed
- The particle emitter is now a prefab called Stars.
- MoveCamera script now takes a target POI object, if the gameobject passed in has a POIController script attached we rip its info. The CameraMovement class still works the same but we pass the new info to the MoveToPosition function in the CameraController script.

## [0.0.11] - 2017-02-19 [YANKED]

## [0.0.10] - 2017-02-19
### Added
- Stars to the environment.
- Star material.
- Star sprite.

### Chaged
- Updated Icon image.
- Updated Global Illumination settings.


## [0.0.9] - 2017-02-13
### Added
- Resized map to fix shadow glitch.
- Removed all but the Entrance Icon.
- Updated Global Illumination settings.

## [0.0.8] - 2017-02-13
### Added
- Starting camera position.
- Added icons to the following positions:
	- Tower
	- Pool
	- Entrance
	- Arch
	- Parking
- A white ground plane.
- Reset the cameras far distance back to 1000.

### Changed
- Updated the starting zoom of the camera.
- Updated the max zoom and min zoom settings to work with the model size. The new values are now 40 min, 200 max, and a new speed of 25.
- Changed the far render distance for the camera from 1000 to 5000 units

## [0.0.7] - 2017-02-13
### Added
- Imported Graybox model of the resort.

## [0.0.6] - 2017-02-13
### Added
- Users can now click and drag with left mouse button to rotate. This does not cause issues with checking for left clicks on buttons because the EventSystem is listening for clicks not holds. The User will accidentally only move to a new position if they start their orbit with their mouse over an icon and they release while still over the icon.

### Changed
- Users no longer use middle mouse button to orbit.
- Commented out the debug prints from Camera Movement and Icon Controller scripts.

## [0.0.5] - 2017-02-13
### Added
- Default icon image to Unity.
- Fixed a bug where the Camera Movement script wasn't moving the camera to the new position, we were missing an EventSystem object in the scene.

### Changed
- Renamed UpdateCamerasTargets to UpdateCamerasTarget in the Icon Controller script.

## [0.0.4] - 2017-02-13
### Added
- CameraController script, it allows the camera to zoom in and out rotate around the object.
- CameraMovement script, it allows the camera to switch targets based on what icon was clicked.
- IconController script, it makes the icon rotate to always face the camera.

### Changed
- There was an issue with folders not staying when they were empty so here is a list of the following folders that will exist with this version:
	- Prefabs
	- Sprites
	- Scirpts

## [0.0.3] - 2017-02-06
### Added
- The following folders to the Unity project:
	- Images
	- Materials
	- Models
	- Prefabs
	- Scripts
	- Textures
- The Main scene for project.

## [0.0.2] - 2017-02-06
### Changed
- Updated the README based on info from the proposal document.

## [0.0.1] - 2017-01-29
### Added
- This CHANGELOG file.

### Changed
- Re-worked the Programming Style to user Allman indent style and the Microsoft .NET Framework style.