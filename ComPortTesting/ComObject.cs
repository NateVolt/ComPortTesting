using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPortTesting
{
    public static class ComObject
    {
        public static bool UseRtsAndDtr = false;

        public static string[] GetAllPorts() => SerialPort.GetPortNames();

        public static List<KeyValuePair<int,string>> GetResponsesAtBaudRate(string comPort, params int[] baudRates)
        {
            List<KeyValuePair<int, string>> responses = new List<KeyValuePair<int, string>>();
            foreach (int baudRate in baudRates)
            {
                responses.Add(GetResponseAtBaudRate(comPort, baudRate));
            }
            return responses;
        }

        private static KeyValuePair<int, string> GetResponseAtBaudRate(string comPort, int baudRate)
        {
            int tries = 0;
            while (tries < 3)
            {
                try
                {
                    using (SerialPort port = new SerialPort(comPort, baudRate))
                    {
                        port.ReadTimeout = 200;
                        port.WriteTimeout = 200;
                        if (UseRtsAndDtr)
                        {
                            port.DtrEnable = true;
                            port.RtsEnable = true; 
                        }
                        port.Open();
                        port.WriteLine("*IDN?");
                        string response = port.ReadLine();
                        return new KeyValuePair<int, string>(baudRate, GetIdnResponse(port));
                    }
                }
                catch (Exception)
                {
                    tries++;
                } 
            }
            return new KeyValuePair<int, string>(baudRate, null);
        }

        private static string GetIdnResponse(SerialPort port)
        {
            ClearDataArrivingAtPort(port);
            int tries = 0;
            while (tries < 3)
            {
                tries++;
                try
                {

                    port.WriteLine("*IDN?");
                    string response = port.ReadLine();
                    return response;
                }
                catch (Exception)
                {

                    throw;
                } 
            }
            throw new Exception();
        }

        private static void ClearDataArrivingAtPort(SerialPort port)
        {
            int previousReadTimeout = port.ReadTimeout;
            port.ReadTimeout = 1;
            int readTimeoutErrors = 0;
            while (readTimeoutErrors < 3)
            {
                try
                {
                    port.DiscardInBuffer();
                    port.ReadLine();
                }
                catch (TimeoutException)
                {
                    readTimeoutErrors++;
                }
                catch
                {
                    throw;
                }
            }
            port.ReadTimeout = previousReadTimeout;
        }
    }
}
