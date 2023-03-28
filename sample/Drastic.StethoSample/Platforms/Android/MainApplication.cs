using Android.App;
using Android.Runtime;
using Drastic.Stetho;

namespace Drastic.StethoSample;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

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
}
