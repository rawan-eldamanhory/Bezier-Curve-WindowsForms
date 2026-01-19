# Bezier Curve – Windows Forms

This project demonstrates the implementation of a **Cubic Bezier Curve** using **C# Windows Forms** and GDI+.

## 📐 What is a Bezier Curve?
A Bezier curve is a parametric curve frequently used in computer graphics and animation.
This project uses **4 control points** to generate a cubic Bezier curve.

## 📘 Mathematical Formula
For parameter t ∈ [0, 1]:

B(t) = (1 − t)³ P₀  
       + 3(1 − t)²t P₁  
       + 3(1 − t)t² P₂  
       + t³ P₃

## 🧩 Features
- Draws four control points
- Generates a smooth cubic Bezier curve
- Uses parametric interpolation
- Rendered using GDI+

## 🛠 Technologies
- C#
- Windows Forms
- GDI+

## ▶️ How to Run
1. Open the solution file in Visual Studio
2. Build and run the project
3. Red dots represent control points
4. Blue line represents the Bezier curve

## 🎯 Educational Purpose
This project is intended for learning **computer graphics fundamentals**, curve interpolation, and geometric algorithms.

---

⭐ Feel free to experiment with different control point positions.
