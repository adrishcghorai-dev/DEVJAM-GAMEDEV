# DEVJAM-GAMEDEV
---
## Team : PIXEL FORGE
## SIGNAL LOST
A synchronized-control puzzle game about communication without words.

### Table of Contents
1. [Overview](#overview)
2. [Core Mechanic](#core-mechanic)
3. [Controls](#controls)
4. [Power Ups](#power-ups)
5. [Anchor Node](#anchor-node)
6. [Goal](#goal)
   

### Overview
SIGNAL LOST is a  platformer puzzle game where the player controls two survivors trapped in a different parts of a structure.
Both characters receive the exact same player input, yet exist in  separate environments with different dangers and layouts.
The characters cannot speak.
They can only communicate through movement.
The only goal is to guide both survivors to the Signal Relay Room.

### Core Mechanic
* One Player
* Two characters
* One shared input

  Every action-moving, stopping, jumping, interacting, is applied to both characters simultaneously.
  This creates puzzles where:
  * A safe move for one may be dangerous for the other
  * Timing and intent matter more than precision
  * Movement itself becomes a language

### Controls
* Movement Control: WASD / Arrow Keys
* Jump: Space

### Power Ups
* High Jump
* Smaller size

### Anchor Node
Anchor Nodes are fixed points that allow temporary desynchronization.
When a character activates an Anchor Node, they look in place, breaking from shared movement.
The other character continues to move freely using the same inputs.
Anchoring is limited and unstable-release reconnects both characters back into sync.
Used to solve puzzles where separation is risky, but necessary.

### Goal 
The SIGNAL LOST conveys the message of isolation and timing.
### Platforms and technologies used
* Unity
* For scripting C# and Visual Scripting
  
