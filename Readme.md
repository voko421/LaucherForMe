![# Marseyloader](SS14.Launcher/Assets/logo-long.png)

Space Station 14 launcher with client-side modding/patching support.

### Changes

* **Integration with the Harmony patching library.**
* * Full functionality regarding anything in client/shared content/engine assemblies.
* Enabled multiaccount
* * Tokens are updated only on connect or account switch to evade alt detection
* Locally change username for screenshots (This doesn't change your username in-game)
* Marsey.

### Contributing
If you have any feature you want added to the main repository you are free to submit a pull request.

### Setting up
1. Build solution
2. Run "SS14.Launcher"

### Running
1. Download release
2. Extract launcher
3. Start the loader

### Patching
Marseyloader uses the [Harmony](https://github.com/pardeike/Harmony) patching library. Introduction for the library is provided [here](https://harmony.pardeike.net/) and documentation [here](https://harmony.pardeike.net/articles/intro.html).

Example patches can be found in the [ExampleMarseyPatch](https://github.com/ValidHunters/ExampleMarseyPatch) repository.

### TODO
* Log cleanup.
