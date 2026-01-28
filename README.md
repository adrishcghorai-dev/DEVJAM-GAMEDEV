## 🎮 DEVJAM-GAMEDEV
![IMG-20260119-WA0032](https://github.com/user-attachments/assets/b435e01c-598e-462e-80b1-68a2fcbcfa54)

---

## 👥 Team : PIXEL FORGE
## 📡 SIGNAL LOST  
*A synchronized-control puzzle game about communication without words.*

---

### 📑 Table of Contents
1. [🧭 Overview](#overview)
2. [🧠 Core Mechanic](#core-mechanic)
3. [🎮 Controls](#controls)
4. [⚡ Power Ups](#power-ups)
5. [⚓ Anchor Node](#anchor-node)
6. [🎯 Goal](#goal)
7. [🧰 Tech Stack Used](#tech-stack-used)
8. [🖼️ Screenshots Of Build](#screenshots-of-build)
9. [📘 Major Learnings](#major-learnings)

---

## 🧭 Overview
SIGNAL LOST is a  platformer puzzle game where the player controls two survivors trapped in a different parts of a structure.  
Both characters receive the exact same player input, yet exist in  separate environments with different dangers and layouts.  
The characters cannot speak.  
They can only communicate through movement.  
The only goal is to guide both survivors to the Signal Relay Room.

---

## 🧠 Core Mechanic
* One Player  
* Two characters  
* One shared input  

Every action-moving, stopping, jumping, interacting, is applied to both characters simultaneously.  
This creates puzzles where:
* A safe move for one may be dangerous for the other  
* Timing and intent matter more than precision  
* Movement itself becomes a language  

---

## 🎮 Controls
* Movement Control: WASD / Arrow Keys  
* Jump: Space  

---

## ⚡ Power Ups
* High Jump  
* Smaller size  

---

## ⚓ Anchor Node
Anchor Nodes are fixed points that allow temporary desynchronization.  
When a character activates an Anchor Node, they look in place, breaking from shared movement.  
The other character continues to move freely using the same inputs.  
Anchoring is limited and unstable-release reconnects both characters back into sync.  
Used to solve puzzles where separation is risky, but necessary.

---

## 🎯 Goal
The SIGNAL LOST conveys the message of isolation and timing.

---

## 🧰 Tech Stack Used
* 🧩 Unity  
* 💻 C#  
* 🔀 Visual Scripting  
* 🎨 Post-Processing Package  

---

## 🖼️ Screenshots Of Build
<img width="852" height="481" alt="Screenshot 2026-01-19 191820" src="https://github.com/user-attachments/assets/96cf9ca1-1ddb-4034-8205-e67effd4dc62" /><br/>
Main menu background design  

<img width="811" height="377" alt="Screenshot 2026-01-18 142159" src="https://github.com/user-attachments/assets/ea8cd226-52ad-43fd-b246-ee81e88bd35f" /><br/>
One of the levels with postprocessing effects  

<img width="1914" height="1019" alt="Screenshot 2026-01-23 205455" src="https://github.com/user-attachments/assets/229076d4-9fce-4d39-82fc-581b4cf03b9a" /><br/>
Project structure in software[unity]  

<img width="1517" height="483" alt="image" src="https://github.com/user-attachments/assets/63103a37-c57a-413d-b634-7c754e972bd6" /><br/>
Main menu added with functionality  

<img width="1000" height="890" alt="image" src="https://github.com/user-attachments/assets/0812c7fd-874b-4541-9428-fe80ae00f79a" /><br/>
Visual scripting  

---

## 📘 Major Learnings
* Gained first-time experience working in a team-based, collaborative game development environment  
* Implemented visual effects and sound design for the first time  
* Fixed numerous bugs and performed systematic debugging  
* Conducted playtesting sessions and incorporated player feedback  
* Designed and iterated on puzzle mechanics and level layouts  
* Used visual scripting alongside standard C# scripting  
* Exchanged and synchronized variables between visual scripting systems and C# code  
* Learned how to integrate multiple scripting workflows in a single project  
* Working toward a fully polished game release by August 2026 with game story  
