# FanControl.GPUZ

ENGLISH version see below.

高度自定义的电脑风扇温控软件[FanControl](https://github.com/Rem0o/FanControl.Releases)，的GPU-Z插件，借助GPU-Z的监控能力给`FanControl`提供显存温度和Hot Spot温度数据。

> 吐槽一下：全网搜了几遍，截止2021.7.20，英伟达官方似乎都没有提供公开的API来获取GDDR6X的显存温度，而一些第三方工具，包括`HWiNFO`、`GPU-Z`，以及一些显卡挖矿程序都能够获取到显存温度。英伟达官方开发者论坛关于这个问题有个帖子已经大半年了，关注的人也不少，但是英伟达官方丝毫没有回应。`FanControl`依赖开源的[NvAPIWrapper](https://github.com/falahati/NvAPIWrapper)，所以暂时也没有内置显存温度传感器，作者提供了`HWiNFO`的插件，不过`HWiNFO`近来越发限制免费使用，免费版的传感器共享内存会在12小时后自动关闭，需要人工重新开启，这对风扇温控来说影响还是比较大的。而`GPU-Z`目前仍然支持免费不受限地共享温度传感器数据，所以我开了这么一个项目。

## 安装方法

1. 推荐直接下载我这里编译发布的`plugins.zip`包，然后直接解压到`FanControl`的`plugins`文件夹中。
> 也可以自行编译项目，将`bin/release`里面的编译结果复制到`FanControl`的`plugins`文件夹，复制过去以后注意对每个文件检查右键属性，确保没有被锁定。
2. 先运行`GPU-Z`，然后运行`FanControl`。

## 备注

此项目由`FanControl`的官方插件[FanControl.HWInfo](https://github.com/Rem0o/FanControl.HWInfo)修改而来, 然后依赖了我对[JohnnyUT/GpuzShMem](https://github.com/JohnnyUT/GpuzShMem)项目的[fork](https://github.com/vision57/GpuzShMem)，来提供对`GPU-Z`共享内存温度传感器的访问。

我这里编译好的插件dll，只在我自己的开发环境Win10+VS2019+.Net SDK上保证正常运行。如果你们的机器环境运行有问题，可以提issue，带上FanControl的日志（就在FanControl的根目录里面），或者自己编译。


---------


Plugin for [FanControl](https://github.com/Rem0o/FanControl.Releases) that provides support for GPU-Z sensors using its shared memory feature.

## To install

1. Download the binary release `plugins.zip`, unzip it into FanControl's `plugins` folder.
> Or compile project and then copy the `bin/release` content into FanControl's `plugins` folder, open each file's property dialog(mouse right click), check any tips like `Unblock`.
2. Make sure GPU-Z running before starting FanControl.

## Remark

This project code is mainly modified from official `FanControl` plugin [FanControl.HWInfo](https://github.com/Rem0o/FanControl.HWInfo), and depends on [my own fork](https://github.com/vision57/GpuzShMem) of [JohnnyUT/GpuzShMem](https://github.com/JohnnyUT/GpuzShMem).

Binary releases are tested on my develping environment only, which is Win10+VS2019+dotNet SDK. If it's not working for you, feel free to submit issues, or compile it yourself.
