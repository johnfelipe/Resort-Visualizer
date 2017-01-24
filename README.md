<p style="text-align: center;">
![Resort Visualizer](http://i.imgur.com/ohEL0KO.png)

[![](https://img.shields.io/badge/made%20by-Ferris%20State%20University-blue.svg?style=flat-square)](http://www.ferris.edu/dagd/) [![](https://img.shields.io/badge/engine-Unity-brightgreen.svg?style=flat-square)](https://unity3d.com/) [![](https://img.shields.io/badge/dependencies-WebGL-brightgreen.svg?style=flat-square)](https://docs.unity3d.com/Manual/webgl-gettingstarted.html) [![](https://img.shields.io/badge/issues-0%20open-brightgreen.svg?style=flat-square)](https://github.com/AndrewK9/Resort-Visualizer/issues) [![](https://img.shields.io/badge/license-NonCommercial%20CC%204-brightgreen.svg?style=flat-square)](https://github.com/AndrewK9/Resort-Visualizer/blob/master/LICENSE)
</p>

## Table of Contents
1. [Introduction](#introduction)
1. [Install](#install)
1. [Usage](#usage)
1. [Team](#team)
	- [Project Leader](#project-leader)
	- [Programmers](#programmers)
	- [Artists](#artists)
1. [Screenshots](#screenshots)
1. [Style Guide](#style-guide)
	- [Visual Appeal](#visual-appeal)
	- [Variable Prefixes](#variable-prefixes)
	- [Using Properties](#using-properties)
1. [Contribute](#contribute)
1. [License](#license)

## Introduction
This Resort Visualizer prototype is being created for [Pillar Workshop](http://www.pillarworkshop.com/) by students at [Ferris State University](http://www.ferris.edu/dagd/). The goal of this project is to provide the client with a 3D web-based interactive visualizer. The visualizer will run on the WebGL JavaScirpt API and will be built in Unity 3D.

## Install
This project uses [Unity](https://unity3d.com/) and [WebGL](https://docs.unity3d.com/Manual/webgl-gettingstarted.html). Go check them out if you don't have them locally installed.

## Usage
Currently, this section is barren, as new features are built into the project this section will be updated.

## Team
#### Project Leader

Logan Armstrong |
|-----|
| [Email](larmstrong30298@gmail.com) |

#### Programmers

Kyle Andrews |
|-----|
| [Email](andrewskyle28@gmail.com) |

#### Artists

Brent Perko | Ed Chrzanowski | Cameron Ames | Brad Vriesman | Jole Striegle |
|-----|-----|-----|-----|-----|
| [Email](brentp3rk0@gmail.com) | [Email](chrzane1@ferris.edu) | [Email](amesc3@ferris.edu) | [Email](vriesmb@ferris.edu) | [Email](striegj@ferris.edu) |

## Screenshots
Currently, this section is barren, as new features are built into the project this section will be updated.

## Style Guide
#### Visual Appeal
Tabs not spaces, for this project we will be using four spaced tabs when indenting.
All selection and iteration statements will have a beginning and ending curly brace, including single-line statements.
```
if(x == y) { return true; }
```

#### Variable Prefixes
_Global - g__
_Private - m__
_Static - s__
```
public int g_numOfCows = 0;
private bool m_ownsCows = false;
public static int s_costOfCow = 500;
```
Variables made public for ease of access through the inspector pannel do not need a prefix.

#### Using Properties
All global variables muse declare their using properties and a private variable counterpart.
```
private int m_numOfCows = 2;
public int g_numOfCows
{
    get
    {
        return m_numOfCows;
    }
}
```
Never allow other scripts to set a public global variable, instead create a public function that sets the private variable.
```
public void SetNumOfCows(int newNumOfCows)
{
    m_numOfCows = newNumOfCows;
}
```


## Contribute
Feel free to [open an issue](https://github.com/AndrewK9/Resort-Visualizer/issues) or clone this project to start working on your own, however, fixes and features contributions will only be accepted from Ferris State University students who are currently on the Resort Visualizer team.

## License
[Creative Commons Attribution-NonCommercial 4.0 International Public License](https://github.com/AndrewK9/Resort-Visualizer/blob/master/LICENSE) (c) [Ferris State University](http://www.ferris.edu/dagd/)