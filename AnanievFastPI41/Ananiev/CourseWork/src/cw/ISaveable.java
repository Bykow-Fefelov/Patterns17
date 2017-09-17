package cw;

import java.io.DataInputStream;
import java.io.DataOutputStream;

// ��������� ��� ��������, ������� ����� ���� �������� � ��������� �� �����
public interface ISaveable {
	
	public void writeToFile(DataOutputStream out) throws Exception;
	
	public void readFromFile(DataInputStream in) throws Exception;
	
}
