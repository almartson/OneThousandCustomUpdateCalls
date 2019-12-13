# OneThousandCustomUpdateCalls

This is my custom version of [https://github.com/valyard/Unity-Updates, original Blog: https://blogs.unity3d.com/es/2015/12/23/1k-update-calls/ ], ready to be modified to make an optimum new video game.


## How does it work?

If you are developing a Unity video game that has MANY GameObjects, each one with its own 'Update()' Method (in its own Script); then you may encounter a performance problem. With this example (or rather: 'Empty Project Skelleton'), you can Optimize your game by using ONLY ONE Unity-Update Method. In the Unity Blog it was called: the 'manager pattern'. Just replace the 'Original Game Object'. The same Idea can be applied wth LateUpdate() and FixedUpdate() methods.

NOTE: If your game has an GameManager (with an Update method), and you only have a few Scripts with the Update() method, maybe this pattern is not the ideal solution. It is a good optimization only when you have several Scripts running their own Update()'s separately. 

I recommend you to read the original (very good) Unity Blog article: https://blogs.unity3d.com/es/2015/12/23/1k-update-calls/ .

It has been tested in Unity 2018.4.0f1. You have a Timer-Counter GameObject to Benchmark it if you feel so.

I hope this helps someone.
Happy video game coding!
