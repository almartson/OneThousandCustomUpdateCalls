# OneThousandCustomUpdateCalls

This is my custom version of [https://github.com/valyard/Unity-Updates, original Blog: https://blogs.unity3d.com/es/2015/12/23/1k-update-calls/ ], ready to be modified to make an optimum new video game.


## How does it work?

If you are developing a Unity video game that has MANY GameObjects, each one with its own 'Update()' Method (in its own Script); then you may encounter a performance problem. With this example (or rather: 'Empty Project Skelleton'), you can Optimize your game by using ONLY ONE Unity-Update Method. In the Unity Blog it was called: the 'manager pattern'. Just replace the 'Original Game Object'. The same Idea can be applied with LateUpdate() and FixedUpdate() methods.

NOTE: If your game has a GameManager (with an Update method), and you only have a few Scripts with the Update() method (for instance: less than 20 GameObjects updating themselves at the same time...), maybe this pattern is not the ideal solution. It is a good optimization only when you have several Scripts running their own Update()'s separately. 

I recommend you to read the original (great eye-opener) Unity Blog article: https://blogs.unity3d.com/es/2015/12/23/1k-update-calls/ .

It has been tested in Unity 2018.4.0f1. You have a Timer-Counter GameObject to Benchmark it if you feel so.

I hope this helps someone.
Happy video game coding!

*****************************************

MIT License

Copyright (c) 2019 AlMartson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
