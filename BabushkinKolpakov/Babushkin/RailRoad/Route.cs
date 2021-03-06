using System;
using System.Collections.Generic;

namespace RailRoad
{
    ///
    /// <summary> * Created by IDIB on 27.09.2015. </summary>
    /// 
    [Serializable()]
	public class Route
	{
        public Int64 id;                                                 // уникальный индефикатор
		public string Name;                                            // низвание маршрута
        public Station Start;                                          // станция начало
        public Station Finish;                                         // станция конец
		public Train ThisTrain;                                        // поезд осуществляющий маршрут
		public DateTime StartDate;                                     // дата начала
		public DateTime FinishDate;                                    // дата конца
        public double CruiserSpeed;                                    // курсовая скорость
		public DateTime TimeLenght;                                    // время в пути фактичаское
		public double Lenght;                                          // длина пути
        public List<Station> RouteList;                              // маршрутный лист
        public List<Arrow> RouteListA;
        public Int64 ID
        {
            get
            {
                return id;
            }
        }


		public Route()
		{

		}

		public Route(Int64 _id, string name, Station start, Station finish, Train thisTrain, DateTime startDate, DateTime finishDate, double cruiserSpeed, List<Station> routeList)
		{
            id = _id;
			Name = name;
			Start = start;
			Finish = finish;
			ThisTrain = thisTrain;
			StartDate = startDate;
			FinishDate = finishDate;
			CruiserSpeed = cruiserSpeed;
			RouteList = routeList;
		}
        
        public Route(List<Arrow> a)
        {
            RouteListA = a;
        }

        public void CalcTime()
        {
            double tims = Lenght / ThisTrain.SpeedCruiser;
            FinishDate = StartDate.AddHours(Math.Floor(tims)+1);            
        }

        public string tostr()
        {
            string s = "длина ";
            s += Lenght;
            s += "время прибытия";
            s += FinishDate.Day + "/" + FinishDate.Month + "/" + FinishDate.Year + " " + FinishDate.Hour + ":" + FinishDate.Minute;
            return s;
        }

        public string toStr()
        {
            string s = "Название: ";
            s += Name;
            s += "станция отбытия:";
            s += Start.Name;
            s += "станция прибытия:";
            s += Finish.Name;
            s += "время отбытия";
            s += StartDate.Day + "/" + StartDate.Month + "/" + StartDate.Year + " " + StartDate.Hour + ":" + StartDate.Minute;
            s += "время прибытия";
            s += FinishDate.Day + "/" + FinishDate.Month + "/" + FinishDate.Year + " " + FinishDate.Hour + ":" + FinishDate.Minute;
            return s;
        }

	}

}