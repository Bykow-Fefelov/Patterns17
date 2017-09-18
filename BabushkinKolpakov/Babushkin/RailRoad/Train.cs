using System;
using System.Collections.Generic;

namespace RailRoad
{
///
/// <summary> * Created by IDIB on 27.09.2015. </summary>
/// 
    [Serializable()]
	public class Train
	{
        public Int64 id; // ���������� �����������
        public string Name; // ���
        public double Mileage; // ������
        public double SpeedMax; // ������������ ��������
		public double SpeedCruiser; // �������� ��������

        public Int64 ID
        {
            get
            {
                return id;
            }
        }

        public Train()
        {

        }

        public Train(Int64 _id,string name, double speed)
        {
            id = _id;
            Name = name;
            SpeedCruiser = speed;
            SpeedMax = speed * 1.3;
        }
	}

}