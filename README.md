# 🐦 Flappy Bird

A modern recreation of the classic arcade mobile game **Flappy Bird**, built using the **Unity** game engine. This project demonstrates core game development concepts in Unity, including C# scripting, physics, and UI management.

![Flappy Bird Preview](Game%20Images/Game2.jpg)

---

## 🚀 Features

- **Flap-to-Fly Mechanic**  
  The bird's movement is controlled by a single input (Space key), applying an upward force to a `Rigidbody2D`.

- **Procedural Pipe Generation**  
  Pipes are spawned at a regular `spawnRate` of **2 seconds** from a Pipe Spawner object. The vertical position of the gap is randomized between a `minY` of **-1f** and a `maxY` of **3f**.

- **Dynamic Obstacles**  
  Pipes move continuously from right to left at a fixed `moveSpeed` of **5 units per second**. Once a pipe moves past a certain `deadZone` of **-90**, it is automatically destroyed to optimize performance.

- **Scoring System**  
  The player's score is tracked by a `LogicScript`. A `PipeMiddleScript` on each pipe detects when the bird passes through the gap and increases the score by 1.

- **Game Over Screen**  
  A Game Over screen is set to inactive by default. When the bird collides with a pipe, the `gameOver()` function is triggered, activating this screen and ending the game.

- **Restart Functionality**  
  A "Play Again" button on the Game Over screen calls the `restartGame()` method in the `LogicScript`, reloading the active scene to start a new game.

---

## 🛠️ Technologies Used

- **Game Engine:** Unity  
- **Language:** C#  
- **Physics:** Unity's built-in 2D physics engine (`Rigidbody2D`, `CircleCollider2D`)  
- **Rendering:** Universal Render Pipeline (URP)

---

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download)  
- Unity Editor (LTS version recommended)

---

### 🔧 Installation

1. Clone the repository:

```bash
   git clone https://github.com/Manvith-kumar16/Flappy-Bird.git
````

2. Open the project in Unity Editor.

---

### ▶️ Running the Application

1. Open the `Flappy Bird.unity` scene file.
2. Press the **Play** button in the Unity Editor to run the game.

---

## 🤝 Contributing

Contributions are welcome! If you have suggestions or find bugs, feel free to open an issue or submit a pull request.

1. Fork the project

2. Create your feature branch:

   ```bash
   git checkout -b feature/AmazingFeature
   ```

3. Commit your changes:

   ```bash
   git commit -m 'Add some AmazingFeature'
   ```

4. Push to the branch:

   ```bash
   git push origin feature/AmazingFeature
   ```

5. Open a Pull Request

---

## 🙏 Acknowledgments

* The original creators of **Flappy Bird** for the inspiration
* Unity documentation and community for guidance and support

---

![Flappy Bird Preview](Game%20Images/Game3.jpg)

---
