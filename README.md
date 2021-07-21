# FanControl.GPUZ
Plugin for [FanControl](https://github.com/Rem0o/FanControl.Releases) that provides support for GPU-Z sensors using its shared memory feature.

## To install

1. Copy the bin/release content into FanControl's "plugins" folder.
2. Make sure GPU-Z running.

## Remark

This project code is mainly modified from official `FanControl` plugin [FanControl.HWInfo](https://github.com/Rem0o/FanControl.HWInfo), and depends on [my own fork](https://github.com/vision57/GpuzShMem) of [JohnnyUT/GpuzShMem](https://github.com/JohnnyUT/GpuzShMem).

Binary releases are tested on my develping environment only, which is Win10+VS2019+dotNet SDK. If it's not working for you, feel free to submit issues, or compile it yourself.

VS2019 building target of this project is `Any CPU`, but the dependency lib `GpuzShMem.dll` is native C++. So if your Windows is 32bit, you should use the `x86`/`win32` build of `GpuzShMem.dll`, and if your Windows is 64bit, you should use the `x64` build of `GpuzShMem.dll`. The default `GpuzShMem.dll` here is `x64`.
