using System;

namespace RailRoad
{

///
/// <summary> * Created by IDIB on 23.10.2015. </summary>
/// 
    [Serializable()]
	public class ErrorRoad
	{
		internal int Type; // ��� ������

		public ErrorRoad()
		{
		}

		public override string ToString()
		{
			string mes;
			switch (Type)
			{
				case 0:
					mes = "���� �� ������";
					break;
                case 1:
                    mes = "���� �� ����� ������ �� �������";
                    break;
                case 2:
                    mes = "����� � ����� ID ��� ����";
                    break;
				default:
					mes = "����������� ������";
					break;
			}
			return mes;
		}

		public ErrorRoad(int type)
		{
			Type = type;
		}


	}

}