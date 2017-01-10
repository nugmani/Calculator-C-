using System;
using System.Collections.Generic;
using System.Text;

namespace КУРСАЧ
{
    class time
    {
        private long sec = new long();
        private long min = new long();
        private long hour = new long();
        public time(){}
        public time(long s , long m , long h)
        {
            this.sec = s;
            this.min = m;
            this.hour = h;
        }
        public void normalize()
        {
            if (this.sec >= 60)
            {
                this.min += this.sec / 60;
                this.sec = this.sec % 60;
            }
            if (this.min >= 60)
            {
                this.hour += this.min / 60;
                this.min = this.min % 60;
            }
            if (this.hour >= 24)
            {
                this.hour = this.hour % 24;
            }
        }
        public long get_hour()
        {
            normalize();
            return hour;
        }
        public long get_min()
        {
            normalize();
            return min;
        }
        public long get_sec()
        {
            normalize();
            return sec;
        }
        private void add(long s)
        {
            this.sec += s ;
            this.normalize();
        }
        private void add(time t)
        {
            this.sec += t.sec;
            this.min += t.min;
            this.hour += t.hour;
            this.normalize();
        }
        private void sub(long s)
        {
            this.sec -= s;
            this.normalize();
        }
        private void sub(time t)
        {
            this.sec -= t.sec;
            this.min -= t.min;
            this.hour -= t.hour;
            this.normalize();
        }
        private void flash()
        {
            this.sec = 0;
            this.min = 0;
            this.hour = 0;
        
        }
        private long perevodsec()
        {
           long s = new long();
           s  = this.hour * 3600 + this.min * 60 + this.sec;
           return s;
        }
        
        public static time operator+(time t , time t2)
        {
            time rez = new time(0,0,0);
            rez.add(t2);
            rez.add(t);
            rez.normalize();
            return rez;
        }
        public static time operator -(time t, time t2)
        {
            time rez = new time(0, 0, 0);
            long s = new long();
            long s1 = new long();
            long s2 = new long();
            long constanta = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            s2 = s - s1;
            constanta = 3600 * 24;
           if (s < s1)
           {
               rez.sub(s1);
               rez.add(s);
               rez.add(constanta);
           }
            else
           {
               rez.sub(s1);
               rez.add(s);
                
           }

            
            rez.normalize();
            return rez;
        }
        public static bool operator > (time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s=t.perevodsec();
            s1=t2.perevodsec();
            if (s > s1)
                return true;
            else return false;
        }
        public static bool operator <(time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            if (s < s1)
                return true;
            else return false;
        }
        public static bool operator >=(time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            if (s >= s1)
                return true;
            else return false;
        }
        public static bool operator <=(time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            if (s <= s1)
                return true;
            else return false;
        }
        public static bool operator ==(time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            if (s == s1)
                return true;
            else return false;
        }
        public static bool operator !=(time t, time t2)
        {
            long s = new long();
            long s1 = new long();
            s = t.perevodsec();
            s1 = t2.perevodsec();
            if (s != s1)
                return true;
            else return false;
        }

        }
        
}
