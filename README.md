# fake-unity
clf-utils uses the UnityEngine namespace, but when working in a c# environment without it, it errors out.
This class reimplements all the classes we use from the UnityEngine namespace from the bottom up, so we can use clf-utils outside of Unity.
