# ArcaneCast Team Roadmap

## Goal of Version 1

Create a prototype where:

Webcam → Hand Detection → Gesture Recognition → Unity Receives Gesture → Spell Animation

No multiplayer, no database, no cloud deployment, no advanced AI training.

---

## Nima — UI / Design / Unity

### Learn

* Unity Basics
* Unity UI System
* Scene Management
* Animations
* Particle Effects

### Tasks

* Main Menu
* Settings Menu
* Health Bar (HUD)
* Mana Bar
* Spell Icons
* Basic Environment Design
* Character Design Integration

### Deliverables

* Functional game menu
* Playable game scene
* UI assets integrated into Unity

---

## Aylin — Unity / C# / Game Mechanics

### Learn

* C#
* Unity Scripting
* State Machines
* Character Controllers
* Collision Detection

### Tasks

* Player Movement
* Enemy Logic
* Health System
* Damage System
* Spell System
* Cooldowns
* Win/Lose Conditions

### Deliverables

* Playable combat system
* Spell execution framework

---

## Sadra — Data Management + ML Support

### Learn

* Python
* NumPy
* Data Processing
* Dataset Organization

### Tasks

* Organize gesture datasets
* Label gesture samples
* Build data collection scripts
* Help with preprocessing

### Deliverables

* Clean dataset structure
* Dataset documentation

---

## Sahand — ML / Deep Learning / Gesture Recognition Lead

### Learn

* OpenCV
* MediaPipe
* PyTorch
* Gesture Classification
* Computer Vision

### Tasks

* Webcam processing
* Hand landmark extraction
* Gesture recognition system
* Training experiments
* ML pipeline design

### Deliverables

* Gesture detection module
* Trained recognition model
* Real-time gesture prediction

---

## Shirin — Webcam Framework

### Learn

* OpenCV
* MediaPipe
* Camera APIs

### Tasks

* Webcam integration
* Camera calibration
* Frame processing
* Hand landmark visualization

### Deliverables

* Stable camera pipeline
* Webcam utility modules

---

## Abolfazl — Unity ↔ Python Communication

### Learn

* Python Sockets
* JSON
* TCP/IP Basics

### Tasks

* Send gesture data from Python
* Receive gesture data in Unity
* Design communication protocol

### Example

Python:
{
"gesture": "fireball"
}

Unity:
Cast Fireball

### Deliverables

* Working real-time communication system

---

## Setayesh — Backend

### Learn

* FastAPI
* REST APIs
* JSON
* Project Architecture

### Tasks

* Future backend planning
* API experimentation
* Logging system
* Configuration management

### Deliverables

* Backend prototype (future versions)

Note: Backend is not required for Version 1.

---

# Milestones

## Milestone 1

Webcam detects hand.

Owner:
Sahand + Shirin

---

## Milestone 2

Recognize 3 gestures.

Example:

* Fireball
* Shield
* Lightning

Owner:
Sahand + Sadra

---

## Milestone 3

Unity receives gesture.

Owner:
Abol + Aylin

---

## Milestone 4

Spell animation plays.

Owner:
Nima + Aylin

---

## Milestone 5

Complete prototype demo.

Gesture → Spell → Animation
