# Rubik's Cube Simulator (2D)

A lightweight, console-based Rubik's Cube engine designed for accuracy and logic testing. This project serves as a foundational "warmup" for a future 3D implementation, focusing on the underlying mathematical swaps required to model a cube.

## 🕹️ How to Use

The application runs in an input loop. Enter your moves as a string of characters and press **Enter** to see the updated state.

### Move Notation
The simulator supports the 12 standard face rotations. **Uppercase** is clockwise; **lowercase** is counter-clockwise.

| Face  | Clockwise | Counter-Clockwise |
| :---  | :---:     | :---:             |
| Front | `F`       | `f`               |
| Back  | `B`       | `b`               |
| Left  | `L`       | `l`               |
| Right | `R`       | `r`               |
| Up    | `U`       | `u`               |
| Down  | `D`       | `d`               |

**To Exit:** Press **Enter** on an empty line.

---

## ⚙️ Technical Details



* **Logic:** The cube is modeled as a series of index-based swaps across 54 positions (0-53).
* **Colors:** Represented as Blue, Orange, Yellow, Red, Green, and White.
* **Validation:** Includes a comprehensive suite of **Unit Tests** to ensure face rotations and edge-piece interactions accurately mirror a physical cube.

## 🚀 Roadmap
- [x] Functional 2D Console Engine
- [x] Accurate Move Logic & Unit Tests
- [ ] 3D Visualization Layer
- [ ] Move Solver (Planned algorithms: A*, DFS, or Heuristic-based search)

---
*See **Sample.txt** for example move sequences.*
