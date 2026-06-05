# Arcana hands

**A gesture-controlled spell casting game powered by Computer Vision, Machine Learning, and Unity.**

Arcana hands allows players to cast spells using real hand gestures in front of a webcam instead of relying on traditional keyboard and mouse inputs.

The project combines Computer Vision, Deep Learning, Game Development, and Software Engineering into a single interactive experience.

---

## Project Vision

Most games use buttons and key combinations to trigger abilities.

Arcana hands explores a different approach:

```text
Player Hand Gesture
        ↓
Computer Vision
        ↓
Gesture Recognition
        ↓
Unity Game Engine
        ↓
Spell Casting
```

By combining real-time hand tracking with game mechanics, players can interact with the game world using natural movements.

---

## Features

### Computer Vision

* Real-time webcam input
* Hand landmark tracking
* Gesture recognition
* Motion analysis

### Game Systems

* Spell casting mechanics
* Health and mana systems
* Enemy interactions
* Visual spell effects

### Machine Learning

* Gesture classification
* Dataset collection
* Model training and evaluation
* Real-time inference

---

## Technology Stack

### Machine Learning

* Python
* NumPy
* OpenCV
* MediaPipe
* PyTorch (future)

### Game Development

* Unity
* C#

### Communication

* Python Sockets
* JSON Messaging

### Backend (Future Versions)

* FastAPI

---

## Repository Structure

```text
Arcana hands/
│
├── README.md
├── docs/
├── ml/
├── unity/
└── communication/
```

---

## Development Roadmap

### Version 1

Goal:

Detect hand gestures from a webcam and identify simple spell patterns.

Example:

```text
Open Palm → Shield
Circle Motion → Fireball
Two Fingers → Lightning
```

### Version 2

Goal:

Connect the gesture recognition system to Unity.

```text
Gesture
    ↓
Python
    ↓
Unity
    ↓
Spell Animation
```

### Version 3

Goal:

Create a fully playable combat experience.

```text
Player
    ↓
Gesture
    ↓
Spell
    ↓
Enemy Damage
```

---

## Team Members

### Sahand

Machine Learning Lead

Responsibilities:

* Gesture Recognition
* Deep Learning
* Computer Vision
* Model Development

---

### Nima

Unity UI & Design

Responsibilities:

* Menus
* HUD
* Visual Design
* User Experience

---

### Aylin

Gameplay Programming

Responsibilities:

* C#
* Game Mechanics
* Combat Systems
* Character Logic

---

### Sadra

Data & Dataset Management

Responsibilities:

* Data Collection
* Labeling
* Preprocessing
* Dataset Organization

---

### Shirin

Camera Systems

Responsibilities:

* Webcam Framework
* OpenCV Integration
* Video Processing

---

### Abol

Unity-Python Communication

Responsibilities:

* Socket Programming
* Message Passing
* Integration Layer

---

### Setayesh

Backend Development

Responsibilities:

* API Design
* Infrastructure Planning
* Future Backend Services

---

## Why This Project Exists

Arcana hands is more than a game.

It serves as a learning platform for:

* Computer Vision
* Machine Learning
* Deep Learning
* Unity Development
* Team Collaboration
* Git & GitHub Workflows

The goal is not only to build a playable game but also to understand the technologies behind modern interactive systems.

---

## Current Status

🚧 Early Development

Current Milestone:

Hand Detection → Gesture Recognition → Unity Integration

---

## Future Goals

* Custom-trained gesture models
* Multiplayer support
* Voice-powered spell casting
* Full fantasy combat system
* Advanced spell combinations

---

> "Magic is just technology that understands your gestures."
