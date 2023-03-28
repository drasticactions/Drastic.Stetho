# Drastic.Stetho

Drastic.Stetho is an updated .NET binding of [Stetho](https://github.com/facebook/stetho), a library for inspecting Android apps with the Chrome/Edge Dev Tools. It was original bound to Xamarin.Android by [nventive](https://github.com/nventive/Binding.Stetho); I updated it to the newest version available and removed broken nodes that were not needed.

Stetho has not been updated since (as of this writing) 2021, and seems broken in the newest Chrome builds. Oddly, it still works on Edge. That said, I would switch to [Flipper](https://github.com/drasticactions/Drastic.Flipper) instead. Still, this could be useful for those interested in Android Binding, like I am.

## How to

- Check out this repo and attach the `Drastic.Stetho` project to your Android project
- In your Android Application class, add...

```csharp
    public override void OnCreate()
    {
        base.OnCreate();

        DrasticStetho.Stetho.Initialize(
            DrasticStetho.Stetho
            .NewInitializerBuilder(this)
            .EnableDumpapp(DrasticStetho.Stetho.DefaultDumperPluginsProvider(this))
            .EnableWebKitInspector(DrasticStetho.Stetho.DefaultInspectorModulesProvider(this))
            .Build()
        );
    }
```