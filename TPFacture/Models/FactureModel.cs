using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPFacture.Models
{
    public class FactureModel
    {
        private int _t0prix = 30;
        private int _t1prix = 40;
        private int _t2prix = 50;
        private int _t0kw = 60;
        private int _t1kw = 600;
        public int DernierIndex { get; set; }
        public int IndexActif { get; set; }
        public int Consommation { get { return IndexActif - DernierIndex; } }
        public int T0kw { 
            get {
                if (Consommation >= _t0kw)
                    return _t0kw;
                else
                    return Consommation;
            } }
        public int T1kw {
            get
            {
                if (Consommation >= (_t0kw + _t1kw))
                {
                    return _t1kw;
                }
                else if (Consommation <= _t0kw)
                {
                    return 0;
                }
                else
                {
                    return Consommation - _t0kw;
                }
            }
        }
        public int T2kw {
            get
            {
                if (Consommation >= (_t0kw + _t1kw))
                    return Consommation - (_t0kw + _t1kw);
                else
                    return 0;
            }
        }
        public int T0prix { get { return _t0prix; }  }
        public int T1prix { get { return _t1prix; } }
        public int T2prix { get { return _t2prix; } }
        public int T0total { get { return T0kw* T0prix; } }
        public int T1total { get { return T1kw * T1prix; } }
        public int T2total { get { return T2kw * T2prix; } }
        public int TVA { get { return Convert.ToInt32((T0total + T1total + T2total) * 0.1); } }
        public int TotalAPayer { get { return (T0total+T1total+T2total+TVA); } }
    }
}