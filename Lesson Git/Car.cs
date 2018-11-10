using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Git
{
    class Car
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

        }
        
        #endregion
    }
}
