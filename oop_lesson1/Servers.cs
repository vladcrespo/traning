using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson1
{
    class Servers : Computers, Powers
    {
        public int countCPU;
        public string typeBody;
        public string typeServer;
        public int cpuSpeed;//MGz        
        protected int _hddSpeed;
        public int HddSpeed
        {
            get { return this._hddSpeed; }
            set { value = (value < 5600) ? 5600 : value; value = (value > 7200) ? 7200 : value; this._hddSpeed = value; }
        }
        public Servers()
        {
            this.typeBody = "cтойка(Blade)";
            this.typeServer = "сервер";
        }
        public float PerfomanceIndex()
        {
            float PI;
            PI = ((float)this.cpuSpeed * (float)this.countCPU) / (float)this.HddSpeed;
            return PI;
        }
        public override string getItem()
        {
            string str = "";
            str += "Компьютер: ";
            str += this.model;
            str += ", производитель: ";
            str += this.manufactured;
            //---------------
            str += ", тип сервера: ";
            str += this.typeServer;
            //---------------
            str += ", процессор: ";
            str += this.cpu;
            //---------------
            str += ", кол-во процессоров: ";
            str += this.countCPU;
            //---------------
            str += ", ОЗУ: ";
            str += this.ram;
            str += "ГБ, HDD: ";
            str += this.Hdd;
            //---------------
            str += ", производительность: ";
            str += this.PerfomanceIndex();
            //---------------
            str += ", цена: ";
            str += this.Price;
            str += " ";
            str += this.currency;
            return str;
        }

        public float getPower(Servers s)
        {
            float cpuPowers = cpuSpeed * 1.2f;
            return cpuPowers;
        }
    }
}
