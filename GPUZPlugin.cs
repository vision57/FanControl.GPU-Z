using FanControl.Plugins;
using GpuzDemo;
using System;
using System.Linq;

namespace FanControl.GPUZ
{
    public class GPUZPlugin : IPlugin
    {
        private GpuzWrapper _gpuz;

        public string Name => "GPU-Z";

        public void Close()
        {
            _gpuz?.Close();
            _gpuz = null;
        }

        public void Initialize()
        {
            _gpuz = new GpuzWrapper();
            _gpuz.Open();
        }

        public void Load(IPluginSensorsContainer _container)
        {

            String sensorName;

            for (int i = 0; (sensorName = this._gpuz?.SensorName(i)) != String.Empty; i++)
            {
                var unit = this._gpuz.SensorUnit(i);
                var psensor = new GPUZPluginSensor(this._gpuz, i);

                if (unit == "RPM")
                {

                    // _container.FanSensors.Add(psensor);
                }
                else if (unit == "°C")
                {
                    _container.TempSensors.Add(psensor);
                }
            }

        }

    }
}
