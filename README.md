# Unity 3D Basics Core

A 3D basics project built with Unity as part of a structured game development learning roadmap.

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## Features

- **3D Scene** - Plane, Cube, Door, InteractableObject
- **CharacterController Movement** - WASD ile 3D hareket, yerçekimi
- **MouseLook** - Fare ile bakış, cursor kilitleme
- **Raycast Interaction** - Kameradan ray, E tuşu ile etkileşim
- **Door Opening** - E tuşu ile kapı açma (rotation)
- **Color Change** - E tuşu ile obje rengi değiştirme
- **Mixamo Character** - FBX karakter import

## Controls

| Tuş | Aksiyon |
|-----|---------|
| W/A/S/D | Hareket |
| Fare | Bakış yönü |
| E | Etkileşim (kapı aç / renk değiştir) |

## Technical Details

- **Engine:** Unity 6
- **Language:** C#
- **Movement:** CharacterController (Rigidbody değil)
- **Camera:** FPS tarzı, Player'ın child'ı
- **Interaction:** Physics.Raycast, interactionRange: 3f
- **Input:** Legacy Input System (Input.GetAxis)

## Development Timeline

| Versiyon | Tarih | Milestone |
|----------|-------|-----------|
| v0.1.0 | Haziran 2026 - Hafta 3 | 3D scene, movement, MouseLook, Raycast interaction |

---

Made with Unity