# Change Log
All notable chagnes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/) 
and this project adheres to [Semantic Versioning](http://semver.org/).

---

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