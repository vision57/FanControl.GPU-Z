using FanControl.Plugins;
using GpuzDemo;
using System;

namespace FanControl.GPUZ
{
    public class GPUZPluginSensor : IPluginSensor
    {
        private readonly GpuzWrapper gpuz;

        private readonly int index;

        public GPUZPluginSensor(GpuzWrapper gpuz, int index)
        {
            this.gpuz = gpuz;
            this.index = index;

            Name = this.gpuz.SensorName(this.index);
            Id = this.index.ToString();
        }

        public string Name { get; }

        public float? Value { get; private set; }

        public string Id { get; }

        public void Update() => Value = (float) this.gpuz.SensorValue(this.index);
    }
}
