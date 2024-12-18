# NeurImmersion: Immersive Artificial Neural Network Visualization in Virtual Reality

## Introduction
NeurImmersion is a VR-based application designed to provide an engaging and interactive learning experience for understanding the inner workings of Artificial Neural Networks (ANNs). By immersing users into a first-person perspective within a neural network, the platform enables intuitive learning of complex machine learning concepts through interactive exploration and gameplay.

## Features

### Immersive Exploration of Neural Networks
- Users can embody neurons and traverse layers of a neural network.
- Visualize and interact with key components, including:
  - **Input layers**: Experience how data propagates through the network.
  - **Hidden layers**: Learn about activation functions, weights, and biases.
  - **Output layers**: Observe the decision-making process.

### Interactive Gradient Flow Simulation
- Interact with gradient flows and activation functions to understand their roles in training neural networks.

### Engaging Quizzes and Challenges
- Solve real-time trivia and challenges to reinforce learning, including:
  - Identifying activation types (ReLU, Sigmoid, Tanh, etc.).

### Real-Time Feedback and Visualization
- See changes to network outputs dynamically as you interact with the system.
- Understand training processes through animations and live data visualization.

## Implementation

### Technology Stack
- **VR Development Platform**: Unity
- **Dependencies**: Meta XR All-in-One SDK, ProBuilder
- **Supported Devices**: Meta Quest 2, Meta Quest 3
- **Programming Language**: C#

### Working Prototype
1. **Head and Hand Tracking**
   - Head tracking with 6DOF (6 Degrees of Freedom)
   - Hand tracking with controllers (button selection - left/right trigger, cube grabbing - left/right grip, continuous movement - left joystick)
   - Head and hand tracking enabled through OVRCameraRigInteraction
     
2. **Weight Update**
   - PhysicalGrab and DistanceGrab of weight cubes with left/right controller grip
   - Users navigate between layers to explore how inputs transform into outputs.
  
<table>
  <tr>
    <td style="text-align: center; margin: 0 auto;">
      <img src="images/physical_grab.png" alt="Image 1" style="width: 300px;">
      <p>PhysicalGrab</p>
    </td>
    <td style="text-align: center;">
      <img src="images/distance_grab.png" alt="Image 2" style="width: 300px;">
      <p>DistanceGrab</p>
    </td>
  </tr>
</table>

3. **ReLU Function**
   - Text explanation
   - 3D visualization of the ReLU activation process

<table>
  <tr>
    <td style="text-align: center; margin: 0 auto;">
      <img src="images/relu_screen.png" alt="Image 1" style="width: 300px;">
      <p>ReLU text explanation</p>
    </td>
    <td style="text-align: center;">
      <img src="images/relu_demo.png" alt="Image 2" style="width: 300px;">
      <p>ReLU visualization</p>
    </td>
  </tr>
</table>

4. **Quiz Module**
   - Integrated question panels that pause gameplay for interactive learning.

<table>
  <tr>
    <td style="text-align: center; margin: 0 auto;">
      <img src="images/relu_screen.png" alt="Image 1" style="width: 300px;">
    </td>
    <td style="text-align: center;">
      <img src="images/relu_demo.png" alt="Image 2" style="width: 300px;">
      <p>Trivia question</p>
    </td>
  </tr>
</table>

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/AlvinJ404/neurimmersion.git
2. Import the neurimmersion directory into Unity
3. Connect computer to VR headset (through Meta Quest Link and RIFT or other methods)
4. Locate the **Play Button** in the Unity toolbar, positioned at the center of the top panel of the Unity development environment
5. Click the **Play Button** to initiate Play Mode. This allows you to test and interact with NeurImmersion in real time within the editor
6. To exit Play Mode, click the **Play Button** again
7. Alternatively, go to File > Build and Run
