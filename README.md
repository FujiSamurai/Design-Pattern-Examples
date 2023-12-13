# Design-Pattern-Examples

# Note
This repository will be basic examples of Design Pattern for Unity 

# 1 - Object Pool Design Pattern

![image](https://github.com/FujiSamurai/Design-Pattern-Examples/assets/79170712/923abcde-16f0-4ba4-a5d9-4dc80f4a409e)

The Object Pool Design Pattern is a design pattern for recycling objects instead of recreating them every time the application needs them.

By keeping reusable object instances in a resource pool and throwing them out when needed, this pattern helps minimize the overhead of initializing, instantiating, or deactivating objects and improves the performance of our application. This pattern can be adapted for various game types. But if you need a simple example, just imagine, there is a train in the background, and that train continuously passes there at specific intervals. Our train object(obviously this is a game object) must be repeatedly recreated. But those instances can take up more and more space as time goes on. This pattern allowed us to reduce those spaces. If we determine some kind of distance of maximum range for the train or add a simple countdown for the train's lifetime, and put it in our pool array, that makes instead of recreating that object, simply spawn from spawner one by one.

![image](https://github.com/FujiSamurai/Design-Pattern-Examples/assets/79170712/830f037e-4815-4d1a-bdcf-85de1009f393)
