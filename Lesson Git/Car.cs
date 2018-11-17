using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Git
{
   public class Car
    {
        #region Variables
        Double mileage;

        bool IsDirty;
        bool IsWorking;
        #endregion
        public Car()
        {
            mileage = 0;
            IsDirty = false;
            IsWorking = true;
        }

        #region Properties
        public bool look
        {
            get { return IsDirty; }
            set { IsDirty = value; }
        }
        public bool StateEngine
        {
            get { return IsWorking; }
            set { IsWorking = value; }

        }
        public Double Mileage
        {
           get { return mileage; }
           private set { }
        }
        
        #endregion

        #region Methods

        public void Travel(double path)
        {
            double prediction;
            prediction =mileage+path ;
            if (path <= 0) throw new ArgumentException("Path less zero   ");
            if (IsWorking == false) throw new BrokenCarException("Car is broken");
            IsDirty = true;
            
            
            if (prediction>=1000)
            {
                mileage = 1000;
                IsWorking = false;
            }
                      
            else if((path>1000)&&(path<=2000)&&(prediction>=2000))
            {
                mileage = 2000;
                IsWorking = false;
            }
            else if ((path>2000)&&(path<=5000)&&(prediction>=5000))
            {
                mileage = 5000;
                IsWorking = false;
            }
            else
            {
                mileage+= path ;
            }
            IsDirty = true;
        }
        
        #endregion
    }
}
