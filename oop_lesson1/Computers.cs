using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson1
{
    class Computers
    {
        public static int countComp = 0;
        public static float summPrice = 0;

        public string manufactured;
        public string model;
        public string cpu;        
        public int ram;//Gb
        protected int _hdd;//Gb        
        public int Hdd
        {
            get { return this._hdd; }
            set { value = (value < 100) ? 100 : value; value = (value > 1000) ? 1000 : value; this._hdd = value; }
        }        
        protected float _price;
        public float Price
        {
            get { return this._price; }
            set { summPrice += value;  value = (this.currs == 1) ? value : value * 70; this._price = value; }
        }
        protected string strLocs;
        protected string currency;
        protected int currs;


        //Construktor class
        public Computers()
        {
            Computers.countComp++;            
            //Console.WriteLine("экземпляр создан в " + DateTime.Now +  "\n");            
        }


        //Статичные методы
        public static float meanSumm()
        {
            float mSumm;
            mSumm = summPrice / countComp;
            return mSumm;
        } 


        public virtual string getItem()
        {
            string str = "";
            str += "Компьютер: ";
            str += this.model;
            str += ", производитель: ";
            str += this.manufactured;
            str += ", процессор: ";
            str += this.cpu;
            str += ", ОЗУ: ";
            str += this.ram;
            str += "ГБ, HDD: ";
            str += this.Hdd;
            str += "ГБ, цена: ";
            str += this.Price;
            str += " ";
            str += this.currency;
            return str;
        }

        public void setCurr(int curr)
        {
            if (curr == 1) this.currency = "долларов"; else this.currency = "рублей";
            this.currs = curr;            
        }

        public string getCurr()
        {
            return this.currency;
        }

        public void setLoc(int locations)
        {
            if (locations != 77 && locations != 64 && locations != 63) locations = 77;
             
            switch (locations)
            {
                case 64:
                    this.strLocs = "Саратов";
                    break;
                case 77:
                    this.strLocs = "Москва";
                    break;
                case 63:
                    this.strLocs = "Самара";
                    break;
            }
        }
        public string getLoc()
        {
            return this.strLocs;
        }

    }
}
